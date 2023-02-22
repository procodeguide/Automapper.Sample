# Automapper.Sample
Sample source code for demonstration of impelementation of Automapper in ASP.NET Core

Complete article is available at https://procodeguide.com/programming/automapper-in-asp-net-core/

## Self Contained
Two different types of [.NET Core Application Deployment](https://github.com/dotnet/docs/blob/master/docs/core/deploying/index.md):

You can create two types of deployments for .NET Core applications:

Framework-dependent deployment. As the name implies, framework-dependent deployment (FDD) relies on a shared system-wide version of .NET Core to be present on the target system. Because .NET Core is already present, your app is also portable between installations of .NET Core. Your app contains only its own code and any third-party dependencies that are outside of the .NET Core libraries. FDDs contain .dll files that can be launched by using the dotnet utility from the command line. For example, dotnet app.dll runs an application named app.

Self-contained deployment. Unlike FDD, a self-contained deployment (SCD) does not rely on any shared components to be present on the target system. All components, including both .NET Core libraries and the .NET Core runtime, are included with the application and are isolated from other .NET Core applications. SCDs include an executable (such as app.exe on Windows platforms for an application named app), which is a renamed version of the platform-specific .NET Core host, and a .dll file (such as app.dll), which is the actual application.
