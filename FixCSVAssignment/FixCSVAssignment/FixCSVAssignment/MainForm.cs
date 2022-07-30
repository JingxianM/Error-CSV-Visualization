using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using CsvHelper;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic;


namespace FixCSVAssignment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        DataTable dt;
        Brush[,] errorColors;

        void DrawGrid(PaintEventArgs e, Brush[,] errorColors)
        {
            e.Graphics.Clear(Color.White);
            Console.WriteLine(errorColors.Length);
            Rectangle[,] rects = new Rectangle[DataGridView.ColumnCount, DataGridView.RowCount];
            Pen p = new Pen(Brushes.Gray);
            p.Width = 2;
            Point[] pointsX = new Point[10 * DataGridView.ColumnCount];
            Point[] pointsY = new Point[10 * DataGridView.RowCount];
            int countX = 0;
            int countY = 0;
            for (int i = 0; i < DataGridView.ColumnCount * 10; i += 10)
            {
                for (int j = 0; j < DataGridView.RowCount * 10; j += 10)
                {
                    if (countX < DataGridView.ColumnCount && countY < DataGridView.RowCount)
                    {
                        rects[countX, countY] = new Rectangle(i, j, 10, 10);
                        e.Graphics.DrawRectangle(p, rects[countX, countY]);
                        e.Graphics.FillRectangle(errorColors[countX, countY], rects[countX, countY]);
                    }
                    countY++;
                }
                countX++;
                countY = 0;
            }
        }


        Brush[,] CheckErrors(Brush[,] errorColors)
        {
            // Show wrong error type.
            List<Type> dataTypes = new List<Type>();
            int isInt;
            decimal isDecial;
            char isChar;
            DateTime isTime;
            Regex allLetters = new Regex("/^[A-Za-z]+$/");
            //Check each cell's data type.
            if (dt != null)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    int stringCount = 0;
                    int decimalCount = 0;
                    int intCount = 0;
                    int timeCount = 0;
                    int charCount = 0;
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        // If decimal
                        if (decimal.TryParse(dt.Rows[j].ItemArray[i].ToString(), out isDecial))
                        {
                            decimalCount++;
                        }

                        // If int
                        else if (int.TryParse(dt.Rows[j].ItemArray[i].ToString(), out isInt))
                        {
                            intCount++;
                            Console.WriteLine(int.TryParse(dt.Rows[j].ItemArray[i].ToString(), out isInt));
                        }
                        

                        // If time
                        else if (DateTime.TryParse(dt.Rows[j].ItemArray[i].ToString(), out isTime))
                        {
                            timeCount++;
                        }

                        // If Char
                        else if (Char.TryParse(dt.Rows[j].ItemArray[i].ToString(), out isChar))
                        {
                            charCount++;
                        }

                        // If string
                        else
                        {
                            stringCount++;
                        }
                        
                    }

                    if (decimalCount > stringCount && decimalCount > intCount && decimalCount > timeCount && decimalCount > charCount)
                    {
                        dataTypes.Insert(i, typeof(decimal));
                    }

                    else if (intCount > stringCount && intCount > decimalCount && intCount > timeCount && intCount > charCount)
                    {
                        dataTypes.Insert(i, typeof(int));
                    }

                    // If time
                    else if (timeCount > stringCount && timeCount > intCount && timeCount > decimalCount && timeCount > charCount)
                    {
                        dataTypes.Insert(i, typeof(DateTime));
                    }
                    // If Char
                    else if (charCount > stringCount && charCount > intCount && charCount > decimalCount && charCount > timeCount)
                    {
                        dataTypes.Insert(i, typeof(char));
                    }

                    else
                    {
                        dataTypes.Insert(i, typeof(string));
                    }
                }

                // Highlight the errors.
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        Type currentType;
                        // If decimal
                        if (decimal.TryParse(dt.Rows[j].ItemArray[i].ToString(), out isDecial))
                        {
                            currentType = typeof(decimal);
                        }

                        // If int
                        else if (int.TryParse(dt.Rows[j].ItemArray[i].ToString(), out isInt))
                        {
                            currentType = typeof(int);
                        }

                        // If time
                        else if (DateTime.TryParse(dt.Rows[j].ItemArray[i].ToString(), out isTime))
                        {
                            currentType = typeof(DateTime);
                        }

                        // if Char
                        else if (Char.TryParse(dt.Rows[j].ItemArray[i].ToString(), out isChar))
                        {
                            currentType=typeof(char);
                        }

                        // If string
                        else
                        {
                            currentType = typeof(string);
                        }

                        if (currentType != null)
                        {
                            if (currentType != dataTypes[i] && !string.IsNullOrEmpty(dt.Rows[j].ItemArray[i].ToString()))
                            {
                                DataGridView.Rows[j].Cells[i].Style.BackColor = Color.Yellow;
                                errorColors[i, j] = Brushes.Yellow;
                            }
                            if (currentType == dataTypes[i] && !string.IsNullOrEmpty(dt.Rows[j].ItemArray[i].ToString()))
                            {
                                DataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                                errorColors[i, j] = Brushes.White;
                            }
                        }
                        currentType = null;
                    }

                }

                // Set empty cells to blue
                for (int i = 0; i < DataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < DataGridView.Columns.Count; j++)
                    {
                        if (string.IsNullOrEmpty(DataGridView.Rows[i].Cells[j].Value.ToString()))
                        {
                            DataGridView.Rows[i].Cells[j].Style.BackColor = Color.SkyBlue;
                            errorColors[j, i] = Brushes.SkyBlue;
                        }
                    }
                }


                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (errorColors[i, j] == null)
                        {
                            errorColors[i, j] = Brushes.Green;
                        }
                    }
                }
                return errorColors;
            }
            else
            {
                MessageBox.Show("No file upload.");
                return null;
            }

        }

        void AddToChart()
        {
            int emptyCellCount = 0;
            int datatypeCount = 0;
            int noErrorCount = 0;
            for (int i = 0; i < DataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < DataGridView.Columns.Count; j++)
                {
                    if (DataGridView.Rows[i].Cells[j].Style.BackColor == Color.SkyBlue)
                    {
                        emptyCellCount++;
                    }
                    else if (DataGridView.Rows[i].Cells[j].Style.BackColor == Color.Yellow)
                    {
                        datatypeCount++;
                    }
                    else
                    {
                        noErrorCount++;
                    }
                    ErrorsChart.Series[0].Points.Clear();
                    ErrorsChart.Series[0].Points.AddXY("Empty Cell Error",emptyCellCount);
                    ErrorsChart.Series[0].Points.AddXY("Data Type Error", datatypeCount);
                    ErrorsChart.Series[0].Points.AddXY("No Error", noErrorCount);

                    for (int pointCount = 0; pointCount < ErrorsChart.Series[0].Points.Count; pointCount++)
                    {
                        if (pointCount == 0)
                        {
                            ErrorsChart.Series[0].Points[pointCount].Color = Color.SkyBlue;
                        }

                        if (pointCount == 1)
                        { 
                            ErrorsChart.Series[0].Points[pointCount].Color = Color.Yellow;
                        }

                        if (pointCount == 2)
                        { 
                            ErrorsChart.Series[0].Points[pointCount].Color = Color.Green; 
                        }
                    }
                    ErrorsChart.Series[0].IsValueShownAsLabel = true;
                    
                }
            }
        
        }
        void WriteToFile()
        {
            using (var writer = new StreamWriter(SaveFileDialog.FileName))
            {
                string line = "";
                string firstLine = "";   
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    firstLine +=  DataGridView.Columns[i].HeaderText;
                    if (i != dt.Columns.Count - 1)
                    {
                        firstLine += ",";
                    }
                }
                // firstLine += "\n";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                       line += dt.Rows[i].ItemArray[j];
                       // if it's not the last element
                       if (j != dt.Rows[i].ItemArray.Count() - 1)
                       {
                         line += ",";
                       }
       
                        
                    }
                    line += "\n";
                }
                writer.WriteLine(firstLine);
                writer.WriteLine(line);
            }
        }

  
        private void MainForm_Load(object sender, EventArgs e)
        {
            ErrorsChart.Visible = false;
            ErrorsPanel.AutoScroll = true;
        }

        private void TableViewButton_Click(object sender, EventArgs e)
        {
            ErrorsChart.Visible = false;
            DataGridView.Visible = true;
            ErrorsPanel.Visible = true;
            RowColLabel.Visible = false;
            ColorMeaning.Visible = true;
            EmptyCell.Visible = true;
            DataType.Visible = true;
            NoErrors.Visible = true;
            EditCellButton.Visible = true;
            AddColumnButton.Visible = true;
            AddRowButton.Visible = true;
            DeleteColumnButton.Visible = true;
            DeleteRowButton.Visible = true;
            DeleteColumnUpDown.Visible = true;
            DeleteRowUpDown.Visible = true;
            RowColLabel.Visible = true;
        }

        private void ChartViewButton_Click(object sender, EventArgs e)
        {
            ErrorsChart.Visible = true;
            DataGridView.Visible = false;
            //ErrorsPanel.Visible = true;
            RowColLabel.Visible = false;
            ColorMeaning.Visible = false;
            EmptyCell.Visible = false;
            DataType.Visible = false;
            NoErrors.Visible =false;
            EditCellButton.Visible = false;
            AddColumnButton.Visible = false;
            AddRowButton.Visible = false;
            DeleteColumnButton.Visible = false;
            DeleteRowButton.Visible = false;
            DeleteColumnUpDown.Visible = false;
            DeleteRowUpDown.Visible = false;
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            DialogResult open = OpenFileDialog.ShowDialog();
            if (open == DialogResult.OK)
            {
                using (var reader = new StreamReader(OpenFileDialog.FileName))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    // Do any configuration to `CsvReader` before creating CsvDataReader.
                    using (var dr = new CsvDataReader(csv))
                    {
                        dt = new DataTable();
                        dt.Load(dr);
                        // After load data, set the read only to false, for edit cells.
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            dt.Columns[i].ReadOnly = false;
                        }
                        DataGridView.DataSource = dt;
                        errorColors = new Brush[dt.Columns.Count, dt.Rows.Count];
                        CheckErrors(errorColors);
                        AddToChart();
                        
                        foreach (DataGridViewColumn c in DataGridView.Columns)
                        {
                            c.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                        if (Form.ActiveForm != null)
                        {
                            Form.ActiveForm.Refresh();
                        }
                    }
                }   
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ExportFileButton_Click(object sender, EventArgs e)
        {
            if (errorColors != null)
            {
                int errorsCount = 0;
                foreach (Brush b in errorColors)
                {
                    if (!(b == Brushes.White))
                    {
                        errorsCount++;
                    }
                }
                if (errorsCount == 0)
                {
                    DialogResult export = SaveFileDialog.ShowDialog();
                    if (export == DialogResult.OK)
                    {
                        WriteToFile();
                    }
                }
                else
                {
                    MessageBox.Show("The file still has errors, please correct them.");

                }
            }
            else 
            {
                MessageBox.Show("No file uploaded.");
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ErrorsPanel_Paint(object sender, PaintEventArgs e)
        {
            if (dt != null)
            {
                DrawGrid(e, errorColors);
                PanelButton.Location = (new Point(7, dt.Rows.Count * 10 + 10));
            }
        }

        private void EditCellButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedCells.Count != 0)
            {
                string dataValue = Interaction.InputBox("Please inpu new data","Cell Data");
                if (!string.IsNullOrEmpty(dataValue))
                {
                    dt.Rows[DataGridView.SelectedCells[0].RowIndex].SetField<string>(DataGridView.SelectedCells[0].ColumnIndex, dataValue);

                }
        
            }
            CheckErrors(errorColors);
            ErrorsPanel.Refresh();
            AddToChart();
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            if (dt != null)
            {
                string colName = Interaction.InputBox("Please input column name", "New Column");
                // If input is not null, then it will be set as new column.
                // After add new column, check the errors again, and update pir chart.
                if (!string.IsNullOrEmpty(colName))
                {
                    DataColumn col = new DataColumn(colName);
                    dt.Columns.Add(col);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i].SetField<string>(dt.Columns[dt.Columns.Count - 1], "");
                    }
                    errorColors = new Brush[DataGridView.Columns.Count, DataGridView.Rows.Count];
                    DataGridView.Refresh();
                    CheckErrors(errorColors);
                    ErrorsPanel.Refresh();
                    AddToChart();
                    foreach (DataGridViewColumn c in DataGridView.Columns)
                    {
                        c.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }

                }
            }
            else
            {
                MessageBox.Show("No file upload.");
            }

        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            if (dt != null)
            {
               DataRow row =  dt.NewRow();
               dt.Rows.Add(row);
               errorColors = new Brush[DataGridView.Columns.Count, DataGridView.Rows.Count];
               DataGridView.Refresh();
               CheckErrors(errorColors);
               ErrorsPanel.Refresh();
               AddToChart();
            }
            else
            {
                MessageBox.Show("No file upload.");
            }

        }

        private void DeleteColumnButton_Click(object sender, EventArgs e)
        {
            if (dt != null) 
            {
                if (dt.Columns.Count > 0 && (int)DeleteColumnUpDown.Value > -1 &&
                    (int)DeleteColumnUpDown.Value < dt.Columns.Count)
                {
                    dt.Columns.RemoveAt((int)DeleteColumnUpDown.Value - 1);
                    errorColors = new Brush[DataGridView.Columns.Count, DataGridView.Rows.Count];
                    DataGridView.Refresh();
                    CheckErrors(errorColors);
                    ErrorsPanel.Refresh();
                    AddToChart();
                }
                else if (dt.Columns.Count < 0 || (int)DeleteColumnUpDown.Value > dt.Columns.Count)
                {
                    MessageBox.Show("Column number not exist.");
                }
            }
            else
            {
                MessageBox.Show("No file upload.");
            }



        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            if (dt != null)
            {
                if (dt.Rows.Count > 0 && (int)DeleteRowUpDown.Value > -1 &&
                    (int)DeleteRowUpDown.Value < dt.Rows.Count)
                {
                    dt.Rows.RemoveAt((int)DeleteRowUpDown.Value - 1);
                    DataGridView.Refresh();
                    CheckErrors(errorColors);
                    ErrorsPanel.Refresh();
                    AddToChart();
                }
                else if (dt.Rows.Count < 0 || (int)DeleteRowUpDown.Value > dt.Rows.Count)
                {
                    MessageBox.Show("Column number not exist.");
                }
            }
            else
            {
                MessageBox.Show("No file upload.");
            }

        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowColLabel.Text = "Row: " + (DataGridView.SelectedCells[0].RowIndex + 1) +
               ", Col: " + (DataGridView.SelectedCells[0].ColumnIndex + 1);
        }


    }
}
