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
    public partial class frmUpdateItem : Form
    {
        public String Value { get; set; }

        public frmUpdateItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Value = "!!CancelUpdate!!";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Value = textBox1.Text;
            this.Close();
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.Value;
        }
    }
}
