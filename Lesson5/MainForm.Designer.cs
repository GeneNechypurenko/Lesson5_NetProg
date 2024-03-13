namespace Lesson5
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            messageGroupBox = new GroupBox();
            sendButton = new Button();
            messageTextBox = new TextBox();
            chatGroupBox = new GroupBox();
            chatTextBox = new TextBox();
            messageGroupBox.SuspendLayout();
            chatGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // messageGroupBox
            // 
            messageGroupBox.Controls.Add(sendButton);
            messageGroupBox.Controls.Add(messageTextBox);
            messageGroupBox.Dock = DockStyle.Bottom;
            messageGroupBox.Location = new Point(0, 390);
            messageGroupBox.Name = "messageGroupBox";
            messageGroupBox.Size = new Size(800, 60);
            messageGroupBox.TabIndex = 0;
            messageGroupBox.TabStop = false;
            messageGroupBox.Text = "Send Message";
            // 
            // sendButton
            // 
            sendButton.Dock = DockStyle.Right;
            sendButton.Location = new Point(659, 23);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(138, 34);
            sendButton.TabIndex = 1;
            sendButton.Text = "SEND MESSAGE";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // messageTextBox
            // 
            messageTextBox.Dock = DockStyle.Left;
            messageTextBox.Location = new Point(3, 23);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(650, 27);
            messageTextBox.TabIndex = 0;
            // 
            // chatGroupBox
            // 
            chatGroupBox.Controls.Add(chatTextBox);
            chatGroupBox.Dock = DockStyle.Fill;
            chatGroupBox.Location = new Point(0, 0);
            chatGroupBox.Name = "chatGroupBox";
            chatGroupBox.Size = new Size(800, 390);
            chatGroupBox.TabIndex = 1;
            chatGroupBox.TabStop = false;
            chatGroupBox.Text = "Chat Window";
            // 
            // chatTextBox
            // 
            chatTextBox.Dock = DockStyle.Fill;
            chatTextBox.Location = new Point(3, 23);
            chatTextBox.Multiline = true;
            chatTextBox.Name = "chatTextBox";
            chatTextBox.Size = new Size(794, 364);
            chatTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chatGroupBox);
            Controls.Add(messageGroupBox);
            Name = "MainForm";
            Text = "Form1";
            messageGroupBox.ResumeLayout(false);
            messageGroupBox.PerformLayout();
            chatGroupBox.ResumeLayout(false);
            chatGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox messageGroupBox;
        private GroupBox chatGroupBox;
        private Button sendButton;
        private TextBox messageTextBox;
        private TextBox chatTextBox;
    }
}
