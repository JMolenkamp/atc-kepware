global using System.ComponentModel;
global using System.Diagnostics.CodeAnalysis;
global using System.Net;
global using System.Reflection;
global using System.Text;

global using Atc.Console.Spectre;
global using Atc.Console.Spectre.CommandSettings;
global using Atc.Console.Spectre.Factories;
global using Atc.Console.Spectre.Helpers;
global using Atc.Console.Spectre.Logging;
global using Atc.Helpers;
global using Atc.Kepware.Configuration.CLI.Commands;
global using Atc.Kepware.Configuration.CLI.Commands.Connectivity;
global using Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes.Connectivity;
global using Atc.Kepware.Configuration.CLI.Commands.DescriptionAttributes.IotGateway;
global using Atc.Kepware.Configuration.CLI.Commands.Helpers;
global using Atc.Kepware.Configuration.CLI.Commands.IotGateway;
global using Atc.Kepware.Configuration.CLI.Commands.Settings;
global using Atc.Kepware.Configuration.CLI.Commands.Settings.Connectivity;
global using Atc.Kepware.Configuration.CLI.Commands.Settings.IotGateway;
global using Atc.Kepware.Configuration.CLI.Extensions;
global using Atc.Kepware.Configuration.Contracts;
global using Atc.Kepware.Configuration.Contracts.Connectivity;
global using Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.EuroMap63;
global using Atc.Kepware.Configuration.Contracts.Connectivity.Drivers.OpcUaClient;
global using Atc.Kepware.Configuration.Contracts.IotGateway;
global using Atc.Kepware.Configuration.Services;

global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.Logging;

global using Spectre.Console;
global using Spectre.Console.Cli;
