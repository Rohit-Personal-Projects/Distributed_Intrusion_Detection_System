namespace USB_Policy
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gboxUSB_Storage = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.USB_radio_Disabled = new System.Windows.Forms.RadioButton();
            this.USB_radio_FullAccess = new System.Windows.Forms.RadioButton();
            this.USB_radio_ReadOnly = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.REG_cbox_DisableRegistry = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gboxUSB_Storage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gboxUSB_Storage);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(11, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 130);
            this.panel1.TabIndex = 12;
            // 
            // gboxUSB_Storage
            // 
            this.gboxUSB_Storage.Controls.Add(this.pictureBox1);
            this.gboxUSB_Storage.Controls.Add(this.textBox2);
            this.gboxUSB_Storage.Controls.Add(this.USB_radio_Disabled);
            this.gboxUSB_Storage.Controls.Add(this.USB_radio_FullAccess);
            this.gboxUSB_Storage.Controls.Add(this.USB_radio_ReadOnly);
            this.gboxUSB_Storage.Location = new System.Drawing.Point(10, 14);
            this.gboxUSB_Storage.Name = "gboxUSB_Storage";
            this.gboxUSB_Storage.Size = new System.Drawing.Size(242, 100);
            this.gboxUSB_Storage.TabIndex = 3;
            this.gboxUSB_Storage.TabStop = false;
            this.gboxUSB_Storage.Text = "USB Storage Devices Policy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::USB_Policy.Properties.Resources.usb;
            this.pictureBox1.Location = new System.Drawing.Point(3, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(77, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 18);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Access Mode:";
            // 
            // USB_radio_Disabled
            // 
            this.USB_radio_Disabled.AutoSize = true;
            this.USB_radio_Disabled.Location = new System.Drawing.Point(77, 78);
            this.USB_radio_Disabled.Name = "USB_radio_Disabled";
            this.USB_radio_Disabled.Size = new System.Drawing.Size(66, 17);
            this.USB_radio_Disabled.TabIndex = 6;
            this.USB_radio_Disabled.TabStop = true;
            this.USB_radio_Disabled.Text = "Disabled";
            this.USB_radio_Disabled.UseVisualStyleBackColor = true;
            // 
            // USB_radio_FullAccess
            // 
            this.USB_radio_FullAccess.AutoSize = true;
            this.USB_radio_FullAccess.Location = new System.Drawing.Point(77, 36);
            this.USB_radio_FullAccess.Name = "USB_radio_FullAccess";
            this.USB_radio_FullAccess.Size = new System.Drawing.Size(154, 17);
            this.USB_radio_FullAccess.TabIndex = 5;
            this.USB_radio_FullAccess.TabStop = true;
            this.USB_radio_FullAccess.Text = "Full Access ( Read && Write)";
            this.USB_radio_FullAccess.UseVisualStyleBackColor = true;
            // 
            // USB_radio_ReadOnly
            // 
            this.USB_radio_ReadOnly.AutoSize = true;
            this.USB_radio_ReadOnly.Location = new System.Drawing.Point(77, 57);
            this.USB_radio_ReadOnly.Name = "USB_radio_ReadOnly";
            this.USB_radio_ReadOnly.Size = new System.Drawing.Size(75, 17);
            this.USB_radio_ReadOnly.TabIndex = 4;
            this.USB_radio_ReadOnly.TabStop = true;
            this.USB_radio_ReadOnly.Text = "Read Only";
            this.USB_radio_ReadOnly.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.REG_cbox_DisableRegistry);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(259, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registry Editor Policy";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // REG_cbox_DisableRegistry
            // 
            this.REG_cbox_DisableRegistry.AutoSize = true;
            this.REG_cbox_DisableRegistry.Location = new System.Drawing.Point(77, 74);
            this.REG_cbox_DisableRegistry.Name = "REG_cbox_DisableRegistry";
            this.REG_cbox_DisableRegistry.Size = new System.Drawing.Size(101, 17);
            this.REG_cbox_DisableRegistry.TabIndex = 6;
            this.REG_cbox_DisableRegistry.Text = "Disable Regedit";
            this.REG_cbox_DisableRegistry.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(77, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 49);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Disabling registry editor (Regedit) will prevent users to change USB storage poli" +
                "cy from registry.";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(428, 260);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 26);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(330, 260);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(92, 26);
            this.btnRestore.TabIndex = 10;
            this.btnRestore.Text = "&Refresh";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnApply
            // 
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApply.Location = new System.Drawing.Point(228, 260);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(92, 26);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 100);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(318, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 22;
            //this.label2.Text = "Copyright © 2009, Özcan İLİKHAN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "IDS USB Lock";
            // 
            // pictureBox4
            // 
           // this.pictureBox4.Image = global::USB_Policy.Properties.Resources.advancedsettings;
            this.pictureBox4.Location = new System.Drawing.Point(15, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 75);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // btnSecurity
            // 
            this.btnSecurity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSecurity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurity.Location = new System.Drawing.Point(12, 260);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Size = new System.Drawing.Size(92, 26);
            this.btnSecurity.TabIndex = 13;
            this.btnSecurity.Text = "&Password";
            this.btnSecurity.UseVisualStyleBackColor = true;
            this.btnSecurity.Click += new System.EventHandler(this.btnSecurity_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 296);
            this.Controls.Add(this.btnSecurity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnApply);
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.Text = "USB Policy";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.gboxUSB_Storage.ResumeLayout(false);
            this.gboxUSB_Storage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gboxUSB_Storage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton USB_radio_Disabled;
        private System.Windows.Forms.RadioButton USB_radio_FullAccess;
        private System.Windows.Forms.RadioButton USB_radio_ReadOnly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox REG_cbox_DisableRegistry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSecurity;



    }
}

