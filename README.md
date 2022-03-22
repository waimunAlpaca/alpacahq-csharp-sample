# alpacahq-csharp-sample

A simple C# project to get you started on alpaca APIs.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

Install [.NET 6.0](https://dotnet.microsoft.com/en-us/download).;


Install the Alpaca.Markets package.

```
dotnet add package Alpaca.Markets
```

Install the Alpaca.Markets.Extensions package.

```
dotnet add package Alpaca.Markets.Extensions
```

Verify the version of the Alpaca.Markets packages your project is currently using. 

| Package | Stable | Pre-release |
| ------- | ------ | ----------- |
| [Alpaca.Markets](https://olegra.github.io/Alpaca.Markets/api/Alpaca.Markets.html) | [![Nuget](https://img.shields.io/nuget/v/Alpaca.Markets?logo=NuGet)](https://www.nuget.org/packages/Alpaca.Markets) | [![Nuget](https://img.shields.io/nuget/vpre/Alpaca.Markets?logo=NuGet)](https://www.nuget.org/packages/Alpaca.Markets/absoluteLatest) |
| [Alpaca.Markets.Extensions](https://olegra.github.io/Alpaca.Markets/api/Alpaca.Markets.Extensions.html) | [![Nuget](https://img.shields.io/nuget/v/Alpaca.Markets.Extensions?logo=NuGet)](https://www.nuget.org/packages/Alpaca.Markets.Extensions) | [![Nuget](https://img.shields.io/nuget/vpre/Alpaca.Markets.Extensions?logo=NuGet)](https://www.nuget.org/packages/Alpaca.Markets.Extensions/absoluteLatest) |


### Setup the API KEY_ID and SECRET_KEY

1. Get the API Key & Secret from [Alpaca](https://app.alpaca.markets/paper/dashboard/overview).  

2. Set the `KEY_ID` & `SECRET_KEY` values in `Program.cs`.  

### Run the project

To run the command.

```
dotnet run
```

You should be able to view your positions in the [Alpaca](https://app.alpaca.markets/paper/dashboard/overview) website / `Order History` tab.

## References

Check out the **UsageExamples** project for near-to-real-world strategy implementation using this SDK and the **Alpaca.Markets.Tests** repository for SDK usage examples.

* [Alpaca.Markets.Tests](https://github.com/alpacahq/alpaca-trade-api-csharp/tree/develop/Alpaca.Markets.Tests)
* [Alpaca.Markets.Extensions.Tests](https://github.com/alpacahq/alpaca-trade-api-csharp/tree/develop/Alpaca.Markets.Extensions.Tests)
* [UsageExamples](https://github.com/alpacahq/alpaca-trade-api-csharp/tree/develop/UsageExamples)


## Built With

* Official client SDKs [alpaca-trade-api-csharp](https://github.com/alpacahq/alpaca-trade-api-csharp/) / [NuGet](https://www.nuget.org/packages/Alpaca.Markets/)
* [alpaca Broker API](https://alpaca.markets/docs/broker/)
* [alpaca Trading API](https://alpaca.markets/docs/trading/)
* [alpaca Market Data API](https://alpaca.markets/docs/market-data/)
* [README.md](https://github.com/waimunAlpaca/README.md) - Yet another README.md template! 

## Contributing

Want to file a bug, contribute some code, or improve documentation? Excellent! Read up on our [CONTRIBUTING.md](https://github.com/angular/angular/blob/master/CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Wai Mun** - *Initial work* - [waimunAlpaca](https://github.com/waimunAlpaca)

## License

This project is licensed under the Apache License License - see the [LICENSE](LICENSE) file for details

## Acknowledgments

* [CONTRIBUTING.md](https://github.com/angular/angular/blob/master/CONTRIBUTING.md) - Contributing to Angular.
* [Conventional Commits](https://www.conventionalcommits.org/) - A specification for adding human and machine readable meaning to commit messages.
