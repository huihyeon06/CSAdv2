using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAdv2
{
    internal class Program
    {

        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }

            //ToString() 구현
            public override string ToString()
            {
                return string.Format("Name:{0}, Price:{1}", Name, Price);
            }
            static void Main(string[] args)
        {
                
        }
    }
}
