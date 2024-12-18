using System.Text.RegularExpressions;

namespace AdventOfCode.challenges;

public class MullItOver : Challenge {
	public MullItOver(string inFile) : base(inFile) { }

	public void Run() {
		Regex r = new Regex(@"mul\((\d*),(\d*)\)");

		int total = 0;
		
		foreach (string l in this.Input.Lines) {
			MatchCollection x = r.Matches(l);
			foreach (Match m in x) {
				string s = m.ToString().Substring(4, m.Length-5);
				string[] p = s.Split(",");
				int res = int.Parse(p[0]) * int.Parse(p[1]);
				total += int.Parse(p[0]) * int.Parse(p[1]);
				Console.WriteLine($"{p[0]} * {p[1]} = {res}");
			}
		}
		
		Console.WriteLine($"Multiplication Result (Pt. 1): {total}");
	}
}