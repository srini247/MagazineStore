# Magazine Store Application

# To run this application 

1. click clone/download button on top right ans select download zip.this will down the project source as .zip file
2. goto downloaded folder , open MagazineStore.sln file in visual studio 2017.
3. Build project to load necessary Nuget packages.
4. run (ctlr + f5) to run in realease mode.

* Magazine Store is console application built on .Net Framework 4.5.1 and Visual Studio 2017.

* Nuget package installed Microsoft.AspNet.WebApi.Client(For web api calls) and Newtonsoft.Json(to convert outout to json string).

* Magazine Store makes multiple asycn webapi call to retrive Data.

* Running in release mode will be faster than running in debug mode.

 * webapi static class handles all the webapi calls.

 * Models contains all the data objects.

 * Failed webapi calls will return null object and a error message is logged to console.

