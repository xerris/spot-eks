using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpotEKS
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new SpotStack(app, "StackStack");
            app.Synth();
        }
    }
}
