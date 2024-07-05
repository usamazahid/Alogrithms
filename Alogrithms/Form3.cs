using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alogrithms
{
    public partial class Form3 : Form
    {

        private ChartValues<ObservableValue> linearTimes;
        private ChartValues<ObservableValue> binaryTimes;
        private ChartValues<ObservableValue> jumpTimes;

        public Form3()
        {
            InitializeComponent();

            // Initialize chart values
            linearTimes = new ChartValues<ObservableValue>();
            binaryTimes = new ChartValues<ObservableValue>();
            jumpTimes = new ChartValues<ObservableValue>();

            // Setup LiveCharts cartesian chart
            cartesianChart1.Series = new SeriesCollection
        {
            new LineSeries { Title = "Linear Search", Values = linearTimes },
            new LineSeries { Title = "Binary Search", Values = binaryTimes },
            new LineSeries { Title = "Jump Search", Values = jumpTimes }
        };

            cartesianChart1.AxisX.Add(new Axis { Title = "Array Size" });
            cartesianChart1.AxisY.Add(new Axis { Title = "Time (ms)" });

            // Perform search comparisons
            CompareSearchMethods();
        }

        private void CompareSearchMethods()
        {
            int[] arraySizes = { 1000, 5000, 10000, 50000, 100000, 500000, 1000000 };

            foreach (var size in arraySizes)
            {
                int[] array = GenerateSortedArray(size);
                int target = 500000; // Target value to search for

                Stopwatch stopwatch = new Stopwatch();

                // Measure linear search time
                stopwatch.Start();
                int linearIndex = LinearSearch(array, target);
                stopwatch.Stop();
                linearTimes.Add(new ObservableValue(stopwatch.ElapsedMilliseconds));

                // Measure binary search time
                stopwatch.Restart();
                int binaryIndex = BinarySearch(array, target);
                stopwatch.Stop();
                binaryTimes.Add(new ObservableValue(stopwatch.ElapsedMilliseconds));

                // Measure jump search time
                stopwatch.Restart();
                int jumpIndex = JumpSearch(array, target);
                stopwatch.Stop();
                jumpTimes.Add(new ObservableValue(stopwatch.ElapsedMilliseconds));
            }
        }

        private int[] GenerateSortedArray(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(100000); // Generate random numbers
            }
            Array.Sort(array); // Sort the array
            return array;
        }

        private int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return i; // Return index if target found
            }
            return -1; // Return -1 if target not found
        }

        private int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == target)
                    return mid; // Return index if target found
                else if (array[mid] < target)
                    left = mid + 1; // Ignore left half
                else
                    right = mid - 1; // Ignore right half
            }
            return -1; // Return -1 if target not found
        }

        private int JumpSearch(int[] array, int target)
        {
            int n = array.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;

            // Jumping forward in array by step
            while (array[Math.Min(step, n) - 1] < target)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1; // If element is not present in the array
            }

            // Linear search for target in the current block
            while (array[prev] < target)
            {
                prev++;
                if (prev == Math.Min(step, n))
                    return -1; // If element is not present in the array
            }

            // If target found
            if (array[prev] == target)
                return prev;

            return -1; // If element is not present in the array
        }
    }
}
