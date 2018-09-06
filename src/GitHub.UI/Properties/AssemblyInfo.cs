﻿using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Markup;

[assembly: AssemblyTitle("GitHub.UI")]
[assembly: AssemblyDescription("GitHub flavored WPF styles and controls")]
[assembly: Guid("f3cec21e-6a86-43ae-97a6-a274fa31efbe")]
[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                     //(used if a resource is not found in the page, 
                                     // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                              //(used if a resource is not found in the page, 
                                              // app, or any theme specific resource dictionaries)
    )]

[assembly: XmlnsDefinition("https://github.com/github/VisualStudio", "GitHub.Helpers")]
[assembly: XmlnsDefinition("https://github.com/github/VisualStudio", "GitHub.UI")]
[assembly: XmlnsDefinition("https://github.com/github/VisualStudio", "GitHub.UI.Controls")]
[assembly: XmlnsDefinition("https://github.com/github/VisualStudio", "GitHub.UI.Converters")]
[assembly: XmlnsDefinition("https://github.com/github/VisualStudio", "GitHub.UI.Helpers")]
[assembly: XmlnsDefinition("https://github.com/github/VisualStudio", "GitHub.UI.TestAutomation")]
