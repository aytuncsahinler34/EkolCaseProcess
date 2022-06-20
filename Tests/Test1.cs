using EkolCaseProcess;
using Xunit;
using FluentAssertions;

namespace EkolCaseProcessTest
{
	public class Test1
	{
		
		[Theory]
		[InlineData("aabbbistanbulaaassskkkk b bbbbbcacaankara", 9, "aabbbistanbulaaassskkkk b bbbbbcacaankara")]
		[InlineData("aabbbistanbulaaassskkkk b bbbbbcacaankara", 5, "aabbbistanbulaaassskkkk b *****cacaankara")]
		[InlineData("aabbbistanbulaaassskkkk b bbbbbcacaankara", 4, "aabbbistanbulaaasss**** b *****cacaankara")]
		[InlineData("aabbbistanbulaaassskkkk b bbbbbcacaankara", 3, "aa***istanbul********** b *****cacaankara")]
		[InlineData("aabbbistanbulaaassskkkk b bbbbbcacaankara", 2, "*****istanbul********** b *****cac**nkara")]
        public void ExecuteCommands(string text, int count, string editedData) 
		{
            var editText = new EditText(text, count);
            var data = editText.Start();
			data.Should().Be(editedData);
        }
    }
}
