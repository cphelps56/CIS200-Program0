using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public class Address
    {
        private int _zip; //field to hold the zip code

        public string Name { get; set; } // auto-implemented property Name
        public string Address1 { get; set; } // auto-implemented property Address Line 1
        public string Address2 { get; set; }// auto-implemented property Address Line 2
        public string City { get; set; } //  auto-implemented property City
        public string State { get; set; } // auto implemented property State

        // Constructor
        // Precondition: 1 <= Zip <= 99999
        // Postcondition: The address will be initialized with the specified values given when the object is created.
        public Address(string addressName, string addressLine1, string addressLine2, string addressCity, string addressState, int addressZip)
        {
            Name = addressName;
            Address1 = addressLine1;
            Address2 = addressLine2;
            City = addressCity;
            State = addressState;
            Zip = addressZip;
        }

       // property for the Zip code.
        public int Zip
        {
            // Precondition: None
            // Postconditio: The zip is returned
            get
            {
                return _zip;
            }

            // Precondition: 1 <= value <= 99999
            // Postcondition: The Zip will be set to a specified value
            set
            {
                if (value >= 0 && value <= 99999)
                {
                    _zip = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        // Precondition: None
        // Postcondition: Returns the data about the address in a formatted string.
        public override string ToString()
        {
            if(Address2 == "")
            return string.Format(Name + System.Environment.NewLine + Address1 + System.Environment.NewLine + City + ", " + State + ", " + Zip.ToString("D5"));
            else
            return string.Format(Name + System.Environment.NewLine + Address1 + System.Environment.NewLine + Address2 + System.Environment.NewLine + City + ", " + State + ", " + Zip.ToString("D5"));

        }

    }
}
