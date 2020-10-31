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
            this.label1_WordLists = new System.Windows.Forms.Label();
            this.listBox1_ShowLists = new System.Windows.Forms.ListBox();
            this.listBox2_ShowLanguages = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.button1_NewList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_WordLists
            // 
            this.label1_WordLists.AutoSize = true;
            this.label1_WordLists.Location = new System.Drawing.Point(169, 30);
            this.label1_WordLists.Name = "label1_WordLists";
            this.label1_WordLists.Size = new System.Drawing.Size(53, 13);
            this.label1_WordLists.TabIndex = 1;
            this.label1_WordLists.Text = "Word lists";
            // 
            // listBox1_ShowLists
            // 
            this.listBox1_ShowLists.FormattingEnabled = true;
            this.listBox1_ShowLists.Location = new System.Drawing.Point(172, 46);
            this.listBox1_ShowLists.Name = "listBox1_ShowLists";
            this.listBox1_ShowLists.Size = new System.Drawing.Size(229, 212);
            this.listBox1_ShowLists.TabIndex = 2;
            this.listBox1_ShowLists.SelectedIndexChanged += new System.EventHandler(this.listBox1_ShowLists_SelectedIndexChanged);
            // 
            // listBox2_ShowLanguages
            // 
            this.listBox2_ShowLanguages.FormattingEnabled = true;
            this.listBox2_ShowLanguages.Location = new System.Drawing.Point(439, 46);
            this.listBox2_ShowLanguages.Name = "listBox2_ShowLanguages";
            this.listBox2_ShowLanguages.Size = new System.Drawing.Size(223, 212);
            this.listBox2_ShowLanguages.TabIndex = 3;
            this.listBox2_ShowLanguages.SelectedIndexChanged += new System.EventHandler(this.listBox2_ShowLanguages_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Words: ";
            // 
            // Counter
            // 
            this.Counter.AllowDrop = true;
            this.Counter.AutoEllipsis = true;
            this.Counter.AutoSize = true;
            this.Counter.Location = new System.Drawing.Point(209, 30);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(0, 13);
            this.Counter.TabIndex = 5;
            // 
            // button1_NewList
            // 
            this.button1_NewList.Location = new System.Drawing.Point(172, 264);
            this.button1_NewList.Name = "button1_NewList";
            this.button1_NewList.Size = new System.Drawing.Size(75, 23);
            this.button1_NewList.TabIndex = 6;
            this.button1_NewList.Text = "New List";
            this.button1_NewList.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Languages";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1_NewList);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2_ShowLanguages);
            this.Controls.Add(this.listBox1_ShowLists);
            this.Controls.Add(this.label1_WordLists);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1_WordLists;
        private System.Windows.Forms.ListBox listBox1_ShowLists;
        private System.Windows.Forms.ListBox listBox2_ShowLanguages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Button button1_NewList;
        private System.Windows.Forms.Label label2;
    }
}

