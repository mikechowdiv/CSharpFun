using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NetDisconnectedModel
{
    public partial class GenDataFromTypedDataset : Form
    {
        public GenDataFromTypedDataset()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDS);

        }

        private void GenDataFromTypedDataset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDS.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.northwindDS.Employees);

        }

        private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
