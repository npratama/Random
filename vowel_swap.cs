using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stvisionit
{
    class Program
    {

        static void Main(string[] args)
        {

            string A = "leetcode";
            Console.WriteLine("a: {0}", A);
            A = reverse(A);
            Console.WriteLine("a: {0}", A);

            Console.ReadLine();

        }

        public static string reverse(string value)
        {
            char[] cArray = value.ToCharArray();
            string reverse = String.Empty;
            List<int> vowel_location = new List<int>();
        
            //find where is the vowels first
            for (int i = 0; i < cArray.Length; i++)
            {               
                if ((cArray[i] == 'a' || cArray[i] == 'i' || cArray[i] == 'u' || cArray[i] == 'e' || cArray[i] == 'o') ) vowel_location.Add(i);                
            }
            
            //do the actual swap
            //keep track what index of vowel location used
            int k = 0;
            //order the vowel location from behind
            int c = vowel_location.Count()-1;
            for (int i = 0; i < cArray.Length; i++)
            {
                //if vowel found
                if (i == vowel_location[k])
                {
                    //add the backward counted vowel to main newly reconstructed string
                    reverse += cArray[vowel_location[c]];
                    //vowel counter index up
                    k ++;
                    //reversed reading for vowel up
                    c--;
                }
                else
                //if not vowel then just rearange forward reading as usual
                reverse += cArray[i];
               
            }
            
            //my original answer
            //for (int i = cArray.Length - 1; i > -1; i--)
            //{

            //    reverse += cArray[i];
            //}
            return reverse;
        }
    }
}
