namespace File_operations
{
    [TestClass]
    public class Customer
    {
      public int CustomerId { get; set; }
        public string CustomerName;

         string CustomerEmail;
        public string Email { 
            get {
                return CustomerEmail; }
            set {
                if (value.Contains('@'))
                {
                    this.CustomerEmail = value;
                }
                else
                {
                    throw new Exception("Invalid Email");
                }
            } 
        }
        public string CustomerPhone;
      public string address;
        
        
    }
}