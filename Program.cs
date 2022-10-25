// See https://aka.ms/new-console-template for more information
using Jint;
using JintPocConsoleApp;
using System.Linq;

// https://github.com/sebastienros/jint

var mapperScriptLines = File.ReadAllLines(".\\mapper.mjs").Where(l => !l.StartsWith("export"));

var processedScriptLines = new List<string>();

foreach (var line in mapperScriptLines)
{
    if (line.StartsWith("import"))
    {
        var importLines = File.ReadLines(".\\enumMappers.mjs").Where(l => !l.StartsWith("export")).ToArray();
        Array.ForEach(importLines, l => processedScriptLines.Add(l));
    }
    else
    {
        processedScriptLines.Add(line);
    }
}

var mapScript = String.Join(Environment.NewLine, processedScriptLines);

var engine = new Engine()
    .Execute(mapScript);

var inputs = new Dictionary<string, object>
{
    { "source", new SourceModel { LoanAmount = 666, securityPostcode = "PR1 9LB", SecurityType = SecurityType.House } },
};

//var result = engine.Invoke("add", new Inputs { a = 1, b = 2}); // -> 3
var result = engine.Invoke("map", inputs); // -> 3

Console.WriteLine("result=" + result);