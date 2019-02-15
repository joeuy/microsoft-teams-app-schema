namespace Microsoft.Teams.AppSchema
{
    using System.Collections.Generic;

    public interface IAppDefinition
    {
        /// <summary>
        /// The version of the manifest used to create this app
        /// </summary>
        string ManifestVersion { get; set; }

        /// <summary>
        /// The app's version provided by the developer
        /// </summary>
        string Version { get; set; }

        /// <summary>
        /// The name of the app.
        /// </summary>
        INameDefinition Name { get; set; }

        /// <summary>
        /// A description of the app
        /// </summary>
        IDescriptionDefinition Description { get; set; }

        /// <summary>
        /// The information of the developer.
        /// </summary>
        IDeveloperDefinition Developer { get; set; }

        /// <summary>
        /// An app's accent color in RGB notation
        /// </summary>
        string AccentColor { get; set; }

        /// <summary>
        /// A list of valid domains from which the app expects to load any content
        /// </summary>
        IEnumerable<string> ValidDomains { get; set; }

        /// <summary>
        /// A list of bots associated with this app
        /// </summary>
        IEnumerable<IBotDefinition> Bots { get; set; }
        /*
		/// <summary>
		/// A list of tabs to be shown in the tabs gallery for a given set of scopes
		/// </summary>
		GalleryTabDefinitionItem[] GalleryTabs { get; set; }

		/// <summary>
		/// A list of static tab instances to be created by default for a given set of scopes
		/// </summary>
		StaticTabDefinitionItem[] StaticTabs { get; set; }

		/// <summary>
		/// A list of input extensions to be made available for a given set of scopes
		/// </summary>
		InputExtensionDefinitionItem[] InputExtensions { get; set; }

		/// <summary>
		/// A list of connectors to be made available for a given set of scopes
		/// </summary>
		ConnectorDefinitionItem[] Connectors { get; set; }

		/// <summary>
		/// A list of mobile modules supported by App
		/// </summary>
		MobileModuleDefinitionItem[] MobileModules { get; set; }

		/// <summary>
		/// Web application information for single sign-on
		/// </summary>
		WebApplicationInfoItem WebApplicationInfo { get; set; }*/
    }
}
