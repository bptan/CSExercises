namespace CSExercises
{
    public class Ex41
    {
        //static void Main(string[] args)
        //{
        //    System.Console.WriteLine(InString("abcdefg", "csde"));
        //}
        public static bool InString(string s1, string s2)
        {
            bool found = false;
            
            for(int i = 0; i<s1.Length-s2.Length;i++)
            {
                string ins1 = s1.Substring(i,s2.Length);
                if(ins1 == s2)
                {
                    found = true;
                }               
            }
            return found;
            
        }
    }
}
