namespace WindowsFormsApp1
{
    partial class FormNewList
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1_SaveNewList = new System.Windows.Forms.Button();
            this.button2_CancelNewList = new System.Windows.Forms.Button();
            this.textBox2_Languages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_ListName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter list name";
            // 
            // button1_SaveNewList
            // 
            this.button1_SaveNewList.Location = new System.Drawing.Point(87, 358);
            this.button1_SaveNewList.Name = "button1_SaveNewList";
            this.button1_SaveNewList.Size = new System.Drawing.Size(75, 23);
            this.button1_SaveNewList.TabIndex = 2;
            this.button1_SaveNewList.Text = "Save";
            this.button1_SaveNewList.UseVisualStyleBackColor = true;
            this.button1_SaveNewList.Click += new System.EventHandler(this.button1_SaveNewList_Click);
            // 
            // button2_CancelNewList
            // 
            this.button2_CancelNewList.Location = new System.Drawing.Point(177, 358);
            this.button2_CancelNewList.Name = "button2_CancelNewList";
            this.button2_CancelNewList.Size = new System.Drawing.Size(75, 23);
            this.button2_CancelNewList.TabIndex = 3;
            this.button2_CancelNewList.Text = "Cancel";
            this.button2_CancelNewList.UseVisualStyleBackColor = true;
            this.button2_CancelNewList.Click += new System.EventHandler(this.button2_CancelNewList_Click);
            // 
            // textBox2_Languages
            // 
            this.textBox2_Languages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2_Languages.Location = new System.Drawing.Point(87, 97);
            this.textBox2_Languages.Multiline = true;
            this.textBox2_Languages.Name = "textBox2_Languages";
            this.textBox2_Languages.Size = new System.Drawing.Size(165, 255);
            this.textBox2_Languages.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add languages";
            // 
            // textBox1_ListName
            // 
            this.textBox1_ListName.Location = new System.Drawing.Point(87, 46);
            this.textBox1_ListName.Name = "textBox1_ListName";
            this.textBox1_ListName.Size = new System.Drawing.Size(165, 20);
            this.textBox1_ListName.TabIndex = 0;
            // 
            // FormNewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(307, 393);
            this.Controls.Add(this.textBox1_ListName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2_Languages);
            this.Controls.Add(this.button2_CancelNewList);
            this.Controls.Add(this.button1_SaveNewList);
            this.Controls.Add(this.label1);
            this.Name = "FormNewList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_SaveNewList;
        private System.Windows.Forms.Button button2_CancelNewList;
        private System.Windows.Forms.TextBox textBox2_Languages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_ListName;
    }
}