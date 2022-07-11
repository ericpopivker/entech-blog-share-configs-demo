// See https://aka.ms/new-console-template for more information
using ShareConfigsDemo.Core;

var config = ConfigHelper.Load();
var key1Value = config.GetSection("Key1").Value;
Console.WriteLine($"Key1: {key1Value}");
