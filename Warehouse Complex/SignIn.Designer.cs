
namespace Warehouse_Complex
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.b_signin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_registr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.tb_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.ForeColor = System.Drawing.Color.White;
            this.tb_login.Location = new System.Drawing.Point(144, 95);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(176, 29);
            this.tb_login.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.ForeColor = System.Drawing.Color.White;
            this.tb_password.Location = new System.Drawing.Point(144, 169);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(176, 29);
            this.tb_password.TabIndex = 1;
            // 
            // b_signin
            // 
            this.b_signin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.b_signin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_signin.ForeColor = System.Drawing.Color.White;
            this.b_signin.Location = new System.Drawing.Point(190, 229);
            this.b_signin.Name = "b_signin";
            this.b_signin.Size = new System.Drawing.Size(91, 44);
            this.b_signin.TabIndex = 2;
            this.b_signin.Text = "Войти";
            this.b_signin.UseVisualStyleBackColor = false;
            this.b_signin.Click += new System.EventHandler(this.b_signin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(195, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // b_registr
            // 
            this.b_registr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_registr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.b_registr.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_registr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_registr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_registr.ForeColor = System.Drawing.Color.White;
            this.b_registr.Location = new System.Drawing.Point(151, 288);
            this.b_registr.Name = "b_registr";
            this.b_registr.Size = new System.Drawing.Size(170, 44);
            this.b_registr.TabIndex = 5;
            this.b_registr.Text = "Регистрация";
            this.b_registr.UseVisualStyleBackColor = false;
            this.b_registr.Click += new System.EventHandler(this.b_registr_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(457, 396);
            this.Controls.Add(this.b_registr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_signin);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(473, 435);
            this.MinimumSize = new System.Drawing.Size(473, 435);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button b_signin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_registr;
    }
}