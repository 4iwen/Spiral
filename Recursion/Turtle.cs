namespace Recursion;

public class Turtle
{
    private int _x, _y;
    private Direction _direction;
    private readonly char _symbol;

    public Turtle(int startX, int startY, Direction startDirection, char symbol)
    {
        _x = startX;
        _y = startY;
        _direction = startDirection;
        _symbol = symbol;
        
        Console.SetCursorPosition(_x,_y);
    }

    public void MoveForward(int length)
    {
        for (int step = 0; step < length; step++)
        {
            if (_direction == Direction.Down)
                _y++;
            else if (_direction == Direction.Right)
                _x++;
            else if (_direction == Direction.Up)
                _y--;
            else if (_direction == Direction.Left)
                _x--;
            
            Draw();
        }
    }
    
    public void TurnRight()
    {
        _direction = _direction switch
        {
            Direction.Down => Direction.Left,
            Direction.Left => Direction.Up,
            Direction.Up => Direction.Right,
            Direction.Right => Direction.Down,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
    public void TurnLeft()
    {
        _direction = _direction switch
        {
            Direction.Down => Direction.Right,
            Direction.Right => Direction.Up,
            Direction.Up => Direction.Left,
            Direction.Left => Direction.Down,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
    private void Draw()
    {
        Console.SetCursorPosition(_x, _y);
        Console.Write(_symbol);
    }
}