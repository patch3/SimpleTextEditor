using LibraryLab13;
using System.IO;
using static System.Net.WebRequestMethods;

namespace WinFormsApp1 {
    public partial class Form2 : Form {

        public string DataBuf = string.Empty;

        private FolderBrowserDialog _newPath;

        private TextMoreFiles _filesList;

        public string _path;

        public string Path {
            get => _path;
            private set => _path = value;
        }

        public Form2() {
            InitializeComponent();
        }

        private void NewCatalogClick(object sender, EventArgs e) {
            _newPath = new FolderBrowserDialog();
            if (_newPath.ShowDialog() == DialogResult.Cancel) return;

            _path = _newPath.SelectedPath;

            label2.Text = "Выбранный католог: " + _path;

            WalkDirectory(_path);
        }



        private void button2_Click(object sender, EventArgs e) {
            WalkDirectory(_path);
        }


        private void WalkDirectory(string dirPath) {
            listBox1.Items.Clear();
            _filesList = new TextMoreFiles();
            foreach (string filePath in Directory.EnumerateFiles(dirPath)) {
                if (System.IO.Path.GetExtension(filePath) == ".txt") {
                    listBox1.Items.Add(filePath);
                    _filesList.Add(new TextFile(filePath));
                }
            }
            SortKistFile();
        }



        private void OpenFileClick(object sender, EventArgs e) {
            DataBuf = _path + listBox1.SelectedItem.ToString();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
            SortKistFile();
            foreach (TextFile file in _filesList) {
                listBox1.Items.Add(file.FilePath);
            }
        }
        /// <summary>
        /// Сортировка по выбраному режиму
        /// </summary>
        private void SortKistFile() {
            switch (comboBox1.SelectedItem.ToString()) {
                case "Имени":
                    _filesList.SortByPath();
                    break;
                case "Размеру":
                    _filesList.SortByLength();
                    break;
                case "количеству слов":
                    _filesList.SortByCountWord();
                    break;
            }
        }
    }
}
