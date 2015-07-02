# WinFormsSquirrelExample
An attempt to use squirrel and fluent migration in a winform project

- created a winform project
- enable auto update nuget package on build
- added demo library to demo project
- added squirrel nuget pkg to program

- downloaded and installed nuget package explorer for windows application
- created a new simple package (id, title, version)
- added a lib folder to package
- added a .net 4.5 folder to lib (as written in squirrel docs)
- saved the metadata as the .nuspec in the main program dir
- added all the /bin/debug/*.dll to the 4.5 folder 
- resaved the .nuspec
- create a batch file that packs the .nuspec and produces a .nupkg (same dir)

- run squirrel from PMConsole: Squirrel --releasify 
- restarted VS if error: https://github.com/Squirrel/Squirrel.Windows/issues/222

