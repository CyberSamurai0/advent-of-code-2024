using System.Runtime.CompilerServices;

namespace AdventOfCode.challenges;

public class HistorianHysteria : Challenge {
	public HistorianHysteria(string inFile) : base(inFile) { }

	private List<int>? _left;
	private List<int>? _right;

	private int _sum;
	
	public void Run() {
		_left = new List<int>();
		_right = new List<int>();
		_sum = 0;
		
		foreach (string l in this.Input.Lines) {
			string[] x = l.Split("   ");
			_left.Add(int.Parse(x[0]));
			_right.Add(int.Parse(x[1]));
		}
		
		_left.Sort();
		_right.Sort();

		for (int i = 0; i < this.Input.Lines.Length; i++) {
			_sum += Math.Abs(_left[i] - _right[i]);
		}
		
		Console.WriteLine("Total Distance between Lists: " + _sum);
	}
}