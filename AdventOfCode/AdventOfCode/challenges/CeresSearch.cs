namespace AdventOfCode.challenges;

public class CeresSearch : Challenge {
	public CeresSearch(string inFile) : base(inFile) { }
	
	private bool tryN(int row, int col) {
		if (row - 3 < 0) return false;
		if (this.Input.Lines[row][col] != 'X') return false;
		if (this.Input.Lines[row-1][col] != 'M') return false;
		if (this.Input.Lines[row-2][col] != 'A') return false;
		if (this.Input.Lines[row-3][col] != 'S') return false;
		
		return true;
	}

	private bool tryS(int row, int col) {
		if (row + 3 > this.Input.Lines.Length - 1) return false;
		if (this.Input.Lines[row][col] != 'X') return false;
		if (this.Input.Lines[row+1][col] != 'M') return false;
		if (this.Input.Lines[row+2][col] != 'A') return false;
		if (this.Input.Lines[row+3][col] != 'S') return false;
		
		return true;
	}

	private bool tryE(int row, int col) {
		if (col + 3 > this.Input.Lines[0].Length - 1) return false;
		if (this.Input.Lines[row][col] != 'X') return false;
		if (this.Input.Lines[row][col+1] != 'M') return false;
		if (this.Input.Lines[row][col+2] != 'A') return false;
		if (this.Input.Lines[row][col+3] != 'S') return false;
		
		return true;
	}

	private bool tryW(int row, int col) {
		if (col - 3 < 0) return false;
		if (this.Input.Lines[row][col] != 'X') return false;
		if (this.Input.Lines[row][col-1] != 'M') return false;
		if (this.Input.Lines[row][col-2] != 'A') return false;
		if (this.Input.Lines[row][col-3] != 'S') return false;
		
		return true;
	}

	private bool tryNW(int row, int col) {
		if (row - 3 < 0 || col - 3 < 0) return false;
		if (this.Input.Lines[row][col] != 'X') return false;
		if (this.Input.Lines[row-1][col-1] != 'M') return false;
		if (this.Input.Lines[row-2][col-2] != 'A') return false;
		if (this.Input.Lines[row-3][col-3] != 'S') return false;
		
		return true;
	}

	private bool tryNE(int row, int col) {
		if (row - 3 < 0 || col + 3 > this.Input.Lines[0].Length - 1) return false;
		if (this.Input.Lines[row][col] != 'X') return false;
		if (this.Input.Lines[row-1][col+1] != 'M') return false;
		if (this.Input.Lines[row-2][col+2] != 'A') return false;
		if (this.Input.Lines[row-3][col+3] != 'S') return false;
		
		return true;
	}

	private bool trySW(int row, int col) {
		if (row + 3 > this.Input.Lines.Length - 1 || col - 3 < 0) return false;
		if (this.Input.Lines[row][col] != 'X') return false;
		if (this.Input.Lines[row+1][col-1] != 'M') return false;
		if (this.Input.Lines[row+2][col-2] != 'A') return false;
		if (this.Input.Lines[row+3][col-3] != 'S') return false;
		
		return true;
	}

	private bool trySE(int row, int col) {
		if (row + 3 > this.Input.Lines.Length - 1 || col + 3 > this.Input.Lines[0].Length - 1) return false;
		if (this.Input.Lines[row][col] != 'X') return false;
		if (this.Input.Lines[row+1][col+1] != 'M') return false;
		if (this.Input.Lines[row+2][col+2] != 'A') return false;
		if (this.Input.Lines[row+3][col+3] != 'S') return false;
		
		return true;
	}

	public void Run() {
		int total = 0;

		for (int row = 0; row < this.Input.Lines.Length; row++) {
			for (int col = 0; col < this.Input.Lines[0].Length; col++) {
				if (this.Input.Lines[row][col] == 'X') {
					total += tryN(row, col) ? 1 : 0;
					total += tryS(row, col) ? 1 : 0;
					total += tryE(row, col) ? 1 : 0;
					total += tryW(row, col) ? 1 : 0;
					total += tryNW(row, col) ? 1 : 0;
					total += tryNE(row, col) ? 1 : 0;
					total += trySW(row, col) ? 1 : 0;
					total += trySE(row, col) ? 1 : 0;
				}
			}
		}
		
		Console.WriteLine($"\"XMAS\" Count (Pt. 1): {total}");
	}
}