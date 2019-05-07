namespace HashTableAssignment
{
    partial class Form1
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAddToHash = new System.Windows.Forms.Button();
            this.btnRetrieveFromHash = new System.Windows.Forms.Button();
            this.btnRemoveFromHash = new System.Windows.Forms.Button();
            this.btnIsEmpty = new System.Windows.Forms.Button();
            this.btnContainsKey = new System.Windows.Forms.Button();
            this.btnClearHashTable = new System.Windows.Forms.Button();
            this.btnListEmployees = new System.Windows.Forms.Button();
            this.btnListKeys = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtContainer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(51, 24);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(51, 57);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(188, 17);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(177, 26);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(188, 57);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(177, 26);
            this.txtLastName.TabIndex = 3;
            // 
            // btnAddToHash
            // 
            this.btnAddToHash.Location = new System.Drawing.Point(448, 53);
            this.btnAddToHash.Name = "btnAddToHash";
            this.btnAddToHash.Size = new System.Drawing.Size(234, 51);
            this.btnAddToHash.TabIndex = 4;
            this.btnAddToHash.Text = "Add to Hash";
            this.btnAddToHash.UseVisualStyleBackColor = true;
            this.btnAddToHash.Click += new System.EventHandler(this.btnAddToHash_Click);
            // 
            // btnRetrieveFromHash
            // 
            this.btnRetrieveFromHash.Location = new System.Drawing.Point(743, 53);
            this.btnRetrieveFromHash.Name = "btnRetrieveFromHash";
            this.btnRetrieveFromHash.Size = new System.Drawing.Size(252, 51);
            this.btnRetrieveFromHash.TabIndex = 5;
            this.btnRetrieveFromHash.Text = "Retrieve from Hash";
            this.btnRetrieveFromHash.UseVisualStyleBackColor = true;
            this.btnRetrieveFromHash.Click += new System.EventHandler(this.btnRetrieveFromHash_Click);
            // 
            // btnRemoveFromHash
            // 
            this.btnRemoveFromHash.Location = new System.Drawing.Point(448, 129);
            this.btnRemoveFromHash.Name = "btnRemoveFromHash";
            this.btnRemoveFromHash.Size = new System.Drawing.Size(234, 51);
            this.btnRemoveFromHash.TabIndex = 6;
            this.btnRemoveFromHash.Text = "Remove from Hash";
            this.btnRemoveFromHash.UseVisualStyleBackColor = true;
            this.btnRemoveFromHash.Click += new System.EventHandler(this.btnRemoveFromHash_Click);
            // 
            // btnIsEmpty
            // 
            this.btnIsEmpty.Location = new System.Drawing.Point(743, 129);
            this.btnIsEmpty.Name = "btnIsEmpty";
            this.btnIsEmpty.Size = new System.Drawing.Size(252, 51);
            this.btnIsEmpty.TabIndex = 7;
            this.btnIsEmpty.Text = "Is Empty?";
            this.btnIsEmpty.UseVisualStyleBackColor = true;
            this.btnIsEmpty.Click += new System.EventHandler(this.btnIsEmpty_Click);
            // 
            // btnContainsKey
            // 
            this.btnContainsKey.Location = new System.Drawing.Point(448, 205);
            this.btnContainsKey.Name = "btnContainsKey";
            this.btnContainsKey.Size = new System.Drawing.Size(234, 51);
            this.btnContainsKey.TabIndex = 8;
            this.btnContainsKey.Text = "Contains Key?";
            this.btnContainsKey.UseVisualStyleBackColor = true;
            this.btnContainsKey.Click += new System.EventHandler(this.btnContainsKey_Click);
            // 
            // btnClearHashTable
            // 
            this.btnClearHashTable.Location = new System.Drawing.Point(743, 205);
            this.btnClearHashTable.Name = "btnClearHashTable";
            this.btnClearHashTable.Size = new System.Drawing.Size(252, 51);
            this.btnClearHashTable.TabIndex = 9;
            this.btnClearHashTable.Text = "Clear Hash Table";
            this.btnClearHashTable.UseVisualStyleBackColor = true;
            this.btnClearHashTable.Click += new System.EventHandler(this.btnClearHashTable_Click);
            // 
            // btnListEmployees
            // 
            this.btnListEmployees.Location = new System.Drawing.Point(448, 277);
            this.btnListEmployees.Name = "btnListEmployees";
            this.btnListEmployees.Size = new System.Drawing.Size(234, 51);
            this.btnListEmployees.TabIndex = 10;
            this.btnListEmployees.Text = "List All Employees";
            this.btnListEmployees.UseVisualStyleBackColor = true;
            this.btnListEmployees.Click += new System.EventHandler(this.btnListEmployees_Click);
            // 
            // btnListKeys
            // 
            this.btnListKeys.Location = new System.Drawing.Point(743, 277);
            this.btnListKeys.Name = "btnListKeys";
            this.btnListKeys.Size = new System.Drawing.Size(252, 51);
            this.btnListKeys.TabIndex = 11;
            this.btnListKeys.Text = "List All Keys";
            this.btnListKeys.UseVisualStyleBackColor = true;
            this.btnListKeys.Click += new System.EventHandler(this.btnListKeys_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(444, 365);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status:";
            // 
            // txtContainer
            // 
            this.txtContainer.Location = new System.Drawing.Point(13, 95);
            this.txtContainer.Multiline = true;
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.ReadOnly = true;
            this.txtContainer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContainer.Size = new System.Drawing.Size(412, 360);
            this.txtContainer.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 467);
            this.Controls.Add(this.txtContainer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnListKeys);
            this.Controls.Add(this.btnListEmployees);
            this.Controls.Add(this.btnClearHashTable);
            this.Controls.Add(this.btnContainsKey);
            this.Controls.Add(this.btnIsEmpty);
            this.Controls.Add(this.btnRemoveFromHash);
            this.Controls.Add(this.btnRetrieveFromHash);
            this.Controls.Add(this.btnAddToHash);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Hash Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAddToHash;
        private System.Windows.Forms.Button btnRetrieveFromHash;
        private System.Windows.Forms.Button btnRemoveFromHash;
        private System.Windows.Forms.Button btnIsEmpty;
        private System.Windows.Forms.Button btnContainsKey;
        private System.Windows.Forms.Button btnClearHashTable;
        private System.Windows.Forms.Button btnListEmployees;
        private System.Windows.Forms.Button btnListKeys;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtContainer;
    }
}

