# Got2Insure Technical CSharp VehicleValueService Test
Base build for the Got2Insure Technical C# VehicleValueService Test

# Instructions
1. Unzip the password protected `got2insure.settings.zip` file to your `%TEMP%` folder using the password provided separately.
2. Open the solution in VS 2019 or VS 2022.
3. Read the instructions in the `src\Got2Insure.Technical.CSharp.VehicleValueService\VehicleValueService.cs`

Note that your system may have different `%TEMP%` folders for 32-bit (`x86`) and 64-bit (`x64`). If you get an error indicating that `got2insure.settings.json` cannot be found, three potential solutions are:

* Unzip `got2insure.settings.zip` to both `%TEMP%` folders.
* Change the default processor architecture for running tests in Visual Studio.
* Update line 12 of `VehicleValueServiceTests.cs` to point at the full file path of the unzipped `got2insure.settings.json` file.
