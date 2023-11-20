namespace TempForms
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ResultGrid1 = new System.Windows.Forms.DataGridView();
            this.updateButton1 = new System.Windows.Forms.Button();
            this.clrButton1 = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.graphButton1 = new System.Windows.Forms.Button();
            this.TempVis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FigCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.opsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ResultsGrid2 = new System.Windows.Forms.DataGridView();
            this.TempBoxUp = new System.Windows.Forms.TextBox();
            this.TempBoxLow = new System.Windows.Forms.TextBox();
            this.UBoundLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toCSVButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempVis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultGrid1
            // 
            this.ResultGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGrid1.Location = new System.Drawing.Point(12, 0);
            this.ResultGrid1.Name = "ResultGrid1";
            this.ResultGrid1.Size = new System.Drawing.Size(485, 350);
            this.ResultGrid1.TabIndex = 0;
            this.ResultGrid1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ResultGrid1_CellFormatting);
            // 
            // updateButton1
            // 
            this.updateButton1.Location = new System.Drawing.Point(711, 212);
            this.updateButton1.Name = "updateButton1";
            this.updateButton1.Size = new System.Drawing.Size(166, 23);
            this.updateButton1.TabIndex = 5;
            this.updateButton1.Text = "UPDATE";
            this.updateButton1.UseVisualStyleBackColor = true;
            this.updateButton1.Click += new System.EventHandler(this.updateButton1_Click);
            // 
            // clrButton1
            // 
            this.clrButton1.Location = new System.Drawing.Point(711, 249);
            this.clrButton1.Name = "clrButton1";
            this.clrButton1.Size = new System.Drawing.Size(166, 23);
            this.clrButton1.TabIndex = 6;
            this.clrButton1.Text = "CLEAR";
            this.clrButton1.UseVisualStyleBackColor = true;
            this.clrButton1.Click += new System.EventHandler(this.clrButton1_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(519, 35);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(169, 139);
            this.checkedListBox.TabIndex = 7;
            this.checkedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select The Days to Analyze:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(724, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Figure Legend:";
            // 
            // graphButton1
            // 
            this.graphButton1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.graphButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.graphButton1.Location = new System.Drawing.Point(519, 327);
            this.graphButton1.Name = "graphButton1";
            this.graphButton1.Size = new System.Drawing.Size(357, 24);
            this.graphButton1.TabIndex = 10;
            this.graphButton1.Text = "VISUALIZE\r\n";
            this.graphButton1.UseVisualStyleBackColor = false;
            this.graphButton1.Click += new System.EventHandler(this.graphButton1_Click);
            // 
            // TempVis
            // 
            chartArea1.Name = "ChartArea1";
            this.TempVis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TempVis.Legends.Add(legend1);
            this.TempVis.Location = new System.Drawing.Point(12, 472);
            this.TempVis.Name = "TempVis";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.TempVis.Series.Add(series1);
            this.TempVis.Size = new System.Drawing.Size(865, 440);
            this.TempVis.TabIndex = 11;
            this.TempVis.Text = "chart1";
            this.TempVis.Visible = false;
            // 
            // FigCheckListBox
            // 
            this.FigCheckListBox.FormattingEnabled = true;
            this.FigCheckListBox.Location = new System.Drawing.Point(728, 35);
            this.FigCheckListBox.Name = "FigCheckListBox";
            this.FigCheckListBox.Size = new System.Drawing.Size(148, 139);
            this.FigCheckListBox.TabIndex = 12;
            this.FigCheckListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.FigCheckListBox_ItemCheck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Operations :";
            // 
            // opsCheckedListBox
            // 
            this.opsCheckedListBox.FormattingEnabled = true;
            this.opsCheckedListBox.Location = new System.Drawing.Point(519, 237);
            this.opsCheckedListBox.Name = "opsCheckedListBox";
            this.opsCheckedListBox.Size = new System.Drawing.Size(141, 49);
            this.opsCheckedListBox.TabIndex = 14;
            this.opsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.opsCheckedListBox_ItemCheck);
            // 
            // ResultsGrid2
            // 
            this.ResultsGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsGrid2.Location = new System.Drawing.Point(12, 356);
            this.ResultsGrid2.Name = "ResultsGrid2";
            this.ResultsGrid2.Size = new System.Drawing.Size(485, 110);
            this.ResultsGrid2.TabIndex = 15;
            // 
            // TempBoxUp
            // 
            this.TempBoxUp.Location = new System.Drawing.Point(522, 388);
            this.TempBoxUp.Margin = new System.Windows.Forms.Padding(2);
            this.TempBoxUp.Name = "TempBoxUp";
            this.TempBoxUp.Size = new System.Drawing.Size(104, 20);
            this.TempBoxUp.TabIndex = 16;
            this.TempBoxUp.Tag = "upper";
            this.TempBoxUp.TextChanged += new System.EventHandler(this.TempBox_TextChanged);
            this.TempBoxUp.Validating += new System.ComponentModel.CancelEventHandler(this.TempBox_Validating);
            // 
            // TempBoxLow
            // 
            this.TempBoxLow.Location = new System.Drawing.Point(522, 437);
            this.TempBoxLow.Margin = new System.Windows.Forms.Padding(2);
            this.TempBoxLow.Name = "TempBoxLow";
            this.TempBoxLow.Size = new System.Drawing.Size(104, 20);
            this.TempBoxLow.TabIndex = 17;
            this.TempBoxLow.Tag = "lower";
            this.TempBoxLow.TextChanged += new System.EventHandler(this.TempBox_TextChanged);
            this.TempBoxLow.Validating += new System.ComponentModel.CancelEventHandler(this.TempBox_Validating);
            // 
            // UBoundLabel
            // 
            this.UBoundLabel.AutoSize = true;
            this.UBoundLabel.Location = new System.Drawing.Point(520, 372);
            this.UBoundLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UBoundLabel.Name = "UBoundLabel";
            this.UBoundLabel.Size = new System.Drawing.Size(133, 13);
            this.UBoundLabel.TabIndex = 18;
            this.UBoundLabel.Text = "Temperature Upper Bound";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 422);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Temperature Lower Bound";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(666, 372);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 69);
            this.listBox1.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toCSVButton1
            // 
            this.toCSVButton1.Location = new System.Drawing.Point(712, 286);
            this.toCSVButton1.Margin = new System.Windows.Forms.Padding(2);
            this.toCSVButton1.Name = "toCSVButton1";
            this.toCSVButton1.Size = new System.Drawing.Size(164, 21);
            this.toCSVButton1.TabIndex = 21;
            this.toCSVButton1.Text = "EXPORT CSV";
            this.toCSVButton1.UseVisualStyleBackColor = true;
            this.toCSVButton1.Click += new System.EventHandler(this.toCSVButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 862);
            this.Controls.Add(this.toCSVButton1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UBoundLabel);
            this.Controls.Add(this.TempBoxLow);
            this.Controls.Add(this.TempBoxUp);
            this.Controls.Add(this.ResultsGrid2);
            this.Controls.Add(this.opsCheckedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FigCheckListBox);
            this.Controls.Add(this.TempVis);
            this.Controls.Add(this.graphButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.clrButton1);
            this.Controls.Add(this.updateButton1);
            this.Controls.Add(this.ResultGrid1);
            this.Name = "Form1";
            this.Text = "Temperature Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempVis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultGrid1;
        private System.Windows.Forms.Button updateButton1;
        private System.Windows.Forms.Button clrButton1;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button graphButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart TempVis;
        private System.Windows.Forms.CheckedListBox FigCheckListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox opsCheckedListBox;
        private System.Windows.Forms.DataGridView ResultsGrid2;
        private System.Windows.Forms.TextBox TempBoxUp;
        private System.Windows.Forms.TextBox TempBoxLow;
        private System.Windows.Forms.Label UBoundLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button toCSVButton1;
    }
}

