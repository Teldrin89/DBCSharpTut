// using - provides a whole bunch of different libraries that will be used
// to get methods and objects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// the namespace - used to define globally unique objects
namespace DBCSharpTut
{
    // default name for class - Program - will define variables and 
    // methods for class objects
    class CSTut1
    {
        // The "Main" function with several atributes: static - meaning it 
        // belongs to the class (can execute without object), void - meaning 
        // it will not return anything (can be for example int - returns integer)
        // The function will receive multiple values in string array - arguments
        static void Main(string[] args)
        {
            // Simple "Hello" write script, writeline - it will put a new line
            // in the end - have to end line with ";" !!!
            Console.WriteLine("Hello Annia");
            // to keep console open we have to add one more line
            // this will make it close on hitting return ("enter")
            Console.ReadLine();


        }
    }
}
