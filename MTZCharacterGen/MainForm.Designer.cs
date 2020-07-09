namespace MTZCharacterGen
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tctrl_main = new System.Windows.Forms.TabControl();
            this.tpg_main_CharGen = new System.Windows.Forms.TabPage();
            this.tpg_main_MektonDesign = new System.Windows.Forms.TabPage();
            this.tpg_main_StarshipDesign = new System.Windows.Forms.TabPage();
            this.tpg_main_Settings = new System.Windows.Forms.TabPage();
            this.tctrl_chargen = new System.Windows.Forms.TabControl();
            this.tpg_chargen_lifepath1 = new System.Windows.Forms.TabPage();
            this.tpg_chargen_stats = new System.Windows.Forms.TabPage();
            this.tpg_chargen_skills = new System.Windows.Forms.TabPage();
            this.tpg_chargen_lifepath2 = new System.Windows.Forms.TabPage();
            this.tpg_chargen_equipment = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tctrl_main.SuspendLayout();
            this.tpg_main_Settings.SuspendLayout();
            this.tctrl_chargen.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "S&ave";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tctrl_main
            // 
            this.tctrl_main.Controls.Add(this.tpg_main_CharGen);
            this.tctrl_main.Controls.Add(this.tpg_main_MektonDesign);
            this.tctrl_main.Controls.Add(this.tpg_main_StarshipDesign);
            this.tctrl_main.Controls.Add(this.tpg_main_Settings);
            this.tctrl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrl_main.Location = new System.Drawing.Point(0, 24);
            this.tctrl_main.Name = "tctrl_main";
            this.tctrl_main.SelectedIndex = 0;
            this.tctrl_main.Size = new System.Drawing.Size(1046, 575);
            this.tctrl_main.TabIndex = 1;
            // 
            // tpg_main_CharGen
            // 
            this.tpg_main_CharGen.Location = new System.Drawing.Point(4, 22);
            this.tpg_main_CharGen.Name = "tpg_main_CharGen";
            this.tpg_main_CharGen.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_main_CharGen.Size = new System.Drawing.Size(1038, 549);
            this.tpg_main_CharGen.TabIndex = 0;
            this.tpg_main_CharGen.Text = "Character Generator";
            this.tpg_main_CharGen.UseVisualStyleBackColor = true;
            // 
            // tpg_main_MektonDesign
            // 
            this.tpg_main_MektonDesign.Location = new System.Drawing.Point(4, 22);
            this.tpg_main_MektonDesign.Name = "tpg_main_MektonDesign";
            this.tpg_main_MektonDesign.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_main_MektonDesign.Size = new System.Drawing.Size(1038, 549);
            this.tpg_main_MektonDesign.TabIndex = 1;
            this.tpg_main_MektonDesign.Text = "Mekton Design";
            this.tpg_main_MektonDesign.UseVisualStyleBackColor = true;
            // 
            // tpg_main_StarshipDesign
            // 
            this.tpg_main_StarshipDesign.Location = new System.Drawing.Point(4, 22);
            this.tpg_main_StarshipDesign.Name = "tpg_main_StarshipDesign";
            this.tpg_main_StarshipDesign.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_main_StarshipDesign.Size = new System.Drawing.Size(1038, 549);
            this.tpg_main_StarshipDesign.TabIndex = 2;
            this.tpg_main_StarshipDesign.Text = "Starship Design";
            this.tpg_main_StarshipDesign.UseVisualStyleBackColor = true;
            // 
            // tpg_main_Settings
            // 
            this.tpg_main_Settings.Controls.Add(this.tctrl_chargen);
            this.tpg_main_Settings.Location = new System.Drawing.Point(4, 22);
            this.tpg_main_Settings.Name = "tpg_main_Settings";
            this.tpg_main_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_main_Settings.Size = new System.Drawing.Size(1038, 549);
            this.tpg_main_Settings.TabIndex = 3;
            this.tpg_main_Settings.Text = "Settings";
            this.tpg_main_Settings.UseVisualStyleBackColor = true;
            // 
            // tctrl_chargen
            // 
            this.tctrl_chargen.Controls.Add(this.tpg_chargen_lifepath1);
            this.tctrl_chargen.Controls.Add(this.tpg_chargen_stats);
            this.tctrl_chargen.Controls.Add(this.tpg_chargen_skills);
            this.tctrl_chargen.Controls.Add(this.tpg_chargen_lifepath2);
            this.tctrl_chargen.Controls.Add(this.tpg_chargen_equipment);
            this.tctrl_chargen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrl_chargen.Location = new System.Drawing.Point(3, 3);
            this.tctrl_chargen.Name = "tctrl_chargen";
            this.tctrl_chargen.SelectedIndex = 0;
            this.tctrl_chargen.Size = new System.Drawing.Size(1032, 543);
            this.tctrl_chargen.TabIndex = 0;
            // 
            // tpg_chargen_lifepath1
            // 
            this.tpg_chargen_lifepath1.Location = new System.Drawing.Point(4, 22);
            this.tpg_chargen_lifepath1.Name = "tpg_chargen_lifepath1";
            this.tpg_chargen_lifepath1.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_chargen_lifepath1.Size = new System.Drawing.Size(1024, 517);
            this.tpg_chargen_lifepath1.TabIndex = 0;
            this.tpg_chargen_lifepath1.Text = "Life Path, part 1";
            this.tpg_chargen_lifepath1.UseVisualStyleBackColor = true;
            // 
            // tpg_chargen_stats
            // 
            this.tpg_chargen_stats.Location = new System.Drawing.Point(4, 22);
            this.tpg_chargen_stats.Name = "tpg_chargen_stats";
            this.tpg_chargen_stats.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_chargen_stats.Size = new System.Drawing.Size(1024, 517);
            this.tpg_chargen_stats.TabIndex = 1;
            this.tpg_chargen_stats.Text = "Character Stats";
            this.tpg_chargen_stats.UseVisualStyleBackColor = true;
            // 
            // tpg_chargen_skills
            // 
            this.tpg_chargen_skills.Location = new System.Drawing.Point(4, 22);
            this.tpg_chargen_skills.Name = "tpg_chargen_skills";
            this.tpg_chargen_skills.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_chargen_skills.Size = new System.Drawing.Size(1024, 517);
            this.tpg_chargen_skills.TabIndex = 2;
            this.tpg_chargen_skills.Text = "Character Skills";
            this.tpg_chargen_skills.UseVisualStyleBackColor = true;
            // 
            // tpg_chargen_lifepath2
            // 
            this.tpg_chargen_lifepath2.Location = new System.Drawing.Point(4, 22);
            this.tpg_chargen_lifepath2.Name = "tpg_chargen_lifepath2";
            this.tpg_chargen_lifepath2.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_chargen_lifepath2.Size = new System.Drawing.Size(1024, 517);
            this.tpg_chargen_lifepath2.TabIndex = 3;
            this.tpg_chargen_lifepath2.Text = "Life Path, part 2";
            this.tpg_chargen_lifepath2.UseVisualStyleBackColor = true;
            // 
            // tpg_chargen_equipment
            // 
            this.tpg_chargen_equipment.Location = new System.Drawing.Point(4, 22);
            this.tpg_chargen_equipment.Name = "tpg_chargen_equipment";
            this.tpg_chargen_equipment.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_chargen_equipment.Size = new System.Drawing.Size(1024, 517);
            this.tpg_chargen_equipment.TabIndex = 4;
            this.tpg_chargen_equipment.Text = "Equipment";
            this.tpg_chargen_equipment.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 599);
            this.Controls.Add(this.tctrl_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tctrl_main.ResumeLayout(false);
            this.tpg_main_Settings.ResumeLayout(false);
            this.tctrl_chargen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tctrl_main;
        private System.Windows.Forms.TabPage tpg_main_CharGen;
        private System.Windows.Forms.TabPage tpg_main_MektonDesign;
        private System.Windows.Forms.TabPage tpg_main_StarshipDesign;
        private System.Windows.Forms.TabPage tpg_main_Settings;
        private System.Windows.Forms.TabControl tctrl_chargen;
        private System.Windows.Forms.TabPage tpg_chargen_lifepath1;
        private System.Windows.Forms.TabPage tpg_chargen_stats;
        private System.Windows.Forms.TabPage tpg_chargen_skills;
        private System.Windows.Forms.TabPage tpg_chargen_lifepath2;
        private System.Windows.Forms.TabPage tpg_chargen_equipment;
    }
}

