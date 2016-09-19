namespace _06_Book_Titles
{
    internal class Book
    {
        public string wordsToReturn = "";
        public string Title
        {
            get
            {
                return wordsToReturn;
            }
            internal set
            {
                string[] words = value.Split(' ');
                bool firstWord = true;
                foreach (string word in words)
                {
                    if ((word == "the" || word == "a" || word == "an" || word == "and" || word == "in" || word == "of" )&& firstWord == false)
                    {
                        wordsToReturn = wordsToReturn + " " + word;
                    }
                    else
                    {
                        wordsToReturn = wordsToReturn + " " + word.Substring(0, 1).ToUpper() + word.Substring(1);
                        wordsToReturn = wordsToReturn.Trim();
                    }
                    firstWord = false;
                }

            }

        }


    }
}