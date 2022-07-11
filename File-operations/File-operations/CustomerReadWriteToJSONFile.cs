using System.Text.Json;
using System.Text.Json.Serialization;

namespace File_operations
{
    [TestClass]
    public class CustomerReadWriteToJSONFile
    {
        [TestMethod]
        public void WriteFile()
        {
            Customer customerobj = new Customer();
            customerobj.CustomerId = 1;
            customerobj.CustomerName = "Dhanya";
            customerobj.Email = "simondhanya@gmail.com";
            customerobj.address = "sugddyg jbduc USA";

            string text = JsonSerializer.Serialize(customerobj);


            File.WriteAllTextAsync(@"D:\github\File-operations\customer.txt", text);
        }

        [TestMethod]
        public void AppendFile()
        {

            File.AppendAllText(@"D:\github\File-operations\WriteText.txt", "This is appending a line of text to an existing line");

        }
    }
}