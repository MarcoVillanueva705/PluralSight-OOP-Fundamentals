using System;

namespace PluralSight_OOP_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //GIVEN A BUSINESS REQUEST:
            //You must now make code that is defended, manageable, scalable, maintainable and testable
            //The first step to building an OOP application is to identify the classes

            //Identify the classes that represent the business entities
            //Definte the appropriate properties (data)
            //Define methods (actions/behavior)

            //
            //When extracting classes from words, start with the Nouns
            //Look at each noun in the requirments, and determine if it's a class
            //

            //***Customer, Product, Order***

            //Defining Apporpriate Members

            //Customer's Name (Last name, first name)
            //Email address
            //Home and Work address

            //Product name
            //Description
            //Current Price

            //Order
            //Customer
            //Order Date
            //Shipping Address
            //Order items

            //**It wouldn't make sense to require a separate order
            //for each ordered product; that's why the 'Order item class** 

            //Order Items
            //Product 
            //Quantity

            //*Define Appropriate Members

            //Customer
            //-Name
            //-Email
            //-Home add
            //-Work add
            //Validate()
            //Retrieve()
            //Save()

            //Product
            //-Product Name
            //-Description
            //-Current Price
            //Validate()
            //Retrieve()
            //Save()

            //Order
            //-Customer
            //-Order date
            //S-hipping address
            //Order dates
            //Validate()
            //Retrieve()
            //Save()
        }

        //Order Item
        //-Product
        //-Quantity
        //Validate()
        //Retrieve()
        //Save()
    }
}
