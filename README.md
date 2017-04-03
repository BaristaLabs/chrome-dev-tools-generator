# chrome-dev-tools
Dot Net Core based implementation of the [Chrome Remote Interface](https://developer.chrome.com/devtools/docs/debugger-protocol)
 
Some use cases for this are:
 - Information Gathering - Use the web as a data source by creating structured data out of unstructured data
 - Testing - Ensure sites are up and behave according to a pre-determined notion
 - Automation - Do things like perform automated password resets, enter online contests, notify when sites change, etc...
 - Artifact Generation - Use Chrome as a tool to generate PDFs, Images, json/xml/txt/csv/... from web and locally supplied data sources

The protocol itself is defined by Google via a JSON-based definition of a websocket interface, allowing for tools to generate the required interface implementation in the language of choice. 

This generator is a work in progress, currently it:

 1. Launches a local instance of chrome
 2. Gets the commit/version of the local instance of chrome
 3. Gets the corresponding Chrome Debugger protocol definition from Google/Chromium sources
 4. Validates the protocol definition against the schema of the generator classes (to ensure the protocol definition schema hasn't evolved - which would require improving the generator classes)
 5. Using mustache-based templates, generates .cs files for each protocol domain, types, commands...
 
Further work needs to be done to add events, generate the .csproj file too, and get the whole thing working as a minimum viable product and go from there.
