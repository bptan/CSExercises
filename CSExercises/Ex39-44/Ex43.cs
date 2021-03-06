using System;
namespace CSExercises
{
    public class Ex43
    {
        static void Main(string[] args)
        {
            for (int num = 0; num < 101; num++)
            {
                Console.Write(Hex(num) + " ");
            }
            Console.WriteLine();

            for (int num = 0; num < 101; num++)
            {
                string hexValue = num.ToString("X");
                Console.Write(hexValue + " ");
            }


        }
        public static string Hex(int i)
        {
            
            
            int hexadecimal = 0;
            int hexalength = 16;
            string hexastring = "";
            int count = 0; // tracks if hexadecimal has more than 1 digit
            while (i >= hexalength)
            {
                hexadecimal += 10;
                i -= 16;
                count ++;
            }
            
            if (i < 10)
            {
                hexadecimal += i;
                hexastring = Convert.ToString(hexadecimal);
            }
            else if (count != 0)
            {
                
                switch (i)
                {
                    case 10:
                        hexastring = Convert.ToString(hexadecimal).Substring(0, 1) + "A";
                        break;
                    case 11:
                        hexastring = Convert.ToString(hexadecimal).Substring(0, 1) + "B";
                        break;
                    case 12:
                        hexastring = Convert.ToString(hexadecimal).Substring(0, 1) + "C";
                        break;
                    case 13:
                        hexastring = Convert.ToString(hexadecimal).Substring(0, 1) + "D";
                        break;
                    case 14:
                        hexastring = Convert.ToString(hexadecimal).Substring(0, 1) + "E";
                        break;
                    case 15:
                        hexastring = Convert.ToString(hexadecimal).Substring(0, 1) + "F";
                        break;
                }
            }
            else
            {
                switch (i)
                {
                    case 10:
                        hexastring = "A";
                        break;
                    case 11:
                        hexastring = "B";
                        break;
                    case 12:
                        hexastring = "C";
                        break;
                    case 13:
                        hexastring = "D";
                        break;
                    case 14:
                        hexastring = "E";
                        break;
                    case 15:
                        hexastring = "F";
                        break;
                }
            }
            return hexastring;
        }
    }
}
