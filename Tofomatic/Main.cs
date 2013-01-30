using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Tofomatic
{
    public partial class Main : Form
    {
        private AboutBox abox;
        private string dossierRoot = "";        
        private string dossierPhotos = "D:\\Photos";
        private string dossierPhotosRaw = "D:\\Photos RAW";
        private TextInfo info = CultureInfo.CurrentCulture.TextInfo;
        private delegate void stringDelegate(string logText);

        public Main()
        {
            InitializeComponent();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Affichage de la form "A Propos"
            abox = new AboutBox();
            abox.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string nouveauNom = "";
            string ancienNom = "";
            string chemin = "";
            string dossier = "";
            string extension = "";
            int compteur = 1;
            foreach (string photosJpg in Directory.GetFiles(folderBrowserDialogRoot.SelectedPath, "*.jpg", SearchOption.TopDirectoryOnly))
            {
                // IMG_7037.JPG
                // D:\2010.08.31 Visite du Mont Saint Michel
                chemin = photosJpg.Substring(0, photosJpg.LastIndexOf("\\"));
                dossier = chemin.Substring(3);
                ancienNom = photosJpg.Substring(chemin.Length + 1);
                ancienNom = ancienNom.Substring(0, ancienNom.Length - 4);
                if (System.IO.File.Exists(chemin + "\\" + ancienNom + ".CR2"))
                {
                    extension = ".CR2";
                }
                else if (System.IO.File.Exists(chemin + "\\" + ancienNom + ".DNG"))
                {
                    extension = ".DNG";
                }
                //imagePhoto = System.Drawing.Image.FromFile(photosJpg)
                //nouveauNom = Format(GetDateTaken(imagePhoto), "yyyy.MM.dd-HH.mm.ss") & "_" & ancienNom
                //imagePhoto.Dispose()
                // %folder1%_%num%-%name%%ext%
                // 2010.08.31-12.22.43_IMG_7037
                nouveauNom = dossier + "_" + getCompt(compteur);
                nouveauNom = nouveauNom.Replace(".", "");
                nouveauNom = nouveauNom.Replace(",", "");
                nouveauNom = nouveauNom.Replace("-", "");
                nouveauNom = nouveauNom.Replace(" ", "");
                nouveauNom = nouveauNom.Insert(8, "_");
                nouveauNom = nouveauNom + "-" + ancienNom.Substring(20);
                //writeLog(nouveauNom)
                Directory.Move(photosJpg, chemin + "\\" + nouveauNom + ".jpg");
                writeLog("Renommage de la photo " + photosJpg + " en " + chemin + "\\" + nouveauNom + ".jpg");
                if (extension.Length > 0)
                {
                    Directory.Move(chemin + "\\" + ancienNom + extension, chemin + "\\" + nouveauNom + extension);
                    writeLog("Renommage de la photo " + chemin + "\\" + ancienNom + extension + " en " + chemin + "\\" + nouveauNom + extension);
                }
                compteur += 1;
            }
        }

        private void btn_selectRootPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialogRoot.ShowDialog();
            txtBox_rootPath.Text = folderBrowserDialogRoot.SelectedPath;
            dossierRoot = folderBrowserDialogRoot.SelectedPath;

        }

        private string getCompt(int compteur)
        {
            if (compteur < 10)
            {
                return "00" + compteur;
            }
            else if (compteur < 100)
            {
                return "0" + compteur;
            }
            else
            {
                return compteur.ToString();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lancementAutomatiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renommageDesPhotosToolStripMenuItem_Click(sender, e);
            toolStripMenuItem2_Click(sender, e);
            séparationDesPhotosRAWToolStripMenuItem_Click(sender,e);
            déplacementDesDossiersToolStripMenuItem_Click(sender, e);
        }

        private void orphelinsJPGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orphelinsRAWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchRawOrphans(folderBrowserDialogRoot.SelectedPath);
        //writeLog(colRawOrphans.Count & " Fichier(s) orphelin(s) trouvé(s) :")
        //For Each orphelin As String In colRawOrphans
        //    writeLog(orphelin)
        //Next
        }

        private string[] getFiles(string SourceFolder, string Filter, System.IO.SearchOption searchOption)
        {
            // ArrayList will hold all file names
            ArrayList alFiles = new ArrayList();

            // Create an array of filter string
            string[] MultipleFilters = Filter.Split('|');
            
            // for each filter find mathing file names
            foreach (string FileFilter in MultipleFilters)
            {
                // add found file names to array list
                alFiles.AddRange(Directory.GetFiles(SourceFolder, FileFilter, searchOption));
            }

            // returns string array of relevant file names
            return alFiles.OfType<object>().Select(o => o.ToString()).ToArray();
                //ToArray(Type.GetType("System.String"));
        }
        
        private void searchRawOrphans(string path)
        {
            
            string sourceFileExts = "*.dng|*.cr2";

            foreach (string fichierRaw in getFiles(folderBrowserDialogRoot.SelectedPath, sourceFileExts, SearchOption.AllDirectories))
            {
                if (checkOrphans(fichierRaw, "jpg"))
                {
                    writeLog(fichierRaw);
                }
            }
        }

        private bool checkOrphans(string fichierSource, string extensionToCheck)
        {
            return !System.IO.File.Exists(fichierSource.Substring(0, fichierSource.Length - 3) + extensionToCheck);
        }
        
        private void writeLog(string logText)
        {
            Thread threadLog = new Thread(new ThreadStart(() => ThreadWorker(logText)));
            threadLog.Start();

            //if (logbox.InvokeRequired)
            //{
            //    stringDelegate sd = new stringDelegate(writeLog);
            //    this.Invoke(sd, new object[] { logText });
            //}
            //else
            //{
            //    logbox.Text = string.Format("{0:yyyy.MM.dd HH:mm:ss ssss}", DateTime.Now) + " - " + logText + Environment.NewLine + logbox.Text;
            //}


            //if (logbox.Text != "")
            //{
            //    logbox.Text += Environment.NewLine;
            //}
            
            //logbox.Text += string.Format("{0:yyyy.MM.dd HH:mm:ss ssss}", DateTime.Now);
            //logbox.Text += " - ";
            //logbox.Text = logText + logbox.Text;
        }

        private void ThreadWorker(string logText)
        {
            if (logbox.InvokeRequired)
            {
                stringDelegate sd = new stringDelegate(ThreadWorker);
                this.Invoke(sd, new object[] { logText });
            }
            else
            {
                logbox.Text = string.Format("{0:yyyy.MM.dd HH:mm:ss ssss}", DateTime.Now) + " - " + logText + Environment.NewLine + logbox.Text;
            }
        }

        private void renommageDuDossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nouveauDossier = info.ToTitleCase(folderBrowserDialogRoot.SelectedPath);
            if (folderBrowserDialogRoot.SelectedPath != nouveauDossier)
            {
                string tmpNom = nouveauDossier + "_tmp";
                Directory.Move(folderBrowserDialogRoot.SelectedPath, tmpNom);
                Directory.Move(tmpNom, nouveauDossier);
                writeLog("Renommage du dossier " + folderBrowserDialogRoot.SelectedPath + " en " + nouveauDossier);
                txtBox_rootPath.Text = nouveauDossier;
                folderBrowserDialogRoot.SelectedPath = nouveauDossier;
                writeLog("Mis à jour de la sélection du dossier en " + nouveauDossier);
                //Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(dossierRoot, tmpNom);
                //Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory("D:\\" + tmpNom, nouveauDossier);
                //Interaction.MsgBox("dossier OK");
            }
            else
            {
                writeLog("Le dossier " + nouveauDossier + " est déjà correct");
            }
        }

        private void renommageDesPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nouveauNom = "";
            string ancienNom = "";
            string chemin = "";
            string extension = "";
            foreach (string photosJpg in Directory.GetFiles(folderBrowserDialogRoot.SelectedPath, "*.jpg", SearchOption.TopDirectoryOnly))
            {
                // IMG_7037.JPG
                // D:\2010.08.31 Visite du Mont Saint Michel
                chemin = photosJpg.Substring(0, photosJpg.LastIndexOf("\\"));
                ancienNom = photosJpg.Substring(chemin.Length + 1);
                ancienNom = ancienNom.Substring(0, ancienNom.Length - 4);
                if (File.Exists(chemin + "\\" + ancienNom + ".CR2"))
                {
                    extension = ".CR2";
                }
                else if (File.Exists(chemin + "\\" + ancienNom + ".DNG"))
                {
                    extension = ".DNG";
                }
                Image imagePhoto = System.Drawing.Image.FromFile(photosJpg);
                nouveauNom = string.Format("{0:yyyy.MM.dd-HH.mm.ss}", GetDateTaken(imagePhoto)) + "_" + ancienNom;
                imagePhoto.Dispose();
                Directory.Move(photosJpg, chemin + "\\" + nouveauNom + ".jpg");
                writeLog("Renommage de la photo " + photosJpg + " en " + chemin + "\\" + nouveauNom + ".jpg");
                if (extension.Length > 0)
                {
                    Directory.Move(chemin + "\\" + ancienNom + extension, chemin + "\\" + nouveauNom + extension);
                    writeLog("Renommage de la photo " + chemin + "\\" + ancienNom + extension + " en " + chemin + "\\" + nouveauNom + extension);
                }
            }

        }

        public DateTime GetDateTaken(Image targetImg)
        {
            //Property Item 306 corresponds to the Date Taken
            PropertyItem propItem = targetImg.GetPropertyItem(306);
            DateTime dtaken = default(DateTime);

            //Convert date taken metadata to a DateTime object
            string sdate = Encoding.UTF8.GetString(propItem.Value).Trim();
            string secondhalf = sdate.Substring(sdate.IndexOf(" "), (sdate.Length - sdate.IndexOf(" ")));
            string firsthalf = sdate.Substring(0, 10);
            firsthalf = firsthalf.Replace(":", "-");
            //secondhalf = secondhalf.Replace(":", "-")
            sdate = firsthalf + secondhalf;
            dtaken = DateTime.Parse(sdate);
            return dtaken;
        }

        private void listerLesPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (string photosJpg in Directory.GetFiles(folderBrowserDialogRoot.SelectedPath, "*", SearchOption.TopDirectoryOnly))
            {
                writeLog(photosJpg);
            }

        }

        private void séparationDesPhotosRAWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sourceFileExts = "*.dng|*.cr2";
            if (getFiles(folderBrowserDialogRoot.SelectedPath, sourceFileExts, SearchOption.AllDirectories).Length > 0)
            {
                string nomDossier = dossierRoot.Insert(dossierRoot.IndexOf(" "), "-RAW");
                if (!Directory.Exists(nomDossier))
                {
                    Directory.CreateDirectory(nomDossier);
                }

                foreach (string fichierRaw in getFiles(folderBrowserDialogRoot.SelectedPath, sourceFileExts, SearchOption.AllDirectories))
                {
                    Directory.Move(fichierRaw, nomDossier + "\\" + fichierRaw.Substring(fichierRaw.LastIndexOf("\\")));
                }

                writeLog("separation raw terminée");
            }
        }

        private void déplacementDesDossiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Directory.Exists(dossierPhotos)) & (Directory.Exists(dossierPhotosRaw)))
            {
                string nomDossier = dossierRoot.Insert(dossierRoot.IndexOf(" "), "-RAW");
                string nomNouveauDossier = dossierRoot.Insert(dossierRoot.IndexOf("\\") + 1, "Photos\\");
                string nomNouveauDossierRaw = nomDossier.Insert(nomDossier.IndexOf("\\") + 1, "Photos RAW\\");
                Directory.Move(dossierRoot, nomNouveauDossier);
                if (Directory.Exists(nomDossier))
                {
                    Directory.Move(nomDossier, nomNouveauDossierRaw);
                }
            }
            writeLog("deplacement terminé");

        }

        private void lancementManuelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
