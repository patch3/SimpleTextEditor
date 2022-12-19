using System.Collections;


namespace LibraryLab13 {
    class TextMoreFiles : IEnumerable<TextFile> {

        protected List<TextFile> TextFilesList;
        public uint Count { get; protected set; }

        public TextMoreFiles() {
            TextFilesList = new();
            Count = 0;
        }

        public TextFile this[int i] {
            get {
                if (i >= 0 && i < Count)
                    return TextFilesList[i];
                else return null;
            }
        }

        protected void Add(TextFile TextFile) {
            TextFilesList.Add(TextFile);
            ++Count;
        }
        public void Remove(TextFile TextFile) {
            if (TextFilesList.Remove(TextFile))
                --Count;
        }
        public void RemoveAt(int index) {
            if (index >= 0 && index < Count) {
                TextFilesList.RemoveAt(index);
                --Count;
            }
        }

        public override bool Equals(object? obj) {
            return obj is TextMoreFiles files &&
                   EqualityComparer<List<TextFile>>.Default.Equals(TextFilesList, files.TextFilesList);
        }

        public int IndexOfFile(string name) {
            int index = 1;
            for (int d = 0; d < this.TextFilesList.Count; ++d) {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
                if (TextFilesList[d].FStream.Name == name)
                    index = d;
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
                ++d;
            }
            return index;
        }

        public IEnumerator<TextFile> GetEnumerator() {
            for (int i = 0; i < TextFilesList.Count; ++i)
                yield return TextFilesList[i];
        }

        IEnumerator IEnumerable.GetEnumerator() {
            for (int i = 0; i < TextFilesList.Count; ++i)
                yield return TextFilesList[i];
        }

        public override int GetHashCode() {
            return HashCode.Combine(TextFilesList);
        }

        

    }
}
