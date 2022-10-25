using system.Data;

namespace MyWebsite
{
    class Customer{

        [Key]
        public string Id {get; set;}

        public string FName {get; set;}
        public string LName {get; set;}

        [Datatype(DataType.Date)]
        public dateTime DateOfBirth {get;set;}

        public string Address {get; set;}

        public string City {get; set;}

        
    }
}