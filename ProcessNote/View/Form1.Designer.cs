namespace ProcessNote
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
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.PIDTextBox = new System.Windows.Forms.TextBox();
            this.CPUTextBox = new System.Windows.Forms.TextBox();
            this.memoryTextBox = new System.Windows.Forms.TextBox();
            this.runningTimeTextBox = new System.Windows.Forms.TextBox();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.processNameLabel = new System.Windows.Forms.Label();
            this.PIDLabel = new System.Windows.Forms.Label();
            this.CPULabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.runningTimeLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.commentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveCommentButton = new System.Windows.Forms.Button();
            this.threadsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(26, 37);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(371, 290);
            this.resultListBox.TabIndex = 0;
            this.resultListBox.SelectedIndexChanged += new System.EventHandler(this.resultListBox_SelectedIndexChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(23, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(62, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Name [PID]";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(546, 55);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(237, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // PIDTextBox
            // 
            this.PIDTextBox.Location = new System.Drawing.Point(546, 106);
            this.PIDTextBox.Name = "PIDTextBox";
            this.PIDTextBox.ReadOnly = true;
            this.PIDTextBox.Size = new System.Drawing.Size(237, 20);
            this.PIDTextBox.TabIndex = 3;
            // 
            // CPUTextBox
            // 
            this.CPUTextBox.Location = new System.Drawing.Point(546, 158);
            this.CPUTextBox.Name = "CPUTextBox";
            this.CPUTextBox.ReadOnly = true;
            this.CPUTextBox.Size = new System.Drawing.Size(237, 20);
            this.CPUTextBox.TabIndex = 4;
            // 
            // memoryTextBox
            // 
            this.memoryTextBox.Location = new System.Drawing.Point(546, 206);
            this.memoryTextBox.Name = "memoryTextBox";
            this.memoryTextBox.ReadOnly = true;
            this.memoryTextBox.Size = new System.Drawing.Size(237, 20);
            this.memoryTextBox.TabIndex = 5;
            // 
            // runningTimeTextBox
            // 
            this.runningTimeTextBox.Location = new System.Drawing.Point(546, 254);
            this.runningTimeTextBox.Name = "runningTimeTextBox";
            this.runningTimeTextBox.ReadOnly = true;
            this.runningTimeTextBox.Size = new System.Drawing.Size(237, 20);
            this.runningTimeTextBox.TabIndex = 6;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Location = new System.Drawing.Point(546, 307);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.ReadOnly = true;
            this.startTimeTextBox.Size = new System.Drawing.Size(237, 20);
            this.startTimeTextBox.TabIndex = 7;
            // 
            // processNameLabel
            // 
            this.processNameLabel.AutoSize = true;
            this.processNameLabel.Location = new System.Drawing.Point(439, 62);
            this.processNameLabel.Name = "processNameLabel";
            this.processNameLabel.Size = new System.Drawing.Size(77, 13);
            this.processNameLabel.TabIndex = 8;
            this.processNameLabel.Text = "Process name:";
            // 
            // PIDLabel
            // 
            this.PIDLabel.AutoSize = true;
            this.PIDLabel.Location = new System.Drawing.Point(439, 106);
            this.PIDLabel.Name = "PIDLabel";
            this.PIDLabel.Size = new System.Drawing.Size(28, 13);
            this.PIDLabel.TabIndex = 9;
            this.PIDLabel.Text = "PID:";
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Location = new System.Drawing.Point(439, 161);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(64, 13);
            this.CPULabel.TabIndex = 10;
            this.CPULabel.Text = "CPU usage:";
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(439, 213);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(79, 13);
            this.memoryLabel.TabIndex = 11;
            this.memoryLabel.Text = "Memory usage:";
            // 
            // runningTimeLabel
            // 
            this.runningTimeLabel.AutoSize = true;
            this.runningTimeLabel.Location = new System.Drawing.Point(439, 261);
            this.runningTimeLabel.Name = "runningTimeLabel";
            this.runningTimeLabel.Size = new System.Drawing.Size(72, 13);
            this.runningTimeLabel.TabIndex = 12;
            this.runningTimeLabel.Text = "Running time:";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(439, 314);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(54, 13);
            this.startTimeLabel.TabIndex = 13;
            this.startTimeLabel.Text = "Start time:";
            // 
            // commentRichTextBox
            // 
            this.commentRichTextBox.Location = new System.Drawing.Point(546, 349);
            this.commentRichTextBox.Name = "commentRichTextBox";
            this.commentRichTextBox.Size = new System.Drawing.Size(237, 60);
            this.commentRichTextBox.TabIndex = 14;
            this.commentRichTextBox.Text = "";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(439, 352);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(54, 13);
            this.commentLabel.TabIndex = 15;
            this.commentLabel.Text = "Comment:";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(26, 352);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(98, 23);
            this.refreshButton.TabIndex = 16;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(26, 427);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 23);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveCommentButton
            // 
            this.saveCommentButton.Location = new System.Drawing.Point(546, 427);
            this.saveCommentButton.Name = "saveCommentButton";
            this.saveCommentButton.Size = new System.Drawing.Size(98, 23);
            this.saveCommentButton.TabIndex = 18;
            this.saveCommentButton.Text = "Save comment";
            this.saveCommentButton.UseVisualStyleBackColor = true;
            this.saveCommentButton.Click += new System.EventHandler(this.saveCommentButton_Click);
            // 
            // threadsButton
            // 
            this.threadsButton.Location = new System.Drawing.Point(685, 427);
            this.threadsButton.Name = "threadsButton";
            this.threadsButton.Size = new System.Drawing.Size(98, 23);
            this.threadsButton.TabIndex = 19;
            this.threadsButton.Text = "Threads";
            this.threadsButton.UseVisualStyleBackColor = true;
            this.threadsButton.Click += new System.EventHandler(this.threadsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 462);
            this.Controls.Add(this.threadsButton);
            this.Controls.Add(this.saveCommentButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.commentRichTextBox);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.runningTimeLabel);
            this.Controls.Add(this.memoryLabel);
            this.Controls.Add(this.CPULabel);
            this.Controls.Add(this.PIDLabel);
            this.Controls.Add(this.processNameLabel);
            this.Controls.Add(this.startTimeTextBox);
            this.Controls.Add(this.runningTimeTextBox);
            this.Controls.Add(this.memoryTextBox);
            this.Controls.Add(this.CPUTextBox);
            this.Controls.Add(this.PIDTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.resultListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox PIDTextBox;
        private System.Windows.Forms.TextBox CPUTextBox;
        private System.Windows.Forms.TextBox memoryTextBox;
        private System.Windows.Forms.TextBox runningTimeTextBox;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.Label processNameLabel;
        private System.Windows.Forms.Label PIDLabel;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label runningTimeLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.RichTextBox commentRichTextBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveCommentButton;
        private System.Windows.Forms.Button threadsButton;
    }
}

