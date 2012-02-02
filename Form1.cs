using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SRTEditor
{
    public partial class Form1 : Form
    {
        List<string> _timingsEng;
        List<string> _english;
        List<string> _timingsLoj;
        List<string> _lojban;
        int currentEngPosition;
        int currentLojPosition;

        public Form1()
        {
            InitializeComponent();
#if DEBUG
            checkPreferences();

            //if this isn't there, load my usual preferences.
            if (DualTextBox.Text == "")
            {
                OpenTextBox.Text = @"C:\Users\Ross\Dropbox\Documents\Lojban\Scott Pilgrim vs the World (2010)[Eng].srt";
                SaveTextBox.Text = @"C:\Users\Ross\Dropbox\Documents\Lojban\Scott Pilgrim vs the World (2010)[Loj].srt";
                DualTextBox.Text = @"C:\Users\Ross\Dropbox\Documents\Lojban\Scott Pilgrim vs the World (2010)[Eng+Loj].srt";
                LoadEngFile(OpenTextBox.Text);
                LoadEngInfo(0);
                LoadLojFile(SaveTextBox.Text);
                LoadLojInfo(0);
            }
#else
            checkPreferences();
#endif
        }

        private void checkPreferences()
        {
            FileInfo fi = new FileInfo(Application.UserAppDataPath + "\\prefs.txt");

            try
            {
                if (fi.Exists)
                    using (StreamReader sr = fi.OpenText())
                    {
                        //if the preferences don't start with this, assume that they are no good.
                        if (sr.ReadLine() != "SRT Preferences")
                            return;

                        OpenTextBox.Text = sr.ReadLine();
                        SaveTextBox.Text = sr.ReadLine();
                        DualTextBox.Text = sr.ReadLine();
                        string engPos_ = sr.ReadLine();
                        string lojPos_ = sr.ReadLine();
                        int engPos = engPos_ != "" ? c(engPos_) : -1;
                        int lojPos = lojPos_ != "" ? c(lojPos_) : -1;

                        if (OpenTextBox.Text != "")
                        {
                            LoadEngFile(OpenTextBox.Text);

                            if (engPos >= 0 && engPos < _english.Count)
                                LoadEngInfo(engPos);
                            else
                                LoadEngInfo(0);
                        }

                        if (SaveTextBox.Text != "")
                        {
                            LoadLojFile(SaveTextBox.Text);

                            if (lojPos >= 0 && lojPos < _lojban.Count)
                                LoadLojInfo(lojPos);
                            else
                                LoadLojInfo(0);
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retriving preferences from file " + fi.FullName + "\r\nError: \r\n" + ex.Message);
            }
        }

        private void writePreferences()
        {
            DirectoryInfo di = new DirectoryInfo(Application.UserAppDataPath);
            FileInfo fi = new FileInfo(Application.UserAppDataPath + "\\prefs.txt");

            try
            {
                if (!di.Exists)
                    di.Create();

                if (!fi.Exists)
                    fi.Create();

                using (StreamWriter sw = fi.CreateText())
                {
                    sw.WriteLine("SRT Preferences");
                    sw.WriteLine(OpenTextBox.Text);
                    sw.WriteLine(SaveTextBox.Text);
                    sw.WriteLine(DualTextBox.Text);
                    sw.WriteLine(currentEngPosition);
                    sw.WriteLine(currentLojPosition);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving preferences from file " + fi.FullName + "\r\nError: \r\n" + ex.Message);
            }

        }

        private void LoadEngInfo(int position)
        {
            if (position >= 0 && position < _english.Count)
            {
                currentEngPosition = position;
                IndexEngLabel.Text = (position + 1).ToString() + "/" + _english.Count;
                TimeEngTextBox.Text = _timingsEng[position];
                EnglishTextBox.Text = _english[position];

            }
        }

        private void LoadLojInfo(int position)
        {
            if (position >= 0 && position < _lojban.Count)
            {
                currentLojPosition = position;
                IndexLojLabel.Text = (position + 1).ToString() + "/" + _lojban.Count;
                TimeLojTextBox.Text = _timingsLoj[position];
                LojbanTextBox.Text = _lojban[position];
            }
        }

        private void SaveInfo()
        {
            _timingsLoj[currentLojPosition] = TimeLojTextBox.Text;
            _lojban[currentLojPosition] = LojbanTextBox.Text;
        }

        private void LoadEngFile(string path)
        {
            try
            {
                _timingsEng = new List<string>();
                _english = new List<string>();

                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        sr.ReadLine(); //number
                        _timingsEng.Add(sr.ReadLine());
                        string text = "";
                        for (string s = sr.ReadLine(); s != ""; s = sr.ReadLine())
                        {
                            text += s + "\r\n";
                        }
                        text = text.Trim(); //get rid of trailing newline char
                        _english.Add(text);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Failed to load English SRT File. Error: \r\n" + e.Message);
            }
        }
        private void LoadLojFile(string path)
        {
            try
            {
                _timingsLoj = new List<string>();
                _lojban = new List<string>();

                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        sr.ReadLine(); //number
                        _timingsLoj.Add(sr.ReadLine());
                        string text = "";
                        for (string s = sr.ReadLine(); s != ""; s = sr.ReadLine())
                        {
                            text += s + "\r\n";
                        }
                        text = text.Trim(); //get rid of trailing newline char
                        _lojban.Add(text);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to load Lojban SRT File. Error: \r\n" + e.Message);
            }
        }

        #region movement buttons
        private void PrevButton_Click(object sender, EventArgs e)
        {
            SaveInfo();
            LoadEngInfo(currentEngPosition - 1);
            LoadLojInfo(currentLojPosition - 1);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            SaveInfo();
            LoadEngInfo(currentEngPosition + 1);
            LoadLojInfo(currentLojPosition + 1);
        }

        private void PrevEngButton_Click(object sender, EventArgs e)
        {
            LoadEngInfo(currentEngPosition - 1);
        }

        private void NextEngButton_Click(object sender, EventArgs e)
        {
            LoadEngInfo(currentEngPosition + 1);
        }

        private void PrevLojButton_Click(object sender, EventArgs e)
        {
            SaveInfo();
            LoadLojInfo(currentLojPosition - 1);
        }

        private void NextLojButton_Click(object sender, EventArgs e)
        {
            SaveInfo();
            LoadLojInfo(currentLojPosition + 1);
        }

        private void InsertLojButton_Click(object sender, EventArgs e)
        {
            _timingsLoj.Insert(currentLojPosition+1, "");
            _lojban.Insert(currentLojPosition+1, "");
            LoadLojInfo(currentLojPosition + 1);
        }

        private void DeleteLojButton_Click(object sender, EventArgs e)
        {
            _timingsLoj.RemoveAt(currentLojPosition);
            _lojban.RemoveAt(currentLojPosition);
            LoadLojInfo(currentLojPosition);
        }

        private void JumpButton_Click(object sender, EventArgs e)
        {
            SaveInfo();
            int distance = Convert.ToInt32(JumpTextBox.Text);
            LoadEngInfo(currentEngPosition + distance);
            LoadLojInfo(currentLojPosition + distance);
        }
#endregion

        #region output functions
        private void OutputBothButton_Click(object sender, EventArgs earg)
        {
            SaveInfo();

            List<string> dual = new List<string>();
            List<string> dualtimings = new List<string>();

            int l = 0;
            int e = 0;

            while (l < _lojban.Count && e < _english.Count)
            {
                double i = compareTimings(_timingsEng[e],_timingsLoj[l]);
                if (i == 0)
                {
                    //timings match, do a merge
                    dualtimings.Add(_timingsLoj[l]);
                    string s = _english[e].Replace("\r\n", " ");
                    s += "\r\n";
                    s += _lojban[l].Replace("\r\n", " ");
                    dual.Add(s);

                    e++;
                    l++;
                }
                else if (i < 0)
                {
                    //an extra english is present, add it
                    dualtimings.Add(_timingsEng[e]);
                    dual.Add(_english[e]);
                    e++;
                }
                else if (i > 0)
                {
                    //an extra lojban is present, add it
                    dualtimings.Add(_timingsLoj[l]);
                    dual.Add(_lojban[l]);
                    l++;
                }
            }
            //throw all the remaining ones in
            if (l != _lojban.Count)
            {
                for (int i = l; i < _lojban.Count; i++)
                {
                    dualtimings.Add(_timingsLoj[i]);
                    dual.Add(_lojban[i]);
                }
            }
            if (e != _english.Count)
            {
                for (int i = e; i < _english.Count; i++)
                {
                    dualtimings.Add(_timingsEng[i]);
                    dual.Add(_english[i]);
                }
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(DualTextBox.Text))
                {
                    for (int i = 0; i < dual.Count; i++)
                    {
                        sw.WriteLine((i + 1).ToString());
                        sw.WriteLine(dualtimings[i]);
                        sw.WriteLine(dual[i]);
                        sw.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save Dual SRT File. Error: \r\n" + ex.Message);
            }

        }

        private void SaveLojButton_Click(object sender, EventArgs e)
        {
            SaveInfo();

            try
            {
                using (StreamWriter sw = new StreamWriter(SaveTextBox.Text))
                {
                    for (int i = 0; i < _lojban.Count; i++)
                    {
                        sw.WriteLine((i + 1).ToString());
                        sw.WriteLine(_timingsLoj[i]);
                        sw.WriteLine(_lojban[i]);
                        sw.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save Lojban SRT File. Error: \r\n" + ex.Message);
            }
        }
        #endregion

        #region misc utilities
        private double compareTimings(string first, string second)
        {
            double f = c(first[0]) * 10 * 60 * 60 + c(first[1]) * 60 * 60 + c(first[3]) * 10 * 60 + c(first[4]) * 60 + c(first[6])*10 + c(first[7]);
            f += c(first[9]) * 0.1 + c(first[10]) * 0.01 + c(first[11]) * 0.001;
            double s = c(second[0]) * 10 * 60 * 60 + c(second[1]) * 60 * 60 + c(second[3]) * 10 * 60 + c(second[4]) * 60 + c(second[6]) * 10 + c(second[7]);
            s += c(second[9]) * 0.1 + c(second[10]) * 0.01 + c(second[11]) * 0.001;
            return f - s;
        }

        private int c(char c)
        {
            return Convert.ToInt32(c);
        }

        private int c(string c)
        {
            return Convert.ToInt32(c);
        }
#endregion      

        //Shorcut keys
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.Right)
                NextButton_Click(this, new EventArgs());
            if (e.Alt && e.KeyCode == Keys.Left)
                PrevButton_Click(this, new EventArgs());
            if (e.Alt && e.KeyCode == Keys.Up)
                PrevLojButton_Click(this, new EventArgs());
            if (e.Alt && e.KeyCode == Keys.Down)
                NextLojButton_Click(this, new EventArgs());
        }

        #region choose file stuff
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenTextBox.Text = openFileDialog1.FileName;
            LoadEngFile(OpenTextBox.Text);
            LoadEngInfo(0);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void SavePathButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            SaveTextBox.Text = saveFileDialog1.FileName;
            LoadLojFile(SaveTextBox.Text);
            LoadLojInfo(0);
        }

        private void DualPathButton_Click(object sender, EventArgs e)
        {
            saveFileDialog2.ShowDialog();
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            DualTextBox.Text = saveFileDialog2.FileName;
        }
        #endregion

        //confirm before quitting
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            writePreferences();

            DialogResult dr = MessageBox.Show("Are you sure you want to quit? (Unsaved work will be lost)", "Quit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                e.Cancel = true;
        }
    }
}
