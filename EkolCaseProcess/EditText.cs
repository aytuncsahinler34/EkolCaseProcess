using System.Collections.Generic;

namespace EkolCaseProcess
{
	public class EditText
	{
		private readonly string _text;
		private readonly int _count;

        public EditText(string text, int count) 
        {
            _text = text;
            _count = count;
        }

        public string Start() 
        {
            var list = new List<int>();
            var charList = _text.ToCharArray();
            
            for (int i = 0; i < charList.Length - 1; i++) 
            {
                if (charList[i] == charList[i + 1]) 
                {
                    list.Add(i);
                    list.Add(i + 1);
                }
                else 
                {
                    if (list.Count >= _count) 
                    {
                        foreach (var item in list) 
                        {
                            charList[item] = '*';
                        }
                    }

                    list = new List<int>();
                }
            }

            return new string(charList);
        }
    }
}
