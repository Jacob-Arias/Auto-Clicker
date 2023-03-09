namespace Auto_Clicker
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
            this.label1 = new System.Windows.Forms.Label();
            this.msDelayTXT = new System.Windows.Forms.TextBox();
            this.secDelayTXT = new System.Windows.Forms.TextBox();
            this.minDelayTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto Clicker";
            // 
            // msDelayTXT
            // 
            this.msDelayTXT.Location = new System.Drawing.Point(437, 139);
            this.msDelayTXT.Name = "msDelayTXT";
            this.msDelayTXT.Size = new System.Drawing.Size(100, 22);
            this.msDelayTXT.TabIndex = 2;
            this.msDelayTXT.TextChanged += new System.EventHandler(this.msDelayTXT_TextChanged);
            // 
            // secDelayTXT
            // 
            this.secDelayTXT.Location = new System.Drawing.Point(253, 139);
            this.secDelayTXT.Name = "secDelayTXT";
            this.secDelayTXT.Size = new System.Drawing.Size(100, 22);
            this.secDelayTXT.TabIndex = 3;
            this.secDelayTXT.TextChanged += new System.EventHandler(this.secDelayTXT_TextChanged);
            // 
            // minDelayTXT
            // 
            this.minDelayTXT.Location = new System.Drawing.Point(74, 139);
            this.minDelayTXT.Name = "minDelayTXT";
            this.minDelayTXT.Size = new System.Drawing.Size(100, 22);
            this.minDelayTXT.TabIndex = 4;
            this.minDelayTXT.TextChanged += new System.EventHandler(this.minDelayTXT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Delay";
            // 
            // startBTN
            // 
            this.startBTN.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.Location = new System.Drawing.Point(168, 208);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(257, 94);
            this.startBTN.TabIndex = 6;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Milliseconds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(553, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "To end the program move the mouse while its clicking to the program menu\r\nthen on" +
    "ce your on it (don\'t hover over the buttons) press q on the keyboard\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minDelayTXT);
            this.Controls.Add(this.secDelayTXT);
            this.Controls.Add(this.msDelayTXT);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox msDelayTXT;
        private System.Windows.Forms.TextBox secDelayTXT;
        private System.Windows.Forms.TextBox minDelayTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

