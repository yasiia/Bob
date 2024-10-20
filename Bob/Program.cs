namespace Bob
{
    internal class Program
    {
        public static class Bob
        {
            public static string Response(string statement)
            {
                statement = statement.Trim();

                bool isQuestion = statement.EndsWith("?");
                bool isYelling = IsYelling(statement);


                if (isYelling && isQuestion)
                {
                    return "Calm down, I know what I'm doing!";
                }


                if (isYelling)
                {
                    return "Whoa, chill out!";
                }


                if (isQuestion)
                {
                    return "Sure.";
                }
                if (string.IsNullOrEmpty(statement))
                {
                    return "Fine. Be that way!";
                }

                return "Whatever.";
            }


            private static bool IsYelling(string statement)
            {
                bool hasLetters = false;
                bool isUpperCase = true;

                foreach (char c in statement)
                {
                    if (char.IsLetter(c))
                    {
                        hasLetters = true;
                        if (char.IsLower(c))
                        {
                            isUpperCase = false;
                            break;
                        }
                    }
                }

                return hasLetters && isUpperCase;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Bob.Response("How are you?"));            
            Console.WriteLine(Bob.Response("HELLO!"));                 
            Console.WriteLine(Bob.Response("HELLO?"));                 
            Console.WriteLine(Bob.Response("   "));                   
            Console.WriteLine(Bob.Response("Whatever."));
        }
    }
}
