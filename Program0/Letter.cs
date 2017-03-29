using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class Letter : Parcel
    {
        // Constructor
        // Preconditions: Fixed Cost >= 0
        // Postconditions: The letter object will be created with the values specified when it's created
        public Letter(Address Origin, Address Destination, decimal FixedCost)
        :base( Origin, Destination)
        {
            Cost = FixedCost;
        }
       
        private decimal _cost; // field to hold the cost

        // property that gets and sets cost
        private decimal Cost
        {
            // Preconditions: No specific requirements
            // Postconditions: Returns the cost
            get
            {
                return _cost;
            }
            // Preconditions: value >= 0
            // Postconditions: sets the cost to a specified value
            set
            {
                if (value >= 0)
                {
                    _cost = value;
                }
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        // Method that returns the cost
        // Preconditions: No specific restrictions
        // Postconditions: Returns the cost
        public override decimal CalcCost()
        {
            return Cost;
        }

        // Preconditions: No specific restrictions
        // Postconditions: Returns the data about the letter as a formatted string.
        public override string ToString()
        {
            return string.Format("Origin Address: " +System.Environment.NewLine + OriginAddress.ToString() + "\n\nDestination Address: " + System.Environment.NewLine + DestinationAddress.ToString() + "\n\nCost: " + CalcCost().ToString("c") + System.Environment.NewLine + "------------------------------------");

        }
    }
}
