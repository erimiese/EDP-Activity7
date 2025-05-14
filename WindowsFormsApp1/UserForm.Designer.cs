namespace WindowsFormsApp1
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_list = new System.Windows.Forms.DataGridView();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.upd_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.upd_email = new System.Windows.Forms.TextBox();
            this.upd_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.search_un = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 574);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(58, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.pink;
            this.pictureBox1.Location = new System.Drawing.Point(63, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(24, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Clothing Store Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(777, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "LIST OF USERS ";
            // 
            // user_list
            // 
            this.user_list.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_list.Location = new System.Drawing.Point(374, 175);
            this.user_list.Name = "user_list";
            this.user_list.RowHeadersWidth = 51;
            this.user_list.Size = new System.Drawing.Size(552, 368);
            this.user_list.TabIndex = 9;
            this.user_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_list_CellContentClick);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(950, 473);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 8;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(378, 124);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(252, 22);
            this.searchBox.TabIndex = 7;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // upd_btn
            // 
            this.upd_btn.Location = new System.Drawing.Point(1062, 473);
            this.upd_btn.Name = "upd_btn";
            this.upd_btn.Size = new System.Drawing.Size(75, 23);
            this.upd_btn.TabIndex = 6;
            this.upd_btn.Text = "Update";
            this.upd_btn.Click += new System.EventHandler(this.upd_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(1169, 473);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Back";
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // upd_email
            // 
            this.upd_email.Location = new System.Drawing.Point(981, 243);
            this.upd_email.Name = "upd_email";
            this.upd_email.Size = new System.Drawing.Size(229, 22);
            this.upd_email.TabIndex = 4;
            this.upd_email.TextChanged += new System.EventHandler(this.upd_email_TextChanged);
            // 
            // upd_pass
            // 
            this.upd_pass.Location = new System.Drawing.Point(981, 346);
            this.upd_pass.Name = "upd_pass";
            this.upd_pass.Size = new System.Drawing.Size(229, 22);
            this.upd_pass.TabIndex = 3;
            this.upd_pass.TextChanged += new System.EventHandler(this.upd_pass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label3.Location = new System.Drawing.Point(374, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search by username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label4.Location = new System.Drawing.Point(977, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label6.Location = new System.Drawing.Point(977, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password";
            // 
            // search_un
            // 
            this.search_un.Location = new System.Drawing.Point(851, 123);
            this.search_un.Name = "search_un";
            this.search_un.Size = new System.Drawing.Size(75, 23);
            this.search_un.TabIndex = 11;
            this.search_un.Text = "find";
            this.search_un.UseVisualStyleBackColor = true;
            this.search_un.Click += new System.EventHandler(this.search_un_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1290, 574);
            this.Controls.Add(this.search_un);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upd_pass);
            this.Controls.Add(this.upd_email);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.upd_btn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.user_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView user_list;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button upd_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox upd_email;
        private System.Windows.Forms.TextBox upd_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button search_un;
    }
}
