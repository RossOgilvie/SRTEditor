namespace SRTEditor
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
            this.SaveLojButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.JumpButton = new System.Windows.Forms.Button();
            this.EnglishTextBox = new System.Windows.Forms.TextBox();
            this.LojbanTextBox = new System.Windows.Forms.TextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.OpenTextBox = new System.Windows.Forms.TextBox();
            this.SaveTextBox = new System.Windows.Forms.TextBox();
            this.SavePathButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TimeEngTextBox = new System.Windows.Forms.TextBox();
            this.IndexEngLabel = new System.Windows.Forms.Label();
            this.PrevButton = new System.Windows.Forms.Button();
            this.IndexLojLabel = new System.Windows.Forms.Label();
            this.TimeLojTextBox = new System.Windows.Forms.TextBox();
            this.PrevEngButton = new System.Windows.Forms.Button();
            this.NextEngButton = new System.Windows.Forms.Button();
            this.PrevLojButton = new System.Windows.Forms.Button();
            this.NextLojButton = new System.Windows.Forms.Button();
            this.InsertLojButton = new System.Windows.Forms.Button();
            this.DeleteLojButton = new System.Windows.Forms.Button();
            this.OutputBothButton = new System.Windows.Forms.Button();
            this.JumpTextBox = new System.Windows.Forms.TextBox();
            this.DualTextBox = new System.Windows.Forms.TextBox();
            this.DualPathButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveLojButton
            // 
            this.SaveLojButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveLojButton.Location = new System.Drawing.Point(619, 377);
            this.SaveLojButton.Name = "SaveLojButton";
            this.SaveLojButton.Size = new System.Drawing.Size(120, 38);
            this.SaveLojButton.TabIndex = 0;
            this.SaveLojButton.TabStop = false;
            this.SaveLojButton.Text = "Save";
            this.SaveLojButton.UseVisualStyleBackColor = true;
            this.SaveLojButton.Click += new System.EventHandler(this.SaveLojButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Location = new System.Drawing.Point(367, 377);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(120, 38);
            this.NextButton.TabIndex = 1;
            this.NextButton.TabStop = false;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // JumpButton
            // 
            this.JumpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.JumpButton.Location = new System.Drawing.Point(241, 377);
            this.JumpButton.Name = "JumpButton";
            this.JumpButton.Size = new System.Drawing.Size(120, 38);
            this.JumpButton.TabIndex = 2;
            this.JumpButton.TabStop = false;
            this.JumpButton.Text = "Jump";
            this.JumpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JumpButton.UseVisualStyleBackColor = true;
            this.JumpButton.Click += new System.EventHandler(this.JumpButton_Click);
            // 
            // EnglishTextBox
            // 
            this.EnglishTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.EnglishTextBox.Location = new System.Drawing.Point(6, 42);
            this.EnglishTextBox.Multiline = true;
            this.EnglishTextBox.Name = "EnglishTextBox";
            this.EnglishTextBox.Size = new System.Drawing.Size(340, 200);
            this.EnglishTextBox.TabIndex = 2;
            // 
            // LojbanTextBox
            // 
            this.LojbanTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LojbanTextBox.Location = new System.Drawing.Point(5, 42);
            this.LojbanTextBox.Multiline = true;
            this.LojbanTextBox.Name = "LojbanTextBox";
            this.LojbanTextBox.Size = new System.Drawing.Size(357, 200);
            this.LojbanTextBox.TabIndex = 1;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(12, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(174, 20);
            this.OpenButton.TabIndex = 5;
            this.OpenButton.TabStop = false;
            this.OpenButton.Text = "English Subtitles";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // OpenTextBox
            // 
            this.OpenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenTextBox.Location = new System.Drawing.Point(192, 12);
            this.OpenTextBox.Name = "OpenTextBox";
            this.OpenTextBox.Size = new System.Drawing.Size(547, 20);
            this.OpenTextBox.TabIndex = 6;
            this.OpenTextBox.TabStop = false;
            // 
            // SaveTextBox
            // 
            this.SaveTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveTextBox.Location = new System.Drawing.Point(192, 39);
            this.SaveTextBox.Name = "SaveTextBox";
            this.SaveTextBox.Size = new System.Drawing.Size(547, 20);
            this.SaveTextBox.TabIndex = 8;
            this.SaveTextBox.TabStop = false;
            // 
            // SavePathButton
            // 
            this.SavePathButton.Location = new System.Drawing.Point(12, 38);
            this.SavePathButton.Name = "SavePathButton";
            this.SavePathButton.Size = new System.Drawing.Size(174, 20);
            this.SavePathButton.TabIndex = 7;
            this.SavePathButton.TabStop = false;
            this.SavePathButton.Text = "Lojban Subtitles";
            this.SavePathButton.UseVisualStyleBackColor = true;
            this.SavePathButton.Click += new System.EventHandler(this.SavePathButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "srt";
            this.openFileDialog1.Title = "Please select the English Subtitle File";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "srt";
            this.saveFileDialog1.OverwritePrompt = false;
            this.saveFileDialog1.Title = "Please select where to save the Lojban Subtitle File";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // TimeEngTextBox
            // 
            this.TimeEngTextBox.Location = new System.Drawing.Point(94, 16);
            this.TimeEngTextBox.Name = "TimeEngTextBox";
            this.TimeEngTextBox.Size = new System.Drawing.Size(252, 20);
            this.TimeEngTextBox.TabIndex = 9;
            this.TimeEngTextBox.TabStop = false;
            // 
            // IndexEngLabel
            // 
            this.IndexEngLabel.AutoSize = true;
            this.IndexEngLabel.Location = new System.Drawing.Point(6, 19);
            this.IndexEngLabel.Name = "IndexEngLabel";
            this.IndexEngLabel.Size = new System.Drawing.Size(13, 13);
            this.IndexEngLabel.TabIndex = 10;
            this.IndexEngLabel.Text = "0";
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrevButton.Location = new System.Drawing.Point(115, 377);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(120, 38);
            this.PrevButton.TabIndex = 11;
            this.PrevButton.TabStop = false;
            this.PrevButton.Text = "Previous";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // IndexLojLabel
            // 
            this.IndexLojLabel.AutoSize = true;
            this.IndexLojLabel.Location = new System.Drawing.Point(6, 19);
            this.IndexLojLabel.Name = "IndexLojLabel";
            this.IndexLojLabel.Size = new System.Drawing.Size(13, 13);
            this.IndexLojLabel.TabIndex = 13;
            this.IndexLojLabel.Text = "0";
            // 
            // TimeLojTextBox
            // 
            this.TimeLojTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLojTextBox.Location = new System.Drawing.Point(86, 16);
            this.TimeLojTextBox.Name = "TimeLojTextBox";
            this.TimeLojTextBox.Size = new System.Drawing.Size(276, 20);
            this.TimeLojTextBox.TabIndex = 12;
            this.TimeLojTextBox.TabStop = false;
            // 
            // PrevEngButton
            // 
            this.PrevEngButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrevEngButton.Location = new System.Drawing.Point(6, 248);
            this.PrevEngButton.Name = "PrevEngButton";
            this.PrevEngButton.Size = new System.Drawing.Size(80, 21);
            this.PrevEngButton.TabIndex = 14;
            this.PrevEngButton.TabStop = false;
            this.PrevEngButton.Text = "<";
            this.PrevEngButton.UseVisualStyleBackColor = true;
            this.PrevEngButton.Click += new System.EventHandler(this.PrevEngButton_Click);
            // 
            // NextEngButton
            // 
            this.NextEngButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NextEngButton.Location = new System.Drawing.Point(94, 248);
            this.NextEngButton.Name = "NextEngButton";
            this.NextEngButton.Size = new System.Drawing.Size(80, 21);
            this.NextEngButton.TabIndex = 16;
            this.NextEngButton.TabStop = false;
            this.NextEngButton.Text = ">";
            this.NextEngButton.UseVisualStyleBackColor = true;
            this.NextEngButton.Click += new System.EventHandler(this.NextEngButton_Click);
            // 
            // PrevLojButton
            // 
            this.PrevLojButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrevLojButton.Location = new System.Drawing.Point(5, 248);
            this.PrevLojButton.Name = "PrevLojButton";
            this.PrevLojButton.Size = new System.Drawing.Size(80, 21);
            this.PrevLojButton.TabIndex = 17;
            this.PrevLojButton.TabStop = false;
            this.PrevLojButton.Text = "<";
            this.PrevLojButton.UseVisualStyleBackColor = true;
            this.PrevLojButton.Click += new System.EventHandler(this.PrevLojButton_Click);
            // 
            // NextLojButton
            // 
            this.NextLojButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextLojButton.Location = new System.Drawing.Point(91, 248);
            this.NextLojButton.Name = "NextLojButton";
            this.NextLojButton.Size = new System.Drawing.Size(80, 21);
            this.NextLojButton.TabIndex = 18;
            this.NextLojButton.TabStop = false;
            this.NextLojButton.Text = ">";
            this.NextLojButton.UseVisualStyleBackColor = true;
            this.NextLojButton.Click += new System.EventHandler(this.NextLojButton_Click);
            // 
            // InsertLojButton
            // 
            this.InsertLojButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertLojButton.Location = new System.Drawing.Point(177, 248);
            this.InsertLojButton.Name = "InsertLojButton";
            this.InsertLojButton.Size = new System.Drawing.Size(80, 21);
            this.InsertLojButton.TabIndex = 19;
            this.InsertLojButton.TabStop = false;
            this.InsertLojButton.Text = "Insert";
            this.InsertLojButton.UseVisualStyleBackColor = true;
            this.InsertLojButton.Click += new System.EventHandler(this.InsertLojButton_Click);
            // 
            // DeleteLojButton
            // 
            this.DeleteLojButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteLojButton.Location = new System.Drawing.Point(263, 248);
            this.DeleteLojButton.Name = "DeleteLojButton";
            this.DeleteLojButton.Size = new System.Drawing.Size(80, 21);
            this.DeleteLojButton.TabIndex = 20;
            this.DeleteLojButton.TabStop = false;
            this.DeleteLojButton.Text = "Delete";
            this.DeleteLojButton.UseVisualStyleBackColor = true;
            this.DeleteLojButton.Click += new System.EventHandler(this.DeleteLojButton_Click);
            // 
            // OutputBothButton
            // 
            this.OutputBothButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBothButton.Location = new System.Drawing.Point(493, 377);
            this.OutputBothButton.Name = "OutputBothButton";
            this.OutputBothButton.Size = new System.Drawing.Size(120, 38);
            this.OutputBothButton.TabIndex = 21;
            this.OutputBothButton.TabStop = false;
            this.OutputBothButton.Text = "Ouput Dual";
            this.OutputBothButton.UseVisualStyleBackColor = true;
            this.OutputBothButton.Click += new System.EventHandler(this.OutputBothButton_Click);
            // 
            // JumpTextBox
            // 
            this.JumpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.JumpTextBox.Location = new System.Drawing.Point(283, 387);
            this.JumpTextBox.Name = "JumpTextBox";
            this.JumpTextBox.Size = new System.Drawing.Size(75, 20);
            this.JumpTextBox.TabIndex = 22;
            this.JumpTextBox.TabStop = false;
            this.JumpTextBox.Text = "10";
            this.JumpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DualTextBox
            // 
            this.DualTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DualTextBox.Location = new System.Drawing.Point(192, 65);
            this.DualTextBox.Name = "DualTextBox";
            this.DualTextBox.Size = new System.Drawing.Size(547, 20);
            this.DualTextBox.TabIndex = 24;
            this.DualTextBox.TabStop = false;
            // 
            // DualPathButton
            // 
            this.DualPathButton.Location = new System.Drawing.Point(12, 64);
            this.DualPathButton.Name = "DualPathButton";
            this.DualPathButton.Size = new System.Drawing.Size(174, 20);
            this.DualPathButton.TabIndex = 23;
            this.DualPathButton.TabStop = false;
            this.DualPathButton.Text = "Output of Dual Subtitles";
            this.DualPathButton.UseVisualStyleBackColor = true;
            this.DualPathButton.Click += new System.EventHandler(this.DualPathButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.IndexEngLabel);
            this.groupBox1.Controls.Add(this.TimeEngTextBox);
            this.groupBox1.Controls.Add(this.PrevEngButton);
            this.groupBox1.Controls.Add(this.NextEngButton);
            this.groupBox1.Controls.Add(this.EnglishTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 275);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "English Subtitles";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TimeLojTextBox);
            this.groupBox2.Controls.Add(this.LojbanTextBox);
            this.groupBox2.Controls.Add(this.IndexLojLabel);
            this.groupBox2.Controls.Add(this.PrevLojButton);
            this.groupBox2.Controls.Add(this.NextLojButton);
            this.groupBox2.Controls.Add(this.DeleteLojButton);
            this.groupBox2.Controls.Add(this.InsertLojButton);
            this.groupBox2.Location = new System.Drawing.Point(370, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 275);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lojban Subtitles";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.DefaultExt = "srt";
            this.saveFileDialog2.Title = "Choose a location to output dual language subtitles";
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DualTextBox);
            this.Controls.Add(this.DualPathButton);
            this.Controls.Add(this.JumpTextBox);
            this.Controls.Add(this.OutputBothButton);
            this.Controls.Add(this.JumpButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.SaveTextBox);
            this.Controls.Add(this.SavePathButton);
            this.Controls.Add(this.OpenTextBox);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SaveLojButton);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "SRT Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveLojButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button JumpButton;
        private System.Windows.Forms.TextBox EnglishTextBox;
        private System.Windows.Forms.TextBox LojbanTextBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TextBox OpenTextBox;
        private System.Windows.Forms.TextBox SaveTextBox;
        private System.Windows.Forms.Button SavePathButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox TimeEngTextBox;
        private System.Windows.Forms.Label IndexEngLabel;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Label IndexLojLabel;
        private System.Windows.Forms.TextBox TimeLojTextBox;
        private System.Windows.Forms.Button PrevEngButton;
        private System.Windows.Forms.Button NextEngButton;
        private System.Windows.Forms.Button PrevLojButton;
        private System.Windows.Forms.Button NextLojButton;
        private System.Windows.Forms.Button InsertLojButton;
        private System.Windows.Forms.Button DeleteLojButton;
        private System.Windows.Forms.Button OutputBothButton;
        private System.Windows.Forms.TextBox JumpTextBox;
        private System.Windows.Forms.TextBox DualTextBox;
        private System.Windows.Forms.Button DualPathButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

