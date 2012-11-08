namespace BasicDatabaseCRUD
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnRefreshItems = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lstMenuItems2 = new System.Windows.Forms.ListView();
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(205, 436);
            this.btnUpdateItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(187, 56);
            this.btnUpdateItem.TabIndex = 1;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(400, 436);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(187, 56);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnRefreshItems
            // 
            this.btnRefreshItems.Location = new System.Drawing.Point(595, 436);
            this.btnRefreshItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshItems.Name = "btnRefreshItems";
            this.btnRefreshItems.Size = new System.Drawing.Size(187, 56);
            this.btnRefreshItems.TabIndex = 3;
            this.btnRefreshItems.Text = "Refresh Items";
            this.btnRefreshItems.UseVisualStyleBackColor = true;
            this.btnRefreshItems.Click += new System.EventHandler(this.btnRefreshItems_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(10, 436);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(187, 56);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lstMenuItems2
            // 
            this.lstMenuItems2.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstMenuItems2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMenuItems2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemName,
            this.id});
            this.lstMenuItems2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMenuItems2.FullRowSelect = true;
            this.lstMenuItems2.GridLines = true;
            this.lstMenuItems2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMenuItems2.Location = new System.Drawing.Point(10, 14);
            this.lstMenuItems2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstMenuItems2.MultiSelect = false;
            this.lstMenuItems2.Name = "lstMenuItems2";
            this.lstMenuItems2.Scrollable = false;
            this.lstMenuItems2.Size = new System.Drawing.Size(772, 414);
            this.lstMenuItems2.TabIndex = 5;
            this.lstMenuItems2.UseCompatibleStateImageBehavior = false;
            this.lstMenuItems2.View = System.Windows.Forms.View.Details;
            // 
            // itemName
            // 
            this.itemName.Text = "Name";
            this.itemName.Width = 875;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 502);
            this.Controls.Add(this.lstMenuItems2);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnRefreshItems);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnUpdateItem);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Item Database";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnRefreshItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListView lstMenuItems2;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader itemName;
    }
}

