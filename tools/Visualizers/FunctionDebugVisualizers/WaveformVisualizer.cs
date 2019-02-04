using Microsoft.VisualStudio.DebuggerVisualizers;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Controls;
using FunctionVisualizersGUI;
using System;

//[assembly: System.Diagnostics.DebuggerVisualizer(
//    typeof(VisualizerForFunctions.WaveformVisualizer),
//    typeof(VisualizerObjectSource),
//    Target = typeof(float[]),
//    Description = "Rock On !!!")]
//namespace VisualizerForFunctions
//{
    //public class WaveformVisualizer : Visualizer<float[]>
    //{
        //protected override float[] LoadData(IVisualizerObjectProvider objectProvider)
        //{
        //    return StreamToArray(objectProvider.GetData());
        //}

        //protected override UserControl GetPresenter(float[] data)
        //{
        //    return new FunctionPresenter(data);
        //}

        //private static float[] StreamToArray(Stream stream)
        //{
        //    BinaryFormatter deserializer = new BinaryFormatter();
        //    return (float[])deserializer.Deserialize(stream);
        //}

        //public static void ArrayToStream(float[] arr, ref Stream stream)
        //{
        //    BinaryFormatter serializer = new BinaryFormatter();
        //    serializer.Serialize(stream, arr);
        //}
   // }
//}
