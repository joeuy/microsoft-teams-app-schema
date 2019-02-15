namespace Microsoft.Teams.AppSchemaClassGenerator
{
    using System.IO;
    using System.Linq;
    using System.Text;
    using Microsoft.Extensions.CommandLineUtils;
    using NJsonSchema;
    using NJsonSchema.CodeGeneration.CSharp;

    class Program
    {
        private static readonly string CopyrightHeaderFormat =
@"//-----------------------------------------------------------------------
// <copyright file=""{0}"" company=""Microsoft"">
//     Copyright © Microsoft Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------";

        static void Main(string[] args)
        {
            var commandLineApplication = new CommandLineApplication(false);

            var inputFileOption = commandLineApplication.Option(
                "-i | --input", "The input file containing the schema",
                CommandOptionType.SingleValue);

            var outputFileOption = commandLineApplication.Option(
                "-o | --output", "The output file that will be created or overwritten with the class",
                CommandOptionType.SingleValue);

            var classNamePostFixOption = commandLineApplication.Option(
                "-cpf | --classpostfix", "The postfix to apply to generated class names.",
                CommandOptionType.SingleValue);

            var namespaceOption = commandLineApplication.Option(
                "-ns | --namespace", "The namespace to generate classes under.",
                CommandOptionType.SingleValue);

            var rootClassNameOption = commandLineApplication.Option(
                "-r | --root", "The root object's class name",
                CommandOptionType.SingleValue);

            commandLineApplication.OnExecute(() =>
            {
                if (!inputFileOption.HasValue())
                {
                    return 1;
                }
                var inputFilePath = inputFileOption.Value();

                var outputFilePath = Path.Combine(Path.GetDirectoryName(inputFilePath), "Generated", Path.GetFileNameWithoutExtension(inputFilePath) + ".cs");
                if (outputFileOption.HasValue())
                {
                    outputFilePath = outputFileOption.Value();
                }

                var classNamePostFix = string.Empty;
                if (classNamePostFixOption.HasValue())
                {
                    classNamePostFix = classNamePostFixOption.Value();
                }

                var generatedNamespace = string.Empty;
                if (namespaceOption.HasValue())
                {
                    generatedNamespace = namespaceOption.Value();
                }

                var rootClassName = string.Empty;
                if (rootClassNameOption.HasValue())
                {
                    rootClassName = rootClassNameOption.Value();
                }

                var outputFileName = Path.GetFileName(outputFilePath);

                Directory.CreateDirectory(Path.GetDirectoryName(outputFilePath));

                using (var outputStream = new StreamWriter(outputFilePath, false, Encoding.UTF8))
                {
                    outputStream.WriteLine(string.Format(CopyrightHeaderFormat, outputFileName));
                    string contents = File.ReadAllText(inputFilePath);

                    var schemaTask = JsonSchema4.FromJsonAsync(contents);
                    schemaTask.Wait();
                    var schema = schemaTask.Result;

                    var settings = new CSharpGeneratorSettings()
                    {
                        Namespace = generatedNamespace,
                        ClassStyle = CSharpClassStyle.Poco,
                        PropertyNameGenerator = new CustomCSharpPropertyNameGenerator(),
                        TypeNameGenerator = new CustomTypeNameGenerator(classNamePostFix),
                        GenerateDataAnnotations = false,
                    };

                    var codeGenerator = new CSharpGenerator(schema, settings);
                    var code = codeGenerator.GenerateFile(rootClassName);

                    outputStream.WriteLine(code);
                }

                return 0;
            });

            commandLineApplication.Execute(args);
        }
    }

    class CustomCSharpPropertyNameGenerator : CSharpPropertyNameGenerator
    {
        public override string Generate(JsonProperty property)
        {
            return base.Generate(property)
                .Replace('$', 'D');
        }
    }

    class CustomTypeNameGenerator : DefaultTypeNameGenerator
    {
        private string PostFix { get; set; }

        public CustomTypeNameGenerator(string postFix)
        {
            PostFix = postFix;
        }

        protected override string Generate(JsonSchema4 schema, string typeNameHint)
        {
            var name = base.Generate(schema, typeNameHint);
            if (string.IsNullOrWhiteSpace(name))
            {
                // If this definition is an object in an array, try to pull the hint as the name of the array property.
                if (schema.ParentSchema != null && schema.ParentSchema.IsArray &&
                    schema.ParentSchema.ParentSchema != null && schema.ParentSchema.ParentSchema.IsObject)
                {
                    var pair = schema.ParentSchema.ParentSchema.Properties.Where(d => d.Value == schema.ParentSchema).FirstOrDefault();
                    var key = pair.Key;
                    if (!schema.IsEnumeration && key.EndsWith('s'))
                    {
                        key = key.Substring(0, key.Length - 1);
                    }
                    name = base.Generate(schema, key);
                }
                else
                {
                    name = "Anonymous";
                }
            }
            if (!name.EndsWith(PostFix))
            {
                name += PostFix;
            }
            return name;
        }
    }
}
