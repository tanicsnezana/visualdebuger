using Microsoft.VisualStudio.DebuggerVisualizers;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Controls;
using FunctionVisualizersGUI;
using System;
using Items;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(VisualizerForFunctions.FunctionVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(Function),
    Description = "Rock On !!!")]
namespace VisualizerForFunctions
{
    public class FunctionVisualizerObjectSource : VisualizerObjectSource
    {
        public override void GetData(object target, Stream outgoingData)
        {
            FunctionVisualizer.FunctionToStream((Function)target, ref outgoingData);
        }

        public override object CreateReplacementObject(object target, Stream incomingData)
        {
            throw new NotImplementedException();
        }
    }

    public class FunctionVisualizer : Visualizer<Function>
    {
        protected override Function LoadData(IVisualizerObjectProvider objectProvider)
        {
            return StreamToFunction(objectProvider.GetData());
        }

        protected override UserControl GetPresenter(Function data)
        {
            return new FunctionPresenter(data);
        }

        private static Function StreamToString(Stream stream)
        {
            BinaryFormatter deserializer = new BinaryFormatter();
            return (Function)deserializer.Deserialize(stream);
        }

        public static void ArrayToStream(float[] arr, ref Stream stream)
        {
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(stream, arr);
        }
     
        public static void FunctionToStream(Function f, ref Stream stream)
        {
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(stream, f);
        }

        private static Function StreamToFunction(Stream stream)
        {
            BinaryFormatter deserializer = new BinaryFormatter();
            return (Function)deserializer.Deserialize(stream);
        }
    }
}
