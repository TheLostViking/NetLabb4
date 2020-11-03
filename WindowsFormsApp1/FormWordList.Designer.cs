namespace WindowsFormsApp1
{
    partial class FormWordList
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
            this.label_WordLists = new System.Windows.Forms.Label();
            this.listBox1_ShowLists = new System.Windows.Forms.ListBox();
            this.listBox2_ShowLanguages = new System.Windows.Forms.ListBox();
            this.label_Words = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.button1_NewList = new System.Windows.Forms.Button();
            this.label_Languages = new System.Windows.Forms.Label();
            this.button_EditListOpen = new System.Windows.Forms.Button();
            this.label_NumberOfWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_WordLists
            // 
            this.label_WordLists.AutoSize = true;
            this.label_WordLists.Location = new System.Drawing.Point(169, 30);
            this.label_WordLists.Name = "label_WordLists";
            this.label_WordLists.Size = new System.Drawing.Size(53, 13);
            this.label_WordLists.TabIndex = 1;
            this.label_WordLists.Text = "Word lists";
            // 
            // listBox1_ShowLists
            // 
            this.listBox1_ShowLists.FormattingEnabled = true;
            this.listBox1_ShowLists.Location = new System.Drawing.Point(172, 46);
            this.listBox1_ShowLists.Name = "listBox1_ShowLists";
            this.listBox1_ShowLists.Size = new System.Drawing.Size(229, 212);
            this.listBox1_ShowLists.TabIndex = 2;
            this.listBox1_ShowLists.SelectedIndexChanged += new System.EventHandler(this.listBox1_ShowLists_SelectedIndexChanged);
            this.listBox1_ShowLists.DoubleClick += new System.EventHandler(this.listBox1_ShowLists_DoubleClick);
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
            // label_Words
            // 
            this.label_Words.AutoSize = true;
            this.label_Words.Location = new System.Drawing.Point(344, 30);
            this.label_Words.Name = "label_Words";
            this.label_Words.Size = new System.Drawing.Size(44, 13);
            this.label_Words.TabIndex = 4;
            this.label_Words.Text = "Words: ";
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
            this.button1_NewList.Size = new System.Drawing.Size(119, 23);
            this.button1_NewList.TabIndex = 6;
            this.button1_NewList.Text = "Create New List";
            this.button1_NewList.UseVisualStyleBackColor = true;
            this.button1_NewList.Click += new System.EventHandler(this.button1_NewList_Click);
            // 
            // label_Languages
            // 
            this.label_Languages.AutoSize = true;
            this.label_Languages.Location = new System.Drawing.Point(436, 30);
            this.label_Languages.Name = "label_Languages";
            this.label_Languages.Size = new System.Drawing.Size(60, 13);
            this.label_Languages.TabIndex = 7;
            this.label_Languages.Text = "Languages";
            // 
            // button_EditListOpen
            // 
            this.button_EditListOpen.Location = new System.Drawing.Point(298, 263);
            this.button_EditListOpen.Name = "button_EditListOpen";
            this.button_EditListOpen.Size = new System.Drawing.Size(103, 23);
            this.button_EditListOpen.TabIndex = 8;
            this.button_EditListOpen.Text = "Edit List";
            this.button_EditListOpen.UseVisualStyleBackColor = true;
            this.button_EditListOpen.Click += new System.EventHandler(this.button_EditListOpen_Click);
            // 
            // label_NumberOfWords
            // 
            this.label_NumberOfWords.AutoSize = true;
            this.label_NumberOfWords.Location = new System.Drawing.Point(388, 30);
            this.label_NumberOfWords.Name = "label_NumberOfWords";
            this.label_NumberOfWords.Size = new System.Drawing.Size(0, 13);
            this.label_NumberOfWords.TabIndex = 9;
            // 
            // FormWordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_NumberOfWords);
            this.Controls.Add(this.button_EditListOpen);
            this.Controls.Add(this.label_Languages);
            this.Controls.Add(this.button1_NewList);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.label_Words);
            this.Controls.Add(this.listBox2_ShowLanguages);
            this.Controls.Add(this.listBox1_ShowLists);
            this.Controls.Add(this.label_WordLists);
            this.Name = "FormWordList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sebastians Glossary Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_WordLists;
        private System.Windows.Forms.ListBox listBox1_ShowLists;
        private System.Windows.Forms.ListBox listBox2_ShowLanguages;
        private System.Windows.Forms.Label label_Words;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Button button1_NewList;
        private System.Windows.Forms.Label label_Languages;
        private System.Windows.Forms.Button button_EditListOpen;
        private System.Windows.Forms.Label label_NumberOfWords;
    }
}

