﻿using DependencyManagement.Composition.Containers;
using DependencyManagement.Examples.Simple;
using DependencyManagement.Injection.Extensions;

await using var container = new Container()
    .WithStrategies()
    .WithProviders();

container.SetTarget<ExampleService>().ToSingleton();
container.SetTarget<ModernExampleService>().ToSingleton();

var service = container.LastInstance<ModernExampleService>();

Console.WriteLine(service.GetHashCode());