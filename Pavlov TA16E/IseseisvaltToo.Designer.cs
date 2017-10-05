namespace Pavlov_TA16E
{
    partial class PA_IseseisvaltToo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PA_IseseisvaltToo));
            this.PA_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PA_groupBox1 = new System.Windows.Forms.GroupBox();
            this.PA_Nimi = new System.Windows.Forms.MaskedTextBox();
            this.AP_Delite = new System.Windows.Forms.Button();
            this.AP_Update = new System.Windows.Forms.Button();
            this.AP_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PA_Kood = new System.Windows.Forms.MaskedTextBox();
            this.PA_groupBox2 = new System.Windows.Forms.GroupBox();
            this.PA_Nimikiri = new System.Windows.Forms.ListBox();
            this.AP_Read = new System.Windows.Forms.Button();
            this.AP_Write = new System.Windows.Forms.Button();
            this.AP_openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AP_saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.PA_too = new System.Windows.Forms.Button();
            this.PA_groupBox1.SuspendLayout();
            this.PA_groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PA_exit
            // 
            this.PA_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PA_exit.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PA_exit.Location = new System.Drawing.Point(13, 573);
            this.PA_exit.Margin = new System.Windows.Forms.Padding(4);
            this.PA_exit.Name = "PA_exit";
            this.PA_exit.Size = new System.Drawing.Size(194, 60);
            this.PA_exit.TabIndex = 2;
            this.PA_exit.Text = "EXIT";
            this.PA_exit.UseVisualStyleBackColor = true;
            this.PA_exit.Click += new System.EventHandler(this.PA_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(713, 573);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aleksandr Pavlov\r\n      TA-16E";
            // 
            // PA_groupBox1
            // 
            this.PA_groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PA_groupBox1.Controls.Add(this.PA_Nimi);
            this.PA_groupBox1.Controls.Add(this.AP_Delite);
            this.PA_groupBox1.Controls.Add(this.AP_Update);
            this.PA_groupBox1.Controls.Add(this.AP_Add);
            this.PA_groupBox1.Controls.Add(this.label3);
            this.PA_groupBox1.Controls.Add(this.label2);
            this.PA_groupBox1.Controls.Add(this.PA_Kood);
            this.PA_groupBox1.Location = new System.Drawing.Point(63, 26);
            this.PA_groupBox1.Name = "PA_groupBox1";
            this.PA_groupBox1.Size = new System.Drawing.Size(769, 215);
            this.PA_groupBox1.TabIndex = 4;
            this.PA_groupBox1.TabStop = false;
            // 
            // PA_Nimi
            // 
            this.PA_Nimi.Location = new System.Drawing.Point(283, 93);
            this.PA_Nimi.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.PA_Nimi.Name = "PA_Nimi";
            this.PA_Nimi.Size = new System.Drawing.Size(415, 30);
            this.PA_Nimi.TabIndex = 8;
            // 
            // AP_Delite
            // 
            this.AP_Delite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AP_Delite.Location = new System.Drawing.Point(413, 147);
            this.AP_Delite.Name = "AP_Delite";
            this.AP_Delite.Size = new System.Drawing.Size(146, 40);
            this.AP_Delite.TabIndex = 7;
            this.AP_Delite.Text = "Delete";
            this.AP_Delite.UseVisualStyleBackColor = false;
            this.AP_Delite.Click += new System.EventHandler(this.AP_Delite_Click);
            // 
            // AP_Update
            // 
            this.AP_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AP_Update.Location = new System.Drawing.Point(244, 147);
            this.AP_Update.Name = "AP_Update";
            this.AP_Update.Size = new System.Drawing.Size(146, 40);
            this.AP_Update.TabIndex = 6;
            this.AP_Update.Text = "Update";
            this.AP_Update.UseVisualStyleBackColor = false;
            this.AP_Update.Click += new System.EventHandler(this.AP_Update_Click);
            // 
            // AP_Add
            // 
            this.AP_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AP_Add.Location = new System.Drawing.Point(66, 147);
            this.AP_Add.Name = "AP_Add";
            this.AP_Add.Size = new System.Drawing.Size(146, 40);
            this.AP_Add.TabIndex = 5;
            this.AP_Add.Text = "Add";
            this.AP_Add.UseVisualStyleBackColor = false;
            this.AP_Add.Click += new System.EventHandler(this.AP_Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Isikukood";
            // 
            // PA_Kood
            // 
            this.PA_Kood.Location = new System.Drawing.Point(283, 44);
            this.PA_Kood.Mask = "00000000000";
            this.PA_Kood.Name = "PA_Kood";
            this.PA_Kood.Size = new System.Drawing.Size(415, 30);
            this.PA_Kood.TabIndex = 2;
            // 
            // PA_groupBox2
            // 
            this.PA_groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PA_groupBox2.Controls.Add(this.PA_Nimikiri);
            this.PA_groupBox2.Controls.Add(this.AP_Read);
            this.PA_groupBox2.Controls.Add(this.AP_Write);
            this.PA_groupBox2.Location = new System.Drawing.Point(63, 247);
            this.PA_groupBox2.Name = "PA_groupBox2";
            this.PA_groupBox2.Size = new System.Drawing.Size(769, 295);
            this.PA_groupBox2.TabIndex = 5;
            this.PA_groupBox2.TabStop = false;
            // 
            // PA_Nimikiri
            // 
            this.PA_Nimikiri.FormattingEnabled = true;
            this.PA_Nimikiri.ItemHeight = 23;
            this.PA_Nimikiri.Location = new System.Drawing.Point(60, 26);
            this.PA_Nimikiri.Name = "PA_Nimikiri";
            this.PA_Nimikiri.Size = new System.Drawing.Size(637, 211);
            this.PA_Nimikiri.TabIndex = 10;
            this.PA_Nimikiri.SelectedIndexChanged += new System.EventHandler(this.PA_Nimikiri_SelectedIndexChanged);
            this.PA_Nimikiri.DoubleClick += new System.EventHandler(this.PA_Nimikiri_DoubleClick);
            this.PA_Nimikiri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PA_Nimikiri_MouseDown);
            // 
            // AP_Read
            // 
            this.AP_Read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AP_Read.Location = new System.Drawing.Point(56, 249);
            this.AP_Read.Name = "AP_Read";
            this.AP_Read.Size = new System.Drawing.Size(146, 40);
            this.AP_Read.TabIndex = 8;
            this.AP_Read.Text = "Read";
            this.AP_Read.UseVisualStyleBackColor = false;
            this.AP_Read.Click += new System.EventHandler(this.AP_Read_Click);
            // 
            // AP_Write
            // 
            this.AP_Write.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AP_Write.Location = new System.Drawing.Point(542, 249);
            this.AP_Write.Name = "AP_Write";
            this.AP_Write.Size = new System.Drawing.Size(146, 40);
            this.AP_Write.TabIndex = 9;
            this.AP_Write.Text = "Write";
            this.AP_Write.UseVisualStyleBackColor = false;
            this.AP_Write.Click += new System.EventHandler(this.AP_Write_Click);
            // 
            // AP_openFileDialog1
            // 
            this.AP_openFileDialog1.FileName = "openFileDialog1";
            // 
            // PA_too
            // 
            this.PA_too.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PA_too.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PA_too.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PA_too.Location = new System.Drawing.Point(326, 573);
            this.PA_too.Margin = new System.Windows.Forms.Padding(4);
            this.PA_too.Name = "PA_too";
            this.PA_too.Size = new System.Drawing.Size(248, 60);
            this.PA_too.TabIndex = 6;
            this.PA_too.Text = "Formi kirjeldus";
            this.PA_too.UseVisualStyleBackColor = false;
            this.PA_too.Click += new System.EventHandler(this.PA_too_Click);
            // 
            // PA_IseseisvaltToo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 636);
            this.Controls.Add(this.PA_too);
            this.Controls.Add(this.PA_groupBox2);
            this.Controls.Add(this.PA_groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PA_exit);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PA_IseseisvaltToo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IseseisvaltToo";
            this.Load += new System.EventHandler(this.IseseisvaltToo_Load);
            this.PA_groupBox1.ResumeLayout(false);
            this.PA_groupBox1.PerformLayout();
            this.PA_groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PA_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox PA_groupBox1;
        private System.Windows.Forms.Button AP_Delite;
        private System.Windows.Forms.Button AP_Update;
        private System.Windows.Forms.Button AP_Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox PA_Kood;
        private System.Windows.Forms.GroupBox PA_groupBox2;
        private System.Windows.Forms.ListBox PA_Nimikiri;
        private System.Windows.Forms.Button AP_Read;
        private System.Windows.Forms.Button AP_Write;
        private System.Windows.Forms.OpenFileDialog AP_openFileDialog1;
        private System.Windows.Forms.SaveFileDialog AP_saveFileDialog1;
        private System.Windows.Forms.MaskedTextBox PA_Nimi;
        private System.Windows.Forms.Button PA_too;
    }
}