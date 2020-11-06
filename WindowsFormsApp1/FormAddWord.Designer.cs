namespace WindowsFormsApp1
{
    partial class FormAddWord
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
            this.button_AddWordOK = new System.Windows.Forms.Button();
            this.button_AddWordCancel = new System.Windows.Forms.Button();
            this.dataGridView_AddWords = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddWords)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddWordOK
            // 
            this.button_AddWordOK.Location = new System.Drawing.Point(68, 166);
            this.button_AddWordOK.Name = "button_AddWordOK";
            this.button_AddWordOK.Size = new System.Drawing.Size(75, 23);
            this.button_AddWordOK.TabIndex = 1;
            this.button_AddWordOK.Text = "Add";
            this.button_AddWordOK.UseVisualStyleBackColor = true;
            this.button_AddWordOK.Click += new System.EventHandler(this.button_AddWordOK_Click);
            // 
            // button_AddWordCancel
            // 
            this.button_AddWordCancel.Location = new System.Drawing.Point(253, 166);
            this.button_AddWordCancel.Name = "button_AddWordCancel";
            this.button_AddWordCancel.Size = new System.Drawing.Size(75, 23);
            this.button_AddWordCancel.TabIndex = 2;
            this.button_AddWordCancel.Text = "Cancel";
            this.button_AddWordCancel.UseVisualStyleBackColor = true;
            this.button_AddWordCancel.Click += new System.EventHandler(this.button_AddWordCancel_Click);
            // 
            // dataGridView_AddWords
            // 
            this.dataGridView_AddWords.AllowUserToAddRows = false;
            this.dataGridView_AddWords.AllowUserToDeleteRows = false;
            this.dataGridView_AddWords.AllowUserToResizeColumns = false;
            this.dataGridView_AddWords.AllowUserToResizeRows = false;
            this.dataGridView_AddWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AddWords.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dataGridView_AddWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AddWords.Location = new System.Drawing.Point(2, 4);
            this.dataGridView_AddWords.Name = "dataGridView_AddWords";
            this.dataGridView_AddWords.RowHeadersVisible = false;
            this.dataGridView_AddWords.Size = new System.Drawing.Size(381, 156);
            this.dataGridView_AddWords.TabIndex = 0;
            // 
            // FormAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.dataGridView_AddWords);
            this.Controls.Add(this.button_AddWordCancel);
            this.Controls.Add(this.button_AddWordOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddWord";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddWord";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddWordOK;
        private System.Windows.Forms.Button button_AddWordCancel;
        private System.Windows.Forms.DataGridView dataGridView_AddWords;
    }
}