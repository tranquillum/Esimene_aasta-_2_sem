namespace Pavlov_TA16E
{
    partial class PA_09_03_2017
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PA_09_03_2017));
            this.PA_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PA_ListBox1 = new System.Windows.Forms.ListBox();
            this.PA_btnLoeFile = new System.Windows.Forms.Button();
            this.PA_openfileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PA_FileName = new System.Windows.Forms.Label();
            this.PA_xtxbox1 = new System.Windows.Forms.TextBox();
            this.PA_btnlisa = new System.Windows.Forms.Button();
            this.PA_btnkustutada = new System.Windows.Forms.Button();
            this.PA_btnmuuda = new System.Windows.Forms.Button();
            this.PA_tuhikud = new System.Windows.Forms.Button();
            this.PA_btnsalvesta = new System.Windows.Forms.Button();
            this.PA_saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.PA_xtxbox2 = new System.Windows.Forms.TextBox();
            this.PA_btnLoeTekst = new System.Windows.Forms.Button();
            this.PA_lbl2 = new System.Windows.Forms.Label();
            this.PA_lbl1 = new System.Windows.Forms.Label();
            this.PA_listBoxsumb = new System.Windows.Forms.ListBox();
            this.PA_btnsumb = new System.Windows.Forms.Button();
            this.PA_btnsalvesta2 = new System.Windows.Forms.Button();
            this.PA_btnloemassiiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PA_exit
            // 
            this.PA_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PA_exit.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PA_exit.Location = new System.Drawing.Point(15, 598);
            this.PA_exit.Name = "PA_exit";
            this.PA_exit.Size = new System.Drawing.Size(181, 49);
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
            this.label1.Location = new System.Drawing.Point(695, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aleksandr Pavlov\r\n      TA-16E";
            // 
            // PA_ListBox1
            // 
            this.PA_ListBox1.FormattingEnabled = true;
            this.PA_ListBox1.HorizontalScrollbar = true;
            this.PA_ListBox1.ItemHeight = 23;
            this.PA_ListBox1.Location = new System.Drawing.Point(215, 12);
            this.PA_ListBox1.Name = "PA_ListBox1";
            this.PA_ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PA_ListBox1.Size = new System.Drawing.Size(616, 165);
            this.PA_ListBox1.TabIndex = 4;
            this.PA_ListBox1.SelectedIndexChanged += new System.EventHandler(this.PA_ListBox1_SelectedIndexChanged);
            // 
            // PA_btnLoeFile
            // 
            this.PA_btnLoeFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PA_btnLoeFile.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PA_btnLoeFile.Location = new System.Drawing.Point(12, 44);
            this.PA_btnLoeFile.Name = "PA_btnLoeFile";
            this.PA_btnLoeFile.Size = new System.Drawing.Size(187, 44);
            this.PA_btnLoeFile.TabIndex = 5;
            this.PA_btnLoeFile.Text = "Loe Fail";
            this.PA_btnLoeFile.UseVisualStyleBackColor = false;
            this.PA_btnLoeFile.Click += new System.EventHandler(this.PA_btnLoeFile_Click);
            // 
            // PA_openfileDialog1
            // 
            this.PA_openfileDialog1.FileName = "openFileDialog1";
            this.PA_openfileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.PA_fileDialog1_FileOk);
            // 
            // PA_FileName
            // 
            this.PA_FileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PA_FileName.Location = new System.Drawing.Point(12, 260);
            this.PA_FileName.Name = "PA_FileName";
            this.PA_FileName.Size = new System.Drawing.Size(819, 31);
            this.PA_FileName.TabIndex = 6;
            // 
            // PA_xtxbox1
            // 
            this.PA_xtxbox1.Location = new System.Drawing.Point(12, 12);
            this.PA_xtxbox1.Name = "PA_xtxbox1";
            this.PA_xtxbox1.Size = new System.Drawing.Size(187, 30);
            this.PA_xtxbox1.TabIndex = 7;
            // 
            // PA_btnlisa
            // 
            this.PA_btnlisa.BackColor = System.Drawing.Color.Aqua;
            this.PA_btnlisa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PA_btnlisa.Location = new System.Drawing.Point(12, 94);
            this.PA_btnlisa.Name = "PA_btnlisa";
            this.PA_btnlisa.Size = new System.Drawing.Size(87, 29);
            this.PA_btnlisa.TabIndex = 8;
            this.PA_btnlisa.Text = "Lisa";
            this.PA_btnlisa.UseVisualStyleBackColor = false;
            this.PA_btnlisa.Click += new System.EventHandler(this.PA_btnlisa_Click);
            // 
            // PA_btnkustutada
            // 
            this.PA_btnkustutada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PA_btnkustutada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PA_btnkustutada.Location = new System.Drawing.Point(112, 94);
            this.PA_btnkustutada.Name = "PA_btnkustutada";
            this.PA_btnkustutada.Size = new System.Drawing.Size(87, 29);
            this.PA_btnkustutada.TabIndex = 9;
            this.PA_btnkustutada.Text = "Kustuta";
            this.PA_btnkustutada.UseVisualStyleBackColor = false;
            this.PA_btnkustutada.Click += new System.EventHandler(this.PA_btnkustutada_Click);
            // 
            // PA_btnmuuda
            // 
            this.PA_btnmuuda.BackColor = System.Drawing.Color.Teal;
            this.PA_btnmuuda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PA_btnmuuda.Location = new System.Drawing.Point(12, 129);
            this.PA_btnmuuda.Name = "PA_btnmuuda";
            this.PA_btnmuuda.Size = new System.Drawing.Size(87, 29);
            this.PA_btnmuuda.TabIndex = 10;
            this.PA_btnmuuda.Text = "Muuda";
            this.PA_btnmuuda.UseVisualStyleBackColor = false;
            this.PA_btnmuuda.Click += new System.EventHandler(this.PA_btnmuuda_Click);
            // 
            // PA_tuhikud
            // 
            this.PA_tuhikud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PA_tuhikud.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PA_tuhikud.Location = new System.Drawing.Point(112, 129);
            this.PA_tuhikud.Name = "PA_tuhikud";
            this.PA_tuhikud.Size = new System.Drawing.Size(87, 29);
            this.PA_tuhikud.TabIndex = 11;
            this.PA_tuhikud.Text = "tuh kust";
            this.PA_tuhikud.UseVisualStyleBackColor = false;
            this.PA_tuhikud.Click += new System.EventHandler(this.PA_tuhikud_Click);
            // 
            // PA_btnsalvesta
            // 
            this.PA_btnsalvesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PA_btnsalvesta.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PA_btnsalvesta.Location = new System.Drawing.Point(12, 164);
            this.PA_btnsalvesta.Name = "PA_btnsalvesta";
            this.PA_btnsalvesta.Size = new System.Drawing.Size(187, 44);
            this.PA_btnsalvesta.TabIndex = 12;
            this.PA_btnsalvesta.Text = "Salvesta fail";
            this.PA_btnsalvesta.UseVisualStyleBackColor = false;
            this.PA_btnsalvesta.Click += new System.EventHandler(this.PA_btnsalvesta_Click);
            // 
            // PA_xtxbox2
            // 
            this.PA_xtxbox2.Location = new System.Drawing.Point(215, 302);
            this.PA_xtxbox2.Multiline = true;
            this.PA_xtxbox2.Name = "PA_xtxbox2";
            this.PA_xtxbox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PA_xtxbox2.Size = new System.Drawing.Size(523, 246);
            this.PA_xtxbox2.TabIndex = 13;
            // 
            // PA_btnLoeTekst
            // 
            this.PA_btnLoeTekst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PA_btnLoeTekst.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PA_btnLoeTekst.Location = new System.Drawing.Point(12, 304);
            this.PA_btnLoeTekst.Name = "PA_btnLoeTekst";
            this.PA_btnLoeTekst.Size = new System.Drawing.Size(187, 44);
            this.PA_btnLoeTekst.TabIndex = 14;
            this.PA_btnLoeTekst.Text = "Loe Tekst";
            this.PA_btnLoeTekst.UseVisualStyleBackColor = false;
            this.PA_btnLoeTekst.Click += new System.EventHandler(this.PA_btnLoeTekst_Click);
            // 
            // PA_lbl2
            // 
            this.PA_lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PA_lbl2.Location = new System.Drawing.Point(215, 551);
            this.PA_lbl2.Name = "PA_lbl2";
            this.PA_lbl2.Size = new System.Drawing.Size(616, 31);
            this.PA_lbl2.TabIndex = 15;
            // 
            // PA_lbl1
            // 
            this.PA_lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PA_lbl1.Location = new System.Drawing.Point(217, 227);
            this.PA_lbl1.Name = "PA_lbl1";
            this.PA_lbl1.Size = new System.Drawing.Size(616, 31);
            this.PA_lbl1.TabIndex = 16;
            // 
            // PA_listBoxsumb
            // 
            this.PA_listBoxsumb.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PA_listBoxsumb.FormattingEnabled = true;
            this.PA_listBoxsumb.ItemHeight = 17;
            this.PA_listBoxsumb.Location = new System.Drawing.Point(750, 302);
            this.PA_listBoxsumb.Name = "PA_listBoxsumb";
            this.PA_listBoxsumb.Size = new System.Drawing.Size(81, 242);
            this.PA_listBoxsumb.TabIndex = 17;
            // 
            // PA_btnsumb
            // 
            this.PA_btnsumb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PA_btnsumb.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PA_btnsumb.Location = new System.Drawing.Point(12, 354);
            this.PA_btnsumb.Name = "PA_btnsumb";
            this.PA_btnsumb.Size = new System.Drawing.Size(187, 44);
            this.PA_btnsumb.TabIndex = 18;
            this.PA_btnsumb.Text = "Sumbolid";
            this.PA_btnsumb.UseVisualStyleBackColor = false;
            this.PA_btnsumb.Click += new System.EventHandler(this.PA_btnsumb_Click);
            // 
            // PA_btnsalvesta2
            // 
            this.PA_btnsalvesta2.BackColor = System.Drawing.Color.Olive;
            this.PA_btnsalvesta2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PA_btnsalvesta2.Location = new System.Drawing.Point(11, 404);
            this.PA_btnsalvesta2.Name = "PA_btnsalvesta2";
            this.PA_btnsalvesta2.Size = new System.Drawing.Size(184, 44);
            this.PA_btnsalvesta2.TabIndex = 19;
            this.PA_btnsalvesta2.Text = "Salvesta tekst";
            this.PA_btnsalvesta2.UseVisualStyleBackColor = false;
            this.PA_btnsalvesta2.Click += new System.EventHandler(this.PA_btnsalvesta2_Click);
            // 
            // PA_btnloemassiiv
            // 
            this.PA_btnloemassiiv.BackColor = System.Drawing.Color.Gray;
            this.PA_btnloemassiiv.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PA_btnloemassiiv.Location = new System.Drawing.Point(8, 214);
            this.PA_btnloemassiiv.Name = "PA_btnloemassiiv";
            this.PA_btnloemassiiv.Size = new System.Drawing.Size(191, 44);
            this.PA_btnloemassiiv.TabIndex = 20;
            this.PA_btnloemassiiv.Text = "Loe massiiv";
            this.PA_btnloemassiiv.UseVisualStyleBackColor = false;
            this.PA_btnloemassiiv.Click += new System.EventHandler(this.PA_btnloemassiiv_Click);
            // 
            // PA_09_03_2017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.PA_exit;
            this.ClientSize = new System.Drawing.Size(889, 664);
            this.Controls.Add(this.PA_btnloemassiiv);
            this.Controls.Add(this.PA_btnsalvesta2);
            this.Controls.Add(this.PA_btnsumb);
            this.Controls.Add(this.PA_listBoxsumb);
            this.Controls.Add(this.PA_lbl1);
            this.Controls.Add(this.PA_lbl2);
            this.Controls.Add(this.PA_btnLoeTekst);
            this.Controls.Add(this.PA_xtxbox2);
            this.Controls.Add(this.PA_btnsalvesta);
            this.Controls.Add(this.PA_tuhikud);
            this.Controls.Add(this.PA_btnmuuda);
            this.Controls.Add(this.PA_btnkustutada);
            this.Controls.Add(this.PA_btnlisa);
            this.Controls.Add(this.PA_xtxbox1);
            this.Controls.Add(this.PA_FileName);
            this.Controls.Add(this.PA_btnLoeFile);
            this.Controls.Add(this.PA_ListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PA_exit);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PA_09_03_2017";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PA_09_03_2017";
            this.Load += new System.EventHandler(this.PA_09_03_2017_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PA_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PA_ListBox1;
        private System.Windows.Forms.Button PA_btnLoeFile;
        private System.Windows.Forms.OpenFileDialog PA_openfileDialog1;
        private System.Windows.Forms.Label PA_FileName;
        private System.Windows.Forms.TextBox PA_xtxbox1;
        private System.Windows.Forms.Button PA_btnlisa;
        private System.Windows.Forms.Button PA_btnkustutada;
        private System.Windows.Forms.Button PA_btnmuuda;
        private System.Windows.Forms.Button PA_tuhikud;
        private System.Windows.Forms.Button PA_btnsalvesta;
        private System.Windows.Forms.SaveFileDialog PA_saveFileDialog1;
        private System.Windows.Forms.TextBox PA_xtxbox2;
        private System.Windows.Forms.Button PA_btnLoeTekst;
        private System.Windows.Forms.Label PA_lbl2;
        private System.Windows.Forms.Label PA_lbl1;
        private System.Windows.Forms.ListBox PA_listBoxsumb;
        private System.Windows.Forms.Button PA_btnsumb;
        private System.Windows.Forms.Button PA_btnsalvesta2;
        private System.Windows.Forms.Button PA_btnloemassiiv;
    }
}