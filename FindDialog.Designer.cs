namespace LocalizationEditorNET9
{
    partial class FindDialog
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
            findText = new System.Windows.Forms.TextBox();
            findNext = new System.Windows.Forms.Button();
            cancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            wholeWords = new System.Windows.Forms.CheckBox();
            matchCase = new System.Windows.Forms.CheckBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            down = new System.Windows.Forms.RadioButton();
            up = new System.Windows.Forms.RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // findText
            // 
            findText.Location = new System.Drawing.Point(88, 13);
            findText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            findText.Name = "findText";
            findText.Size = new System.Drawing.Size(345, 23);
            findText.TabIndex = 0;
            // 
            // findNext
            // 
            findNext.BackColor = System.Drawing.SystemColors.ControlDark;
            findNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            findNext.Location = new System.Drawing.Point(440, 13);
            findNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            findNext.Name = "findNext";
            findNext.Size = new System.Drawing.Size(88, 25);
            findNext.TabIndex = 1;
            findNext.Text = "Find Next";
            findNext.UseVisualStyleBackColor = false;
            findNext.Click += OnFindNext;
            // 
            // cancel
            // 
            cancel.BackColor = System.Drawing.SystemColors.ControlDark;
            cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cancel.Location = new System.Drawing.Point(440, 44);
            cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cancel.Name = "cancel";
            cancel.Size = new System.Drawing.Size(88, 25);
            cancel.TabIndex = 2;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += OnCancel;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 18);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 14);
            label1.TabIndex = 3;
            label1.Text = "Find what:";
            // 
            // wholeWords
            // 
            wholeWords.AutoSize = true;
            wholeWords.Location = new System.Drawing.Point(15, 44);
            wholeWords.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            wholeWords.Name = "wholeWords";
            wholeWords.Size = new System.Drawing.Size(131, 18);
            wholeWords.TabIndex = 4;
            wholeWords.Text = "Match whole words";
            wholeWords.UseVisualStyleBackColor = true;
            // 
            // matchCase
            // 
            matchCase.AutoSize = true;
            matchCase.Location = new System.Drawing.Point(15, 70);
            matchCase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            matchCase.Name = "matchCase";
            matchCase.Size = new System.Drawing.Size(88, 18);
            matchCase.TabIndex = 5;
            matchCase.Text = "Match case";
            matchCase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(down);
            groupBox1.Controls.Add(up);
            groupBox1.Location = new System.Drawing.Point(161, 42);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(272, 46);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Direction";
            // 
            // down
            // 
            down.AutoSize = true;
            down.Checked = true;
            down.Location = new System.Drawing.Point(110, 20);
            down.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            down.Name = "down";
            down.Size = new System.Drawing.Size(57, 18);
            down.TabIndex = 1;
            down.TabStop = true;
            down.Text = "Down";
            down.UseVisualStyleBackColor = true;
            // 
            // up
            // 
            up.AutoSize = true;
            up.Location = new System.Drawing.Point(20, 20);
            up.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            up.Name = "up";
            up.Size = new System.Drawing.Size(41, 18);
            up.TabIndex = 0;
            up.TabStop = true;
            up.Text = "Up";
            up.UseVisualStyleBackColor = true;
            // 
            // FindDialog
            // 
            AcceptButton = findNext;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = cancel;
            ClientSize = new System.Drawing.Size(541, 104);
            Controls.Add(groupBox1);
            Controls.Add(matchCase);
            Controls.Add(wholeWords);
            Controls.Add(label1);
            Controls.Add(cancel);
            Controls.Add(findNext);
            Controls.Add(findText);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FindDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Find";
            FormClosing += OnClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox findText;
        private System.Windows.Forms.Button findNext;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox wholeWords;
        private System.Windows.Forms.CheckBox matchCase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton down;
        private System.Windows.Forms.RadioButton up;
    }
}