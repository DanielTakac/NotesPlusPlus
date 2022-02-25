using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Notes__ {

    public partial class Form1 : Form {

        // This variable gets loaded from config.json so if you want to change it got there
        bool extraSecure;

        // Used for making round corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Form1() {

            InitializeComponent();

            // Makes round corners
            SavePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SavePanel.Width, SavePanel.Height, 20, 20));
            OpenPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, OpenPanel.Width, OpenPanel.Height, 20, 20));

            SavePanel.Visible = false;
            OpenPanel.Visible = false;

            LoadConfig();

        }

        private void LoadConfig() {

            var json = string.Empty;

            using (var fs = File.OpenRead("config.json"))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
            json = sr.ReadToEnd();


            var config = JsonConvert.DeserializeObject<Config>(json);

            extraSecure = config.ExtraSecure;

        }

        public class Config {

            public bool ExtraSecure { get; set; }

        }

        private void NewButton_Click(object sender, EventArgs e) {

            TextArea.Text = string.Empty;

        }

        private void NewWindowButton_Click(object sender, EventArgs e) {

            // Starts another instance of this app
            string path = Environment.CurrentDirectory + @"\Notes++.exe";
            Process.Start(path);

        }

        private void SaveButton_Click(object sender, EventArgs e) {

            SavePanel.Visible = true;

        }

        private void OpenButton_Click(object sender, EventArgs e) {

            OpenPanel.Visible = true;

        }

        private void SaveConfirmButton_Click(object sender, EventArgs e) {

            string fileName = SaveInputTextBox.Text;
            string fileContent = TextArea.Text;

            //Saves the text to a file
            File.WriteAllText($"{fileName}.txt", fileContent);

            SaveInputTextBox.Text = string.Empty;
            SavePanel.Visible = false;

        }

        private void SaveAsHashConfirmButton_Click(object sender, EventArgs e) {

            string fileName = SaveInputTextBox.Text;
            string fileContent = TextArea.Text;

            string hashedText;

            if (extraSecure) {

                hashedText = Hash.StringToBinary(fileContent);
                hashedText = Hash.StringToHex(hashedText);
                hashedText = Hash.HashString(hashedText);

            } else {

                hashedText = Hash.HashString(fileContent);

            }

            //Saves the text to a file
            File.WriteAllText($"{fileName}.txt", hashedText);

            SaveInputTextBox.Text = string.Empty;
            SavePanel.Visible = false;

        }

        private void OpenConfirmButton_Click(object sender, EventArgs e) {

            string fileName = OpenInputTextBox.Text;
            string fileContent;

            fileContent = File.ReadAllText($"{fileName}.txt");

            TextArea.Text = fileContent;

            OpenInputTextBox.Text = string.Empty;
            OpenPanel.Visible = false;

        }

        private void OpenHashConfirmButton_Click(object sender, EventArgs e) {

            string fileName = OpenInputTextBox.Text;
            string fileContent;

            if (extraSecure) {

                fileContent = File.ReadAllText($"{fileName}.txt");
                fileContent = Hash.UnhashString(fileContent);
                fileContent = Hash.HexToString(fileContent);
                fileContent = Hash.BinaryToString(fileContent);

            } else {

                fileContent = File.ReadAllText($"{fileName}.txt");
                fileContent = Hash.UnhashString(fileContent);

            }

            TextArea.Text = fileContent;

            OpenInputTextBox.Text = string.Empty;
            OpenPanel.Visible = false;

        }

        private void ExitButton_Click(object sender, EventArgs e) {

            // Closes the application
            Environment.Exit(0);

        }

    }

}