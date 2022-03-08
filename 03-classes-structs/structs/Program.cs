namespace Experiment
{
  /* *****************
   * 
   * Structs
   * 
   * Structs share most of the same syntax as classes.
   * Structs are defined by using the struct keyword
   * 
   * *****************/

    public struct PostalAddress
    {
      public int streetNumber;
      public string addressLine1;
      public string addressLine2;
      public string city;
      public string postalCode;

      public void echoAddress()
      {
        string address = streetNumber + " " + addressLine1 + ", " + addressLine2 + ", " + city + ", " + postalCode;

        Console.WriteLine("Address is: " + address);  
      }
    }

    class Program
    {
      static void Main(String[] args)
      {
        PostalAddress address;

        address.streetNumber = 1;
        address.addressLine1 = "Newtown Ave";
        address.addressLine2 = "Killarney";
        address.city = "Johannesburg";
        address.postalCode = "2193";

        address.echoAddress();  
      }
    }

}