## What is the deal with this folder?
This folder contains the;
1. JSON schema files,
2. a T4 template to generate CSharp classes from the JSON schema files,
3. and hand-built classes that have a convert to AppDefinitionItem method for each schema.

## What should I use these classes for?
When updating or adding fields to a schema (particularly devPreview version), these generated classes will make sure that your
code properly extracts the data from the manifest. It helps avoid manifest file to csharp class mismatch.

## How do I alter an existing schema?
You should never alter an already published schema (i.e. versions 1.0, 1.1, 1.2, and 1.3). You will probably have to alter the devPreview schema.

Here are the steps:
1. Update the schema JSON file
2. Re-run the ManifestClassesFromSchema.tt file. This will generate a new CSharp class for your schema.
3. Alter the hand-build MicrosoftTeamsAppSchema_<version>.cs class to convert your new or altered properties to an AppDefinitionItem.

## How do I add a new schema?
You will probably not need to do this.
However, if you really do want to do this, then follow these steps:
1. Add the JSON Schema file in the same format as the other schema files.
2. Re-run the ManifestClassesFromSchema.tt file to generate the CSharp class.
3. Create a MicrosoftTeamsAppSchema_<version>.cs partial class and have it implement ITeamsAppManifest.
4. Add your new schema to the AppSchemaEntries list in TeamsAppManifestFactory.

## How do I run the ManifestClassesFromSchema.tt file?
There are two ways; (1) save the ManifestClassesFromSchema.tt file (causes it to re-run) (2) right click the ManifestClassesFromSchema.tt file and click "Run Custom Tool"

## How does it work?
The T4 template uses the [NJsonSchema](https://github.com/RSuter/NJsonSchema) CSharp code generation libary to produce the classes.
There is some custom logic here to name things properly but most of the work is done by the external library.