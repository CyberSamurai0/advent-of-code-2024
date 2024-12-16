namespace AdventOfCode;

public class Challenge {
	public FileInput Input { get; }
	
	public Challenge(string inFile) {
		this.Input = new FileInput(inFile);
	}
}