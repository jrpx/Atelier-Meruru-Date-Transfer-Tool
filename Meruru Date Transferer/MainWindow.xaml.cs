using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Meruru_Date_Transferer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // warning: this function may have an off-by-one error on the dest. 
        private void performTransfer(string infile, string outfile, int start, int finish)
        {
            FileStream inFileStream = new System.IO.FileStream(infile, FileMode.Open, FileAccess.Read, FileShare.None);
            FileStream outFileStream = new System.IO.FileStream(outfile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            inFileStream.Seek(start, SeekOrigin.Begin);
            outFileStream.Seek(start, SeekOrigin.Begin);

            for (int i = start; i < finish; i++)
            {
                int byteCasted = inFileStream.ReadByte();
                if (byteCasted != -1)
                {
                    byte b = (byte)byteCasted;
                    outFileStream.WriteByte(b);
                }

            }

            inFileStream.Close();
            outFileStream.Close();
        }

        private void InputSaveButton_Click(object sender, RoutedEventArgs e)
        {
            string filename = getFile();
            if (filename != "")
            {
                inputFileTextBox.Text = filename;
            }
        }

        private string getFile()
        {
            Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();

            openFileDialog1.Title = "(steam directory)\\UserData\\(your steam id)\\936190\\Remote\\SAVEDATA";
            openFileDialog1.DefaultExt = "";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == true)
            {
                return openFileDialog1.FileName;
            }

            return "";
        }

        private void OutputSaveButton_Click(object sender, RoutedEventArgs e)
        {
            string filename = getFile();
            if (filename != "")
            {
                outputFileTextBox.Text = filename;
            }
        }

        private void DateButton_Click(object sender, RoutedEventArgs e)
        {
            string input = inputFileTextBox.Text;
            string output = outputFileTextBox.Text;

            if ((input == "") || (output == ""))
            {
                MessageBox.Show("We need an input and output file", "Error", MessageBoxButton.OK);
                return;
            }
            if ((input == output))
            {
                MessageBox.Show("Input and output are the same. They need to be different", "Error", MessageBoxButton.OK);
                return;
            }

            performTransfer(input, output, 0x5493E, 0x5493F);

            MessageBox.Show("Hopefully save file will be modified with the new data and not have any bugs. Have fun!", "Done!", MessageBoxButton.OK);
        }
    }
}
