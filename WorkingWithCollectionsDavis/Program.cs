using System;
using System.Collections.Generic;

namespace WorkingWithCollectionsDavis
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ///Collections are more 'full featured' arrays
            /// Object & collection initializers: allow you to initialize the
            /// properties of a new object or initialize the properties of multiple 
            /// new objects in a new collection in just 1 line of code
            /// Remember the Array videos
            /// Arrays are great, but lack a couple of important features
            /// For example: the length of arrays are FIXED
            /// Or you want to use some other technique to retrieve an item
            /// Instead of using an ordinal position, use a KEY instead to 
            /// get at an individual item
            /// That's where collections come into play
            /// WHERE IS THE DOWNLOAD FILE???
            /// 


            /*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Author = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";
            */


            //old style of collections: NO REAL VALUE IN TYPING OUT THIS CODE!
            //Now there is a new style that fixes a lot of problems from old version

            ///Old:
            /// System.Collections.ArrayList myArrayList = new System.Collections.ArrayList();
            /// myArrayList.add(car1); //this involves adding an object
            /// myArrayList.add(car2); //But here you can add multiple classes(BOOK & CAR)
            /// myArrayList.add(b1);
            /// myArrayList.Remove(b1);
            /// 
            /// foreach (object o in myArrayList)
            /// {
            ///     Console.WriteLine(((Car)o).Make);
            /// }
            /// 
            /// This mirrors what you can do in an array, just adds on a few extra features.
            /// However, there are some downsides.
            /// First, since you are adding everything into the arraylist as System.object
            /// Once we go to retrieve the object out of the arraylist, we will 
            /// have to do some data conversion on that object so we can get it 
            /// back to its original data type so we can actually do something
            /// meanignful with it. Here is retrieving each reference in 'o' 
            /// and then making it print each object's 'make'
            /// That's also why we have the Car class in the 'foreach' code,
            /// like a temporary data conversion
            /// THIS CODE ALSO CREATES AN ERROR! As Class Book != Class Car
            /// Though you can remove a single item or a whole range of items with
            /// Arraylists, couldn't do that with a regular array
            /// Though if you .Remove the arraylist of b1, the code works fine. 
            /// No errors because we removed it before 'casting' it in the foreach
            /// function. Of course there are a number of other things you can do with
            /// Arraylists(ex: .Contains-see if it contains an object, .Count, etc.)

            ///This next one is still one of the OLD style collections
            /// This one is not strongly typed, so we can easily break it
            /// 
            /// ListDictionaries allow you to save a KEY along with a value, while 
            /// supporting cool feature
            /// Several Dictionaries to choose from
            /// 
            /// System.Collections.Specialized.ListDictionary myDictionary
            ///     =new System.Collections.Specialized.ListDictionary();
            /// 
            /// The add allows you to add the key and a value, though you can any 
            /// data type to the dictionary
            /// myDictionary.Add(car1.Make, car1);
            /// myDictionary.Add(car2.Make, car2);
            /// myDictionary.Add(b1.Author, b1);
            /// 
            /// Easy to access an element with its key
            /// Console.WriteLine(((Car)myDicitonary["Geo"].Model);
            /// 
            /// Break example: Author is not in Car! Nor is Model in Book!
            /// Done by adding different types(classes) to the dictionary
            /// Console.WriteLine(((Car)myDicitonary["Robert Tabor"].Model);

            //A generic type provides the basic implementation of some functionality
            //In our case, collections. User can make it specific by telling it
            //what data type to use. Then it becomes a strongly typed collection
            //You define a specific type by putting it in angle brackets

            /*
            //This needs a special System for Mac's(shown at top)
            //This is a generic collection until you make it specific by giving
            //it the type. Now it's specific to type car, so it can only hold cars

            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);

            //If we try to add a book class into list, it will put a red line under
            //that code. Data type is wrong, so it's invalid. You can rely on the 
            //list being a car

            foreach (Car car in myList)
            {
                //No casting required!
                Console.WriteLine(car.Model);
            }
            */


            ///The 'TryParse' code,which passes in superhero, .Net will parse the
            /// 'userValue' input parameter into a superhero data type(an enum).
            /// 
            /*
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Type in a superheroes name to see their nickname: ");
            string userValue = Console.ReadLine();

            SuperHero myValue;

            if (Enum.TryParse<SuperHero>(userValue, true, out myValue))
            {
                switch (myValue)
                {
                    case SuperHero.Batman:
                        Console.WriteLine("Caped Crusader");
                        break;
                    case SuperHero.Superman:
                        Console.WriteLine("Man of Steel");
                        break;               
                    case SuperHero.GreenLantern:
                        Console.WriteLine("Emerald Knight");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Does not compute");
            }

*/
            /*
            //Another KEY and VALUE collection:<TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.Make, car1);
            myDictionary.Add(car2.Make, car2);
            //Use '[]' to access values from array or collections
            Console.WriteLine(myDictionary["Geo"].Model);
            */

            //This declares and initializes array in just 1 line of code!
            //string[] names = {"Bob", "Steve", "Brian", "Chuck",  };

            //Like above, in code, there will be onject initializers. See Below

            Car car1 = new Car() { Make = "Oldsmobile", Model = "Cutlas Supreme"};
            Car car2 = new Car() { Make = "Geo", Model = "Prism"};
            Car car3 = new Car() { Make = "Nissan", Model = "Altima" };
            ///Note intellisense only displayed public properties for the car 
            /// to help guide you. It will even show you all the rest of the properties
            /// after you already define one property.
            /// This will work for any data type
            //Note these are accessed/created via names, inlike "myList" below

            /// Now for collection initializers, See Below
            List<Car> myList = new List<Car>() {
                new Car {Make = "Oldsmobile", Model = "Cutlas Supreme"},
                new Car {Make = "Geo", Model = "Prism"},
                new Car {Make = "Nissan", Model = "Altima"}
            };
            ///The above code is used often. Despite it looking like 5 lines of 
            /// code, it is really 1 line of code. Once you understand object initializers,
            /// collection initializers are very easy. Almost exactly like the 3 object initializers
            /// above the 'myList' Code.
            /// Here you're creating new instances of car and adding them to the
            /// collection immediately. The collection itself will keep track
            /// of the reference instead of requireing a name.
            /// THIS CODE IS VERY IMPORTANT!!!!
            Console.ReadLine();


            //Generic collections/methods allows you to define the specific data 
            //type you want to use.
        }
    }

    /*
    enum SuperHero
    {
        Batman,
        Superman,
        GreenLantern
    }
*/
    class Car
	{
		public string Make{ get; set;}
        public string Model { get; set; }
	}

    class Book
    {
		public string Title { get; set; }
		public string Author { get; set; }
		public string ISBN { get; set; }
		
    }
}
