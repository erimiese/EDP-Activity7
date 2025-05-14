namespace WindowsFormsApp1
{
    partial class ForgotPass
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
            this.same_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.show_Newpass = new System.Windows.Forms.CheckBox();
            this.done_btn = new System.Windows.Forms.Button();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // same_email
            // 
            this.same_email.Location = new System.Drawing.Point(380, 212);
            this.same_email.Name = "same_email";
            this.same_email.Size = new System.Drawing.Size(332, 22);
            this.same_email.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email:";
            // 
            // show_Newpass
            // 
            this.show_Newpass.AutoSize = true;
            this.show_Newpass.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_Newpass.Location = new System.Drawing.Point(592, 332);
            this.show_Newpass.Name = "show_Newpass";
            this.show_Newpass.Size = new System.Drawing.Size(120, 20);
            this.show_Newpass.TabIndex = 24;
            this.show_Newpass.Text = "Show Password";
            this.show_Newpass.UseVisualStyleBackColor = true;
            this.show_Newpass.CheckedChanged += new System.EventHandler(this.show_Newpass_CheckedChanged);
            // 
            // done_btn
            // 
            this.done_btn.BackColor = System.Drawing.Color.HotPink;
            this.done_btn.FlatAppearance.BorderSize = 0;
            this.done_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done_btn.ForeColor = System.Drawing.Color.White;
            this.done_btn.Location = new System.Drawing.Point(505, 379);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(124, 49);
            this.done_btn.TabIndex = 23;
            this.done_btn.Text = "Done";
            this.done_btn.UseVisualStyleBackColor = false;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // new_pass
            // 
            this.new_pass.Location = new System.Drawing.Point(385, 295);
            this.new_pass.Name = "new_pass";
            this.new_pass.PasswordChar = '*';
            this.new_pass.Size = new System.Drawing.Size(332, 22);
            this.new_pass.TabIndex = 22;
            this.new_pass.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "RECOVER ACCOUNT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 550);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.pink;
            this.pictureBox1.Location = new System.Drawing.Point(60, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Clothing Store Management System";
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(744, 550);
            this.Controls.Add(this.same_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.show_Newpass);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.new_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPass";
            this.Text = "ForgotPass";
            this.Load += new System.EventHandler(this.ForgotPass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox same_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox show_Newpass;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.TextBox new_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}