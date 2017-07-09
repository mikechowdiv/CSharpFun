﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSqlServer
{
    public partial class Form1 : Form
    {
        TestEntities test;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    dataGridView.DataSource = customerBindingSource;

                }
                else
                {
                    var query = from o in customerBindingSource.DataSource as List<Customer>
                                where o.CustomerID == txtSearch.Text
                                || o.Fullname.Contains(txtSearch.Text)
                                || o.Email == txtSearch.Text
                                || o.Address.Contains(txtSearch.Text)
                                select o;
                    dataGridView.DataSource = query.ToList();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtCustomerID.Focus();
                Customer c = new Customer();
                test.Customers.Add(c);
                customerBindingSource.Add(c);
                customerBindingSource.MoveLast();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtCustomerID.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            customerBindingSource.ResetBindings(false);
            foreach (DbEntityEntry entry in test.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Detached:
                        entry.Reload();
                        break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                customerBindingSource.EndEdit();
                test.SaveChangesAsync();
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerBindingSource.ResetBindings(false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel.Enabled = false;
            test = new TestEntities();
            customerBindingSource.DataSource = test.Customers.ToList();
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    test.Customers.Remove(customerBindingSource.Current as Customer);
                    customerBindingSource.RemoveCurrent();
                }
            }
        }
    }
}
