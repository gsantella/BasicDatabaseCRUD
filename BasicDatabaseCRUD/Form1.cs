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
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lstMenuItems2.Items.Clear();
            
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\users\gsantella\documents\visual studio 2010\Projects\BasicDatabaseCRUD\BasicDatabaseCRUD\MenuItems.accdb");
          
            #region OpenDatabaseConnection
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with opening database.");
            }
            #endregion

            OleDbCommand command = new OleDbCommand("SELECT id, itemName FROM menuItem;", con);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                lstMenuItems2.Items.Add(reader.GetString(1).ToString()).SubItems.Add(reader.GetInt32(0).ToString());
            }

            reader.Close();

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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\users\gsantella\documents\visual studio 2010\Projects\BasicDatabaseCRUD\BasicDatabaseCRUD\MenuItems.accdb");

            #region OpenDatabaseConnection
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with opening database.");
            }
            #endregion

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

                frmMain_Load(null, null);
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
                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\users\gsantella\documents\visual studio 2010\Projects\BasicDatabaseCRUD\BasicDatabaseCRUD\MenuItems.accdb");

                    #region OpenDatabaseConnection
                    try
                    {
                        con.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem with opening database.");
                    }
                    #endregion

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

                    frmMain_Load(null, null);
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
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\users\gsantella\documents\visual studio 2010\Projects\BasicDatabaseCRUD\BasicDatabaseCRUD\MenuItems.accdb");

                #region OpenDatabaseConnection
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem with opening database.");
                }
                #endregion

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

                frmMain_Load(null, null);
            }
            else
            {
                MessageBox.Show("No Option Selected");
            }
        }

        private void btnRefreshItems_Click(object sender, EventArgs e)
        {
            frmMain_Load(null, null);
        }
    }
}
