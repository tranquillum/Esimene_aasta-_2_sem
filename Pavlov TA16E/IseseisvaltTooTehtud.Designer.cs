namespace Pavlov_TA16E
{
    partial class IseseisvaltTooTehtud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IseseisvaltTooTehtud));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PA_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Items.AddRange(new object[] {
            "             Kuidas elemendid töötavad:",
            "",
            "1) textbox (PA_Kood): võib sisestada 11 nubrit",
            "   kontrollimine kas sisestatud kood on õige.",
            "2) textbox (PA_Nimi): võib sisestada ainult tähed",
            "3) nupp (PA_Add): kui on õigesti täidatud (PA_Kood)",
            "   ja (PA_Nimi) lisada andmed (PA_Nimikiri) listboksile",
            "   kui tekstboksid on tühjad näidata hoiatus",
            "   kui (PA_Kood) täidetud valesti näidata hoiatus",
            "4) nupp (PA_Update): kirjutab valitud listboksis",
            "   rea asemele info tekstbokstidest",
            "   ennem vahetamist täüsustad asendamine",
            "5) nupp (PA_Delite): kustutab valitud rida listboksist",
            "6) Listboks (PA_Nimikiri): kui on vajutanud nupp (PA_Add) ",
            "   kirjutakse sisse andmed (PA_Nimi)+\" \"+(PA_Kood)",
            "   üks clik rea peale rea valimine",
            "   DoubleClick  kirjutab andmed listbiksist ",
            "   (PA_Kood)sse ja (PA_Nimi)sse",
            "7) nupp (PA_Read): kirjutab txt. failist andmed listboksile",
            "8) nupp (PA_Write): kirjutab txt. failisse andmed listboksist"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(757, 510);
            this.listBox1.TabIndex = 7;
            // 
            // PA_exit
            // 
            this.PA_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PA_exit.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PA_exit.Location = new System.Drawing.Point(13, 597);
            this.PA_exit.Margin = new System.Windows.Forms.Padding(4);
            this.PA_exit.Name = "PA_exit";
            this.PA_exit.Size = new System.Drawing.Size(194, 60);
            this.PA_exit.TabIndex = 8;
            this.PA_exit.Text = "EXIT";
            this.PA_exit.UseVisualStyleBackColor = true;
            this.PA_exit.Click += new System.EventHandler(this.PA_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(599, 621);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Aleksandr Pavlov\r\n      TA-16E";
            // 
            // IseseisvaltTooTehtud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PA_exit);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IseseisvaltTooTehtud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IseseisvaltTooTehtud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button PA_exit;
        private System.Windows.Forms.Label label1;
    }
}