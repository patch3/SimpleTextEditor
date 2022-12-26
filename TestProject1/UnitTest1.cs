using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryLab13;

namespace TestProject1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            TextFile file1 = new TextFile("1.txt") { Text = "Привет мир" };
            TextFile file2 = new TextFile("2.txt") { Text = "мир привет" };
            file1.FileSave();
            file2.FileSave();
            bool actual = (file1 == file2);
            bool expected = true; // ожидаемое значение
            Assert.AreEqual(expected, actual, "Операция сравнения файлов на  равенство выполнена не верно! ");
        }

        [TestMethod]
        public void TestMethod2() {
            TextFile file1 = new TextFile("1.txt") { Text = "Здравствуй" };
            TextFile file2 = new TextFile("2.txt") { Text = "Ничего пока" };
            file1.FileSave();
            file2.FileSave();
            bool actual = (file1 != file2);
            bool expected = true; // ожидаемое значение
            Assert.AreEqual(expected, actual, "Операция сравнения файлов на  равенство выполнена не верно! ");
        }


        [TestMethod]
        public void TestMethodSearchWordEnding() {
            List<string> expected = new() { "asd", "rthtjasd" };
            TextFile textFile = new("test.txt") {
                Text = "rhr. hrthtj. asd. thtjergr. rthtjasd."
            };
            List<string> actual = textFile.WordsEndingWithSyllable("asd");
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void TextMethodWordCount() {
            TextFile file = new("test1.txt", "в файла 4 слова");
            int expected = 4;
            Assert.AreEqual(file.WordCount(), expected);
        }


    }
   



}