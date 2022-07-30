namespace FixCSVAssignment
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EditCellButton = new System.Windows.Forms.Button();
            this.ExportFileButton = new System.Windows.Forms.Button();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.DeleteRowUpDown = new System.Windows.Forms.NumericUpDown();
            this.DeleteColumnButton = new System.Windows.Forms.Button();
            this.DeleteColumnUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddColumnButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ErrorsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartViewButton = new System.Windows.Forms.Button();
            this.TableViewButton = new System.Windows.Forms.Button();
            this.RowColLabel = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ErrorsPanel = new System.Windows.Forms.Panel();
            this.ScrollButton = new System.Windows.Forms.Button();
            this.PanelButton = new System.Windows.Forms.Button();
            this.NoErrors = new System.Windows.Forms.Label();
            this.EmptyCell = new System.Windows.Forms.Label();
            this.DataType = new System.Windows.Forms.Label();
            this.ColorMeaning = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteRowUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteColumnUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorsChart)).BeginInit();
            this.ErrorsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditCellButton
            // 
            this.EditCellButton.BackColor = System.Drawing.Color.LightBlue;
            this.EditCellButton.FlatAppearance.BorderSize = 0;
            this.EditCellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCellButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCellButton.ForeColor = System.Drawing.Color.Snow;
            this.EditCellButton.Location = new System.Drawing.Point(426, 886);
            this.EditCellButton.Name = "EditCellButton";
            this.EditCellButton.Size = new System.Drawing.Size(169, 51);
            this.EditCellButton.TabIndex = 22;
            this.EditCellButton.Text = "Edit Cell";
            this.EditCellButton.UseVisualStyleBackColor = false;
            this.EditCellButton.Click += new System.EventHandler(this.EditCellButton_Click);
            // 
            // ExportFileButton
            // 
            this.ExportFileButton.BackColor = System.Drawing.Color.LightBlue;
            this.ExportFileButton.FlatAppearance.BorderSize = 0;
            this.ExportFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportFileButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportFileButton.ForeColor = System.Drawing.Color.White;
            this.ExportFileButton.Location = new System.Drawing.Point(213, 279);
            this.ExportFileButton.Name = "ExportFileButton";
            this.ExportFileButton.Size = new System.Drawing.Size(169, 51);
            this.ExportFileButton.TabIndex = 21;
            this.ExportFileButton.Text = "Export File";
            this.ExportFileButton.UseVisualStyleBackColor = false;
            this.ExportFileButton.Click += new System.EventHandler(this.ExportFileButton_Click);
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.BackColor = System.Drawing.Color.LightBlue;
            this.DeleteRowButton.FlatAppearance.BorderSize = 0;
            this.DeleteRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRowButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRowButton.ForeColor = System.Drawing.Color.Snow;
            this.DeleteRowButton.Location = new System.Drawing.Point(1314, 886);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(172, 51);
            this.DeleteRowButton.TabIndex = 20;
            this.DeleteRowButton.Text = "Delete Row";
            this.DeleteRowButton.UseVisualStyleBackColor = false;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // DeleteRowUpDown
            // 
            this.DeleteRowUpDown.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRowUpDown.Location = new System.Drawing.Point(1492, 899);
            this.DeleteRowUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DeleteRowUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DeleteRowUpDown.Name = "DeleteRowUpDown";
            this.DeleteRowUpDown.Size = new System.Drawing.Size(60, 36);
            this.DeleteRowUpDown.TabIndex = 19;
            this.DeleteRowUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DeleteColumnButton
            // 
            this.DeleteColumnButton.BackColor = System.Drawing.Color.LightBlue;
            this.DeleteColumnButton.FlatAppearance.BorderSize = 0;
            this.DeleteColumnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteColumnButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteColumnButton.ForeColor = System.Drawing.Color.Snow;
            this.DeleteColumnButton.Location = new System.Drawing.Point(1033, 886);
            this.DeleteColumnButton.Name = "DeleteColumnButton";
            this.DeleteColumnButton.Size = new System.Drawing.Size(172, 51);
            this.DeleteColumnButton.TabIndex = 18;
            this.DeleteColumnButton.Text = "Delete Column";
            this.DeleteColumnButton.UseVisualStyleBackColor = false;
            this.DeleteColumnButton.Click += new System.EventHandler(this.DeleteColumnButton_Click);
            // 
            // DeleteColumnUpDown
            // 
            this.DeleteColumnUpDown.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteColumnUpDown.Location = new System.Drawing.Point(1211, 899);
            this.DeleteColumnUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DeleteColumnUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DeleteColumnUpDown.Name = "DeleteColumnUpDown";
            this.DeleteColumnUpDown.Size = new System.Drawing.Size(60, 36);
            this.DeleteColumnUpDown.TabIndex = 17;
            this.DeleteColumnUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddColumnButton
            // 
            this.AddColumnButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddColumnButton.FlatAppearance.BorderSize = 0;
            this.AddColumnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddColumnButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddColumnButton.ForeColor = System.Drawing.Color.White;
            this.AddColumnButton.Location = new System.Drawing.Point(828, 886);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.Size = new System.Drawing.Size(169, 51);
            this.AddColumnButton.TabIndex = 16;
            this.AddColumnButton.Text = "Add Column";
            this.AddColumnButton.UseVisualStyleBackColor = false;
            this.AddColumnButton.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddRowButton.FlatAppearance.BorderSize = 0;
            this.AddRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRowButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRowButton.ForeColor = System.Drawing.Color.White;
            this.AddRowButton.Location = new System.Drawing.Point(626, 886);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(169, 51);
            this.AddRowButton.TabIndex = 15;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = false;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.BackColor = System.Drawing.Color.LightBlue;
            this.LoadFileButton.FlatAppearance.BorderSize = 0;
            this.LoadFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadFileButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFileButton.ForeColor = System.Drawing.Color.White;
            this.LoadFileButton.Location = new System.Drawing.Point(12, 279);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(169, 51);
            this.LoadFileButton.TabIndex = 14;
            this.LoadFileButton.Text = "Load File";
            this.LoadFileButton.UseVisualStyleBackColor = false;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(397, 258);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(1181, 622);
            this.DataGridView.TabIndex = 23;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // ErrorsChart
            // 
            this.ErrorsChart.BackColor = System.Drawing.Color.SeaShell;
            this.ErrorsChart.BorderlineColor = System.Drawing.Color.Black;
            this.ErrorsChart.BorderlineWidth = 2;
            chartArea1.BorderWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.ErrorsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ErrorsChart.Legends.Add(legend1);
            this.ErrorsChart.Location = new System.Drawing.Point(645, 292);
            this.ErrorsChart.Name = "ErrorsChart";
            this.ErrorsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ErrorsChart.Series.Add(series1);
            this.ErrorsChart.Size = new System.Drawing.Size(678, 551);
            this.ErrorsChart.TabIndex = 24;
            this.ErrorsChart.Text = "Errors";
            // 
            // ChartViewButton
            // 
            this.ChartViewButton.BackColor = System.Drawing.Color.LightBlue;
            this.ChartViewButton.FlatAppearance.BorderSize = 0;
            this.ChartViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChartViewButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartViewButton.ForeColor = System.Drawing.Color.Snow;
            this.ChartViewButton.Location = new System.Drawing.Point(967, 193);
            this.ChartViewButton.Name = "ChartViewButton";
            this.ChartViewButton.Size = new System.Drawing.Size(224, 59);
            this.ChartViewButton.TabIndex = 26;
            this.ChartViewButton.Text = "Error Cell Distribution";
            this.ChartViewButton.UseVisualStyleBackColor = false;
            this.ChartViewButton.Click += new System.EventHandler(this.ChartViewButton_Click);
            // 
            // TableViewButton
            // 
            this.TableViewButton.BackColor = System.Drawing.Color.LightBlue;
            this.TableViewButton.FlatAppearance.BorderSize = 0;
            this.TableViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableViewButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableViewButton.ForeColor = System.Drawing.Color.Snow;
            this.TableViewButton.Location = new System.Drawing.Point(734, 193);
            this.TableViewButton.Name = "TableViewButton";
            this.TableViewButton.Size = new System.Drawing.Size(214, 59);
            this.TableViewButton.TabIndex = 25;
            this.TableViewButton.Text = "Table Visualization";
            this.TableViewButton.UseVisualStyleBackColor = false;
            this.TableViewButton.Click += new System.EventHandler(this.TableViewButton_Click);
            // 
            // RowColLabel
            // 
            this.RowColLabel.AutoSize = true;
            this.RowColLabel.BackColor = System.Drawing.Color.LightBlue;
            this.RowColLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowColLabel.ForeColor = System.Drawing.Color.White;
            this.RowColLabel.Location = new System.Drawing.Point(393, 234);
            this.RowColLabel.Name = "RowColLabel";
            this.RowColLabel.Size = new System.Drawing.Size(93, 21);
            this.RowColLabel.TabIndex = 27;
            this.RowColLabel.Text = "Row: Col:";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "CSV Filters | *.csv";
            this.OpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "CSV Files | *.csv";
            this.SaveFileDialog.OverwritePrompt = false;
            // 
            // ErrorsPanel
            // 
            this.ErrorsPanel.AutoScroll = true;
            this.ErrorsPanel.BackColor = System.Drawing.Color.Ivory;
            this.ErrorsPanel.Controls.Add(this.ScrollButton);
            this.ErrorsPanel.Controls.Add(this.PanelButton);
            this.ErrorsPanel.Location = new System.Drawing.Point(1594, 258);
            this.ErrorsPanel.Name = "ErrorsPanel";
            this.ErrorsPanel.Size = new System.Drawing.Size(422, 622);
            this.ErrorsPanel.TabIndex = 28;
            this.ErrorsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ErrorsPanel_Paint);
            // 
            // ScrollButton
            // 
            this.ScrollButton.BackColor = System.Drawing.Color.Transparent;
            this.ScrollButton.Location = new System.Drawing.Point(190, 647);
            this.ScrollButton.Name = "ScrollButton";
            this.ScrollButton.Size = new System.Drawing.Size(10, 10);
            this.ScrollButton.TabIndex = 1;
            this.ScrollButton.UseVisualStyleBackColor = false;
            // 
            // PanelButton
            // 
            this.PanelButton.BackColor = System.Drawing.Color.Transparent;
            this.PanelButton.Location = new System.Drawing.Point(3, 647);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(10, 10);
            this.PanelButton.TabIndex = 0;
            this.PanelButton.UseVisualStyleBackColor = false;
            // 
            // NoErrors
            // 
            this.NoErrors.BackColor = System.Drawing.Color.White;
            this.NoErrors.Font = new System.Drawing.Font("Segoe Print", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoErrors.Location = new System.Drawing.Point(76, 753);
            this.NoErrors.Name = "NoErrors";
            this.NoErrors.Size = new System.Drawing.Size(233, 62);
            this.NoErrors.TabIndex = 2;
            this.NoErrors.Text = "No Errors： White";
            this.NoErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoErrors.UseCompatibleTextRendering = true;
            // 
            // EmptyCell
            // 
            this.EmptyCell.BackColor = System.Drawing.Color.SkyBlue;
            this.EmptyCell.Font = new System.Drawing.Font("Segoe Print", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyCell.Location = new System.Drawing.Point(81, 815);
            this.EmptyCell.Name = "EmptyCell";
            this.EmptyCell.Size = new System.Drawing.Size(228, 63);
            this.EmptyCell.TabIndex = 29;
            this.EmptyCell.Text = "Empty Cell Error: Blue";
            this.EmptyCell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataType
            // 
            this.DataType.BackColor = System.Drawing.Color.Yellow;
            this.DataType.Font = new System.Drawing.Font("Segoe Print", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataType.Location = new System.Drawing.Point(81, 878);
            this.DataType.Name = "DataType";
            this.DataType.Size = new System.Drawing.Size(228, 59);
            this.DataType.TabIndex = 30;
            this.DataType.Text = "Data Type Error: Yellow";
            this.DataType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorMeaning
            // 
            this.ColorMeaning.BackColor = System.Drawing.Color.Transparent;
            this.ColorMeaning.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorMeaning.Location = new System.Drawing.Point(5, 719);
            this.ColorMeaning.Name = "ColorMeaning";
            this.ColorMeaning.Size = new System.Drawing.Size(169, 34);
            this.ColorMeaning.TabIndex = 31;
            this.ColorMeaning.Text = "Color Schema";
            this.ColorMeaning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ColorMeaning.UseCompatibleTextRendering = true;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.Location = new System.Drawing.Point(239, 48);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1492, 123);
            this.Title.TabIndex = 32;
            this.Title.Text = "Error CSV Visualization";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.UseCompatibleTextRendering = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(5, 353);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(386, 355);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(2035, 947);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ColorMeaning);
            this.Controls.Add(this.DataType);
            this.Controls.Add(this.EmptyCell);
            this.Controls.Add(this.NoErrors);
            this.Controls.Add(this.ErrorsPanel);
            this.Controls.Add(this.RowColLabel);
            this.Controls.Add(this.ChartViewButton);
            this.Controls.Add(this.TableViewButton);
            this.Controls.Add(this.ErrorsChart);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.EditCellButton);
            this.Controls.Add(this.ExportFileButton);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.DeleteRowUpDown);
            this.Controls.Add(this.DeleteColumnButton);
            this.Controls.Add(this.DeleteColumnUpDown);
            this.Controls.Add(this.AddColumnButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.LoadFileButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error CSV Visualization";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteRowUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteColumnUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorsChart)).EndInit();
            this.ErrorsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditCellButton;
        private System.Windows.Forms.Button ExportFileButton;
        private System.Windows.Forms.Button DeleteRowButton;
        private System.Windows.Forms.NumericUpDown DeleteRowUpDown;
        private System.Windows.Forms.Button DeleteColumnButton;
        private System.Windows.Forms.NumericUpDown DeleteColumnUpDown;
        private System.Windows.Forms.Button AddColumnButton;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart ErrorsChart;
        private System.Windows.Forms.Button ChartViewButton;
        private System.Windows.Forms.Button TableViewButton;
        private System.Windows.Forms.Label RowColLabel;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Panel ErrorsPanel;
        private System.Windows.Forms.Button PanelButton;
        private System.Windows.Forms.Button ScrollButton;
        private System.Windows.Forms.Label NoErrors;
        private System.Windows.Forms.Label EmptyCell;
        private System.Windows.Forms.Label DataType;
        private System.Windows.Forms.Label ColorMeaning;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

