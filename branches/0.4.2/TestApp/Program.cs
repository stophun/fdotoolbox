using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestApp app = new TestApp();
            using (app) { app.Run(args); }
        }
    }
}
