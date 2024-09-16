using System;
namespace zooanimalassingment {
    class Program {
        //The main method thats called once the program runs.
        static void Main(string[] args){
            Console.Write("Enter the animals hunger level (1-10): ");
            int hungerLevel = int.Parse(Console.ReadLine());//Parse = input()}
            //Add code here for your if else statement
                if(hungerLevel >= 8){
            Console.WriteLine("Tiger: Roar!!! I'm HUNGRY!!! Feed Me eveything you have!!!");  
            }
                else if(hungerLevel >4 & hungerLevel < 8){
            Console.WriteLine("Monkey: OOh Ooh Ahh Ahh!! I want some Bananas! Give me bananas!!");
            }
                else{
            Console.WriteLine("Tortoise: Slow.... and... steady... I'll...have..some...lettuce.");    
            }
            //the code below is the ternary operator
            string result = (hungerLevel >= 8) ? "Tigers: Roar!!! That's My food!!! Hand it over!!!" : "Monkeys: Ooh Ooh Aah Aah!! Hey what about the rest of us!!!!!";
            Console.WriteLine(result);
            Console.WriteLine("What day is it? Please give me  a number betweeen 1-7. ( 1 is Sunday and 7 is Saturday)");
            int whatDayIsIT = int.Parse(Console.ReadLine());//Parse = input()}
            {
                // Down below is the main switch statement
            switch (whatDayIsIT) {
                case 1:
                Console.WriteLine("Happy Simian Sunday!!");
                break;
                case 2:
                Console.WriteLine("Hope you have a Miraculous Marsupial Monday!");
                break;
                case 3:
                Console.WriteLine("I Hope you have a transformitive Tortoise Tuesday isn't it?");
                break;
                case 4:
                Console.WriteLine("What a wonderful Whale Wednesday");
                break;
                case 5:
                Console.WriteLine("Are you having a terrific Tiger Thursday");
                break;
                case 6:
                Console.WriteLine("I hope you Have a fantastic Frog Friday!!");
                break; 
                case 7:
                Console.WriteLine(" I Hope it will be a a sunny Saurapod Saturday");
                break;
            }
            }
        }
    }
}