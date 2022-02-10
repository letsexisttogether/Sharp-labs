using System;

// sealed means that the class doesn't have 
// an opportunity to be a father
public sealed class theSuperCar
{
    private static string name;  // the obly one name
    private static string state; // stay; go up, down, right, left; dead
    private static int X; 
    private static int Y; 

    private static theSuperCar carObject;
        

    // Constructer
    private theSuperCar ()
    {
        name = "The super car's name";
        state = "STOP";
    }
    public static theSuperCar GetCarObject ()
    {
        if (carObject == null)
            carObject = new theSuperCar ();
        return carObject;
    }
    public static void Ride(char key)
    {
        if (carObject == null)
            return;
        if (key == 'W')
            state = "UP";
        if (key == 'S')
            state = "DOWN";
        if (key == 'A')
            state = "LEFT";
        if (key == 'D')
            state = "RIGHT";
    }

    public static void tick (float time)
    {
        
    }
   
}

namespace Patterns
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            theSuperCar theCar = theSuperCar.GetCarObject();
            theSuperCar theSecondCar = theSuperCar.GetCarObject();

            

            Console.ReadKey(false);
        }
    }
}
