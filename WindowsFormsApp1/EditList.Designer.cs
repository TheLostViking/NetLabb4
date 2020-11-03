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
            this.DataGridViewEditList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEditList)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewEditList
            // 
            this.DataGridViewEditList.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.DataGridViewEditList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewEditList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewEditList.GridColor = System.Drawing.Color.DarkOrange;
            this.DataGridViewEditList.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewEditList.Name = "DataGridViewEditList";
            this.DataGridViewEditList.Size = new System.Drawing.Size(599, 436);
            this.DataGridViewEditList.TabIndex = 0;
            // 
            // FormEditList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 436);
            this.Controls.Add(this.DataGridViewEditList);
            this.Name = "FormEditList";
            this.ShowIcon = false;
            this.Text = "Edit Mode";
            this.Load += new System.EventHandler(this.FormEditList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEditList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewEditList;
    }
}