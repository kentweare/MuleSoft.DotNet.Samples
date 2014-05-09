using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuleSoft.DotNet.HelloWorld
{

    //Very Simple class 
    public class SayHelloWorld
    {
        public string SayHello (String input)
        {
            return String.Format("Hello {0}", input);
        }   
    }
}
