namespace CSExercises
{
    public class Ex42
    {
        //static void Main(string[] args)
        //{
        //    System.Console.WriteLine(FindWord("abcdefg", "cede"));
        //}
        public static int FindWord(string s1, string s2)
        {
            int startposition = -1;
            for (int i = 0; i < s1.Length - s2.Length; i++)
            {
                string ins1 = s1.Substring(i, s2.Length);
                if (ins1 == s2)
                {
                    startposition = i;
                }
            }
            
            return startposition;
        }
    }
}
