namespace WinFormsApp1 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьИВыводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьСкрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариантToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравнениеФайловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискФайловВКатологеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоСловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.открытьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.печатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NumWords = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumChar = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumStrings = new System.Windows.Forms.ToolStripStatusLabel();
            this.State = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.параметрыToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.печатьИВыводToolStripMenuItem,
            this.выводToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.FileOpenClick);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.FileSaveClick);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.FileSaveAsClick);
            // 
            // печатьИВыводToolStripMenuItem
            // 
            this.печатьИВыводToolStripMenuItem.Name = "печатьИВыводToolStripMenuItem";
            this.печатьИВыводToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.печатьИВыводToolStripMenuItem.Text = "Печать";
            // 
            // выводToolStripMenuItem
            // 
            this.выводToolStripMenuItem.Name = "выводToolStripMenuItem";
            this.выводToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.выводToolStripMenuItem.Text = "Вывод";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem,
            this.показатьСкрытьToolStripMenuItem});
            this.параметрыToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            // 
            // показатьСкрытьToolStripMenuItem
            // 
            this.показатьСкрытьToolStripMenuItem.Name = "показатьСкрытьToolStripMenuItem";
            this.показатьСкрытьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.показатьСкрытьToolStripMenuItem.Text = "Показать/Скрыть";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вариантToolStripMenuItem,
            this.сравнениеФайловToolStripMenuItem,
            this.поискФайловВКатологеToolStripMenuItem,
            this.количествоСловToolStripMenuItem});
            this.поискToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // вариантToolStripMenuItem
            // 
            this.вариантToolStripMenuItem.Name = "вариантToolStripMenuItem";
            this.вариантToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.вариантToolStripMenuItem.Text = "Вариант";
            // 
            // сравнениеФайловToolStripMenuItem
            // 
            this.сравнениеФайловToolStripMenuItem.Name = "сравнениеФайловToolStripMenuItem";
            this.сравнениеФайловToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.сравнениеФайловToolStripMenuItem.Text = "Сравнение файлов";
            // 
            // поискФайловВКатологеToolStripMenuItem
            // 
            this.поискФайловВКатологеToolStripMenuItem.Name = "поискФайловВКатологеToolStripMenuItem";
            this.поискФайловВКатологеToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.поискФайловВКатологеToolStripMenuItem.Text = "Поиск файлов в катологе";
            this.поискФайловВКатологеToolStripMenuItem.Click += new System.EventHandler(this.SearchFilesTheDirectoryClick);
            // 
            // количествоСловToolStripMenuItem
            // 
            this.количествоСловToolStripMenuItem.Name = "количествоСловToolStripMenuItem";
            this.количествоСловToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.количествоСловToolStripMenuItem.Text = "Количество слов";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАвтореToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton,
            this.открытьToolStripButton,
            this.toolStripButton3,
            this.toolStripButton1,
            this.сохранитьToolStripButton,
            this.печатьToolStripButton,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(700, 57);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripButton
            // 
            this.ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton.Image")));
            this.ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton.Name = "ToolStripButton";
            this.ToolStripButton.Size = new System.Drawing.Size(54, 54);
            this.ToolStripButton.Text = "&Открыть";
            this.ToolStripButton.Click += new System.EventHandler(this.FileOpenClick);
            // 
            // открытьToolStripButton
            // 
            this.открытьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.открытьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripButton.Image")));
            this.открытьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripButton.Name = "открытьToolStripButton";
            this.открытьToolStripButton.Size = new System.Drawing.Size(54, 54);
            this.открытьToolStripButton.Text = "&Открыть";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::WinFormsApp1.Properties.Resources.bin_trash_delete_remove_recycle_icon_146878;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WinFormsApp1.Properties.Resources.save_file_disk_open_searsh_loading_clipboard_1513;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.FileSaveClick);
            // 
            // сохранитьToolStripButton
            // 
            this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolStripButton.Image = global::WinFormsApp1.Properties.Resources.diskette_save_saveas_1514;
            this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            this.сохранитьToolStripButton.Size = new System.Drawing.Size(54, 54);
            this.сохранитьToolStripButton.Text = "&Сохранить";
            this.сохранитьToolStripButton.Click += new System.EventHandler(this.FileSaveAsClick);
            // 
            // печатьToolStripButton
            // 
            this.печатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.печатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripButton.Image")));
            this.печатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.печатьToolStripButton.Name = "печатьToolStripButton";
            this.печатьToolStripButton.Size = new System.Drawing.Size(54, 54);
            this.печатьToolStripButton.Text = "&Печать";
            this.печатьToolStripButton.Click += new System.EventHandler(this.PrintPageClick);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WinFormsApp1.Properties.Resources.emblemunreadable_93487;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(700, 295);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NumWords,
            this.NumChar,
            this.NumStrings,
            this.State});
            this.statusStrip1.Location = new System.Drawing.Point(0, 370);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(700, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NumWords
            // 
            this.NumWords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NumWords.LinkColor = System.Drawing.Color.Black;
            this.NumWords.Name = "NumWords";
            this.NumWords.Size = new System.Drawing.Size(74, 17);
            this.NumWords.Text = "Число слов:";
            // 
            // NumChar
            // 
            this.NumChar.Name = "NumChar";
            this.NumChar.Size = new System.Drawing.Size(85, 17);
            this.NumChar.Text = "Число знаков:";
            // 
            // NumStrings
            // 
            this.NumStrings.Name = "NumStrings";
            this.NumStrings.Size = new System.Drawing.Size(43, 17);
            this.NumStrings.Text = "Строк:";
            // 
            // State
            // 
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(69, 17);
            this.State.Text = "Состояние:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Текстовый файл(*.txt)|*.txt|Файл rtf(*.rtf)|*.rtf|Все файлы(*.*)|*.*";
            this.openFileDialog1.Title = "Открыть";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Текстовый файл(*.txt)|*.txt|Файл rtf(*.rtf)|*.rtf|Все файлы(*.*)|*.*";
            this.saveFileDialog1.Title = "Сохранить";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(700, 392);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem параметрыToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton ToolStripButton;
        private ToolStripButton открытьToolStripButton;
        private ToolStripButton печатьToolStripButton;
        private ToolStripButton сохранитьToolStripButton;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private RichTextBox richTextBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel NumWords;
        private ToolStripStatusLabel NumChar;
        private ToolStripStatusLabel NumStrings;
        private ToolStripStatusLabel State;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem печатьИВыводToolStripMenuItem;
        private ToolStripMenuItem выводToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem показатьСкрытьToolStripMenuItem;
        private ToolStripMenuItem вариантToolStripMenuItem;
        private ToolStripMenuItem сравнениеФайловToolStripMenuItem;
        private ToolStripMenuItem поискФайловВКатологеToolStripMenuItem;
        private ToolStripMenuItem количествоСловToolStripMenuItem;
        private ToolStripMenuItem обАвтореToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ToolStripButton toolStripButton3;
        private SaveFileDialog saveFileDialog1;
    }
}