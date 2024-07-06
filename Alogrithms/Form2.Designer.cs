namespace Alogrithms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.btnLinearSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numTo = new System.Windows.Forms.NumericUpDown();
            this.numFrom = new System.Windows.Forms.NumericUpDown();
            this.numTarget = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLinear = new System.Windows.Forms.Button();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnJump = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(0, 0);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(800, 388);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // btnLinearSearch
            // 
            this.btnLinearSearch.Location = new System.Drawing.Point(12, 9);
            this.btnLinearSearch.Name = "btnLinearSearch";
            this.btnLinearSearch.Size = new System.Drawing.Size(76, 45);
            this.btnLinearSearch.TabIndex = 1;
            this.btnLinearSearch.Text = "Search";
            this.btnLinearSearch.UseVisualStyleBackColor = true;
            this.btnLinearSearch.Click += new System.EventHandler(this.btnLinearSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnJump);
            this.panel1.Controls.Add(this.btnBinary);
            this.panel1.Controls.Add(this.btnLinear);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnLinearSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cartesianChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 388);
            this.panel2.TabIndex = 2;
            // 
            // numTo
            // 
            this.numTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTo.Location = new System.Drawing.Point(211, 28);
            this.numTo.Name = "numTo";
            this.numTo.Size = new System.Drawing.Size(60, 26);
            this.numTo.TabIndex = 2;
            this.numTo.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numFrom
            // 
            this.numFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFrom.Location = new System.Drawing.Point(126, 28);
            this.numFrom.Name = "numFrom";
            this.numFrom.Size = new System.Drawing.Size(60, 26);
            this.numFrom.TabIndex = 3;
            this.numFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numTarget
            // 
            this.numTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTarget.Location = new System.Drawing.Point(20, 28);
            this.numTarget.Name = "numTarget";
            this.numTarget.Size = new System.Drawing.Size(60, 26);
            this.numTarget.TabIndex = 4;
            this.numTarget.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Target";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "To";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numTarget);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.numTo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.numFrom);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(509, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 62);
            this.panel3.TabIndex = 7;
            // 
            // btnLinear
            // 
            this.btnLinear.Location = new System.Drawing.Point(94, 9);
            this.btnLinear.Name = "btnLinear";
            this.btnLinear.Size = new System.Drawing.Size(69, 45);
            this.btnLinear.TabIndex = 8;
            this.btnLinear.Text = "Linear";
            this.btnLinear.UseVisualStyleBackColor = true;
            this.btnLinear.Click += new System.EventHandler(this.btnLinear_Click);
            // 
            // btnBinary
            // 
            this.btnBinary.Location = new System.Drawing.Point(169, 9);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(69, 45);
            this.btnBinary.TabIndex = 9;
            this.btnBinary.Text = "Binary";
            this.btnBinary.UseVisualStyleBackColor = true;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnJump
            // 
            this.btnJump.Location = new System.Drawing.Point(244, 9);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(69, 45);
            this.btnJump.TabIndex = 10;
            this.btnJump.Text = "Jump";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linear, Binary and Jump Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button btnLinearSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numFrom;
        private System.Windows.Forms.NumericUpDown numTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btnLinear;
    }
}