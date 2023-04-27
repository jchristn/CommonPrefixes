![alt tag](https://github.com/jchristn/CommonPrefixes/raw/main/Assets/icon.png)

# CommonPrefixes

CommonPrefixes is a simple static library that evalutes a list of strings and returns a list of strings representing the common prefixes found amongst list members based on a user-specified delimiter.

[![NuGet Version](https://img.shields.io/nuget/v/CommonPrefixes.svg?style=flat)](https://www.nuget.org/packages/CommonPrefixes/) [![NuGet](https://img.shields.io/nuget/dt/CommonPrefixes.svg)](https://www.nuget.org/packages/CommonPrefixes) 

## Help, Feedback, Contribute

If you have any issues or feedback, please file an issue here in Github. We'd love to have you help by contributing code for new features, optimization to the existing codebase, ideas for future releases, or fixes!

## New in v1.0.x

- Initial release

## Example Project

Refer to the ```Test``` project for exercising the library.

## Getting Started
```csharp
using CommonPrefixes;

public static List<string> _Values = new List<string>
{
  "/foo/",
  "/foo/bar/",
  "/foo/bar/file1",
  "/foo/bar/file2"
};

List<string> prefixes = PrefixesFinder.Find(_Values, '/');
// List contains:
//    /foo/
//    /foo/bar/
```

## Version History

Refer to CHANGELOG.md for version history.
