using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

class Rectangle : Shape
{
    private float _width;
    private float _length;

    public Rectangle(string color, float length, float width) : base(color)
    {
        _width = width;
        _length = length;

    }
    public override double GetArea()
    {
        return _length * _width;
    }
}
