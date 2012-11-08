using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using Microsoft.Win32;

namespace BasicDatabaseCRUD
{
    public partial class frmMain : Form
    {
        private OleDbConnection con;

        /// <summary>
        /// Class constructor - opens global database connection
        /// </summary>
        public frmMain()
        {
            #region OpenDatabaseConnection
            try
            {
                con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\users\gsantella\documents\visual studio 2010\Projects\BasicDatabaseCRUD\BasicDatabaseCRUD\MenuItems.accdb");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with opening database.");
            }
            #endregion
            InitializeComponent();
        }
        
        /// <summary>
        /// Class destructor - closes global database connection
        /// </summary>
        ~frmMain()
        {
            #region CloseDatabaseConnection
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with closing database.");
            }
            #endregion
        }

        /// <summary>
        /// Reads all items global database connection into the ListView control
        /// </summary>
        private void ReadDatabaseItemsToListView()
        {
            OleDbCommand command = new OleDbCommand("SELECT id, itemName FROM menuItem;", con);
            OleDbDataReader reader = command.ExecuteReader();

            lstMenuItems2.Items.Clear();

            while (reader.Read())
            {
                lstMenuItems2.Items.Add(reader.GetString(1).ToString()).SubItems.Add(reader.GetInt32(0).ToString());
            }

            reader.Close();
        }

        /// <summary>
        /// Load event handler for frmMain
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            ReadDatabaseItemsToListView();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem addItemForm = new frmAddItem();
            addItemForm.ShowDialog();

            if (addItemForm.Value != "!!CancelAdd!!")
            {
                OleDbCommand command = new OleDbCommand("INSERT INTO menuItem(itemName) VALUES('" + addItemForm.Value + "');", con);
                int numRowsAffected = command.ExecuteNonQuery();

                if (numRowsAffected == 1)
                {
                    //MessageBox.Show("Successful Insert");
                }
                else
                {
                    MessageBox.Show("Error with Insert");
                }

                ReadDatabaseItemsToListView();
            }
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (lstMenuItems2.SelectedItems.Count > 0)
            {
                frmUpdateItem updateItemForm = new frmUpdateItem();
                updateItemForm.Value = lstMenuItems2.SelectedItems[0].SubItems[0].Text;
                updateItemForm.ShowDialog();

                if (updateItemForm.Value != "!!CancelUpdate!!")
                {
                    OleDbCommand command = new OleDbCommand("UPDATE menuItem SET itemName = '" + updateItemForm.Value + "' WHERE id = " + lstMenuItems2.SelectedItems[0].SubItems[1].Text + ";", con);
                    int numRowsAffected = command.ExecuteNonQuery();

                    if (numRowsAffected == 1)
                    {
                        //MessageBox.Show("Successful Update");
                    }
                    else
                    {
                        MessageBox.Show("Error with Update");
                    }

                    ReadDatabaseItemsToListView();
                }
            }
            else
            {
                MessageBox.Show("No Option Selected");
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (lstMenuItems2.SelectedItems.Count > 0)
            {
                OleDbCommand command = new OleDbCommand("DELETE FROM menuItem WHERE id = " + lstMenuItems2.SelectedItems[0].SubItems[1].Text + ";", con);
                int numRowsAffected = command.ExecuteNonQuery();

                if (numRowsAffected == 1)
                {
                    //MessageBox.Show("Successful Deletion");
                }
                else
                {
                    MessageBox.Show("Error with Deletion");
                }

                ReadDatabaseItemsToListView();
            }
            else
            {
                MessageBox.Show("No Option Selected");
            }
        }

        /// <summary>
        /// Refreshes all items in the ListView from the database
        /// </summary>
        private void btnRefreshItems_Click(object sender, EventArgs e)
        {
            ReadDatabaseItemsToListView();
        }
    }
}
