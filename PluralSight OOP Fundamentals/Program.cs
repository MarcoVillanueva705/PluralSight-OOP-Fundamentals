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
        //**methods define operations and the actions and behaviors
        //appropriate for the class
        //Validate()
        //Retrieve()
        //Save()

        //**Identifying Classes from Requirements**
        //-ABSTRACTION:
        //The process of defining classes by simplfying
        //reality, ignoring extraneous details, and focusing on
        //what is important for a purpose.
        //It involves abstracting away the extraneous details in order
        //to focus on what is relevant for the particular application.
        //Defining appropriate abstractions is considered one of the pillars
        //or 'key characteristics' of OOP.

        //-ENCAPSULATION
        //A way to hide or 'encapsulate' the data and implementation details 
        //within a class, thus hiding complexity.
        //In C#, the object data is exposed to the application through property
        //getters and setters.
        //The operations are exposed to the application through 'methods'.
        //The exposed set of methods and property method getters and setters
        //define the class interface to the rest of the application.
        //If the UI wants to accecss property such as a name, it must call
        //the 'getter' or 'setter'. The 'getter' retrieves the value of
        //the private data, optionally manipulates the data, and returns it.
        //The 'setter' optionally validates the incoming value, and if valid, 
        //updates the private data.  Any code that wants to perform an operation
        //using the code within the class, must call the methods.  Encapsulation 
        //is a key underlying principal that makes it possible to build large,
        //full-featured systems by breaking complex operations into encapsulated
        //units.  These encapsulated units are classes.  Encapsulation allows
        //the objects in an application to work together without each object knowing
        //the details of other object's implementation. Encapsulation hides both the
        //data and implementation within the class. This data hiding has many benefits:
        //*It protects the data
        //*No other code can modify the underlying data except through the 'getters' and
        //'setters'
        //*This prevents an object's values from being corrupted by other objects
        //*We can add code to the 'getter' to perform operations before the data is provided
        //*For example, we could ensure the user has access to the specific data element.
        //We can add code to the 'setter' to perform operations before the data is set.
        //*For example, we could provide validation so that the data is never set to an invalid
        //value.  
        //Hiding the method implementation details also has it's benefits:
        //*It helps to manage the complexity of the application by breaking it down into 
        //manageable units. 
        //*It shields the other objects from having to know the implementation details.
         //*Only the class needs to understand the implementation.
    }
}
