namespace AdventOfCode.challenges;

public class RedNosedReports : Challenge {
	public RedNosedReports(string inFile) : base(inFile) { }

	private bool CheckReportStable(int[] x) {
		return GetReportBadIndex(x) == -1;
	}

	/// <returns>Index of the first bad value, or -1 if the report is valid</returns>
	private int GetReportBadIndex(int[] x) {
		if (x[0] == x[1]) return 0; // Unstable, no increase/decrease
		
		if (x[0] < x[1]) { // INCREASE
			for (int i = 1; i < x.Length; i++) {
				// Verify that it keeps increasing, and does so by less than 3
				if (x[i - 1] < x[i] && Math.Abs(x[i - 1] - x[i]) <= 3) continue;

				// It does not increase!
				return i;
			}
		} else if (x[0] > x[1]) { // DECREASE
			for (int i = 1; i < x.Length; i++) {
				// Verify that it keeps decreasing, and does so by less than 3
				if (x[i - 1] > x[i] && Math.Abs(x[i - 1] - x[i]) <= 3) continue;

				// It does not decrease!
				return i;
			}
		}

		return -1;
	}
	
	private void PartOne() {
		int count = 0;
		
		foreach (string l in this.Input.Lines) {
			string[] y = l.Split();
			int[] x = y.Select(int.Parse).ToArray();

			if (CheckReportStable(x)) {
				count++;
			}

		}
		
		Console.WriteLine("Stable Reports (Pt. 1): " + count);
	}

	private void PartTwo() {
		int count = 0;
		
		foreach (string l in this.Input.Lines) {
			string[] y = l.Split();
			int[] x = y.Select(int.Parse).ToArray();

			int i = GetReportBadIndex(x);
			if (i == -1) {
				count++;
				continue;
			}
			
			for (int j = 0; j < x.Length; j++) Console.Write((j == i ? "\x1b[31m" : "") + x[j] + " \x1b[0m");
			Console.WriteLine();
			
			int[] z = new int[x.Length-1];
			int zpos = 0;
			for (int j = 0; j < x.Length; j++) {
				if (j == i) continue; // Skip bad index
				z[zpos] = x[j];
				zpos++;
			}
			
			foreach (int j in z) Console.Write(j + " ");
			Console.WriteLine();

			if (CheckReportStable(z)) {
				count++;
				Console.WriteLine("\x1b[34mStable\x1b[0m");
			} else {
				Console.WriteLine("\x1b[31mUnstable\x1b[0m");
				
				// Although HORRIBLY inefficient, this solves the case where the FIRST VALUE is the problem value
				int[] f = new int[x.Length - 1];
				for (int j = 1; j < x.Length; j++) {
					f[j-1] = x[j];
				}
				
				Console.Write("Attempt 2: \t");
				for (int j = 0; j < f.Length; j++) Console.Write((j == 0 ? "\x1b[31m" : "") + f[j] + " \x1b[0m");
				Console.WriteLine();

				if (CheckReportStable(f)) {
					count++;
					Console.WriteLine("\x1b[34mSlightly Stable\x1b[0m");
				} else {
					Console.WriteLine("\x1b[31mUnstable\x1b[0m");
				}
			}
		}
		
		Console.WriteLine("Dampener Stable Reports (Pt. 2): " + count);
	}

	// TODO PT 2 : 398 is not the right answer (too low)
	
	public void Run() {
		PartOne();
		PartTwo();
	}
}