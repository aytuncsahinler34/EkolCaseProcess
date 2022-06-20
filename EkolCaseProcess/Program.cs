using System;

namespace EkolCaseProcess
{
	class Program
	{
		static void Main(string[] args) 
		{
			int count = 3;
			string text = "aabbbistanbulaaassskkkk b bbbbbcacaankara";

			var editText = new EditText(text, count);
			string data = editText.Start();

			Console.WriteLine(data);
			Console.ReadLine();
		}
	}
}
