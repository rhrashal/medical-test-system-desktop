namespace Desktop_Application
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
            this.label2 = new System.Windows.Forms.Label();
            this.textusername = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exist = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(275, 53);
            this.textusername.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(279, 30);
            this.textusername.TabIndex = 1;
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(275, 147);
            this.textpass.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(279, 30);
            this.textpass.TabIndex = 2;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(211, 235);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(96, 74);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exist
            // 
            this.btn_Exist.Location = new System.Drawing.Point(358, 235);
            this.btn_Exist.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btn_Exist.Name = "btn_Exist";
            this.btn_Exist.Size = new System.Drawing.Size(96, 74);
            this.btn_Exist.TabIndex = 3;
            this.btn_Exist.Text = "Exist";
            this.btn_Exist.UseVisualStyleBackColor = true;
            this.btn_Exist.Click += new System.EventHandler(this.btn_Exist_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Click here! If you are not Registred.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Exist);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "Form1";
            this.Text = "Login Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exist;
        private System.Windows.Forms.Button button1;
    }
}

