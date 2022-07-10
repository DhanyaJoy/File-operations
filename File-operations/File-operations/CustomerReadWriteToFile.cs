namespace File_operations
{
    [TestClass]
    public class Customer
    {
      public int CustomerId;
      public string CustomerName;
      public string address;
        
        
    }
        [TestClass]
    public class CustomerReadWriteToFile
    {
        [TestMethod]
        public void WriteFile()
        {
            Customer customerobj = new Customer();
            customerobj.CustomerId = 1;
            customerobj.CustomerName = "Dhanya";
            customerobj.address = "sugddyg jbduc USA";

            string text = customerobj.CustomerId + customerobj.CustomerName + customerobj.address;

            File.WriteAllTextAsync(@"D:\github\File-operations\WriteText.txt", text);
        }

        [TestMethod]
        public void AppendFile()
        {

            File.AppendAllText(@"D:\github\File-operations\WriteText.txt", "This is appending a line of text to an existing line");

        }
        public void ReadFile()
        {
            string text = System.IO.File.ReadAllText(@"D:\github\File-operations\WriteText.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contents of WriteTextt.txt = {0}", text);
        }
    }
}