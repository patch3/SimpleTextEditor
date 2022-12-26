using LibraryLab13;

namespace WinFormsApp1 {
    public partial class Form2 : Form {

        public string DataBuf = string.Empty;

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
            FolderBrowserDialog _newPath = new FolderBrowserDialog();
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
            if (listBox1.SelectedItem == null) {
                WalkDirectory("Файл не выьран");
                return;
            }
            DataBuf = listBox1.SelectedItem.ToString();
            this.Close();
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
                case "Количеству слов":
                    _filesList.SortByCountWord();
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox1.Items.Count <= 0) return;
            SortKistFile();
        }
    }
}
