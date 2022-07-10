namespace File_operations
{
    [TestClass]
    public class BasicFileOperations
    {
        [TestMethod]
        public void WriteFile()
        {
            string text =
           "A class is the most powerful data type in C#. Like a structure, " +
           "a class defines the data and behavior of the data type. ";

            File.WriteAllTextAsync(@"D:\github\File-operations\WriteText.txt", text);
        }

        [TestMethod]
        public void AppendFile()
        {
           
            File.AppendAllText(@"D:\github\File-operations\WriteText.txt","This is appending a line of text to an existing line");
     
        }
    }
}