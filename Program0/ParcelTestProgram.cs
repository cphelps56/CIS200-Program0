// Name: Colin Phelps
// Program 0
// Due Date: 5/21/15
// CIS 200-10
// This program creates several Address objects and several Letter objects, which are part of the Parcel class. It then displays each of the letters using the ToString method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class ParcelTestProgram
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("Bob Smith", "123 Main Street", "", "Louisville", "Kentucky", 40272); // variable to hold the first address created and initialized
            Address address2 = new Address("Tyler Durden", "537 Paper Street", "", "Bradford", "Deleware", 19808); // variable to hold the second address created and initialized
            Address address3 = new Address("Jim Jones", "1000 Red River Road", "Apt. 2", "Phoenix", "Arizona", 30132); // variable to hold the third address created and initialized
            Address address4 = new Address("Sue Johnson", "4567 Peachtree Road", "", "Peachtree City", "Georgia", 67890); // variable to hold the fourth address created and initialized

            Letter letter1 = new Letter(address1, address2, 10); // Variable to hold the first letter object
            Letter letter2 = new Letter(address3, address4, 15); // Variable to hold the second letter object
            Letter letter3 = new Letter(address2, address4, 20); // Variable to hold the third letter object

            List<Parcel> parcelList = new List<Parcel>(); // List to hold parcels created

            // All the created letters are added to the list
            parcelList.Add(letter1);
            parcelList.Add(letter2);
            parcelList.Add(letter3);

            // Loop to display the data for all of the letters.
            int x;
            for (x = 0; x < parcelList.Count; x++)
            {
                Console.WriteLine(parcelList[x].ToString());
            }

            Console.ReadLine();
        }
    }
}
