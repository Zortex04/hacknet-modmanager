﻿namespace HacknetModManager {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnDisableAll = new System.Windows.Forms.Button();
            this.btnEnableAll = new System.Windows.Forms.Button();
            this.btnOpenModFolder = new System.Windows.Forms.Button();
            this.tlpSide = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateMod = new System.Windows.Forms.Button();
            this.btnEditMod = new System.Windows.Forms.Button();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitleVersion = new System.Windows.Forms.Label();
            this.tlpPlay = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlayUnmodded = new System.Windows.Forms.Button();
            this.btnPlayPathfinder = new System.Windows.Forms.Button();
            this.listMods = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tlpBottom.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.tlpSide.SuspendLayout();
            this.tlpPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listMods);
            this.splitContainer1.Panel1.Controls.Add(this.tlpBottom);
            this.splitContainer1.Panel1.Controls.Add(this.tlpTop);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tlpSide);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.lblAuthors);
            this.splitContainer1.Panel2.Controls.Add(this.lblDescription);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitleVersion);
            this.splitContainer1.Panel2.Controls.Add(this.tlpPlay);
            this.splitContainer1.Panel2MinSize = 215;
            this.splitContainer1.Size = new System.Drawing.Size(540, 391);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 3;
            // 
            // tlpBottom
            // 
            this.tlpBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBottom.ColumnCount = 3;
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpBottom.Controls.Add(this.btnRemove, 1, 0);
            this.tlpBottom.Controls.Add(this.btnInstall, 0, 0);
            this.tlpBottom.Controls.Add(this.btnRefresh, 2, 0);
            this.tlpBottom.Location = new System.Drawing.Point(12, 348);
            this.tlpBottom.Name = "tlpBottom";
            this.tlpBottom.RowCount = 1;
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottom.Size = new System.Drawing.Size(185, 31);
            this.tlpBottom.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Location = new System.Drawing.Point(80, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(71, 25);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstall.Location = new System.Drawing.Point(3, 3);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(71, 25);
            this.btnInstall.TabIndex = 3;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Image = global::HacknetModManager.Properties.Resources.arrow_refresh;
            this.btnRefresh.Location = new System.Drawing.Point(157, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tlpTop
            // 
            this.tlpTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTop.ColumnCount = 3;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpTop.Controls.Add(this.btnDisableAll, 1, 0);
            this.tlpTop.Controls.Add(this.btnEnableAll, 0, 0);
            this.tlpTop.Controls.Add(this.btnOpenModFolder, 2, 0);
            this.tlpTop.Location = new System.Drawing.Point(12, 12);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Size = new System.Drawing.Size(185, 31);
            this.tlpTop.TabIndex = 0;
            // 
            // btnDisableAll
            // 
            this.btnDisableAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisableAll.Location = new System.Drawing.Point(79, 3);
            this.btnDisableAll.Name = "btnDisableAll";
            this.btnDisableAll.Size = new System.Drawing.Size(70, 25);
            this.btnDisableAll.TabIndex = 4;
            this.btnDisableAll.Text = "Disable All";
            this.btnDisableAll.UseVisualStyleBackColor = true;
            this.btnDisableAll.Click += new System.EventHandler(this.btnDisableAll_Click);
            // 
            // btnEnableAll
            // 
            this.btnEnableAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnableAll.Location = new System.Drawing.Point(3, 3);
            this.btnEnableAll.Name = "btnEnableAll";
            this.btnEnableAll.Size = new System.Drawing.Size(70, 25);
            this.btnEnableAll.TabIndex = 3;
            this.btnEnableAll.Text = "Enable All";
            this.btnEnableAll.UseVisualStyleBackColor = true;
            this.btnEnableAll.Click += new System.EventHandler(this.btnEnableAll_Click);
            // 
            // btnOpenModFolder
            // 
            this.btnOpenModFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenModFolder.Image = global::HacknetModManager.Properties.Resources.folder_go;
            this.btnOpenModFolder.Location = new System.Drawing.Point(155, 3);
            this.btnOpenModFolder.Name = "btnOpenModFolder";
            this.btnOpenModFolder.Size = new System.Drawing.Size(27, 25);
            this.btnOpenModFolder.TabIndex = 5;
            this.btnOpenModFolder.UseVisualStyleBackColor = true;
            this.btnOpenModFolder.Click += new System.EventHandler(this.btnOpenModFolder_Click);
            // 
            // tlpSide
            // 
            this.tlpSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSide.ColumnCount = 1;
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSide.Controls.Add(this.btnCreateMod, 0, 1);
            this.tlpSide.Controls.Add(this.btnEditMod, 0, 2);
            this.tlpSide.Controls.Add(this.btnHomepage, 0, 0);
            this.tlpSide.Location = new System.Drawing.Point(209, 81);
            this.tlpSide.Name = "tlpSide";
            this.tlpSide.RowCount = 3;
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSide.Size = new System.Drawing.Size(115, 94);
            this.tlpSide.TabIndex = 7;
            // 
            // btnCreateMod
            // 
            this.btnCreateMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateMod.Location = new System.Drawing.Point(3, 34);
            this.btnCreateMod.Name = "btnCreateMod";
            this.btnCreateMod.Size = new System.Drawing.Size(109, 25);
            this.btnCreateMod.TabIndex = 2;
            this.btnCreateMod.Text = "Create";
            this.btnCreateMod.UseVisualStyleBackColor = true;
            // 
            // btnEditMod
            // 
            this.btnEditMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditMod.Location = new System.Drawing.Point(3, 65);
            this.btnEditMod.Name = "btnEditMod";
            this.btnEditMod.Size = new System.Drawing.Size(109, 26);
            this.btnEditMod.TabIndex = 3;
            this.btnEditMod.Text = "Edit";
            this.btnEditMod.UseVisualStyleBackColor = true;
            // 
            // btnHomepage
            // 
            this.btnHomepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHomepage.Location = new System.Drawing.Point(3, 3);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(109, 25);
            this.btnHomepage.TabIndex = 4;
            this.btnHomepage.Text = "Visit Homepage";
            this.btnHomepage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 261);
            this.textBox1.TabIndex = 6;
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoEllipsis = true;
            this.lblAuthors.Location = new System.Drawing.Point(3, 52);
            this.lblAuthors.MaximumSize = new System.Drawing.Size(0, 28);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(0, 26);
            this.lblAuthors.TabIndex = 5;
            this.lblAuthors.Text = "N/A";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 26);
            this.lblDescription.MaximumSize = new System.Drawing.Size(0, 28);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 26);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "N/A";
            // 
            // lblTitleVersion
            // 
            this.lblTitleVersion.AutoEllipsis = true;
            this.lblTitleVersion.AutoSize = true;
            this.lblTitleVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleVersion.Location = new System.Drawing.Point(3, 9);
            this.lblTitleVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblTitleVersion.Name = "lblTitleVersion";
            this.lblTitleVersion.Size = new System.Drawing.Size(31, 17);
            this.lblTitleVersion.TabIndex = 3;
            this.lblTitleVersion.Text = "N/A";
            // 
            // tlpPlay
            // 
            this.tlpPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPlay.ColumnCount = 2;
            this.tlpPlay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPlay.Controls.Add(this.btnPlayUnmodded, 0, 0);
            this.tlpPlay.Controls.Add(this.btnPlayPathfinder, 1, 0);
            this.tlpPlay.Location = new System.Drawing.Point(3, 348);
            this.tlpPlay.Name = "tlpPlay";
            this.tlpPlay.RowCount = 1;
            this.tlpPlay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlay.Size = new System.Drawing.Size(321, 31);
            this.tlpPlay.TabIndex = 2;
            // 
            // btnPlayUnmodded
            // 
            this.btnPlayUnmodded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayUnmodded.Location = new System.Drawing.Point(3, 3);
            this.btnPlayUnmodded.Name = "btnPlayUnmodded";
            this.btnPlayUnmodded.Size = new System.Drawing.Size(154, 25);
            this.btnPlayUnmodded.TabIndex = 1;
            this.btnPlayUnmodded.Text = "Play (Unmodded)";
            this.btnPlayUnmodded.UseVisualStyleBackColor = true;
            this.btnPlayUnmodded.Click += new System.EventHandler(this.btnPlayUnmodded_Click);
            // 
            // btnPlayPathfinder
            // 
            this.btnPlayPathfinder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayPathfinder.Location = new System.Drawing.Point(163, 3);
            this.btnPlayPathfinder.Name = "btnPlayPathfinder";
            this.btnPlayPathfinder.Size = new System.Drawing.Size(155, 25);
            this.btnPlayPathfinder.TabIndex = 0;
            this.btnPlayPathfinder.Text = "Play (Pathfinder)";
            this.btnPlayPathfinder.UseVisualStyleBackColor = true;
            this.btnPlayPathfinder.Click += new System.EventHandler(this.btnPlayPathfinder_Click);
            // 
            // listMods
            // 
            this.listMods.CheckBoxes = true;
            this.listMods.Location = new System.Drawing.Point(12, 50);
            this.listMods.Name = "listMods";
            this.listMods.ShowGroups = false;
            this.listMods.Size = new System.Drawing.Size(185, 292);
            this.listMods.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listMods.TabIndex = 7;
            this.listMods.UseCompatibleStateImageBehavior = false;
            this.listMods.View = System.Windows.Forms.View.List;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 391);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(435, 39);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hacknet Mod Manager";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tlpBottom.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.tlpSide.ResumeLayout(false);
            this.tlpPlay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDisableAll;
        private System.Windows.Forms.Button btnEnableAll;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.Button btnOpenModFolder;
        private System.Windows.Forms.TableLayoutPanel tlpBottom;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPlayPathfinder;
        private System.Windows.Forms.Button btnPlayUnmodded;
        private System.Windows.Forms.TableLayoutPanel tlpPlay;
        private System.Windows.Forms.Label lblTitleVersion;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCreateMod;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tlpSide;
        private System.Windows.Forms.Button btnEditMod;
        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.ListView listMods;
    }
}

