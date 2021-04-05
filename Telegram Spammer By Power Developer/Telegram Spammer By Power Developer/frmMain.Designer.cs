
namespace Telegram_Spammer_By_Power_Developer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlDragBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.picShowMainForm = new System.Windows.Forms.PictureBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnAboutME = new System.Windows.Forms.Button();
            this.btnShowTutorial = new System.Windows.Forms.Button();
            this.pnlChangeForm = new System.Windows.Forms.Panel();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pnlDragBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDragBar
            // 
            this.pnlDragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.pnlDragBar.Controls.Add(this.btnMinimize);
            this.pnlDragBar.Controls.Add(this.btnClose);
            this.pnlDragBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDragBar.Location = new System.Drawing.Point(0, 0);
            this.pnlDragBar.Name = "pnlDragBar";
            this.pnlDragBar.Size = new System.Drawing.Size(564, 28);
            this.pnlDragBar.TabIndex = 1;
            this.pnlDragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(498, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 21);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(531, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 21);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.pnlMenu.Controls.Add(this.picShowMainForm);
            this.pnlMenu.Controls.Add(this.btnRun);
            this.pnlMenu.Controls.Add(this.btnAboutME);
            this.pnlMenu.Controls.Add(this.btnShowTutorial);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 28);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(129, 324);
            this.pnlMenu.TabIndex = 2;
            // 
            // picShowMainForm
            // 
            this.picShowMainForm.Image = ((System.Drawing.Image)(resources.GetObject("picShowMainForm.Image")));
            this.picShowMainForm.Location = new System.Drawing.Point(0, 0);
            this.picShowMainForm.Name = "picShowMainForm";
            this.picShowMainForm.Size = new System.Drawing.Size(129, 102);
            this.picShowMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowMainForm.TabIndex = 1;
            this.picShowMainForm.TabStop = false;
            this.picShowMainForm.Click += new System.EventHandler(this.picShowMainForm_Click);
            // 
            // btnRun
            // 
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(219)))), ((int)(((byte)(202)))));
            this.btnRun.Location = new System.Drawing.Point(0, 222);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(129, 54);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnAboutME
            // 
            this.btnAboutME.FlatAppearance.BorderSize = 0;
            this.btnAboutME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(219)))), ((int)(((byte)(202)))));
            this.btnAboutME.Location = new System.Drawing.Point(0, 162);
            this.btnAboutME.Name = "btnAboutME";
            this.btnAboutME.Size = new System.Drawing.Size(129, 54);
            this.btnAboutME.TabIndex = 0;
            this.btnAboutME.Text = "About ME";
            this.btnAboutME.UseVisualStyleBackColor = true;
            this.btnAboutME.Click += new System.EventHandler(this.btnAboutME_Click);
            // 
            // btnShowTutorial
            // 
            this.btnShowTutorial.FlatAppearance.BorderSize = 0;
            this.btnShowTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTutorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(219)))), ((int)(((byte)(202)))));
            this.btnShowTutorial.Location = new System.Drawing.Point(0, 102);
            this.btnShowTutorial.Name = "btnShowTutorial";
            this.btnShowTutorial.Size = new System.Drawing.Size(129, 54);
            this.btnShowTutorial.TabIndex = 0;
            this.btnShowTutorial.Text = "Tutorial";
            this.btnShowTutorial.UseVisualStyleBackColor = true;
            this.btnShowTutorial.Click += new System.EventHandler(this.btnShowTutorial_Click);
            // 
            // pnlChangeForm
            // 
            this.pnlChangeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.pnlChangeForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChangeForm.Location = new System.Drawing.Point(129, 28);
            this.pnlChangeForm.Name = "pnlChangeForm";
            this.pnlChangeForm.Size = new System.Drawing.Size(435, 324);
            this.pnlChangeForm.TabIndex = 3;
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 352);
            this.Controls.Add(this.pnlChangeForm);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlDragBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlDragBar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShowMainForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDragBar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlChangeForm;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picShowMainForm;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnAboutME;
        private System.Windows.Forms.Button btnShowTutorial;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

