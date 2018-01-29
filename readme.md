# Setup

- Clone the repo
- Navigate to the root directory of the repo
- Execute `dotnet run --environment=development` or open folder in VSCODE

## Fluent Validation Version

The initially rendered version uses the built-in "Data Annotations" attributes within the base MVC (core) framework, the link to the "Fluent" version replaces this with a 3rd party library we frequently use for server-side validation.  This library outputs a basic set of the client side jquery unobtrusive validation attributes so that jquery.validate continues to function.  

Only a subset are supported but we can mix both types.