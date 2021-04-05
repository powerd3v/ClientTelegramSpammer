
namespace Telegram_Spammer_By_Power_Developer
{
    partial class frmSpammer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpammer));
            this.btnRemoveMessage = new System.Windows.Forms.Button();
            this.btnAddMessage = new System.Windows.Forms.Button();
            this.btnRemoveUserName = new System.Windows.Forms.Button();
            this.btnAddUserName = new System.Windows.Forms.Button();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.lbUserNames = new System.Windows.Forms.ListBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnRun = new System.Windows.Forms.Button();
            this.nudMessagesCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMessagesCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveMessage
            // 
            this.btnRemoveMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemoveMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(219)))), ((int)(((byte)(202)))));
            this.btnRemoveMessage.Location = new System.Drawing.Point(334, 242);
            this.btnRemoveMessage.Name = "btnRemoveMessage";
            this.btnRemoveMessage.Size = new System.Drawing.Size(92, 29);
            this.btnRemoveMessage.TabIndex = 8;
            this.btnRemoveMessage.Text = "Remove";
            this.btnRemoveMessage.UseVisualStyleBackColor = true;
            this.btnRemoveMessage.Click += new System.EventHandler(this.btnRemoveMessage_Click);
            // 
            // btnAddMessage
            // 
            this.btnAddMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(219)))), ((int)(((byte)(202)))));
            this.btnAddMessage.Location = new System.Drawing.Point(228, 242);
            this.btnAddMessage.Name = "btnAddMessage";
            this.btnAddMessage.Size = new System.Drawing.Size(92, 29);
            this.btnAddMessage.TabIndex = 9;
            this.btnAddMessage.Text = "Add";
            this.btnAddMessage.UseVisualStyleBackColor = true;
            this.btnAddMessage.Click += new System.EventHandler(this.btnAddMessage_Click);
            // 
            // btnRemoveUserName
            // 
            this.btnRemoveUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemoveUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(219)))), ((int)(((byte)(202)))));
            this.btnRemoveUserName.Location = new System.Drawing.Point(115, 242);
            this.btnRemoveUserName.Name = "btnRemoveUserName";
            this.btnRemoveUserName.Size = new System.Drawing.Size(92, 29);
            this.btnRemoveUserName.TabIndex = 10;
            this.btnRemoveUserName.Text = "Remove";
            this.btnRemoveUserName.UseVisualStyleBackColor = true;
            this.btnRemoveUserName.Click += new System.EventHandler(this.btnRemoveUserName_Click);
            // 
            // btnAddUserName
            // 
            this.btnAddUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(219)))), ((int)(((byte)(202)))));
            this.btnAddUserName.Location = new System.Drawing.Point(9, 242);
            this.btnAddUserName.Name = "btnAddUserName";
            this.btnAddUserName.Size = new System.Drawing.Size(92, 29);
            this.btnAddUserName.TabIndex = 11;
            this.btnAddUserName.Text = "Add";
            this.btnAddUserName.UseVisualStyleBackColor = true;
            this.btnAddUserName.Click += new System.EventHandler(this.btnAddUserName_Click);
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(219)))), ((int)(((byte)(202)))));
            this.btnChoosePath.Location = new System.Drawing.Point(372, 9);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(54, 29);
            this.btnChoosePath.TabIndex = 12;
            this.btnChoosePath.Text = ". . .";
            this.btnChoosePath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPath.ForeColor = System.Drawing.Color.White;
            this.txtPath.Location = new System.Drawing.Point(9, 9);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(357, 29);
            this.txtPath.TabIndex = 5;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMessage.ForeColor = System.Drawing.Color.White;
            this.txtMessage.Location = new System.Drawing.Point(228, 207);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(198, 29);
            this.txtMessage.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(9, 207);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(198, 29);
            this.txtUserName.TabIndex = 7;
            // 
            // lbMessages
            // 
            this.lbMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.lbMessages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessages.ForeColor = System.Drawing.Color.White;
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.ItemHeight = 21;
            this.lbMessages.Location = new System.Drawing.Point(228, 49);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(198, 151);
            this.lbMessages.TabIndex = 3;
            this.lbMessages.DoubleClick += new System.EventHandler(this.lbMessages_DoubleClick);
            // 
            // lbUserNames
            // 
            this.lbUserNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.lbUserNames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserNames.ForeColor = System.Drawing.Color.White;
            this.lbUserNames.FormattingEnabled = true;
            this.lbUserNames.ItemHeight = 21;
            this.lbUserNames.Location = new System.Drawing.Point(9, 49);
            this.lbUserNames.Name = "lbUserNames";
            this.lbUserNames.Size = new System.Drawing.Size(198, 151);
            this.lbUserNames.TabIndex = 4;
            this.lbUserNames.DoubleClick += new System.EventHandler(this.lbUserNames_DoubleClick);
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // btnRun
            // 
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(219)))), ((int)(((byte)(202)))));
            this.btnRun.Location = new System.Drawing.Point(9, 283);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(198, 29);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // nudMessagesCount
            // 
            this.nudMessagesCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.nudMessagesCount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nudMessagesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(219)))), ((int)(((byte)(202)))));
            this.nudMessagesCount.Location = new System.Drawing.Point(228, 285);
            this.nudMessagesCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMessagesCount.Name = "nudMessagesCount";
            this.nudMessagesCount.Size = new System.Drawing.Size(198, 29);
            this.nudMessagesCount.TabIndex = 13;
            // 
            // frmSpammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(435, 324);
            this.Controls.Add(this.nudMessagesCount);
            this.Controls.Add(this.btnRemoveMessage);
            this.Controls.Add(this.btnAddMessage);
            this.Controls.Add(this.btnRemoveUserName);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnAddUserName);
            this.Controls.Add(this.btnChoosePath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.lbUserNames);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSpammer";
            this.Text = "frmSpammer";
            ((System.ComponentModel.ISupportInitialize)(this.nudMessagesCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveMessage;
        private System.Windows.Forms.Button btnAddMessage;
        private System.Windows.Forms.Button btnRemoveUserName;
        private System.Windows.Forms.Button btnAddUserName;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.ListBox lbUserNames;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.NumericUpDown nudMessagesCount;
    }
}