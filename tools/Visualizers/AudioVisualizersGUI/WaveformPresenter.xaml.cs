using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms.DataVisualization.Charting;
using Items;

namespace FunctionVisualizersGUI
{
    /// <summary>
    /// Interaction logic for FunctionPresenter.xaml
    /// </summary>
    public partial class FunctionPresenter : UserControl
    {
        public FunctionPresenter(Function objectToVisualize)
        {
            InitializeComponent();

            PopulateChart1(objectToVisualize, "Function");
        }

        private void PopulateChart1(Function ff, string name)
        {
            var temp = ff.GetYValues();

            Series series = new Series();
            series.Name = name;
            int startPoint = Function.IterationFrom;
            for (int i = 0; i <temp.Length; i++)
            {
                series.Points.AddXY(startPoint, temp[i]);
                startPoint++;
            }

            Color translucentGray = Color.FromArgb(64, 64, 64, 64);
            ChartArea chartArea = new ChartArea();
            chartArea.BackColor = Color.AliceBlue;
            chartArea.BackGradientStyle = GradientStyle.TopBottom;
            chartArea.BackSecondaryColor = Color.White;
            chartArea.BorderColor = translucentGray;
            chartArea.BorderDashStyle = ChartDashStyle.Solid;

            chartArea.AxisX.MajorGrid.LineColor = translucentGray;
            chartArea.AxisY.MajorGrid.LineColor = translucentGray;
            chartArea.AxisX.MajorTickMark.LineColor = Color.Transparent;

            chartArea.AxisX.Minimum = Function.IterationFrom;
            chartArea.AxisX.Maximum = series.Points.Count - 1;

            chartArea.AxisX.Title = "Index";
            chartArea.AxisY.Title = series.Name + "[Index]";
            chartArea.CursorX.IsUserEnabled = false;

            series.ChartType = SeriesChartType.Line;
            series.MarkerSize = 1;
            series.MarkerStyle = MarkerStyle.Circle;
            series.BorderColor = translucentGray;
            series.XValueType = ChartValueType.Int32;
            series.YValueType = ChartValueType.Int32;


            mChart.ChartAreas.Add(chartArea);
            mChart.Series.Add(series);


        }

        private void PopulateChart(float[] values, string name)
        {
            Series series = new Series();
            series.Name = name;
            int startPoint = -50;
            for (int i = 0; i < values.Length; i++)
            {
                series.Points.AddXY(startPoint, values[i]);
                startPoint++;
            }

            Color translucentGray = Color.FromArgb(64, 64, 64, 64);
            ChartArea chartArea = new ChartArea();
            chartArea.BackColor = Color.AliceBlue;
            chartArea.BackGradientStyle = GradientStyle.TopBottom;
            chartArea.BackSecondaryColor = Color.White;
            chartArea.BorderColor = translucentGray;
            chartArea.BorderDashStyle = ChartDashStyle.Solid;

            chartArea.AxisX.MajorGrid.LineColor = translucentGray;
            chartArea.AxisY.MajorGrid.LineColor = translucentGray;
            chartArea.AxisX.MajorTickMark.LineColor = Color.Transparent;

            chartArea.AxisX.Minimum = Function.IterationFrom;
            chartArea.AxisX.Maximum = series.Points.Count - 1;

            chartArea.AxisX.Title = "Index";
            chartArea.AxisY.Title = series.Name + "[Index]";
            chartArea.CursorX.IsUserEnabled = false;

            series.ChartType = SeriesChartType.Line;
            series.MarkerSize = 1;
            series.MarkerStyle = MarkerStyle.Circle;
            series.BorderColor = translucentGray;
            series.XValueType = ChartValueType.Int32;
            series.YValueType = ChartValueType.Int32;


            mChart.ChartAreas.Add(chartArea);
            mChart.Series.Add(series);


        }
    }
}
