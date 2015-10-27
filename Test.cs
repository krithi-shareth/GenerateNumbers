using System;
using System.Collections.Generic;
namespace Test
{

    class Test
    {

        public static string[] printnumber(int n, params KeyValuePair<int,string>[] pairs )
        {
          
            string[] output = new string[n+1];
            for (int i = 1; i <= n; i++)
            {
                output[i] = i.ToString();
                //Console.WriteLine(i);

                foreach (var args in pairs)
                {
                    if (i%args.Key==0)
                    {
                        //override the i value with the string given
                        if (output[i]==i.ToString())
                            output[i] = string.Empty;
                        
                        output[i] += args.Value;
                        //break;
                    }
                }
                
                
            }
            return output;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Parameters to call function: n- limit, new KeyValuePair<int, string>(2, \"string \") ");
            string[] answer = printnumber(15, new KeyValuePair<int, string>(2, "hi"), new KeyValuePair<int, string>(3, "fizz"), new KeyValuePair<int, string>(5, "buzz"));
            foreach (string i in answer)
                Console.WriteLine("{0}", i);
            Console.ReadKey();
        }
    }
}
