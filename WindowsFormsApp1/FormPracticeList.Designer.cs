namespace WindowsFormsApp1
{
    partial class FormPracticeList
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
            this.button_ResetPractice = new System.Windows.Forms.Button();
            this.button_ExitPractice = new System.Windows.Forms.Button();
            this.textBox_AnswerFromUser = new System.Windows.Forms.TextBox();
            this.label_EnterThe = new System.Windows.Forms.Label();
            this.label_FromLanguage = new System.Windows.Forms.Label();
            this.label_ToLanguage = new System.Windows.Forms.Label();
            this.label_Word = new System.Windows.Forms.Label();
            this.label_WordID = new System.Windows.Forms.Label();
            this.label_PracticeModeText = new System.Windows.Forms.Label();
            this.label_Translation = new System.Windows.Forms.Label();
            this.label_CorrectOrNot = new System.Windows.Forms.Label();
            this.label_CorrectAnswers = new System.Windows.Forms.Label();
            this.label_Counter = new System.Windows.Forms.Label();
            this.label_Slash = new System.Windows.Forms.Label();
            this.label_NumberOfTries = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ResetPractice
            // 
            this.button_ResetPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetPractice.Location = new System.Drawing.Point(202, 233);
            this.button_ResetPractice.Name = "button_ResetPractice";
            this.button_ResetPractice.Size = new System.Drawing.Size(95, 23);
            this.button_ResetPractice.TabIndex = 12;
            this.button_ResetPractice.Text = "Reset";
            this.button_ResetPractice.UseVisualStyleBackColor = true;
            this.button_ResetPractice.Click += new System.EventHandler(this.button_ResetPractice_Click);
            // 
            // button_ExitPractice
            // 
            this.button_ExitPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExitPractice.Location = new System.Drawing.Point(307, 233);
            this.button_ExitPractice.Name = "button_ExitPractice";
            this.button_ExitPractice.Size = new System.Drawing.Size(95, 23);
            this.button_ExitPractice.TabIndex = 13;
            this.button_ExitPractice.Text = "Exit";
            this.button_ExitPractice.UseVisualStyleBackColor = true;
            this.button_ExitPractice.Click += new System.EventHandler(this.button_ExitPractice_Click);
            // 
            // textBox_AnswerFromUser
            // 
            this.textBox_AnswerFromUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AnswerFromUser.Location = new System.Drawing.Point(202, 167);
            this.textBox_AnswerFromUser.Name = "textBox_AnswerFromUser";
            this.textBox_AnswerFromUser.Size = new System.Drawing.Size(200, 26);
            this.textBox_AnswerFromUser.TabIndex = 8;
            this.textBox_AnswerFromUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_AnswerFromUser_KeyDown);
            // 
            // label_EnterThe
            // 
            this.label_EnterThe.AutoSize = true;
            this.label_EnterThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EnterThe.Location = new System.Drawing.Point(12, 120);
            this.label_EnterThe.Name = "label_EnterThe";
            this.label_EnterThe.Size = new System.Drawing.Size(75, 20);
            this.label_EnterThe.TabIndex = 1;
            this.label_EnterThe.Text = "Enter the";
            this.label_EnterThe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_FromLanguage
            // 
            this.label_FromLanguage.AutoSize = true;
            this.label_FromLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FromLanguage.Location = new System.Drawing.Point(100, 120);
            this.label_FromLanguage.Name = "label_FromLanguage";
            this.label_FromLanguage.Size = new System.Drawing.Size(98, 20);
            this.label_FromLanguage.TabIndex = 2;
            this.label_FromLanguage.Text = "Translation";
            this.label_FromLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_ToLanguage
            // 
            this.label_ToLanguage.AutoSize = true;
            this.label_ToLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ToLanguage.Location = new System.Drawing.Point(332, 120);
            this.label_ToLanguage.Name = "label_ToLanguage";
            this.label_ToLanguage.Size = new System.Drawing.Size(108, 20);
            this.label_ToLanguage.TabIndex = 5;
            this.label_ToLanguage.Text = "Translation2";
            this.label_ToLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Word
            // 
            this.label_Word.AutoSize = true;
            this.label_Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Word.Location = new System.Drawing.Point(436, 120);
            this.label_Word.Name = "label_Word";
            this.label_Word.Size = new System.Drawing.Size(43, 20);
            this.label_Word.TabIndex = 6;
            this.label_Word.Text = "word";
            this.label_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_WordID
            // 
            this.label_WordID.AutoSize = true;
            this.label_WordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WordID.Location = new System.Drawing.Point(475, 120);
            this.label_WordID.Name = "label_WordID";
            this.label_WordID.Size = new System.Drawing.Size(72, 20);
            this.label_WordID.TabIndex = 7;
            this.label_WordID.Text = "\'WORD\'";
            this.label_WordID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_PracticeModeText
            // 
            this.label_PracticeModeText.AutoSize = true;
            this.label_PracticeModeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PracticeModeText.Location = new System.Drawing.Point(216, 45);
            this.label_PracticeModeText.Name = "label_PracticeModeText";
            this.label_PracticeModeText.Size = new System.Drawing.Size(200, 31);
            this.label_PracticeModeText.TabIndex = 0;
            this.label_PracticeModeText.Text = "Practice Mode";
            // 
            // label_Translation
            // 
            this.label_Translation.AutoSize = true;
            this.label_Translation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Translation.Location = new System.Drawing.Point(198, 120);
            this.label_Translation.Name = "label_Translation";
            this.label_Translation.Size = new System.Drawing.Size(128, 20);
            this.label_Translation.TabIndex = 3;
            this.label_Translation.Text = "translation of the";
            // 
            // label_CorrectOrNot
            // 
            this.label_CorrectOrNot.AutoSize = true;
            this.label_CorrectOrNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CorrectOrNot.Location = new System.Drawing.Point(198, 205);
            this.label_CorrectOrNot.Name = "label_CorrectOrNot";
            this.label_CorrectOrNot.Size = new System.Drawing.Size(0, 20);
            this.label_CorrectOrNot.TabIndex = 9;
            // 
            // label_CorrectAnswers
            // 
            this.label_CorrectAnswers.AutoSize = true;
            this.label_CorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CorrectAnswers.Location = new System.Drawing.Point(408, 205);
            this.label_CorrectAnswers.Name = "label_CorrectAnswers";
            this.label_CorrectAnswers.Size = new System.Drawing.Size(128, 20);
            this.label_CorrectAnswers.TabIndex = 11;
            this.label_CorrectAnswers.Text = "Correct answers!";
            // 
            // label_Counter
            // 
            this.label_Counter.AutoSize = true;
            this.label_Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Counter.Location = new System.Drawing.Point(360, 205);
            this.label_Counter.Name = "label_Counter";
            this.label_Counter.Size = new System.Drawing.Size(19, 20);
            this.label_Counter.TabIndex = 10;
            this.label_Counter.Text = "0";
            // 
            // label_Slash
            // 
            this.label_Slash.AutoSize = true;
            this.label_Slash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Slash.Location = new System.Drawing.Point(374, 205);
            this.label_Slash.Name = "label_Slash";
            this.label_Slash.Size = new System.Drawing.Size(14, 20);
            this.label_Slash.TabIndex = 14;
            this.label_Slash.Text = "/";
            // 
            // label_NumberOfTries
            // 
            this.label_NumberOfTries.AutoSize = true;
            this.label_NumberOfTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NumberOfTries.Location = new System.Drawing.Point(384, 205);
            this.label_NumberOfTries.Name = "label_NumberOfTries";
            this.label_NumberOfTries.Size = new System.Drawing.Size(19, 20);
            this.label_NumberOfTries.TabIndex = 15;
            this.label_NumberOfTries.Text = "0";
            // 
            // FormPracticeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label_NumberOfTries);
            this.Controls.Add(this.label_Slash);
            this.Controls.Add(this.label_Counter);
            this.Controls.Add(this.label_CorrectAnswers);
            this.Controls.Add(this.label_CorrectOrNot);
            this.Controls.Add(this.label_Translation);
            this.Controls.Add(this.label_PracticeModeText);
            this.Controls.Add(this.label_WordID);
            this.Controls.Add(this.label_Word);
            this.Controls.Add(this.label_ToLanguage);
            this.Controls.Add(this.label_FromLanguage);
            this.Controls.Add(this.label_EnterThe);
            this.Controls.Add(this.textBox_AnswerFromUser);
            this.Controls.Add(this.button_ExitPractice);
            this.Controls.Add(this.button_ResetPractice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormPracticeList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Practice Mode";
            this.Load += new System.EventHandler(this.FormPracticeList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ResetPractice;
        private System.Windows.Forms.Button button_ExitPractice;
        private System.Windows.Forms.TextBox textBox_AnswerFromUser;
        private System.Windows.Forms.Label label_EnterThe;
        private System.Windows.Forms.Label label_FromLanguage;
        private System.Windows.Forms.Label label_ToLanguage;
        private System.Windows.Forms.Label label_Word;
        private System.Windows.Forms.Label label_WordID;
        private System.Windows.Forms.Label label_PracticeModeText;
        private System.Windows.Forms.Label label_Translation;
        private System.Windows.Forms.Label label_CorrectOrNot;
        private System.Windows.Forms.Label label_CorrectAnswers;
        private System.Windows.Forms.Label label_Counter;
        private System.Windows.Forms.Label label_Slash;
        private System.Windows.Forms.Label label_NumberOfTries;
    }
}