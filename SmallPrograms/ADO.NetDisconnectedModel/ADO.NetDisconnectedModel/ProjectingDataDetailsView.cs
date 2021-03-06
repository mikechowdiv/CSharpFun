﻿using System;
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
    public partial class ProjectingDataDetailsView : Form
    {
        public ProjectingDataDetailsView()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDS);

        }

        private void ProjectingDataDetailsView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDS.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.northwindDS.Employees);

        }

        private void employeeIDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
