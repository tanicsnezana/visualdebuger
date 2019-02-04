using VisualizerForFunctions;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Linq;
using Items;

namespace VisualizersTest
{
    class Program
    {
        public static void TestShowVisualizer(Function objectToVisualize)
        {
            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(FunctionVisualizer), typeof(VisualizerObjectSource));
            visualizerHost.ShowVisualizer();
        }

        static void Main(string[] args)
        {
            Function f = new Function();
            // FunctionParameter fp = new FunctionParameter('+', 5, 2);
            // FunctionParameter fp1 = new FunctionParameter('-', 4, 1);
            // FunctionParameter fp2 = new FunctionParameter('+', 2, 0);

            // f.Parameter.Add(fp); f.Parameter.Add(fp1); f.Parameter.Add(fp2);

             FunctionParameter fp2 = new FunctionParameter('+', 2, 1);
            f.Parameter.Add(fp2);

            FunctionParameter fp3 = new FunctionParameter('+', 6, 0);
            f.Parameter.Add(fp3);

            //Random rnd = new Random();
            //var arr = Enumerable.Repeat(0, 4410).Select(x => (float)rnd.NextDouble() - 0.5f).ToArray();
            TestShowVisualizer(f);
        }
    }
}
