using System;

class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
class Rectangle : Shape
{
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
            {
                width = value;
            }
        }
    }
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }
    public override int Area()
    {
        return width * height;
    }
    public override string ToString() { return $"[Rectangle] {width} / {height}"; }
    private int width;
    private int height;

}
class Square : Rectangle
{
    public int Size
    {
        get { return this.size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
            {
                this.size = value;
                Width = value;
                Height = value;
            }
        }
    }
    private int size;
}