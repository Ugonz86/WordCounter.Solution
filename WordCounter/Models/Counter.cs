using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public string WordInput { get; set; }
        public string SentenceInput { get; set; }

        private static Char[] _specialCharacters = { '.', ',', '!', '?', '#', '$', '%', '&', '_', '-', '+', '=', '~', '`', '^', '*', '(', ')', '{', '}', '[', ']', '1', '2', '3', '4', '5', '6', '7', '8', '9', '@', 'ñ', 'Ñ'};

        public RepeatCounter(string word, string sentence)
        {
            WordInput = word;
            SentenceInput = sentence;
        }

        public static bool ValidInput(string input)
        {
            bool output = true;
            if (input.Length == 0)
            {
                output = false;
            }
            else if (input.Contains(' '))
            {
                output = false;
            }
            else
            {
                for (int i = 0; i < _specialCharacters.Length; i++)
                {
                    if (input.Contains(_specialCharacters[i]))
                    {
                        output = false;
                    }
                }
            }
            return output;
        }

        public int characterCount()
        {
            int wordCount = 0;

            string[] wordArray = SentenceInput.Split(' ');
            for (int i = 0; i < wordArray.Length; i++)
            {
                foreach (char sentenceChar in _specialCharacters)
                {
                    if (wordArray[i].Contains(sentenceChar))
                    {
                        wordArray[i] = wordArray[i].Trim(_specialCharacters);
                    }
                }

                if (WordInput == wordArray[i])
                {
                    wordCount++;                
                }
            }
            return wordCount;
        }
    }
}