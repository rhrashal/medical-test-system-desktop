namespace Desktop_Application
{
    partial class Doctor
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
            this.txt_dr_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dr_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dr_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dr_mbl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dr_dprt = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Id";
            // 
            // txt_dr_ID
            // 
            this.txt_dr_ID.Location = new System.Drawing.Point(182, 64);
            this.txt_dr_ID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_dr_ID.Name = "txt_dr_ID";
            this.txt_dr_ID.Size = new System.Drawing.Size(100, 25);
            this.txt_dr_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doctor Name";
            // 
            // txt_dr_Name
            // 
            this.txt_dr_Name.Location = new System.Drawing.Point(182, 145);
            this.txt_dr_Name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_dr_Name.Name = "txt_dr_Name";
            this.txt_dr_Name.Size = new System.Drawing.Size(100, 25);
            this.txt_dr_Name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // txt_dr_email
            // 
            this.txt_dr_email.Location = new System.Drawing.Point(182, 220);
            this.txt_dr_email.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_dr_email.Name = "txt_dr_email";
            this.txt_dr_email.Size = new System.Drawing.Size(100, 25);
            this.txt_dr_email.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mobile";
            // 
            // txt_dr_mbl
            // 
            this.txt_dr_mbl.Location = new System.Drawing.Point(182, 301);
            this.txt_dr_mbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_dr_mbl.Name = "txt_dr_mbl";
            this.txt_dr_mbl.Size = new System.Drawing.Size(100, 25);
            this.txt_dr_mbl.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dipartment";
            // 
            // txt_dr_dprt
            // 
            this.txt_dr_dprt.Location = new System.Drawing.Point(182, 379);
            this.txt_dr_dprt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_dr_dprt.Name = "txt_dr_dprt";
            this.txt_dr_dprt.Size = new System.Drawing.Size(100, 25);
            this.txt_dr_dprt.TabIndex = 1;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(40, 471);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 41);
            this.btn_Insert.TabIndex = 2;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(136, 471);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 41);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(229, 471);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 41);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 454);
            this.dataGridView1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Add Or Modify Doctors List";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 522);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_dr_dprt);
            this.Controls.Add(this.txt_dr_mbl);
            this.Controls.Add(this.txt_dr_email);
            this.Controls.Add(this.txt_dr_Name);
            this.Controls.Add(this.txt_dr_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Doctor";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dr_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dr_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dr_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dr_mbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dr_dprt;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
    }
}