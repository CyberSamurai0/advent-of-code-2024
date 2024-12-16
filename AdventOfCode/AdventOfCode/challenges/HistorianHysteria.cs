using System.Runtime.CompilerServices;

namespace AdventOfCode.challenges;

public class HistorianHysteria : Challenge {
	public HistorianHysteria(string inFile) : base(inFile) { }
	
	public void Run() {
		List<int> left = new List<int>();
		List<int> right = new List<int>();
		int sum = 0;
		
		foreach (string l in this.Input.Lines) {
			string[] x = l.Split("   ");
			left.Add(int.Parse(x[0]));
			right.Add(int.Parse(x[1]));
		}
		
		left.Sort();
		right.Sort();

		for (int i = 0; i < this.Input.Lines.Length; i++) {
			sum += Math.Abs(left[i] - right[i]);
		}
		
		Console.WriteLine("Total Distance between Lists (Pt. 1): " + sum);

		int sum2 = 0;
		foreach (int l in left) {
			int count = 0;
			foreach (int r in right) {
				if (l == r) count++;
			}
			sum2 += l * count;
		}
		
		Console.WriteLine("List Similarity Score (Pt. 2): " + sum2);
	}
}