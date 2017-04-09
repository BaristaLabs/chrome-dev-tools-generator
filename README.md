# chrome-dev-tools
Dot Net Core based implementation of the [Chrome Debugger Protocol](https://developer.chrome.com/devtools/docs/debugger-protocol)
 
Some use cases for using the Chrome Debugger Protocol to automate Chrome are:
 - Information Gathering - Use the web as a data source by creating structured data out of unstructured data
 - Testing - Ensure sites are up and behave according to a pre-determined notion
 - Automation - Do things like perform automated password resets, enter online contests, notify when sites change, etc...
 - Artifact Generation - Use Chrome as a tool to generate PDFs, Images, json/xml/txt/csv/... from web and locally supplied data sources
 - Debugging JavaScript - When implementing custom editors, allow for rich debugging of executing javascript, including setting breakpoints, getting immediate values when paused, stepping through and so forth.

The protocol itself is defined by Google via a JSON-based definition of a websocket interface, allowing for tools to generate the required interface implementation in the language of choice. 

A number of other Browsers have started implementing the Chrome Debugger Protocol, including Edge, Safari (iOS), Firefox and possibly more, which makes developing a common interface to one of these browsers highly attractive.


This project is a .Net Core Project Generator which creates a .csproj and corresponding class files that provide the connection and a strongly-typed interface to allow one to develop applictions that use the debugger protocol for fun and profit.

 ## Requirements:

  - Chrome
  - .Net Core 1.1.0

 ## Usage:

 Clone the project and run RemoteInterfaceGeneratorCLI

 ``` Bash
 $ git clone https://github.com/BaristaLabs/chrome-dev-tools
 $ cd chrome-dev-tools\src\RemoteInterfaceGeneratorCLI
 $ dotnet run RemoteInterfaceGeneratorCLI -o "C:\\temp\\ChromeDevToolsRuntime"
 ```

In C:\Temp\ChromeDevToolsRuntime you'll have a .csproj that you can build directly or include as part of a solution.

> See [http://github.com/BaristaLabs/chrome-dev-tools-sample](http://github.com/BaristaLabs/chrome-dev-tools-sample) for a sample of generated output usage.

## Command line options:

  Option | Short | Description
  --------------- | --- | ---
 ```-output-path <path>``` | ```-o``` | Specifies the path to where the .csproj and code files will be generated (Usually contained in a subfolder of a solution that will utilize it) [Default: ./OutputProtocol]
 ```-force``` | ```-f``` | Indicates to delete the output path before files are generated (for a clean output) [Default: false]
 ```-protocol-path <path>``` | -p | When specified, indicates the path to a JSON file that contains the chrome debugging protocol definition to use. If not found, one will be generated using the current installed version of chrome. [Default: chrome-debugging-protocol.json]
 ```-settings <path>``` | -s | When specified indicates the path to a JSON file that contains code generation settings. [Default: ./Templates/settings.json]

 ## Customizing output:
 
 The output that is generated is higly configurable through the use of mustache templates.
 
 The base set of templates is included in /chrome-dev-tools/src/RemoteInterfaceGeneratorCLI/Templates and can be customized to your liking by editing the .mustache files and modifying settings.json.

## Development

Feel free to submit pull requests

#### General Application Flow

A general rundown of the flow of this generator is the following:

 0. Parse command line options and specified settings file.
 1. If a protocol definition file is not found, launches a local instance of Chrome
    1. Gets the commit/version of the launched instance of Chrome
    2. Gets the corresponding Chrome Debugger Protocol definition from Google/Chromium sources
 2. Validates the protocol definition against the schema of the generator classes (to ensure the protocol definition schema hasn't evolved - which would require improving this project)
 3. In memory, using the mustache-based templates, generates .cs files
    1. Perform a pre-scan of all Types, Commands and Events. 
    2. For each include file specified in settings.json, generate the corresponding file.
    3. For each Domain, generate files for each types, events and commands using the corresponding template defined in settings.
 4. Output to disk each generated file.

#### Thanks

Thanks to [Mustache-Sharp](https://github.com/jehugaleahsa/mustache-sharp), [WebSocket4Net](https://github.com/kerryjiang/WebSocket4Net), [NJsonSchema](https://github.com/NJsonSchema/NJsonSchema), [Humanizer](https://github.com/Humanizr/Humanizer)
