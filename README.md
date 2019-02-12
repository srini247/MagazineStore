# Magazine Store Application

# To run this application 

1. Click clone/download button on top right ans select download zip.this will down the project source as .zip file
2. Goto downloads folder on your computer,find MagazineStore-master.zip file and unzip it to desired location.
3. Open Visual studio 2017 --> File --> open --> Project/Solution and browse to unzipped MagazineStore-master folder.
4. Select MazineStore.sln file and click open to open project in Visual studio.
5. Security Warning message might be displayed, clik OK to continue and  open project in Visual studio.
3. Hit F6 Build project to load necessary Nuget packages.
4. Hit (ctlr + F5) to run in realease mode.

# Magazine Store Application Details.

* Magazine Store is console application built on .Net Framework 4.6.1 and Visual Studio 2017.
* Nuget package installed Microsoft.AspNet.WebApi.Client(For web api calls) and Newtonsoft.Json(to convert outout to json string).
* Magazine Store makes multiple asycn webapi call to retrive Data.
* Running in release mode will be faster than running in debug mode.
* webapi static class handles all the webapi calls.
* Models contains all the data objects.
* Failed webapi calls will return null object and a error message is logged to console.

