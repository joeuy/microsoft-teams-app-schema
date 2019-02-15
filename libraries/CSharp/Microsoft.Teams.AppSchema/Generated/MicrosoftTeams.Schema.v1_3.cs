﻿//-----------------------------------------------------------------------
// <copyright file="MicrosoftTeams.Schema.v1_3.cs" company="Microsoft">
//     Copyright © Microsoft Corporation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v9.13.17.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Microsoft.Teams.AppSchema
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class MicrosoftTeamsAppSchema_v1_3 
    {
        [Newtonsoft.Json.JsonProperty("$schema", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Uri Dschema { get; set; }
    
        /// <summary>The version of the schema this manifest is using.</summary>
        [Newtonsoft.Json.JsonProperty("manifestVersion", Required = Newtonsoft.Json.Required.Always)]
        public string ManifestVersion { get; set; }
    
        /// <summary>The version of the app. Changes to your manifest should cause a version change. This version string must follow the semver standard (http://semver.org).</summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Always)]
        public string Version { get; set; }
    
        /// <summary>A unique identifier for this app. This id must be a GUID.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public string Id { get; set; }
    
        /// <summary>A unique identifier for this app in reverse domain notation. E.g: com.example.myapp</summary>
        [Newtonsoft.Json.JsonProperty("packageName", Required = Newtonsoft.Json.Required.Always)]
        public string PackageName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("developer", Required = Newtonsoft.Json.Required.Always)]
        public Developer_v1_3 Developer { get; set; } = new Developer_v1_3();
    
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        public Name_v1_3 Name { get; set; } = new Name_v1_3();
    
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Always)]
        public Description_v1_3 Description { get; set; } = new Description_v1_3();
    
        [Newtonsoft.Json.JsonProperty("icons", Required = Newtonsoft.Json.Required.Always)]
        public Icons_v1_3 Icons { get; set; } = new Icons_v1_3();
    
        /// <summary>A color to use in conjunction with the icon. The value must be a valid HTML color code starting with '#', for example `#4464ee`.</summary>
        [Newtonsoft.Json.JsonProperty("accentColor", Required = Newtonsoft.Json.Required.Always)]
        public string AccentColor { get; set; }
    
        /// <summary>These are tabs users can optionally add to their channels and 1:1 or group chats and require extra configuration before they are added. Configurable tabs are not supported in the personal scope. Currently only one configurable tab per app is supported.</summary>
        [Newtonsoft.Json.JsonProperty("configurableTabs", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ConfigurableTab_v1_3> ConfigurableTabs { get; set; }
    
        /// <summary>A set of tabs that may be 'pinned' by default, without the user adding them manually. Static tabs declared in personal scope are always pinned to the app's personal experience. Static tabs do not currently support the 'teams' scope.</summary>
        [Newtonsoft.Json.JsonProperty("staticTabs", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<StaticTab_v1_3> StaticTabs { get; set; }
    
        /// <summary>The set of bots for this app. Currently only one bot per app is supported.</summary>
        [Newtonsoft.Json.JsonProperty("bots", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Bot_v1_3> Bots { get; set; }
    
        /// <summary>The set of Office365 connectors for this app. Currently only one connector per app is supported.</summary>
        [Newtonsoft.Json.JsonProperty("connectors", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Connector_v1_3> Connectors { get; set; }
    
        /// <summary>The set of compose extensions for this app. Currently only one compose extension per app is supported.</summary>
        [Newtonsoft.Json.JsonProperty("composeExtensions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<ComposeExtension_v1_3> ComposeExtensions { get; set; }
    
        /// <summary>Specifies the permissions the app requests from users.</summary>
        [Newtonsoft.Json.JsonProperty("permissions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<Permissions_v1_3> Permissions { get; set; }
    
        /// <summary>A list of valid domains from which the tabs expect to load any content. Domain listings can include wildcards, for example `*.example.com`. If your tab configuration or content UI needs to navigate to any other domain besides the one use for tab configuration, that domain must be specified here.</summary>
        [Newtonsoft.Json.JsonProperty("validDomains", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<string> ValidDomains { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static MicrosoftTeamsAppSchema_v1_3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MicrosoftTeamsAppSchema_v1_3>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Developer_v1_3 
    {
        /// <summary>The display name for the developer.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        public string Name { get; set; }
    
        /// <summary>The url to the page that provides support information for the app.</summary>
        [Newtonsoft.Json.JsonProperty("websiteUrl", Required = Newtonsoft.Json.Required.Always)]
        public string WebsiteUrl { get; set; }
    
        /// <summary>The url to the page that provides privacy information for the app.</summary>
        [Newtonsoft.Json.JsonProperty("privacyUrl", Required = Newtonsoft.Json.Required.Always)]
        public string PrivacyUrl { get; set; }
    
        /// <summary>The url to the page that provides the terms of use for the app.</summary>
        [Newtonsoft.Json.JsonProperty("termsOfUseUrl", Required = Newtonsoft.Json.Required.Always)]
        public string TermsOfUseUrl { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Developer_v1_3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Developer_v1_3>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Name_v1_3 
    {
        /// <summary>A short display name for the app.</summary>
        [Newtonsoft.Json.JsonProperty("short", Required = Newtonsoft.Json.Required.Always)]
        public string Short { get; set; }
    
        /// <summary>The full name of the app, used if the full app name exceeds 30 characters.</summary>
        [Newtonsoft.Json.JsonProperty("full", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Full { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Name_v1_3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Name_v1_3>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Description_v1_3 
    {
        /// <summary>A short description of the app used when space is limited. Maximum length is 80 characters.</summary>
        [Newtonsoft.Json.JsonProperty("short", Required = Newtonsoft.Json.Required.Always)]
        public string Short { get; set; }
    
        /// <summary>The full description of the app. Maximum length is 4000 characters.</summary>
        [Newtonsoft.Json.JsonProperty("full", Required = Newtonsoft.Json.Required.Always)]
        public string Full { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Description_v1_3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Description_v1_3>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Icons_v1_3 
    {
        /// <summary>A relative file path to a transparent PNG outline icon. The border color needs to be white. Size 20x20.</summary>
        [Newtonsoft.Json.JsonProperty("outline", Required = Newtonsoft.Json.Required.Always)]
        public string Outline { get; set; }
    
        /// <summary>A relative file path to a full color PNG icon. Size 96x96.</summary>
        [Newtonsoft.Json.JsonProperty("color", Required = Newtonsoft.Json.Required.Always)]
        public string Color { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Icons_v1_3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Icons_v1_3>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ConfigurableTab_v1_3 
    {
        /// <summary>The url to use when configuring the tab.</summary>
        [Newtonsoft.Json.JsonProperty("configurationUrl", Required = Newtonsoft.Json.Required.Always)]
        public string ConfigurationUrl { get; set; }
    
        /// <summary>A value indicating whether an instance of the tab's configuration can be updated by the user after creation.</summary>
        [Newtonsoft.Json.JsonProperty("canUpdateConfiguration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool CanUpdateConfiguration { get; set; } = true;
    
        /// <summary>Specifies whether the tab offers an experience in the context of a channel in a team, in a 1:1 or group chat, or in an experience scoped to an individual user alone. These options are non-exclusive. Currently, configurable tabs are only supported in the teams and groupchats scopes.</summary>
        [Newtonsoft.Json.JsonProperty("scopes", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.ObjectModel.ObservableCollection<Scopes_v1_3> Scopes { get; set; } = new System.Collections.ObjectModel.ObservableCollection<Scopes_v1_3>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static ConfigurableTab_v1_3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigurableTab_v1_3>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class StaticTab_v1_3 
    {
        /// <summary>A unique identifier for the entity which the tab displays.</summary>
        [Newtonsoft.Json.JsonProperty("entityId", Required = Newtonsoft.Json.Required.Always)]
        public string EntityId { get; set; }
    
        /// <summary>The display name of the tab.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        public string Name { get; set; }
    
        /// <summary>The url which points to the entity UI to be displayed in the Teams canvas.</summary>
        [Newtonsoft.Json.JsonProperty("contentUrl", Required = Newtonsoft.Json.Required.Always)]
        public string ContentUrl { get; set; }
    
        /// <summary>The url to point at if a user opts to view in a browser.</summary>
        [Newtonsoft.Json.JsonProperty("websiteUrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WebsiteUrl { get; set; }
    
        /// <summary>Specifies whether the tab offers an experience in the context of a channel in a team, or an experience scoped to an individual user alone. These options are non-exclusive. Currently static tabs are only supported in the 'personal' scope.</summary>
        [Newtonsoft.Json.JsonProperty("scopes", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.ObjectModel.ObservableCollection<Scopes_v1_32> Scopes { get; set; } = new System.Collections.ObjectModel.ObservableCollection<Scopes_v1_32>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static StaticTab_v1_3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StaticTab_v1_3>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Bot_v1_3 
    {
        /// <summary>The Microsoft App ID specified for the bot in the Bot Framework portal (https://dev.botframework.com/bots)</summary>
        [Newtonsoft.Json.JsonProperty("botId", Required = Newtonsoft.Json.Required.Always)]
        public string BotId { get; set; }
    
        /// <summary>This value describes whether or not the bot utilizes a user hint to add the bot to a specific channel.</summary>
        [Newtonsoft.Json.JsonProperty("needsChannelSelector", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool NeedsChannelSelector { get; set; } = false;
    
        /// <summary>A value indicating whether or not the bot is a one-way notification only bot, as opposed to a conversational bot.</summary>
        [Newtonsoft.Json.JsonProperty("isNotificationOnly", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsNotificationOnly { get; set; } = false;
    
        /// <summary>A value indicating whether the bot supports uploading/downloading of files.</summary>
        [Newtonsoft.Json.JsonProperty("supportsFiles", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool SupportsFiles { get; set; } = false;
    
        /// <summary>Specifies whether the bot offers an experience in the context of a channel in a team, in a 1:1 or group chat, or in an experience scoped to an individual user alone. These options are non-exclusive.</summary>
        [Newtonsoft.Json.JsonProperty("scopes", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.ObjectModel.ObservableCollection<Scopes_v1_33> Scopes { get; set; } = new System.Collections.ObjectModel.ObservableCollection<Scopes_v1_33>();
    
        /// <summary>The list of commands that the bot supplies, including their usage, description, and the scope for which the commands are valid. A seperate command list should be used for each scope.</summary>
        [Newtonsoft.Json.JsonProperty("commandLists", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.ObservableCollection<CommandList_v1_3> CommandLists { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Bot_v1_3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Bot_v1_3>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Connector_v1_3 
    {
        /// <summary>A unique identifier for the connector which matches its ID in the Connectors Developer Portal.</summary>
        [Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.Always)]
        public string ConnectorId { get; set; }
    
        /// <summary>The url to use for configuring the connector using the inline configuration experience.</summary>
        [Newtonsoft.Json.JsonProperty("configurationUrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConfigurationUrl { get; set; }
    
        /// <summary>Specifies whether the connector offers an experience in the context of a channel in a team, or an experience scoped to an individual user alone. Currently, only the team scope is supported.</summary>
        [Newtonsoft.Json.JsonProperty("scopes", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.ObjectModel.ObservableCollection<Scopes_v1_34> Scopes { get; set; } = new System.Collections.ObjectModel.ObservableCollection<Scopes_v1_34>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Connector_v1_3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Connector_v1_3>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ComposeExtension_v1_3 
    {
        /// <summary>The Microsoft App ID specified for the bot powering the compose extension in the Bot Framework portal (https://dev.botframework.com/bots)</summary>
        [Newtonsoft.Json.JsonProperty("botId", Required = Newtonsoft.Json.Required.Always)]
        public string BotId { get; set; }
    
        /// <summary>A value indicating whether the configuration of a compose extension can be updated by the user.</summary>
        [Newtonsoft.Json.JsonProperty("canUpdateConfiguration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool CanUpdateConfiguration { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("commands", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.ObjectModel.ObservableCollection<Command_v1_3> Commands { get; set; } = new System.Collections.ObjectModel.ObservableCollection<Command_v1_3>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static ComposeExtension_v1_3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ComposeExtension_v1_3>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum Permissions_v1_3
    {
        [System.Runtime.Serialization.EnumMember(Value = @"identity")]
        Identity = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"messageTeamMembers")]
        MessageTeamMembers = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum Scopes_v1_3
    {
        [System.Runtime.Serialization.EnumMember(Value = @"team")]
        Team = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"groupchat")]
        Groupchat = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum Scopes_v1_32
    {
        [System.Runtime.Serialization.EnumMember(Value = @"team")]
        Team = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"personal")]
        Personal = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum Scopes_v1_33
    {
        [System.Runtime.Serialization.EnumMember(Value = @"team")]
        Team = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"personal")]
        Personal = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"groupchat")]
        Groupchat = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CommandList_v1_3 
    {
        /// <summary>Specifies the scopes for which the command list is valid</summary>
        [Newtonsoft.Json.JsonProperty("scopes", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.ObjectModel.ObservableCollection<Scopes_v1_35> Scopes { get; set; } = new System.Collections.ObjectModel.ObservableCollection<Scopes_v1_35>();
    
        [Newtonsoft.Json.JsonProperty("commands", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.ObjectModel.ObservableCollection<Command_v1_32> Commands { get; set; } = new System.Collections.ObjectModel.ObservableCollection<Command_v1_32>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static CommandList_v1_3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CommandList_v1_3>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum Scopes_v1_34
    {
        [System.Runtime.Serialization.EnumMember(Value = @"team")]
        Team = 0,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Command_v1_3 
    {
        /// <summary>Id of the command.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public string Id { get; set; }
    
        /// <summary>Title of the command.</summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Always)]
        public string Title { get; set; }
    
        /// <summary>Description of the command.</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }
    
        /// <summary>A boolean value that indicates if the command should be run once initially with no parameter.</summary>
        [Newtonsoft.Json.JsonProperty("initialRun", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool InitialRun { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("parameters", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.ObjectModel.ObservableCollection<Parameter_v1_3> Parameters { get; set; } = new System.Collections.ObjectModel.ObservableCollection<Parameter_v1_3>();
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Command_v1_3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Command_v1_3>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum Scopes_v1_35
    {
        [System.Runtime.Serialization.EnumMember(Value = @"team")]
        Team = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"personal")]
        Personal = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Command_v1_32 
    {
        /// <summary>The bot command name</summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Always)]
        public string Title { get; set; }
    
        /// <summary>A simple text description or an example of the command syntax and its arguments.</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Always)]
        public string Description { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Command_v1_32 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Command_v1_32>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Parameter_v1_3 
    {
        /// <summary>Name of the parameter.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        public string Name { get; set; }
    
        /// <summary>Title of the parameter.</summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Always)]
        public string Title { get; set; }
    
        /// <summary>Description of the parameter.</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Parameter_v1_3 FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Parameter_v1_3>(data);
        }
    
    }
}
