namespace CSExercises
{
    public class Ex44
    {
        static void Main(string[] args)
        {
            string word = Substitute("abcdeaa", 'a', 'b');
            System.Console.WriteLine(word);
        }
        public static string Substitute(string s, char c1, char c2)
        {
            string newword = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c1)
                {
                    newword += c2;
                }
                else
                {
                    newword += s[i];
                }
            }
            return newword;
        }
    }
}
