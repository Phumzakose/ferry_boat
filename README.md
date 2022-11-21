# ferry_boat

[![.NET](https://github.com/Phumzakose/ferry_boat/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/Phumzakose/ferry_boat/actions/workflows/dotnet-desktop.yml)

# Code Coverage

- To get started work on the tests folder: cd FerryFunction.Test
- To check if all the code is covered by the unit tests: install Coverlet
- To install coverlet run the command: dotnet tool install -g coverlet.console
- After installing the coverlet then build my test by running the command: dotnet build
- Then run the command Coverlet./FerryFunction.Test.dll --target "dotnet" --targetargs "test--no-build"
- Then on the CLI you will see a table that will show you how much is your code covered by the unit tests
- If there is nothing showing then you can also try coverlet collector
- Add the coverlet nugget package by running the command: dotnet add package coverlet.collector
- Then run this command: dotnet test--collect: "XPlat Code Coverage" This command will show you all the tests that are passing and will create a folder named TestResults in your tests folder.

- The Xplat Code Coverage is what is added in that nugget package
- Inside that TestResults folder there will be an xml file that will tell you how much of your code is covered by the unit tests.
- To build that xml file into something that will be user friendly then you can use the report generator to convert the xml file into html
- To install the report generator run the command: dotnet tool install -g dotnet-reportgenerator-globaltool
- Then after installing reportgenerator the run the command: reportgenerator -reports:"./TestResults/df5f0c84-de40-43fd-9017-085e94f77cbc/coverage.cobertura.xml" -targetdir:"coverageresults" -reporttypes:Html
- Then there will be a new folder called coverage results which will have many files got to the html and open it to the browser to see how much code is covered and which lines are covered.
