using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace VisualizerForFunctions
{
    public abstract class Visualizer<T> : DialogDebuggerVisualizer
    {
        // Having separate functions for loading data and creating visualization of data is a work around limitation of managed debugger
        // allowing data extraction only from main visualizer thread which is in MTA thread appartment in combination with WPF limitation
        // allowing creation of WPF controls only from a thread from STA thread appartment.
        //
        protected abstract UserControl GetPresenter(T data);
        protected abstract T LoadData(IVisualizerObjectProvider objectProvider);

        private void ShowVis(T dataToVisualize)
        {
            try
            {
                Window gui = new Window();
                gui.Content = GetPresenter(dataToVisualize);
                gui.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        override protected void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            T dataToVisualize = LoadData(objectProvider);

            try
            {
                Thread t = new Thread(() => ShowVis(dataToVisualize));
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                t.Join();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
