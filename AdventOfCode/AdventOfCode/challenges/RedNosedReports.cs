namespace AdventOfCode.challenges;

public class RedNosedReports : Challenge {
	public RedNosedReports(string inFile) : base(inFile) { }

	public void Run() {
		int count = 0;
		
		foreach (string l in this.Input.Lines) {
			string[] y = l.Split();
			int[] x = y.Select(int.Parse).ToArray();

			int isStable = 1;

			if (x[0] == x[1]) isStable = 0; // Unstable, no increase/decrease
			else if (x[0] < x[1]) { // INCREASE
				for (int i = 1; i < x.Length; i++) {
					// Verify that it keeps increasing, and does so by less than 2
					if (x[i-1] < x[i] && Math.Abs(x[i-1] - x[i]) <= 3) continue;
					isStable = 0;
					break;
				}
			}
			else if (x[0] > x[1]) { // DECREASE
				for (int i = 1; i < x.Length; i++) {
					// Verify that it keeps decreasing, and does so by less than 2
					if (x[i-1] > x[i] && Math.Abs(x[i-1] - x[i]) <= 3) continue;
					isStable = 0;
					break;
				}
			}

			count += isStable; // If stable, add 1
		}
		
		Console.WriteLine("Stable Reports (Pt. 1): " + count);
	}
}