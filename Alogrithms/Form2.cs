using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Alogrithms
{
    public partial class Form2 : Form
    {
        private int[] array;
        private int target, From, To, numOfElements;
        private ChartValues<int> values;
        private LineSeries lineSeries;
        private readonly ChartValues<double> linearTimes, BinaryTimes, JumpTimes;

        public Form2()
        {
            InitializeComponent();

            linearTimes = new ChartValues<double>();
            BinaryTimes = new ChartValues<double>();
            JumpTimes = new ChartValues<double>();

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Linear Search Time",
                    Values = linearTimes,
                    PointGeometrySize = 10
                },
                
                new LineSeries
                {
                    Title = "Binary Search Time",
                    Values = BinaryTimes,
                    PointGeometrySize = 10
                },
                
                new LineSeries
                {
                    Title = "Jump Search Time",
                    Values = JumpTimes,
                    PointGeometrySize = 10
                }

            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Steps"
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Time (ms)"
            });
        }

        public bool resetArray()
        {
            linearTimes.Clear();
            BinaryTimes.Clear();
            JumpTimes.Clear();



            target = Convert.ToInt16(numTarget.Value);
            From = Convert.ToInt16(numFrom.Value);
            To = Convert.ToInt16(numTo.Value);
            if (To < From || target >= To || target <= From)
            {
                MessageBox.Show("Invalid Search Criteria");
                return false;
            }
            numOfElements = To - From + 1;
            array = new int[numOfElements];


            for (int i = 0; i < numOfElements; i++)
            {
                array[i] = From + i;
            }

            return true;

        }

        private void btnLinearSearch_Click(object sender, EventArgs e)
        {
            resetArray();
            LinearSearch(array, target);
            BinarySearch(array, target);
            JumpSearch(array, target);
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            if (resetArray())
            BinarySearch(array, target);
        }

        private void btnJump_Click(object sender, EventArgs e)
        {
            if (resetArray())
                JumpSearch(array, target);
        }

        private void btnLinear_Click(object sender, EventArgs e)
        {
            if (resetArray())
                LinearSearch(array, target);
        }


        private async void LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                linearTimes.Add(i + 1);

                if (arr[i] == target)
                {
                    return;
                }
                await System.Threading.Tasks.Task.Delay(100);
            }
        }

        private async void BinarySearch(int[] arr, int target)
        {
            await Task.Delay(1000);

            int i=0, left = From, right = arr.Length - 1;
            while (left <= right)
            {
                i++;
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                {
                    return;
                }
                else
                {
                    BinaryTimes.Add(i + 1);
                    await System.Threading.Tasks.Task.Delay(100);
                }
                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }

        private async void JumpSearch(int[] arr, int target)
        {
            await Task.Delay(1000);

            int j =0, n = arr.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;

            while (arr[Math.Min(step, n) - 1] < target)
            {
                j++;
                JumpTimes.Add(j + 1);
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return;
                await System.Threading.Tasks.Task.Delay(100);
            }

            for (int i = prev; i < Math.Min(step, n); i++)
            {
                j++;
                JumpTimes.Add(j + 1);
                if (arr[i] == target)
                {
                    return;
                }
                await System.Threading.Tasks.Task.Delay(100);
            }
        }

    }
}
