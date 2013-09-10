NuGet package: [http://nuget.org/packages/MvvmQuickCross](http://nuget.org/packages/mvvmquickcross)

# MvvmQuickCross
Quickly build cross-platform apps in C# with the MVVM pattern and [Xamarin](http://xamarin.com/).

## Summary
MvvmQuickCross is a cross-platform MVVM pattern to quickly build native iOS, Android, Windows Phone and Windows Store Apps with shared C# code and Xamarin.

MvvmQuickCross aims to deliver the benefit of data binding and design-time data to speed up development, while eliminating the coding overhead that data binding brings - by using code snippets - on all platforms.

MvvmQuickCross also aims to maximize the percentage of shared code across platforms, including navigation logic, with a specific Application+Navigator pattern.

MvvmQuickCross is lightweight and easy to modify: it adds no binaries, just one Visual Studio C# code snippets file and a few C# source files.

## Getting Started
**Note: for a detailed step-by-step guide on how to build the CloudAuction example app that can be found in this repository, see [here](http://vincenth.net/blog/archive/2013/08/30/creating-a-cross-platform-native-app-using-mvvmquickcross-and-xamarin-part-1-cross-platform-code-and-windows-8-app.aspx).**

**A quickstart and an overview will be posted and linked to from here shortly (eta Sept 14, 2013)**

The high-level steps for creating a cross-platforn app are:

1. In Visual Studio, create a solution for the platform (Windows Store, Windows Phone, Android, iOS) that you are most productive with. Add a class library project for that platform and an application project for that platform. Reference the class library from the application project.

2. Install the [MvvmQuickCross NuGet package](http://nuget.org/packages/mvvmquickcross) in the class library project.
	
	**Note** that the package installation uses the first part of the solution filename (before the first dot) as the application name for naming new project items and classes.

3. Import the C# code snippets from the MvvmQuickCross\MvvmQuickCross.snippet file into Visual Studio with the Code Snippets Manager (see [how](http://msdn.microsoft.com/en-us/library/ms165394\(v=vs.110\).aspx)).
	
	**Note** do not select the MvvmQuickCross folder itself as the location to import snippets **to**; that may prevent the snippets to be imported correctly, as this would mean copying the snippets file over itself.

4. Start coding, following the guidance in the files ViewModels\\\_VIEWNAME\_ViewModel.cs, \_APPNAME\_Application.cs and I\_APPNAME\_Navigator.cs in your class library project, and the SampleApp and CloudAuction example apps in this GitHub repository

To code your app for other platforms, create a new solution for each platform, with a class library project for that platform and an application project for that platform, just like you did for the first platform. Then add all code files from the existing class library project to the class library project for the new platform. Then code the views, navigator and platform specific service implementations in the application project.