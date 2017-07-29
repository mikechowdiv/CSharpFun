using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NetFromXML
{
    public partial class ReadDataFromXML : Form
    {
        public ReadDataFromXML()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //form_load
            DataSet ds = new DataSet();
            ds.ReadXml(@"E:\workspace\CSharpFun\SmallPrograms\ADO.NetFromXML\items.xml");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
