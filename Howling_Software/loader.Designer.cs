﻿namespace Howling_Software
{
    partial class loader
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loader));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pw_box = new System.Windows.Forms.TextBox();
            this.user_box = new System.Windows.Forms.TextBox();
            this.lgn_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lo_button = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 28;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "Username";
            // 
            // pw_box
            // 
            this.pw_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pw_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pw_box.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_box.ForeColor = System.Drawing.Color.White;
            this.pw_box.Location = new System.Drawing.Point(12, 159);
            this.pw_box.Name = "pw_box";
            this.pw_box.Size = new System.Drawing.Size(190, 20);
            this.pw_box.TabIndex = 26;
            this.pw_box.UseSystemPasswordChar = true;
            // 
            // user_box
            // 
            this.user_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.user_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_box.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_box.ForeColor = System.Drawing.Color.White;
            this.user_box.Location = new System.Drawing.Point(12, 118);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(190, 20);
            this.user_box.TabIndex = 25;
            // 
            // lgn_button
            // 
            this.lgn_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lgn_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lgn_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lgn_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lgn_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgn_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgn_button.ForeColor = System.Drawing.Color.White;
            this.lgn_button.Location = new System.Drawing.Point(12, 197);
            this.lgn_button.Name = "lgn_button";
            this.lgn_button.Size = new System.Drawing.Size(190, 27);
            this.lgn_button.TabIndex = 24;
            this.lgn_button.Text = "Login";
            this.lgn_button.UseVisualStyleBackColor = false;
            this.lgn_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(187, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 20);
            this.panel1.TabIndex = 30;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Howling_Software.Properties.Resources.silhouette_3322007__3401;
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // lo_button
            // 
            this.lo_button.AutoSize = true;
            this.lo_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lo_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lo_button.Location = new System.Drawing.Point(9, 227);
            this.lo_button.Name = "lo_button";
            this.lo_button.Size = new System.Drawing.Size(117, 14);
            this.lo_button.TabIndex = 31;
            this.lo_button.Text = "succesfully logged off!";
            this.lo_button.Visible = false;
            // 
            // loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(214, 245);
            this.Controls.Add(this.lo_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pw_box);
            this.Controls.Add(this.user_box);
            this.Controls.Add(this.lgn_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pw_box;
        private System.Windows.Forms.TextBox user_box;
        private System.Windows.Forms.Button lgn_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lo_button;
    }
}

