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

        int DeletedCount = 0;
        int UpdatedCount = 0;
        int InsertedCount = 0;

        public Form1()
        {
            InitializeComponent();

            _db = new IntelDB();

            toolStripDelete.Text = DeletedCount.ToString();
            toolStripUpdate.Text = UpdatedCount.ToString();
            toolStripInserted.Text = InsertedCount.ToString();
        }

        private void bShowData_Click(object sender, EventArgs e)
        {
            dGVAuthors.DataSource = _db.GetProcessors();
        }

        private void bPushProcessors_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Do you want update DB?", "Caption", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _db.PushProcessors();
            }
        }
    }
}
