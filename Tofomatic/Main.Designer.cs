namespace Tofomatic
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lancementAutomatiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lancementManuelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renommageDuDossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renommageDesPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.séparationDesPhotosRAWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déplacementDesDossiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerLesPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orphelinsJPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orphelinsRAWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialogRoot = new System.Windows.Forms.FolderBrowserDialog();
            this.logbox = new System.Windows.Forms.TextBox();
            this.txtBox_rootPath = new System.Windows.Forms.TextBox();
            this.btn_selectRootPath = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 311);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(630, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lancementAutomatiqueToolStripMenuItem,
            this.lancementManuelToolStripMenuItem,
            this.listerLesPhotosToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // lancementAutomatiqueToolStripMenuItem
            // 
            this.lancementAutomatiqueToolStripMenuItem.Name = "lancementAutomatiqueToolStripMenuItem";
            this.lancementAutomatiqueToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.lancementAutomatiqueToolStripMenuItem.Text = "Lancement automatique";
            this.lancementAutomatiqueToolStripMenuItem.Click += new System.EventHandler(this.lancementAutomatiqueToolStripMenuItem_Click);
            // 
            // lancementManuelToolStripMenuItem
            // 
            this.lancementManuelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renommageDuDossierToolStripMenuItem,
            this.renommageDesPhotosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.séparationDesPhotosRAWToolStripMenuItem,
            this.déplacementDesDossiersToolStripMenuItem});
            this.lancementManuelToolStripMenuItem.Name = "lancementManuelToolStripMenuItem";
            this.lancementManuelToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.lancementManuelToolStripMenuItem.Text = "Lancement manuel";
            this.lancementManuelToolStripMenuItem.Click += new System.EventHandler(this.lancementManuelToolStripMenuItem_Click);
            // 
            // renommageDuDossierToolStripMenuItem
            // 
            this.renommageDuDossierToolStripMenuItem.Name = "renommageDuDossierToolStripMenuItem";
            this.renommageDuDossierToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.renommageDuDossierToolStripMenuItem.Text = "1 - Renommage du dossier";
            this.renommageDuDossierToolStripMenuItem.Click += new System.EventHandler(this.renommageDuDossierToolStripMenuItem_Click);
            // 
            // renommageDesPhotosToolStripMenuItem
            // 
            this.renommageDesPhotosToolStripMenuItem.Name = "renommageDesPhotosToolStripMenuItem";
            this.renommageDesPhotosToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.renommageDesPhotosToolStripMenuItem.Text = "2 - Renommage des photos via EXIF";
            this.renommageDesPhotosToolStripMenuItem.Click += new System.EventHandler(this.renommageDesPhotosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(263, 22);
            this.toolStripMenuItem2.Text = "3 - Renommage des photos";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // séparationDesPhotosRAWToolStripMenuItem
            // 
            this.séparationDesPhotosRAWToolStripMenuItem.Name = "séparationDesPhotosRAWToolStripMenuItem";
            this.séparationDesPhotosRAWToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.séparationDesPhotosRAWToolStripMenuItem.Text = "4 - Séparation des photos RAW";
            this.séparationDesPhotosRAWToolStripMenuItem.Click += new System.EventHandler(this.séparationDesPhotosRAWToolStripMenuItem_Click);
            // 
            // déplacementDesDossiersToolStripMenuItem
            // 
            this.déplacementDesDossiersToolStripMenuItem.Name = "déplacementDesDossiersToolStripMenuItem";
            this.déplacementDesDossiersToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.déplacementDesDossiersToolStripMenuItem.Text = "5 - Déplacement des dossiers";
            this.déplacementDesDossiersToolStripMenuItem.Click += new System.EventHandler(this.déplacementDesDossiersToolStripMenuItem_Click);
            // 
            // listerLesPhotosToolStripMenuItem
            // 
            this.listerLesPhotosToolStripMenuItem.Name = "listerLesPhotosToolStripMenuItem";
            this.listerLesPhotosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.listerLesPhotosToolStripMenuItem.Text = "Lister les photos";
            this.listerLesPhotosToolStripMenuItem.Click += new System.EventHandler(this.listerLesPhotosToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orphelinsJPGToolStripMenuItem,
            this.orphelinsRAWToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // orphelinsJPGToolStripMenuItem
            // 
            this.orphelinsJPGToolStripMenuItem.Name = "orphelinsJPGToolStripMenuItem";
            this.orphelinsJPGToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.orphelinsJPGToolStripMenuItem.Text = "Orphelins JPG";
            this.orphelinsJPGToolStripMenuItem.Click += new System.EventHandler(this.orphelinsJPGToolStripMenuItem_Click);
            // 
            // orphelinsRAWToolStripMenuItem
            // 
            this.orphelinsRAWToolStripMenuItem.Name = "orphelinsRAWToolStripMenuItem";
            this.orphelinsRAWToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.orphelinsRAWToolStripMenuItem.Text = "Orphelins RAW";
            this.orphelinsRAWToolStripMenuItem.Click += new System.EventHandler(this.orphelinsRAWToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A Propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // folderBrowserDialogRoot
            // 
            this.folderBrowserDialogRoot.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialogRoot.SelectedPath = "D:\\";
            // 
            // logbox
            // 
            this.logbox.CausesValidation = false;
            this.logbox.HideSelection = false;
            this.logbox.Location = new System.Drawing.Point(12, 53);
            this.logbox.Multiline = true;
            this.logbox.Name = "logbox";
            this.logbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logbox.Size = new System.Drawing.Size(606, 226);
            this.logbox.TabIndex = 2;
            this.logbox.TabStop = false;
            // 
            // txtBox_rootPath
            // 
            this.txtBox_rootPath.Location = new System.Drawing.Point(12, 27);
            this.txtBox_rootPath.Name = "txtBox_rootPath";
            this.txtBox_rootPath.ReadOnly = true;
            this.txtBox_rootPath.Size = new System.Drawing.Size(334, 20);
            this.txtBox_rootPath.TabIndex = 3;
            this.txtBox_rootPath.Text = "Veuillez choisir un dossier racine";
            // 
            // btn_selectRootPath
            // 
            this.btn_selectRootPath.Location = new System.Drawing.Point(352, 27);
            this.btn_selectRootPath.Name = "btn_selectRootPath";
            this.btn_selectRootPath.Size = new System.Drawing.Size(75, 23);
            this.btn_selectRootPath.TabIndex = 4;
            this.btn_selectRootPath.Text = "Parcourir ...";
            this.btn_selectRootPath.UseVisualStyleBackColor = true;
            this.btn_selectRootPath.Click += new System.EventHandler(this.btn_selectRootPath_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 285);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(605, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 333);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.btn_selectRootPath);
            this.Controls.Add(this.txtBox_rootPath);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Tofomatic";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogRoot;
        private System.Windows.Forms.TextBox logbox;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orphelinsJPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orphelinsRAWToolStripMenuItem;
        internal System.Windows.Forms.TextBox txtBox_rootPath;
        internal System.Windows.Forms.Button btn_selectRootPath;
        private System.Windows.Forms.ToolStripMenuItem lancementManuelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renommageDuDossierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renommageDesPhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem lancementAutomatiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem séparationDesPhotosRAWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déplacementDesDossiersToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem listerLesPhotosToolStripMenuItem;
    }
}

