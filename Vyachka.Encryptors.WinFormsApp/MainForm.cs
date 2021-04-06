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

namespace Vyachka.Encryptors
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeFileFilters();
        }

        private void InitializeFileFilters()
        {
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = @"txt files (.txt)|*.txt";
        }

        public enum Method
        {
            RailFence, Column, Vigener, EMPTY
        }

        private Method DetermineMethod()
        {
            if(RailFenceRBtn.Checked)
            {
                return Method.RailFence;
            }

            if(ColumnRBtn.Checked)
            {
                return Method.Column;
            }

            if(VigenerRBtn.Checked)
            {
                return Method.Vigener;
            }

            return Method.EMPTY;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenToEncryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            string line;
            string text = "";
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog.FileName);
                    line = sr.ReadLine();
                    text += line;
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        text += line;
                    }
                    sr.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong with opening text...");
                }

                PlainTextBox.Text = text;
            }
        }

        private void OpenToDecryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            string line;
            string text = "";
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog.FileName);
                    line = sr.ReadLine();
                    text += line;
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        text += line;
                    }
                    sr.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong with opening text...");
                }

                CipherTextBox.Text = text;
            }
        }

        private void SavePlainTextStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    //Pass the filepath and filename to the StreamWriter Constructor
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    //Write a line of text
                    sw.WriteLine(PlainTextBox.Text);
                    //Close the file
                    sw.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong with saving plain text...");
                }
            }
        }

        private void SaveCipherTextStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    //Pass the filepath and filename to the StreamWriter Constructor
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    //Write a line of text
                    sw.WriteLine(CipherTextBox.Text);
                    //Close the file
                    sw.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong with saving cipher text...");
                }
            }
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            string plainText = "";
            string key = "";
            Method method = DetermineMethod();
            if(!(method == Method.EMPTY))
            {
                switch(method)
                {
                    case Method.RailFence:
                        plainText = Filter.FilterText(PlainTextBox.Text, "eng");
                        key = Filter.FilterText(KeyTextBox.Text, "num");
                        break;

                    case Method.Column:
                        plainText = Filter.FilterText(PlainTextBox.Text, "eng");
                        key = Filter.FilterText(KeyTextBox.Text, "eng");
                        break;

                    case Method.Vigener:
                        plainText = Filter.FilterText(PlainTextBox.Text, "rus");
                        key = Filter.FilterText(KeyTextBox.Text, "rus");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please, choose the encryption method.");
            }

            if(!(method == Method.EMPTY) && IsCorrectKey(key, method) && IsCorrectText(plainText))
            {
                EncryptPlainText(plainText, key, method);
            }
        }

        private void EncryptPlainText(string plainText, string key, Method method)
        {
            switch(method)
            {
                case Method.RailFence:
                    CipherTextBox.Text = RailFenceEncryptor.Encrypt(plainText, key);
                    break;

                case Method.Column:
                    CipherTextBox.Text = ColumnEncryptor.Encrypt(plainText, key);
                    break;

                case Method.Vigener:
                    CipherTextBox.Text = VigenerEncryptor.Encrypt(plainText, key);
                    break;
            }
        }

        private bool IsCorrectKey(string key, Method method)
        {
            switch(method)
            {
                case Method.RailFence:
                    if(IsKeyLengthHigherThanZero(key) && IsKeyNotOverFlowed(key) 
                        && IsKeyHigherThanZero(key))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case Method.Column:
                case Method.Vigener:
                    if(IsKeyLengthHigherThanZero(key))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                default:
                    return false;
            }
        }

        private bool IsKeyHigherThanZero(string strKey)
        {
            int key = int.Parse(strKey);
            if(key > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Key must be greater than 0. Please fix it.");
                return false;
            }
        }

        private bool IsKeyLengthHigherThanZero(string key)
        {
            if(key.Length > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("There are no matching characters for current " +
                                "alphabet in your KEY. \nPlease, fix it.");
                KeyTextBox.Text = "";
                return false;
            }
        }

        private bool IsKeyNotOverFlowed(string strKey)
        {
            try
            {
                int key = int.Parse(strKey);
            }
            catch(FormatException)
            {
                MessageBox.Show("Your key is too big. Please, fix it.");
                return false;
            }

            return true;
        }

        private bool IsCorrectText(string text)
        {
            if(text.Length > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("There are no matching characters for current " +
                                "alphabet in your TEXT. \nPlease, fix it.");
                PlainTextBox.Text = "";
                CipherTextBox.Text = "";
                return false;
            }
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            string cipherText = "";
            string key = "";
            Method method = DetermineMethod();
            if (!(method == Method.EMPTY))
            {
                switch (method)
                {
                    case Method.RailFence:
                        cipherText = Filter.FilterText(CipherTextBox.Text, "eng");
                        key = Filter.FilterText(KeyTextBox.Text, "num");
                        break;

                    case Method.Column:
                        cipherText = Filter.FilterText(CipherTextBox.Text, "eng");
                        key = Filter.FilterText(KeyTextBox.Text, "eng");
                        break;

                    case Method.Vigener:
                        cipherText = Filter.FilterText(CipherTextBox.Text, "rus");
                        key = Filter.FilterText(KeyTextBox.Text, "rus");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please, choose the encryption method.");
            }

            if (!(method == Method.EMPTY) && IsCorrectKey(key, method) && IsCorrectText(cipherText))
            {
                DecryptPlainText(cipherText, key, method);
            }
        }

        private void DecryptPlainText(string cipherText, string key, Method method)
        {
            switch (method)
            {
                case Method.RailFence:
                    PlainTextBox.Text = RailFenceEncryptor.Decrypt(cipherText, key);
                    break;

                case Method.Column:
                    PlainTextBox.Text = ColumnEncryptor.Decrypt(cipherText, key);
                    break;

                case Method.Vigener:
                    PlainTextBox.Text = VigenerEncryptor.Decrypt(cipherText, key);
                    break;
            }
        }
    }
}
