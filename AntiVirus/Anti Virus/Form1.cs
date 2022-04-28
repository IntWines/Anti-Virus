using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Anti_Virus
{
    public partial class frmVCKS : Form
    {
        int viruses;
        string[] virusList = new string[] { "virus", "trojan", "hack", "hacker" };
        public frmVCKS()
        {
            InitializeComponent();
            pctVirus.Hide();
            pctNoVirus.Hide();
            pctNeutral.Show();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lblFolder.Text = folderBrowserDialog1.SelectedPath;
            viruses = 0;
            lblVirus.Text = "Viruses : " + viruses.ToString();
            progressBar1.Value = 0;
            listBox1.Items.Clear();
            pctNeutral.Show();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            List<string> search = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.*").ToList();
            progressBar1.Maximum = search.Count;
            foreach(string item in search)
            {
                try
                {
                    StreamReader stream = new StreamReader(item);
                    string read = stream.ReadToEnd();

                    foreach(string st in virusList)
                    {
                        if(Regex.IsMatch(read,st))
                        {
                            viruses += 1;
                            lblVirus.Text = "Viruses : " + viruses.ToString();
                            listBox1.Items.Add(item);

                        }
                        progressBar1.Increment(1);

                        if(viruses <= 0)
                        {
                            lblSikker.Text = "Filene er sikker!";
                            pctVirus.Hide();
                            pctNeutral.Hide();
                            pctNoVirus.Show();
                        }

                        if (viruses >= 1)
                        {
                            lblSikker.Text = "Filene er usikker!";
                            pctNoVirus.Hide();
                            pctNeutral.Hide();
                            pctVirus.Show();
                        }

                    }

                }
                catch (Exception ex)
                {
                //
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
