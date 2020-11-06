namespace WindowsFormsApp1
{
    partial class FormEditList
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
            this.button_AddWord = new System.Windows.Forms.Button();
            this.button_RemoveWord = new System.Windows.Forms.Button();
            this.button_Practice = new System.Windows.Forms.Button();
            this.button_ExitEditList = new System.Windows.Forms.Button();
            this.dataGridView_EditListGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EditListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddWord
            // 
            this.button_AddWord.Location = new System.Drawing.Point(12, 326);
            this.button_AddWord.Name = "button_AddWord";
            this.button_AddWord.Size = new System.Drawing.Size(95, 23);
            this.button_AddWord.TabIndex = 1;
            this.button_AddWord.Text = "Add word";
            this.button_AddWord.UseVisualStyleBackColor = true;
            this.button_AddWord.Click += new System.EventHandler(this.button_AddWord_Click);
            // 
            // button_RemoveWord
            // 
            this.button_RemoveWord.Location = new System.Drawing.Point(113, 326);
            this.button_RemoveWord.Name = "button_RemoveWord";
            this.button_RemoveWord.Size = new System.Drawing.Size(95, 23);
            this.button_RemoveWord.TabIndex = 2;
            this.button_RemoveWord.Text = "Remove";
            this.button_RemoveWord.UseVisualStyleBackColor = true;
            this.button_RemoveWord.Click += new System.EventHandler(this.button_RemoveWord_Click);
            // 
            // button_Practice
            // 
            this.button_Practice.Location = new System.Drawing.Point(376, 326);
            this.button_Practice.Name = "button_Practice";
            this.button_Practice.Size = new System.Drawing.Size(95, 23);
            this.button_Practice.TabIndex = 3;
            this.button_Practice.Text = "Practice";
            this.button_Practice.UseVisualStyleBackColor = true;
            this.button_Practice.Click += new System.EventHandler(this.button_Practice_Click);
            // 
            // button_ExitEditList
            // 
            this.button_ExitEditList.Location = new System.Drawing.Point(477, 326);
            this.button_ExitEditList.Name = "button_ExitEditList";
            this.button_ExitEditList.Size = new System.Drawing.Size(95, 23);
            this.button_ExitEditList.TabIndex = 4;
            this.button_ExitEditList.Text = "Exit";
            this.button_ExitEditList.UseVisualStyleBackColor = true;
            this.button_ExitEditList.Click += new System.EventHandler(this.button_ExitEditList_Click);
            // 
            // dataGridView_EditListGrid
            // 
            this.dataGridView_EditListGrid.AllowUserToAddRows = false;
            this.dataGridView_EditListGrid.AllowUserToDeleteRows = false;
            this.dataGridView_EditListGrid.AllowUserToResizeColumns = false;
            this.dataGridView_EditListGrid.AllowUserToResizeRows = false;
            this.dataGridView_EditListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_EditListGrid.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dataGridView_EditListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EditListGrid.Location = new System.Drawing.Point(12, 13);
            this.dataGridView_EditListGrid.Name = "dataGridView_EditListGrid";
            this.dataGridView_EditListGrid.ReadOnly = true;
            this.dataGridView_EditListGrid.RowHeadersVisible = false;
            this.dataGridView_EditListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_EditListGrid.Size = new System.Drawing.Size(560, 307);
            this.dataGridView_EditListGrid.TabIndex = 0;
            // 
            // FormEditList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dataGridView_EditListGrid);
            this.Controls.Add(this.button_ExitEditList);
            this.Controls.Add(this.button_Practice);
            this.Controls.Add(this.button_RemoveWord);
            this.Controls.Add(this.button_AddWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormEditList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Mode";
            this.Load += new System.EventHandler(this.FormEditList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EditListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddWord;
        private System.Windows.Forms.Button button_RemoveWord;
        private System.Windows.Forms.Button button_Practice;
        private System.Windows.Forms.Button button_ExitEditList;
        private System.Windows.Forms.DataGridView dataGridView_EditListGrid;
    }
}