using System.Runtime.CompilerServices;

namespace AdventOfCode;

public class FileInput {
	public string Path { get; }
	public string Text { get; }
	public string[] Lines { get; }

	public FileInput(string path) {
		this.Path = path;
		
		if (File.Exists(this.Path)) {
			this.Text = File.ReadAllText(this.Path);
			this.Lines = File.ReadAllLines(this.Path);
		} else {
			Console.WriteLine($"File {this.Path} not found");
			this.Text = "";
			this.Lines = Array.Empty<string>();
		}
	}
}