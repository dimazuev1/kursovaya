
namespace Курсовая_работа
{
    partial class Form3
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
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.LogPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LogLoginTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegLoginTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.SystemColors.Window;
            this.buttonLog.Location = new System.Drawing.Point(97, 538);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(109, 23);
            this.buttonLog.TabIndex = 34;
            this.buttonLog.Text = "Войти";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.SystemColors.Window;
            this.buttonReg.Location = new System.Drawing.Point(97, 244);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(111, 23);
            this.buttonReg.TabIndex = 33;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // LogPasswordTextBox
            // 
            this.LogPasswordTextBox.Location = new System.Drawing.Point(48, 493);
            this.LogPasswordTextBox.Name = "LogPasswordTextBox";
            this.LogPasswordTextBox.Size = new System.Drawing.Size(225, 20);
            this.LogPasswordTextBox.TabIndex = 32;
            // 
            // LogLoginTextBox
            // 
            this.LogLoginTextBox.Location = new System.Drawing.Point(48, 392);
            this.LogLoginTextBox.Name = "LogLoginTextBox";
            this.LogLoginTextBox.Size = new System.Drawing.Size(225, 20);
            this.LogLoginTextBox.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Вход";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Логин";
            // 
            // RegPasswordTextBox
            // 
            this.RegPasswordTextBox.Location = new System.Drawing.Point(48, 194);
            this.RegPasswordTextBox.Name = "RegPasswordTextBox";
            this.RegPasswordTextBox.Size = new System.Drawing.Size(225, 20);
            this.RegPasswordTextBox.TabIndex = 25;
            // 
            // RegLoginTextBox
            // 
            this.RegLoginTextBox.Location = new System.Drawing.Point(48, 77);
            this.RegLoginTextBox.Name = "RegLoginTextBox";
            this.RegLoginTextBox.Size = new System.Drawing.Size(225, 20);
            this.RegLoginTextBox.TabIndex = 24;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(310, 620);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.LogPasswordTextBox);
            this.Controls.Add(this.LogLoginTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegPasswordTextBox);
            this.Controls.Add(this.RegLoginTextBox);
            this.Name = "Form3";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox LogPasswordTextBox;
        private System.Windows.Forms.TextBox LogLoginTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegPasswordTextBox;
        private System.Windows.Forms.TextBox RegLoginTextBox;
    }
}