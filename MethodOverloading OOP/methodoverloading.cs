using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading_OOP
{
    public class methodoverloading
    {
        public int AddNumbers(string s1,string s2)
        {
            int n1 = Convert.ToInt32(s1);
            int n2 = Convert.ToInt32(s2);
            return n1 + n2;
        }
        public int AddNumbers(string s1, string s2,string s3)
        {
            int n1 = Convert.ToInt32(s1);
            int n2 = Convert.ToInt32(s2);
            int n3 = Convert.ToInt32(s3);
            return n1 + n2 + n3;
        }
    }
}
