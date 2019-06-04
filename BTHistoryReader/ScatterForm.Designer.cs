﻿namespace BTHistoryReader
{
    partial class ScatterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScatterForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.GetLegendInfo = new System.Windows.Forms.Timer(this.components);
            this.labelShowSeries = new System.Windows.Forms.Label();
            this.nudShowOnly = new System.Windows.Forms.NumericUpDown();
            this.tboxShowing = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudXscale = new System.Windows.Forms.NumericUpDown();
            this.cboxUseLog = new System.Windows.Forms.CheckBox();
            this.ChartScatter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.nudShowOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartScatter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(578, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // GetLegendInfo
            // 
            this.GetLegendInfo.Enabled = true;
            this.GetLegendInfo.Interval = 250;
            this.GetLegendInfo.Tick += new System.EventHandler(this.GetLegendInfo_Tick);
            // 
            // labelShowSeries
            // 
            this.labelShowSeries.AutoSize = true;
            this.labelShowSeries.Location = new System.Drawing.Point(9, 417);
            this.labelShowSeries.Name = "labelShowSeries";
            this.labelShowSeries.Size = new System.Drawing.Size(83, 13);
            this.labelShowSeries.TabIndex = 3;
            this.labelShowSeries.Text = "SHOW SERIES";
            // 
            // nudShowOnly
            // 
            this.nudShowOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudShowOnly.Location = new System.Drawing.Point(101, 400);
            this.nudShowOnly.Name = "nudShowOnly";
            this.nudShowOnly.ReadOnly = true;
            this.nudShowOnly.Size = new System.Drawing.Size(20, 38);
            this.nudShowOnly.TabIndex = 4;
            this.nudShowOnly.ValueChanged += new System.EventHandler(this.nudShowOnly_ValueChanged);
            // 
            // tboxShowing
            // 
            this.tboxShowing.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tboxShowing.Location = new System.Drawing.Point(172, 411);
            this.tboxShowing.Name = "tboxShowing";
            this.tboxShowing.ReadOnly = true;
            this.tboxShowing.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tboxShowing.Size = new System.Drawing.Size(222, 20);
            this.tboxShowing.TabIndex = 5;
            this.tboxShowing.Text = "Show All";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "X-Factor";
            // 
            // nudXscale
            // 
            this.nudXscale.Location = new System.Drawing.Point(221, 377);
            this.nudXscale.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudXscale.Name = "nudXscale";
            this.nudXscale.ReadOnly = true;
            this.nudXscale.Size = new System.Drawing.Size(38, 20);
            this.nudXscale.TabIndex = 6;
            this.nudXscale.ValueChanged += new System.EventHandler(this.nudXscale_ValueChanged_1);
            // 
            // cboxUseLog
            // 
            this.cboxUseLog.AutoSize = true;
            this.cboxUseLog.Location = new System.Drawing.Point(286, 380);
            this.cboxUseLog.Name = "cboxUseLog";
            this.cboxUseLog.Size = new System.Drawing.Size(108, 17);
            this.cboxUseLog.TabIndex = 8;
            this.cboxUseLog.Text = "Make X log scale";
            this.cboxUseLog.UseVisualStyleBackColor = true;
            this.cboxUseLog.CheckedChanged += new System.EventHandler(this.cboxUseLog_CheckedChanged);
            // 
            // ChartScatter
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartScatter.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            this.ChartScatter.Legends.Add(legend1);
            this.ChartScatter.Location = new System.Drawing.Point(21, 22);
            this.ChartScatter.Name = "ChartScatter";
            this.ChartScatter.Size = new System.Drawing.Size(894, 320);
            this.ChartScatter.TabIndex = 0;
            this.ChartScatter.Text = "Scatter Plot";
            this.ChartScatter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChartScatter_MouseClick);
            // 
            // ScatterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.cboxUseLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudXscale);
            this.Controls.Add(this.tboxShowing);
            this.Controls.Add(this.nudShowOnly);
            this.Controls.Add(this.labelShowSeries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChartScatter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ScatterForm";
            this.Text = "Scatter Plot";
            ((System.ComponentModel.ISupportInitialize)(this.nudShowOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartScatter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer GetLegendInfo;
        private System.Windows.Forms.Label labelShowSeries;
        private System.Windows.Forms.NumericUpDown nudShowOnly;
        private System.Windows.Forms.TextBox tboxShowing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudXscale;
        private System.Windows.Forms.CheckBox cboxUseLog;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartScatter;
    }
}