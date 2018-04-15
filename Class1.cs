using System;           
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Class1
    {
        public static byte MaxValue { get; set; }
       
        static Random r = new Random();
        public static void Random1(Byte[] ran,bool check)
        {
            if (check == true)
            {
                r.NextBytes(ran);
                return;
            }
            if(check==false)
            {
                int i = 0;
                while (i<ran.Length)
                {
                        
                    ran[i] =Convert.ToByte(r.Next(65, 90));
                    i++;
                    
                }
                return;  
               
            }
            }

        public static void Max(byte [] x)
        {

            Array.Sort(x);
            MaxValue = x[x.Length-1];
            return;

        }

        public static void Save(byte[] x)
        {

        }

    }
}
