using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixCSVAssignment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ErrorsChart.Visible = false;
        }

        private void TableViewButton_Click(object sender, EventArgs e)
        {
            ErrorsChart.Visible = false;
            DataGridView.Visible = true;
        }

        private void ChartViewButton_Click(object sender, EventArgs e)
        {
            ErrorsChart.Visible = true;
            DataGridView.Visible = false;
        }
    }
}
