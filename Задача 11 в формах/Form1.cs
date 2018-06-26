using System;
using static Control.Program;
using System.IO;
using System.Windows.Forms;

namespace Задача_11_в_формах
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Click()
        {
            OutDecrypt.Text = "";
            OutEncrypt.Text = "";
        }

        private void OpenMatrix_Click(object sender, EventArgs e)
        {
            Click();
            OpenFileDialog dialogDocumentOpen = new OpenFileDialog
            {
                InitialDirectory =
                    "c:\\Users\\Василий\\Desktop\\Задача 11",
                Filter = @"Текстовые файлы (*.txt)|*.txt"
            };
            if (dialogDocumentOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader inputMatrix = new StreamReader(dialogDocumentOpen.FileName);
                    matrix = ReadMatrix(inputMatrix, out okReading);
                    if(!okReading)
                        MessageBox.Show("Ошибка при чтении матрицы - ключа (возможно не является ключом)", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Ошибка: не удалось считать файл с диска. Источник ошибки: " + ex.Message);
                }
            }
        }

        private void FAQ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Василюк Василий, ПИ-17-1\nуч. практика 1 курс, 2017-18 гг.Задача №11 (838).\nДоброго времени суток!\n" +
                "Данная программа шифрует и расшифровывает заданную последовательность (string.txt)," +
                "при помощи заданной матрицы-ключа (matrix.txt)\nПриятного пользования!", "Справка",
                MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Вы уверены, что хотите выйти?", @"Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void OpenString_Click(object sender, EventArgs e)
        {
            Click();
            OpenFileDialog dialogDocumentOpen = new OpenFileDialog
            {
                InitialDirectory =
                    "c:\\Users\\Василий\\Desktop\\Задача 11",
                Filter = @"Текстовые файлы (*.txt)|*.txt"
            };
            if (dialogDocumentOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader inputString = new StreamReader(dialogDocumentOpen.FileName);
                    symbols = ReadString(inputString, out okReading);
                    if (!okReading)
                        MessageBox.Show("Ошибка при чтении строки (возможно длина строки превышает 100 символов)", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Ошибка: не удалось считать файл с диска. Источник ошибки: " + ex.Message);
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string[] result = new string[] { "Зашифрованная последовательность:", cryptSymbols, "Расшифрованная последовательность:", decryptedSymbols};
            SaveFileDialog dialogDocumentSave = new SaveFileDialog
            {
                InitialDirectory =
                    "c:\\Users\\Василий\\Desktop\\Задача 11",
                Filter = @"Текстовые файлы (*.txt)|*.txt"
            };
            if (dialogDocumentSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllLines(dialogDocumentSave.FileName,result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Ошибка: не удалось считать файл с диска. Источник ошибки: " + ex.Message);
                }
            }
        }

        private void Form1Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Вы уверены, что хотите выйти?", @"Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void Crypt_Click(object sender, EventArgs e)
        {
            if (okReading)
            {
                cryptSymbols = Encrypt(matrix, symbols);
                OutEncrypt.Text = cryptSymbols;
                decryptedSymbols = Decipher(matrix, cryptSymbols);
                OutDecrypt.Text = decryptedSymbols;
            }
            else
                MessageBox.Show("Ошибка при чтении матрицы или строки", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
