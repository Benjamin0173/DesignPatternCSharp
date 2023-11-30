using System;
using System.Collections.Generic;

interface IShape
{
    void Draw();
}

class SimpleShape : IShape
{
    private string _name;

    public SimpleShape(string name)
    {
        _name = name;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing {_name}");
    }
}

abstract class ShapeD : IShape
{
    protected IShape _decoratedShape;

    public ShapeD(IShape decoratedShape)
    {
        _decoratedShape = decoratedShape;
    }

    public virtual void Draw()
    {
        _decoratedShape.Draw();
    }
}

class RedShapeD : ShapeD
{
    public RedShapeD(IShape decoratedShape) : base(decoratedShape) { }

    public override void Draw()
    {
        _decoratedShape.Draw();
        SetRedBorder();
    }

    private void SetRedBorder()
    {
        Console.WriteLine("Border Color: Red");
    }
}


class GroupShape : IShape
{
    private List<IShape> _shapes = new List<IShape>();

    public void AddShape(IShape shape)
    {
        _shapes.Add(shape);
    }

    public void Draw()
    {
        Console.WriteLine("Drawing Group:");
        foreach (var shape in _shapes)
        {
            shape.Draw();
        }
    }
}

// Client code
class Program
{
    static void Main()
    {
        // Create simple shapes
        IShape circle = new SimpleShape("Circle");
        IShape square = new SimpleShape("Square");

        // Create a group of shapes
        GroupShape group1 = new GroupShape();
        group1.AddShape(circle);
        group1.AddShape(square);

        // Create another simple shape
        IShape triangle = new SimpleShape("Triangle");

        IShape decoratedCircle = new RedShapeD(new SimpleShape("Circle"));

        GroupShape group2 = new GroupShape();
        group2.AddShape(group1);
        group2.AddShape(triangle);
        group2.AddShape(decoratedCircle);

        // Draw individual shapes and groups
        Console.WriteLine("Drawing individual shapes:");
        circle.Draw();
        square.Draw();
        triangle.Draw();
        decoratedCircle.Draw();

        Console.WriteLine("\nDrawing group of shapes:");
        group1.Draw();

        Console.WriteLine("\nDrawing group of groups and shapes:");
        group2.Draw();
    }
}
