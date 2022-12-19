using System.Drawing.Printing;
using System.IO;

namespace LibraryLab13 {
    public class TextFile : IComparable {

        public static readonly char[] WORD_SEPARATORS = new char[]{'.', ' ', ',', ';', ':', '-', '!', '?', '"', '_', '\'', '\n'};
        public FileStream FStream { get; protected set; } // поток на файл

        //public string FilePath { get; protected set; }

        protected PrintDocument printDocument ; // поле для настройки пичати
        
        public string Text;

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public TextFile(string path) {
            printDocument = new PrintDocument();
            try {
                FStream = new(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            } catch(Exception) {
                throw new Exception(MyException.ERROR_FILE_OPEN);
            } finally {
                FStream?.Close();
            }
            printDocument.DocumentName = FStream.Name;
            printDocument.PrintPage += PrintPageHandler;
        }
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

        public TextFile(string path, string text) {
            printDocument = new PrintDocument();
            try {
                FStream = new(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                Text = text;
                FileSave();
            } catch (Exception) {
                throw new Exception(MyException.ERROR_FILE_OPEN);
            } finally {
                FStream?.Close();
            }
            
            printDocument.DocumentName = FStream.Name;
            printDocument.PrintPage += PrintPageHandler;
        }

        // закрытие с сохранением
        public void Close() => FStream?.Close();


        // расписчатать содержимое файла
        public void PrintPage() {
            printDocument.Print();
        }

        /// <summary>
        /// обработчик событий для PrintPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintPageHandler(object sender, PrintPageEventArgs e) {
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            Graphics graphics = e.Graphics;
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.

            Font font = new Font("Arial", 10);

            //SizeF textSize = graphics.MeasureString(Text, font);

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            graphics.DrawString(Text, font, Brushes.Black, x, y);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

            //e.Graphics.DrawString(FileRead(), new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        public void FileRead() {
            FStream = new(FStream.Name, FileMode.OpenOrCreate, FileAccess.Read);
            //try {
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            StreamReader reader = new StreamReader(FStream);
                    Text = reader.ReadToEnd();
            reader.Close();
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            /*} catch (Exception) {
                throw new Exception(MyException.ERROR_FILE_READ);
            }*/
        }


        //Сохранение файла
        //Результат: запись файла на диск
        public void FileSave() {
            //try {
            FStream = new(FStream.Name, FileMode.OpenOrCreate, FileAccess.Write);
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            StreamWriter sf = new StreamWriter(FStream);  //если файл существует, то он будет перезаписан
                    string[] str = Text.Split('\n');
                    for (int i = 0; i < str.Length; i++)
                        sf.WriteLine(str[i]);
                sf.Close();
                
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
           //} catch {
                //throw new Exception(MyException.ERROR_FILE_WRITE);
            //}
        }

        public int WordCount() =>
            Text.Split(
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




        /*public override bool Equals(object obj) {
            if (obj == null || obj is not TextFile)
                return false;
            if (FStream.Length == ((TextFile)obj).FStream.Length)
                return true;
            return false;
        }*/
        public override bool Equals(object? obj) {
            return obj is TextFile file &&
                   EqualityComparer<FileStream?>.Default.Equals(FStream, file.FStream);
        }

#pragma warning disable CS8767 // Допустимость значений NULL для ссылочных типов в типе параметра не соответствует неявно реализованному элементу (возможно, из-за атрибутов допустимости значений NULL).
        public int CompareTo(object obj) {
            if (obj == null || obj is not TextFile)
                throw new ArgumentException("Это не обьект класса \"TextFile\"");
            if (FStream?.Length > ((TextFile)obj).FStream?.Length) return 1;
            if (FStream?.Length < ((TextFile)obj).FStream?.Length) return -1;
            return 0;
        }
#pragma warning restore CS8767 // Допустимость значений NULL для ссылочных типов в типе параметра не соответствует неявно реализованному элементу (возможно, из-за атрибутов допустимости значений NULL).

#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
        public override int GetHashCode() => FStream.GetHashCode();
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

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
        
         class FileNameComparer : IComparer<TextFile> {
        public int Compare(TextFile? x, TextFile? y) =>
            String.Compare(x.FStream.Name, y?.FStream.Name);
    }
    class FileLengthComparer : IComparer<TextFile> {
        public int Compare(TextFile? x, TextFile? y) => 
            x.FStream.Length.CompareTo(y.FStream.Length);
    }
    class FileCountWordComparer : IComparer<TextFile> {

        public int Compare(TextFile? x, TextFile? y) =>
            x.WordCount().CompareTo(y.WordCount());
    }
    }
}