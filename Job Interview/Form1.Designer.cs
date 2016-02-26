namespace Job_Interview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.conversationBox = new System.Windows.Forms.RichTextBox();
            this.responseBox = new System.Windows.Forms.RichTextBox();
            this.answerButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // conversationBox
            // 
            this.conversationBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.conversationBox.Location = new System.Drawing.Point(6, 150);
            this.conversationBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conversationBox.Name = "conversationBox";
            this.conversationBox.ReadOnly = true;
            this.conversationBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.conversationBox.Size = new System.Drawing.Size(559, 298);
            this.conversationBox.TabIndex = 0;
            this.conversationBox.Text = "";
            this.conversationBox.TextChanged += new System.EventHandler(this.conversationBox_TextChanged);
            // 
            // responseBox
            // 
            this.responseBox.BackColor = System.Drawing.Color.Snow;
            this.responseBox.Location = new System.Drawing.Point(2, 456);
            this.responseBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.responseBox.MaxLength = 255;
            this.responseBox.Name = "responseBox";
            this.responseBox.Size = new System.Drawing.Size(449, 99);
            this.responseBox.TabIndex = 1;
            this.responseBox.Text = "";
            // 
            // answerButton
            // 
            this.answerButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.answerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.answerButton.Location = new System.Drawing.Point(459, 457);
            this.answerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(106, 98);
            this.answerButton.TabIndex = 2;
            this.answerButton.Text = "Send";
            this.answerButton.UseVisualStyleBackColor = false;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 135);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(171, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kathy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.answerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.conversationBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Online Interview";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox conversationBox;
        private System.Windows.Forms.RichTextBox responseBox;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

