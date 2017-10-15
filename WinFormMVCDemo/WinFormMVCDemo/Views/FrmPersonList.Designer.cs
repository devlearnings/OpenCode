namespace WinFormMVCDemo.Views
{
    partial class FrmPersonList
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
            this.personListView = new System.Windows.Forms.ListView();
            this.Ref = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personListView
            // 
            this.personListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ref,
            this.FirstName,
            this.Age,
            this.Phone});
            this.personListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.personListView.Location = new System.Drawing.Point(8, 9);
            this.personListView.Name = "personListView";
            this.personListView.Size = new System.Drawing.Size(435, 429);
            this.personListView.TabIndex = 8;
            this.personListView.UseCompatibleStateImageBehavior = false;
            this.personListView.View = System.Windows.Forms.View.Details;
            // 
            // Ref
            // 
            this.Ref.Text = "Ref";
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 154;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.Width = 66;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 151;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(449, 67);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(167, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "RefreshData";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(449, 38);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(167, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(449, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmPersonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 449);
            this.Controls.Add(this.personListView);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmPersonList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "All Persons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView personListView;
        private System.Windows.Forms.ColumnHeader Ref;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
    }
}