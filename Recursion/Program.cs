namespace Recursion;

public static class Program
{
    public static void Main()
    {
        Turtle turtle = new Turtle(1, 1, Direction.Right, '#');
        
        Spiral(100, 5, turtle);

        Console.ReadKey();
    }

    private static void Spiral(int length, int decrement, Turtle turtle)
    {
        if (length <= 0)
            return;
        
        turtle.MoveForward(length);
        turtle.TurnRight();
        turtle.MoveForward(length);
        turtle.TurnRight();
        
        Spiral(length - decrement - 1, decrement, turtle);
    }
}
