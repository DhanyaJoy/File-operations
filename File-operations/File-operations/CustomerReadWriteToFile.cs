namespace File_operations
{
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
        [TestMethod]
        public void ReadFile()
        {
            Customer customerobj2=new Customer();
            string text = System.IO.File.ReadAllText(@"D:\github\File-operations\WriteText.txt");

                      
        }
    }
}