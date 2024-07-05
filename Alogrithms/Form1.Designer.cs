namespace Algorithms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button linearSearchButton;
        private System.Windows.Forms.Button binarySearchButton;
        private System.Windows.Forms.Button jumpSearchButton;
        private System.Windows.Forms.Button measurePerformanceButton;
        private System.Windows.Forms.Integration.ElementHost elementHost;
        private LiveCharts.Wpf.CartesianChart cartesianChart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.linearSearchButton = new System.Windows.Forms.Button();
            this.binarySearchButton = new System.Windows.Forms.Button();
            this.jumpSearchButton = new System.Windows.Forms.Button();
            this.measurePerformanceButton = new System.Windows.Forms.Button();
            this.elementHost = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart = new LiveCharts.Wpf.CartesianChart();

            // 
            // linearSearchButton
            // 
            this.linearSearchButton.Location = new System.Drawing.Point(12, 12);
            this.linearSearchButton.Size = new System.Drawing.Size(120, 40);
            this.linearSearchButton.Text = "Linear Search";
            this.linearSearchButton.Click += new System.EventHandler(this.LinearSearchButton_Click);

            // 
            // binarySearchButton
            // 
            this.binarySearchButton.Location = new System.Drawing.Point(138, 12);
            this.binarySearchButton.Size = new System.Drawing.Size(120, 40);
            this.binarySearchButton.Text = "Binary Search";
            this.binarySearchButton.Click += new System.EventHandler(this.BinarySearchButton_Click);

            // 
            // jumpSearchButton
            // 
            this.jumpSearchButton.Location = new System.Drawing.Point(264, 12);
            this.jumpSearchButton.Size = new System.Drawing.Size(120, 40);
            this.jumpSearchButton.Text = "Jump Search";
            this.jumpSearchButton.Click += new System.EventHandler(this.JumpSearchButton_Click);

            // 
            // measurePerformanceButton
            // 
            this.measurePerformanceButton.Location = new System.Drawing.Point(390, 12);
            this.measurePerformanceButton.Size = new System.Drawing.Size(180, 40);
            this.measurePerformanceButton.Text = "Measure Performance";
            this.measurePerformanceButton.Click += new System.EventHandler(this.MeasurePerformanceButton_Click);

            // 
            // elementHost
            // 
            this.elementHost.Location = new System.Drawing.Point(12, 58);
            this.elementHost.Size = new System.Drawing.Size(760, 380);
            this.elementHost.Child = this.cartesianChart;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.linearSearchButton);
            this.Controls.Add(this.binarySearchButton);
            this.Controls.Add(this.jumpSearchButton);
            this.Controls.Add(this.measurePerformanceButton);
            this.Controls.Add(this.elementHost);
            this.Text = "Search Visualization";
        }
    }
}
