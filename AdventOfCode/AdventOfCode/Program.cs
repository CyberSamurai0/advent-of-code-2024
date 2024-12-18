// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Runtime.CompilerServices;
using AdventOfCode.challenges;

string day = args.Length >= 1 ? args[0] : "1";

// WARNING - you must configure the working directory to the source code directory so that it knows where to retrieve input files!
if (day.Equals("1")) new HistorianHysteria("./inputs/one.txt").Run();
if (day.Equals("2")) new RedNosedReports("./inputs/two.txt").Run();
if (day.Equals("3")) new MullItOver("./inputs/three.txt").Run();
if (day.Equals("4")) new CeresSearch("./inputs/four.txt").Run();
return 0;