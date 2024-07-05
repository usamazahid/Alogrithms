using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace Algorithms
{
    public partial class Form1 : Form
    {
        private int[] array;
        private ChartValues<int> values;
        private ChartValues<double> linearTimes;
        private ChartValues<double> binaryTimes;
        private ChartValues<double> jumpTimes;

        public Form1()
        {
            InitializeComponent();

            array = new int[] { 3, 6, 7, 8, 12, 14, 17, 21, 23, 25, 27, 31, 33, 36, 37 };
            values = new ChartValues<int>(array);
            linearTimes = new ChartValues<double>();
            binaryTimes = new ChartValues<double>();
            jumpTimes = new ChartValues<double>();

            cartesianChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Array Values",
                    Values = values,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10
                },
                new LineSeries
                {
                    Title = "Linear Search",
                    Values = linearTimes,
                    PointGeometrySize = 10
                },
                new LineSeries
                {
                    Title = "Binary Search",
                    Values = binaryTimes,
                    PointGeometrySize = 10
                },
                new LineSeries
                {
                    Title = "Jump Search",
                    Values = jumpTimes,
                    PointGeometrySize = 10
                }
            };

            cartesianChart.AxisX.Add(new Axis
            {
                Title = "Index",
                Labels = array.Select((_, index) => index.ToString()).ToArray()
            });

            cartesianChart.AxisY.Add(new Axis
            {
                Title = "Value"
            });
        }

        private async void LinearSearchButton_Click(object sender, EventArgs e)
        {
            int target = 23; // Example target
            for (int i = 0; i < array.Length; i++)
            {
                ResetValues();
                values[i] = array[i] * 2; // Highlight the current element
                await Task.Delay(500); // Wait for visualization

                if (array[i] == target)
                {
                    values[i] = array[i] * 3; // Highlight the found element differently
                    return;
                }
            }
        }

        private async void BinarySearchButton_Click(object sender, EventArgs e)
        {
            int target = 23; // Example target
            int left = 0, right = array.Length - 1;
            while (left <= right)
            {
                ResetValues();
                int mid = left + (right - left) / 2;
                values[mid] = array[mid] * 2; // Highlight the current mid element
                await Task.Delay(500); // Wait for visualization

                if (array[mid] == target)
                {
                    values[mid] = array[mid] * 3; // Highlight the found element differently
                    return;
                }
                if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }

        private async void JumpSearchButton_Click(object sender, EventArgs e)
        {
            int target = 23; // Example target
            int n = array.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;

            while (array[Math.Min(step, n) - 1] < target)
            {
                ResetValues();
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return;
                values[prev] = array[prev] * 2; // Highlight the current jump element
                await Task.Delay(500); // Wait for visualization
            }

            for (int i = prev; i < Math.Min(step, n); i++)
            {
                ResetValues();
                if (array[i] == target)
                {
                    values[i] = array[i] * 3; // Highlight the found element differently
                    return;
                }
                await Task.Delay(500); // Wait for visualization
            }
        }

        private async void MeasurePerformanceButton_Click(object sender, EventArgs e)
        {
            int[] sizes = { 1000, 5000, 10000, 50000, 100000, 500000, 1000000 };
            linearTimes.Clear();
            binaryTimes.Clear();
            jumpTimes.Clear();

            foreach (var size in sizes)
            {
                var testArray = Enumerable.Range(1, size).ToArray();
                var stopwatch = new Stopwatch();

                // Linear Search
                stopwatch.Start();
                LinearSearch(testArray, -1); // Searching for an element not present
                stopwatch.Stop();
                linearTimes.Add(stopwatch.Elapsed.TotalMilliseconds);

                // Binary Search
                stopwatch.Restart();
                BinarySearch(testArray, -1); // Searching for an element not present
                stopwatch.Stop();
                binaryTimes.Add(stopwatch.Elapsed.TotalMilliseconds);

                // Jump Search
                stopwatch.Restart();
                JumpSearch(testArray, -1); // Searching for an element not present
                stopwatch.Stop();
                jumpTimes.Add(stopwatch.Elapsed.TotalMilliseconds);

                await Task.Delay(500); // Wait for visualization
            }
        }

        private void LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return;
                }
            }
        }

        private void BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                {
                    return;
                }
                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }

        private void JumpSearch(int[] arr, int target)
        {
            int n = arr.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;

            while (arr[Math.Min(step, n) - 1] < target)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return;
            }

            for (int i = prev; i < Math.Min(step, n); i++)
            {
                if (arr[i] == target)
                {
                    return;
                }
            }
        }

        private void ResetValues()
        {
            for (int i = 0; i < array.Length; i++)
            {
                values[i] = array[i]; // Reset the value for visualization
            }
        }

    }
}
