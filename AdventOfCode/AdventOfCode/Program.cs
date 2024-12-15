// See https://aka.ms/new-console-template for more information

using AdventOfCode.challenges;

string day;
string input;

if (args.Length >= 2) {
	day = args[0];
	input = args[1];
} else if (args.Length == 1) {
	day = "1";
	input = args[1];
} else {
	Console.WriteLine("Missing required input. Usage:");
	Console.WriteLine(" [day=1] <inputTextFile>");
	return 1;
}

if (day.Equals("1")) new HistorianHysteria(input).Run();

return 0;