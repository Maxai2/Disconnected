using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected
{
    public partial class Form1 : Form
    {
        private IntelDB _db;

        public Form1()
        {
            InitializeComponent();

            _db = new IntelDB();
        }

        BindingSource dataSource;
        DataTable table;

        private void bShowData_Click(object sender, EventArgs e)
        {
            table = _db.GetProcessors();
            
            dGVAuthors.DataSource = table;

            _db.GetProcessors().RowDeleted += Form1_RowDeleted;
            _db.GetProcessors().RowChanged += Form1_RowChanged;
            _db.GetProcessors().TableNewRow += Form1_TableNewRow;
        }

        private void Form1_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            //DataRow row = table.Rows[13];
            //table.Rows.Add(row);

            toolStripInserted.Text = Convert.ToString(Convert.ToInt32(toolStripInserted.Text) + 1);
        }

        private void Form1_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            toolStripUpdate.Text = Convert.ToString(Convert.ToInt32(toolStripUpdate.Text) + 1);
            dGVAuthors.Rows[dGVAuthors.CurrentRow.Index].Cells[dGVAuthors.CurrentCell.ColumnIndex].Style.BackColor = Color.Yellow;
        }

        private void Form1_RowDeleted(object sender, DataRowChangeEventArgs e)
        {
            toolStripDelete.Text = Convert.ToString(Convert.ToInt32(toolStripDelete.Text) + 1);
        }

        private void bPushProcessors_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Do you want update DB?", "Caption", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _db.PushProcessors();

                toolStripInserted.Text = "0";
                toolStripUpdate.Text = "0";
                toolStripDelete.Text = "0";

                int rowCount = dGVAuthors.Rows.Count;
                int columnCount = dGVAuthors.ColumnCount;

                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        dGVAuthors.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
