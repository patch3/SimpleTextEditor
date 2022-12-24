using System.Drawing.Printing;

namespace LibraryLab13 {
    public class TextFile : IComparable {

        public static readonly char[] WORD_SEPARATORS = new char[]{'.', ' ', ',', ';', ':', '-', '!', '?', '"', '_', '\'', '\n'};
        //public FileStream FStream { get; protected set; } // поток на файл

        public string FilePath { get; protected set; }

        protected PrintDocument printDocument ; // поле для настройки пичати

        private string _temp_text;

        protected string _text { // файл в тексте
            get => _temp_text;
            set {
                _temp_text = value;
                Text = value;
            }
        }

        public string Text;

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public TextFile(string path) {
            FilePath = path;
            FileRead();
            printDocument = new PrintDocument();
            printDocument.DocumentName = FilePath;
            printDocument.PrintPage += PrintPageHandler;
        }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public TextFile(string path, string text) {
            FilePath = path;
            _text = text;
            FileSave();
            printDocument = new PrintDocument();
            printDocument.DocumentName = FilePath;
            printDocument.PrintPage += PrintPageHandler;
        }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.


        /// <summary>
        /// расписчатать содержимое файла
        /// </summary>
        public void PrintPage() {
            try {
                printDocument.Print();
            }catch(InvalidPrinterException) {
                throw new Exception(MyException.ERROR_PRINT_TEXT);
            }
        }

        /// <summary>
        /// обработчик событий для PrintPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintPageHandler(object sender, PrintPageEventArgs e) {
            Font font = new Font("Arial", 10);

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            e.Graphics.DrawString(Text, font, Brushes.Black, x, y);
        }


        public void FileRead() {
            using StreamReader reader = new(FilePath);
            _text = reader.ReadToEnd();
        }


        //Сохранение файла
        //Результат: запись файла на диск
        public void FileSave() {
            try {
                using StreamWriter writer = new (FilePath);   //если файл существует, то он будет перезаписан
                /*string[] str = Text.Split('\n');
                for (int i = 0; i < str.Length; i++)
                    writer.WriteLine(str[i]);*/
                writer.Write(Text);
                writer.Flush();
            } catch (Exception ex) {
                Console.WriteLine("Произошла ошибка при сохранении файла: " + ex.Message);
            }
        }

        public int WordCount()=>
            _text.Split(
                WORD_SEPARATORS,
                StringSplitOptions.RemoveEmptyEntries
            ).Length;
        
        

        public static readonly char[] WORD_SEPARATORS_NO_DOT = WORD_SEPARATORS.Skip(1).ToArray();

        public List<string> WordsEndingWithSyllable(string syllable) {
            // Разбиваем текст на предложения, разделителем служит точка
            string[] sentences = Text.Split('.');

            // Список для хранения найденных слов
            List<string> foundWords = new List<string>();

            // Перебираем все предложения
            foreach (string sentence in sentences) {
                // Разбиваем предложение на слова
                string[] words = sentence.Split(WORD_SEPARATORS_NO_DOT, StringSplitOptions.RemoveEmptyEntries);

                // Проверяем, является ли последнее слово в предложении словом, заканчивающимся на заданный слог
                if (words.Length > 0 && words[words.Length - 1].EndsWith(syllable)) {
                    // Добавляем слово в список найденных
                    foundWords.Add(words[words.Length - 1]);
                }
            }
            return foundWords;
        }
        public override bool Equals(object? obj) {
            return obj is TextFile file &&  int.Equals(_text.Length, file._text.Length);
            
        }

#pragma warning disable CS8767 // Допустимость значений NULL для ссылочных типов в типе параметра не соответствует неявно реализованному элементу (возможно, из-за атрибутов допустимости значений NULL).
        public int CompareTo(object obj) {
            if (obj == null || obj is not TextFile)
                throw new ArgumentException("Это не обьект класса \"TextFile\"");
            if (_text.Length > ((TextFile)obj)._text.Length) return 1;
            if (_text.Length < ((TextFile)obj)._text.Length) return -1;
            return 0;
        }
#pragma warning restore CS8767 // Допустимость значений NULL для ссылочных типов в типе параметра не соответствует неявно реализованному элементу (возможно, из-за атрибутов допустимости значений NULL).

        public override int GetHashCode() => _text.GetHashCode();

        public static bool operator ==(TextFile? left, TextFile? right) {
            if (ReferenceEquals(left, null)) {
                return ReferenceEquals(right, null);
            }
            return left.Equals(right);
        }

        public static bool operator !=(TextFile? left, TextFile? right) {
            return !(left == right);
        }

        public static bool operator <(TextFile? left, TextFile? right) {
            return ReferenceEquals(left, null) ? !ReferenceEquals(right, null) : ((IComparable)left).CompareTo(right) < 0;
        }

        public static bool operator <=(TextFile? left, TextFile? right) {
            return ReferenceEquals(left, null) || ((IComparable)left).CompareTo(right) <= 0;
        }

        public static bool operator >(TextFile? left, TextFile? right) {
            return !ReferenceEquals(left, null) && ((IComparable)left).CompareTo(right) > 0;
        }

        public static bool operator >=(TextFile? left, TextFile? right) {
            return ReferenceEquals(left, null) ? ReferenceEquals(right, null) : ((IComparable)left).CompareTo(right) >= 0;
        }

        public class FilePathComparer : IComparer<TextFile> {
            public int Compare(TextFile? x, TextFile? y) =>
                String.Compare(x?.FilePath, y?.FilePath);
        }
        public class FileLengthComparer : IComparer<TextFile?> {
             int IComparer<TextFile?>.Compare(TextFile? x, TextFile? y) => 
                x?._text.Length.CompareTo(y?._text.Length) ?? 0;
        }
        public class FileCountWordComparer : IComparer<TextFile?> {
            int IComparer<TextFile?>.Compare(TextFile? x, TextFile? y) => 
                x?.WordCount().CompareTo(y?.WordCount()) ?? 0;
        }
    }
}