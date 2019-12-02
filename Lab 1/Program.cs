using System;

namespace Lab_1
{
    class Program
    {

        static void Main(string[] args)
        {
           new Program(); // creating an instance.
        }
        // constructor of the class ( executes automaitically when an instance is created ).
        // Rules: 
        // - It must have the same name as the class.
        // - Is the only method that Does Not contain return type.
        

        public Program(){

            Console.WriteLine("My first DotNet App");
        }

        void Test(){
            // Data Types
            //Integer x= 1;
            int age = 99;

            
            // Float
            float gravity = 9.8f;
            // Decimal 
            decimal  money = 12.99m;
            // Boolean
            Bool isThisCraszy = true;

            string text = "This is a String";

            Console.WriteLine("This is my nem: Oliver");

            if(money < 50){
                Console.WriteLine("It is at low cost");
            }
            else{
                Console.WriteLine("It is expensive a the moment");
            }
            for(int i = 0; i < 9; i++){
                Console.WriteLine("Interation: " + i);
            }
        }


    // Methods (function).
    // - Access level ( optional, default is private ).
    // - Return type ( always retun a value of that type ).
    // - Name
    // - Parameters ( type name, type name ).
        public int SayHello(){
         Console.WriteLine("I am a method");
        bool isRainny = false;
        if(isRainny){

        return 21;
        }
        else
        {
        return 6;
        }

        }

    }
}
