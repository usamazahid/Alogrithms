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

namespace Alogrithms
{
    public partial class Form2 : Form
    {
        private int[] array;
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
                Title = "Steps",
                Labels = new[] { "Step 1", "Step 2", "Step 3", "Step 4", "Step 5", "Step 6", "Step 7", "Step 8", "Step 9", "Step 10",
                    "Step 11", "Step 12", "Step 13", "Step 14", "Step 15", "Step 16", "Step 17", "Step 18", "Step 19", "Step 20" } 
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Time (ms)"
            });
        }

        private void btnLinearSearch_Click(object sender, EventArgs e)
        {
            int[] array = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
            int target = 100;

            LinearSearch(array, target);
            BinarySearch(array, target);
            JumpSearch(array, target);
        }

        private async void LinearSearch(int[] arr, int target)
        {
            linearTimes.Clear();
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
            BinaryTimes.Clear();
            await Task.Delay(1000);

            int i=0, left = 0, right = arr.Length - 1;
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
            JumpTimes.Clear();
            await Task.Delay(3000);

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
