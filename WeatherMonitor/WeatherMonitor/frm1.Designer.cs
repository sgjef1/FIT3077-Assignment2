﻿namespace WeatherMonitor
{
    partial class frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.btntemp = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblNav = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddMonitor = new System.Windows.Forms.Button();
            this.btnMonitors = new System.Windows.Forms.Button();
            this.rbtnRain = new System.Windows.Forms.RadioButton();
            this.imgAddMonitors = new System.Windows.Forms.PictureBox();
            this.rbtnTemp = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMonitor1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddMonitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btntemp
            // 
            this.btntemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btntemp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntemp.ForeColor = System.Drawing.Color.White;
            this.btntemp.Location = new System.Drawing.Point(290, 50);
            this.btntemp.Name = "btntemp";
            this.btntemp.Size = new System.Drawing.Size(284, 34);
            this.btntemp.TabIndex = 0;
            this.btntemp.Text = "Make em beautiful";
            this.btntemp.UseVisualStyleBackColor = false;
            this.btntemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(290, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(215, 34);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblNav
            // 
            this.lblNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.lblNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNav.Location = new System.Drawing.Point(0, 0);
            this.lblNav.Name = "lblNav";
            this.lblNav.Size = new System.Drawing.Size(284, 492);
            this.lblNav.TabIndex = 3;
            this.lblNav.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddMonitor
            // 
            this.btnAddMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btnAddMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMonitor.ForeColor = System.Drawing.Color.Silver;
            this.btnAddMonitor.Location = new System.Drawing.Point(0, 75);
            this.btnAddMonitor.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddMonitor.Name = "btnAddMonitor";
            this.btnAddMonitor.Size = new System.Drawing.Size(284, 51);
            this.btnAddMonitor.TabIndex = 6;
            this.btnAddMonitor.Text = "Add Monitor";
            this.btnAddMonitor.UseVisualStyleBackColor = false;
            // 
            // btnMonitors
            // 
            this.btnMonitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btnMonitors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMonitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitors.ForeColor = System.Drawing.Color.Silver;
            this.btnMonitors.Location = new System.Drawing.Point(0, 276);
            this.btnMonitors.Name = "btnMonitors";
            this.btnMonitors.Size = new System.Drawing.Size(284, 53);
            this.btnMonitors.TabIndex = 7;
            this.btnMonitors.Text = "Monitors";
            this.btnMonitors.UseVisualStyleBackColor = false;
            // 
            // rbtnRain
            // 
            this.rbtnRain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.rbtnRain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRain.ForeColor = System.Drawing.Color.Silver;
            this.rbtnRain.Location = new System.Drawing.Point(11, 160);
            this.rbtnRain.Name = "rbtnRain";
            this.rbtnRain.Size = new System.Drawing.Size(247, 22);
            this.rbtnRain.TabIndex = 8;
            this.rbtnRain.TabStop = true;
            this.rbtnRain.Text = "Rainfall";
            this.rbtnRain.UseVisualStyleBackColor = false;
            this.rbtnRain.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // imgAddMonitors
            // 
            this.imgAddMonitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.imgAddMonitors.Image = ((System.Drawing.Image)(resources.GetObject("imgAddMonitors.Image")));
            this.imgAddMonitors.Location = new System.Drawing.Point(12, 92);
            this.imgAddMonitors.Name = "imgAddMonitors";
            this.imgAddMonitors.Size = new System.Drawing.Size(20, 23);
            this.imgAddMonitors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAddMonitors.TabIndex = 9;
            this.imgAddMonitors.TabStop = false;
            // 
            // rbtnTemp
            // 
            this.rbtnTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.rbtnTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTemp.ForeColor = System.Drawing.Color.Silver;
            this.rbtnTemp.Location = new System.Drawing.Point(11, 190);
            this.rbtnTemp.Name = "rbtnTemp";
            this.rbtnTemp.Size = new System.Drawing.Size(247, 25);
            this.rbtnTemp.TabIndex = 10;
            this.rbtnTemp.TabStop = true;
            this.rbtnTemp.Text = "Temperature";
            this.rbtnTemp.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Silver;
            this.btnAdd.Location = new System.Drawing.Point(31, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(215, 32);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnMonitor1
            // 
            this.btnMonitor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btnMonitor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMonitor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitor1.ForeColor = System.Drawing.Color.Silver;
            this.btnMonitor1.Location = new System.Drawing.Point(11, 335);
            this.btnMonitor1.Name = "btnMonitor1";
            this.btnMonitor1.Size = new System.Drawing.Size(267, 34);
            this.btnMonitor1.TabIndex = 14;
            this.btnMonitor1.Text = "Johannesburg";
            this.btnMonitor1.UseVisualStyleBackColor = false;
            this.btnMonitor1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 66);
            this.label1.TabIndex = 15;
            this.label1.Text = "T/D";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(248, 341);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Durban",
            "Cape town"});
            this.comboBox1.Location = new System.Drawing.Point(98, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Location";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(791, 492);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMonitor1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rbtnTemp);
            this.Controls.Add(this.imgAddMonitors);
            this.Controls.Add(this.rbtnRain);
            this.Controls.Add(this.btnMonitors);
            this.Controls.Add(this.btnAddMonitor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btntemp);
            this.Controls.Add(this.lblNav);
            this.Name = "frm1";
            this.Text = "WeatherMonitor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddMonitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntemp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblNav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddMonitor;
        private System.Windows.Forms.Button btnMonitors;
        private System.Windows.Forms.RadioButton rbtnRain;
        private System.Windows.Forms.PictureBox imgAddMonitors;
        private System.Windows.Forms.RadioButton rbtnTemp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMonitor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

