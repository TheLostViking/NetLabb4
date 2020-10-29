namespace WindowsFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1_LoadList = new System.Windows.Forms.Button();
            this.button2_NewList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(424, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 338);
            this.textBox1.TabIndex = 0;
            // 
            // button1_LoadList
            // 
            this.button1_LoadList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1_LoadList.Location = new System.Drawing.Point(713, 356);
            this.button1_LoadList.Name = "button1_LoadList";
            this.button1_LoadList.Size = new System.Drawing.Size(75, 23);
            this.button1_LoadList.TabIndex = 1;
            this.button1_LoadList.Text = "Load List";
            this.button1_LoadList.UseVisualStyleBackColor = true;
            // 
            // button2_NewList
            // 
            this.button2_NewList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2_NewList.Location = new System.Drawing.Point(424, 356);
            this.button2_NewList.Name = "button2_NewList";
            this.button2_NewList.Size = new System.Drawing.Size(75, 23);
            this.button2_NewList.TabIndex = 2;
            this.button2_NewList.Text = "New List";
            this.button2_NewList.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2_NewList);
            this.Controls.Add(this.button1_LoadList);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1_LoadList;
        private System.Windows.Forms.Button button2_NewList;
    }
}

