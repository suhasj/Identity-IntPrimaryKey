Identity-IntPrimaryKey
======================

A sample that shows using the Asp.Net Identity in the project and having primary key for the classes as int. This uses nightly build of Identity and will be changed once RTM packages are released.

Steps to run project
- Clone project on local machine
- Open in VS and try to build
- The build fails because the Identity packages 2.0.0-alpha1-131211 may not be found. This is because they are being loaded from the nightly feed, 'http://myget.org/f/aspnetwebstacknightly' which might have different build number for that day
- To fix this, set up a private feed for nuget for http://www.myget.org/f/aspnetwebstacknightly. More information http://docs.nuget.org/docs/creating-packages/hosting-your-own-nuget-feeds 
- Right click on project and select 'Manage Nuget packages'. In the online tab, click on the above private feed
- Search for the Identity packages. Note down the version
- Change to this version for Identity packages in the packages.config file. Now build project which causes the packages to be downloaded
- Edit the Identity dll references for the project to point to the correct folders.
- This should build the solution with no errors

Changing the primary key to int
- This involves declaring all IDentity model classes with key type being int. Hooking these model classes into IStore classes and manager class. This can be viewed in the IdentityModels.cs class in the current project
- Edit the pages under 'Account' to use the new manager class
