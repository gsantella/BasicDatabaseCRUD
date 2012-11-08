using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BasicDatabaseCRUD
{
    public partial class frmAddItem : Form
    {
        public String Value { get; set; }

        public frmAddItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Value = "!!CancelAdd!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Value = textBox1.Text;
            this.Close();
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {

        }
    }
}
