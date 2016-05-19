namespace GUI
{
    partial class home
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
            this.tcl_Home = new System.Windows.Forms.TabControl();
            this.tpe_Home = new System.Windows.Forms.TabPage();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_function = new System.Windows.Forms.TabPage();
            this.tp_Category = new System.Windows.Forms.TabPage();
            this.tp_Login = new System.Windows.Forms.TabPage();
            this.tcl_Home.SuspendLayout();
            this.tpe_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcl_Home
            // 
            this.tcl_Home.Controls.Add(this.tpe_Home);
            this.tcl_Home.Controls.Add(this.tp_function);
            this.tcl_Home.Controls.Add(this.tp_Category);
            this.tcl_Home.Controls.Add(this.tp_Login);
            this.tcl_Home.ItemSize = new System.Drawing.Size(90, 30);
            this.tcl_Home.Location = new System.Drawing.Point(12, 12);
            this.tcl_Home.Name = "tcl_Home";
            this.tcl_Home.SelectedIndex = 0;
            this.tcl_Home.Size = new System.Drawing.Size(1340, 715);
            this.tcl_Home.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcl_Home.TabIndex = 0;
            // 
            // tpe_Home
            // 
            this.tpe_Home.Controls.Add(this.btn_Login);
            this.tpe_Home.Controls.Add(this.txt_Password);
            this.tpe_Home.Controls.Add(this.txt_Account);
            this.tpe_Home.Controls.Add(this.label3);
            this.tpe_Home.Controls.Add(this.label2);
            this.tpe_Home.Controls.Add(this.label1);
            this.tpe_Home.Location = new System.Drawing.Point(4, 34);
            this.tpe_Home.Name = "tpe_Home";
            this.tpe_Home.Padding = new System.Windows.Forms.Padding(3);
            this.tpe_Home.Size = new System.Drawing.Size(1332, 677);
            this.tpe_Home.TabIndex = 0;
            this.tpe_Home.Text = "Home";
            this.tpe_Home.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(524, 323);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(162, 49);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(445, 250);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(338, 29);
            this.txt_Password.TabIndex = 4;
            // 
            // txt_Account
            // 
            this.txt_Account.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Account.Location = new System.Drawing.Point(445, 202);
            this.txt_Account.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(338, 29);
            this.txt_Account.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập hệ thống";
            // 
            // tp_function
            // 
            this.tp_function.Location = new System.Drawing.Point(4, 34);
            this.tp_function.Name = "tp_function";
            this.tp_function.Padding = new System.Windows.Forms.Padding(3);
            this.tp_function.Size = new System.Drawing.Size(1332, 677);
            this.tp_function.TabIndex = 1;
            this.tp_function.Text = "Chức năng";
            this.tp_function.UseVisualStyleBackColor = true;
            // 
            // tp_Category
            // 
            this.tp_Category.Location = new System.Drawing.Point(4, 34);
            this.tp_Category.Name = "tp_Category";
            this.tp_Category.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Category.Size = new System.Drawing.Size(1332, 677);
            this.tp_Category.TabIndex = 2;
            this.tp_Category.Text = "Danh Mục";
            this.tp_Category.UseVisualStyleBackColor = true;
            // 
            // tp_Login
            // 
            this.tp_Login.Location = new System.Drawing.Point(4, 34);
            this.tp_Login.Name = "tp_Login";
            this.tp_Login.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Login.Size = new System.Drawing.Size(1332, 677);
            this.tp_Login.TabIndex = 3;
            this.tp_Login.Text = "Đăng nhập";
            this.tp_Login.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tcl_Home);
            this.Name = "home";
            this.Text = "Book Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcl_Home.ResumeLayout(false);
            this.tpe_Home.ResumeLayout(false);
            this.tpe_Home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcl_Home;
        private System.Windows.Forms.TabPage tpe_Home;
        private System.Windows.Forms.TabPage tp_function;
        private System.Windows.Forms.TabPage tp_Category;
        private System.Windows.Forms.TabPage tp_Login;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

