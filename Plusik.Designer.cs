namespace Plusik
{
    partial class Plusik
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plusik));
            this.buttonSumm = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStepsCount = new System.Windows.Forms.Label();
            this.buttonSetNumber = new System.Windows.Forms.Button();
            this.textBoxSetNumber = new System.Windows.Forms.TextBox();
            this.labelGoal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ratingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveandcloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLogin = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSumm
            // 
            this.buttonSumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSumm.Location = new System.Drawing.Point(57, 159);
            this.buttonSumm.Name = "buttonSumm";
            this.buttonSumm.Size = new System.Drawing.Size(75, 75);
            this.buttonSumm.TabIndex = 0;
            this.buttonSumm.Text = "+1";
            this.buttonSumm.UseVisualStyleBackColor = true;
            this.buttonSumm.Click += new System.EventHandler(this.summ_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMult.Location = new System.Drawing.Point(356, 159);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(75, 75);
            this.buttonMult.TabIndex = 1;
            this.buttonMult.Text = "*2";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.mult_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(57, 339);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(75, 49);
            this.buttonRandom.TabIndex = 2;
            this.buttonRandom.Text = "GET RANDOM NUMBER";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "GOAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CURRENT";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.BackColor = System.Drawing.SystemColors.Window;
            this.labelCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCurrent.Location = new System.Drawing.Point(219, 214);
            this.labelCurrent.MinimumSize = new System.Drawing.Size(55, 20);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(55, 20);
            this.labelCurrent.TabIndex = 7;
            this.labelCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "MY STEPS";
            // 
            // labelStepsCount
            // 
            this.labelStepsCount.AutoSize = true;
            this.labelStepsCount.BackColor = System.Drawing.SystemColors.Window;
            this.labelStepsCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStepsCount.Location = new System.Drawing.Point(221, 299);
            this.labelStepsCount.MinimumSize = new System.Drawing.Size(55, 20);
            this.labelStepsCount.Name = "labelStepsCount";
            this.labelStepsCount.Size = new System.Drawing.Size(55, 20);
            this.labelStepsCount.TabIndex = 9;
            this.labelStepsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSetNumber
            // 
            this.buttonSetNumber.Location = new System.Drawing.Point(356, 339);
            this.buttonSetNumber.Name = "buttonSetNumber";
            this.buttonSetNumber.Size = new System.Drawing.Size(75, 23);
            this.buttonSetNumber.TabIndex = 10;
            this.buttonSetNumber.Text = "SetNumber";
            this.buttonSetNumber.UseVisualStyleBackColor = true;
            this.buttonSetNumber.Click += new System.EventHandler(this.ButtonSetNumber_Click);
            // 
            // textBoxSetNumber
            // 
            this.textBoxSetNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSetNumber.Location = new System.Drawing.Point(356, 368);
            this.textBoxSetNumber.Name = "textBoxSetNumber";
            this.textBoxSetNumber.Size = new System.Drawing.Size(75, 20);
            this.textBoxSetNumber.TabIndex = 11;
            this.textBoxSetNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSetNumber_KeyDown);
            // 
            // labelGoal
            // 
            this.labelGoal.AutoSize = true;
            this.labelGoal.BackColor = System.Drawing.SystemColors.Window;
            this.labelGoal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelGoal.Location = new System.Drawing.Point(219, 172);
            this.labelGoal.MinimumSize = new System.Drawing.Size(55, 20);
            this.labelGoal.Name = "labelGoal";
            this.labelGoal.Size = new System.Drawing.Size(55, 20);
            this.labelGoal.TabIndex = 12;
            this.labelGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xcToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.SaveandcloseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xcToolStripMenuItem
            // 
            this.xcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.statsToolStripMenuItem,
            this.ratingToolStripMenuItem});
            this.xcToolStripMenuItem.Name = "xcToolStripMenuItem";
            this.xcToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.xcToolStripMenuItem.Text = "Account";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.loginToolStripMenuItem.Text = "LogIn";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.statsToolStripMenuItem.Text = "Stats";
            this.statsToolStripMenuItem.Click += new System.EventHandler(this.statsToolStripMenuItem_Click);
            // 
            // ratingToolStripMenuItem
            // 
            this.ratingToolStripMenuItem.Name = "ratingToolStripMenuItem";
            this.ratingToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ratingToolStripMenuItem.Text = "Rating";
            this.ratingToolStripMenuItem.Click += new System.EventHandler(this.ratingToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.справкаToolStripMenuItem.Text = "Help";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // SaveandcloseToolStripMenuItem
            // 
            this.SaveandcloseToolStripMenuItem.Name = "SaveandcloseToolStripMenuItem";
            this.SaveandcloseToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.SaveandcloseToolStripMenuItem.Text = "Save and Close";
            this.SaveandcloseToolStripMenuItem.Click += new System.EventHandler(this.SaveandcloseToolStripMenuItem_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(421, 24);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(53, 20);
            this.labelLogin.TabIndex = 14;
            this.labelLogin.Text = "Guest";
            // 
            // Plusik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 400);
            this.ControlBox = false;
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelGoal);
            this.Controls.Add(this.textBoxSetNumber);
            this.Controls.Add(this.buttonSetNumber);
            this.Controls.Add(this.labelStepsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonSumm);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Plusik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLUSIK";
            this.Load += new System.EventHandler(this.Plusik_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSumm;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStepsCount;
        private System.Windows.Forms.Button buttonSetNumber;
        private System.Windows.Forms.TextBox textBoxSetNumber;
        private System.Windows.Forms.Label labelGoal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveandcloseToolStripMenuItem;
    }
}

