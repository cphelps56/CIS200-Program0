using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public abstract class Parcel
    {
        public Address OriginAddress { get; set; } // auto-implemented property Origin Address
        public Address DestinationAddress { get; set; } // auto-implemented property Destination Adress.

        // Constructor
        // Preconditions: No specific restrictions
        // The parcel will be created with the specified values given when the object is created
        public Parcel(Address Origin, Address Destination)
        {
            OriginAddress = Origin;
            DestinationAddress = Destination;
        }

        // Abstract method to find the cost
        // Preconditions: No specific restrictions
        // Postconditions: Returns the cost
        public abstract decimal CalcCost();

        // Preconditions: No specific restrictions
        // Postconditions: Returns the data about the parcel as a formatted string.
        public override string ToString()
        {
            return string.Format("Origin Address:" + OriginAddress.ToString() + System.Environment.NewLine + "Destination Address:" + DestinationAddress.ToString() + System.Environment.NewLine + "Cost:" + CalcCost());
        }
    }
}
