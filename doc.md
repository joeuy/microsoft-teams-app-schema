The schema defines the following properties:

# `$schema` (string)

# `manifestVersion` (string, required)

The version of the schema this manifest is using.

# `version` (string, required)

The version of the app. Changes to your manifest should cause a version change. This version string must follow the semver standard (http://semver.org).

# `id` (string, required)

A unique identifier for this app. This id must be a GUID.

Additional restrictions:

* Regex pattern: `^[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}$`

# `packageName` (string, required)

A unique identifier for this app in reverse domain notation. E.g: com.example.myapp

# `developer` (object, required)

Properties of the `developer` object:

## `name` (string, required)

The display name for the developer.

## `websiteUrl` (string, required)

The url to the page that provides support information for the app.

Additional restrictions:

* Regex pattern: `^[Hh][Tt][Tt][Pp][Ss]?://`

## `privacyUrl` (string, required)

The url to the page that provides privacy information for the app.

Additional restrictions:

* Regex pattern: `^[Hh][Tt][Tt][Pp][Ss]?://`

## `termsOfUseUrl` (string, required)

The url to the page that provides the terms of use for the app.

Additional restrictions:

* Regex pattern: `^[Hh][Tt][Tt][Pp][Ss]?://`

# `name` (object, required)

Properties of the `name` object:

## `tiny` (string)

A shorter display name of the app, used on devices such as phone or tablet. If not provided, short name will be truncated to fit.

## `short` (string, required)

A short display name for the app.

## `full` (string)

The full name of the app, used if the full app name exceeds 30 characters.

# `description` (object, required)

Properties of the `description` object:

## `short` (string, required)

A short description of the app used when space is limited. Maximum length is 80 characters.

## `full` (string, required)

The full description of the app. Maximum length is 4000 characters.

# `icons` (object, required)

Properties of the `icons` object:

## `outline` (string, required)

A relative file path to a transparent PNG outline icon. The border color needs to be white. Size 32x32.

## `color` (string, required)

A relative file path to a full color PNG icon. Size 96x96.

# `accentColor` (string, required)

A color to use in conjunction with the icon. The value must be a valid HTML color code starting with '#', for example `#4464ee`.

Additional restrictions:

* Regex pattern: `^#[0-9a-fA-F]{6}$`

# `configurableTabs` (array)

These are tabs users can optionally add to their channels and 1:1 or group chats and require extra configuration before they are added. Configurable tabs are not supported in the personal scope. Currently only one configurable tab per app is supported.

The object is an array with all elements of the type `object`.

The array object has the following properties:

## `configurationUrl` (string, required)

The url to use when configuring the tab.

Additional restrictions:

* Regex pattern: `^[Hh][Tt][Tt][Pp][Ss]://`

## `canUpdateConfiguration` (boolean)

A value indicating whether an instance of the tab's configuration can be updated by the user after creation.

Default: `true`

## `scopes` (array, required)

Specifies whether the tab offers an experience in the context of a channel in a team, in a 1:1 or group chat, or in an experience scoped to an individual user alone. These options are non-exclusive. Currently, configurable tabs are only supported in the teams and groupchats scopes.

## `sharePointPreviewImage` (string)

A relative file path to a tab preview image for use in SharePoint. Size 1024x768.

## `supportedSharePointHosts` (array)

Defines how your tab will be made available in SharePoint.

Additional restrictions:

* Unique items: `true`

## `platforms` (platforms)

Specifies the platforms on which configurable tabs are displayed

# `staticTabs` (array)

A set of tabs that may be 'pinned' by default, without the user adding them manually. Static tabs declared in personal scope are always pinned to the app's personal experience. Static tabs do not currently support the 'teams' scope.

The object is an array with all elements of the type `object`.

The array object has the following properties:

## `entityId` (string, required)

A unique identifier for the entity which the tab displays.

## `name` (string, required)

The display name of the tab.

## `contentUrl` (string, required)

The url which points to the entity UI to be displayed in the Teams canvas.

Additional restrictions:

* Regex pattern: `^[Hh][Tt][Tt][Pp][Ss]://`

## `websiteUrl` (string)

The url to point at if a user opts to view in a browser.

Additional restrictions:

* Regex pattern: `^[Hh][Tt][Tt][Pp][Ss]://`

## `scopes` (array, required)

Specifies whether the tab offers an experience in the context of a channel in a team, or an experience scoped to an individual user alone. These options are non-exclusive. Currently static tabs are only supported in the 'personal' scope.

## `platforms` (platforms)

Specifies the platforms on which staticTabs tabs are displayed

# `bots` (array)

The set of bots for this app. Currently only one bot per app is supported.

The object is an array with all elements of the type `object`.

The array object has the following properties:

## `botId` (string, required)

The Microsoft App ID specified for the bot in the Bot Framework portal (https://dev.botframework.com/bots)

## `needsChannelSelector` (boolean)

This value describes whether or not the bot utilizes a user hint to add the bot to a specific channel.

Default: `false`

## `isNotificationOnly` (boolean)

A value indicating whether or not the bot is a one-way notification only bot, as opposed to a conversational bot.

Default: `false`

## `supportsFiles` (boolean)

A value indicating whether the bot supports uploading/downloading of files.

Default: `false`

## `supportsCalling` (boolean)

A value indicating whether the bot supports audio calling.

Default: `false`

## `supportsVideo` (boolean)

A value indicating whether the bot supports video calling.

Default: `false`

## `scopes` (array, required)

Specifies whether the bot offers an experience in the context of a channel in a team, in a 1:1 or group chat, or in an experience scoped to an individual user alone. These options are non-exclusive.

## `commandLists` (array)

The list of commands that the bot supplies, including their usage, description, and the scope for which the commands are valid. A separate command list should be used for each scope.

The object is an array with all elements of the type `object`.

The array object has the following properties:

### `scopes` (array, required)

Specifies the scopes for which the command list is valid

### `commands` (array, required)

The object is an array with all elements of the type `object`.

The array object has the following properties:

#### `title` (string, required)

The bot command name

#### `description` (string, required)

A simple text description or an example of the command syntax and its arguments.

# `connectors` (array)

The set of Office365 connectors for this app. Currently only one connector per app is supported.

The object is an array with all elements of the type `object`.

The array object has the following properties:

## `connectorId` (string, required)

A unique identifier for the connector which matches its ID in the Connectors Developer Portal.

## `configurationUrl` (string)

The url to use for configuring the connector using the inline configuration experience.

Additional restrictions:

* Regex pattern: `^[Hh][Tt][Tt][Pp][Ss]://`

## `scopes` (array, required)

Specifies whether the connector offers an experience in the context of a channel in a team, or an experience scoped to an individual user alone. Currently, only the team scope is supported.

# `composeExtensions` (array)

The set of compose extensions for this app. Currently only one compose extension per app is supported.

The object is an array with all elements of the type `object`.

The array object has the following properties:

## `botId` (string, required)

The Microsoft App ID specified for the bot powering the compose extension in the Bot Framework portal (https://dev.botframework.com/bots)

## `canUpdateConfiguration` (boolean)

A value indicating whether the configuration of a compose extension can be updated by the user.

Default: `false`

## `commands` (array, required)

The object is an array with all elements of the type `object`.

The array object has the following properties:

### `id` (string, required)

Id of the command.

### `type` (string, enum)

Type of the command

This element must be one of the following enum values:

* `query`
* `action`

Default: `"action"`

### `context` (array)

Context where the command would apply

Default:

```
[
  "compose",
  "commandBox"
]
```

### `title` (string, required)

Title of the command.

### `description` (string)

Description of the command.

### `initialRun` (boolean)

A boolean value that indicates if the command should be run once initially with no parameter.

Default: `false`

### `fetchTask` (boolean)

A boolean value that indicates if it should fetch task module dynamically

Default: `false`

### `parameters` (array, required)

The object is an array with all elements of the type `object`.

The array object has the following properties:

#### `name` (string, required)

Name of the parameter.

#### `inputType` (string, enum)

Type of the parameter

This element must be one of the following enum values:

* `text`
* `textarea`
* `number`
* `date`
* `time`
* `toggle`
* `choiceset`

#### `title` (string, required)

Title of the parameter.

#### `description` (string)

Description of the parameter.

#### `value` (string)

Initial value for the parameter

#### `choices` (array)

The choice options for the parameter

The object is an array with all elements of the type `object`.

The array object has the following properties:

##### `title` (string, required)

Title of the choice

##### `value` (string, required)

Value of the choice

Additional restrictions:

* Minimum items: `1`

## `messageHandlers` (array)

A list of handlers that allow apps to be invoked when certain conditions are met

The object is an array with all elements of the type `object`.

The array object has the following properties:

### `type` (string, enum, required)

Type of the message handler

This element must be one of the following enum values:

* `Link`

### `value` (object, required)

Properties of the `value` object:

#### `domains` (array)

A list of domains that the link message handler can register for, and when they are matched the app will be invoked

The object is an array with all elements of the type `string`.

# `permissions` (array)

Specifies the permissions the app requests from users.

# `devicePermissions` (array)

Specifies the device capabilities the app can request access to.

# `validDomains` (array)

A list of valid domains from which the tabs expect to load any content. Domain listings can include wildcards, for example `*.example.com`. If your tab configuration or content UI needs to navigate to any other domain besides the one use for tab configuration, that domain must be specified here.

The object is an array with all elements of the type `string`.

# `webApplicationInfo` (object)

Properties of the `webApplicationInfo` object:

## `id` (string, required)

AAD application id of the app. This id must be a GUID.

Additional restrictions:

* Regex pattern: `^[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}$`

## `resource` (string, required)

Resource url of app for acquiring auth token for SSO.

---

# Sub Schemas

The schema defines the following additional types:

## `platforms` (array)

This section defines the different environments supported by Teams application. 1. web refers to the Teams website running in a web browser on any compatible device/ computer. 2. Desktop refers to the installed package of Teams application on devices/ machines running Windows or Mac OS 3. phone refers to native apps (apk or ipa) running on Android or IOS Phone devices like iPhone, etc. 4. tablet refers to native apps (apk or ipa) running on Android or IOS Tablet devices like iPad, etc