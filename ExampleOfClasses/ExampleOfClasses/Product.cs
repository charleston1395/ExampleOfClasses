using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOfClasses
{


    public class Name
    {
        // We'll define a variable of type string called `price
        public string Price { get; set; }

        // We'll define a method called `SayPrice
        public void SayPrice()
        {
            // Use `this` to reference the current instance
            Price = "299.99";
            Console.WriteLine("Nintendoswitch" + this.Price);
            // The code can also infer that you're accessing `this`
            Console.WriteLine("Nintendoswitch" + Price);
            
        }
    }
}

//Inside the product class, create a new property of type string that is public called Name 

//Inside the product class, create a new property of type decimal that is public called Price


//Give these two properties you created read and write accessors


//Step 4 
//In your main method, creat a new instance of the Product class and assign values to its Name and Price
//For example, a nintendo switch.  priced at 299.99 

//Step 5 
//print the product's name and price with Console.WriteLine(); 
