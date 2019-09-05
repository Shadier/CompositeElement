using Composite.BL;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tree structure 

            CompositeElement root =
              new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));
            root.Add(new PrimitiveElement("Brown Triangle"));


            // Create a branch

            CompositeElement comp =
              new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));

            CompositeElement compTwo =
              new CompositeElement("Red Circle");
            compTwo.Add(new PrimitiveElement("Red Jr MiniCircle"));
            compTwo.Add(new PrimitiveElement("Black MiniCircle"));
            comp.Add(compTwo);


            root.Add(comp);

            // Add and remove a PrimitiveElement

            PrimitiveElement pe =
              new PrimitiveElement("Yellow Line");
            root.Add(pe);

            // Recursively display nodes

            root.Display(1);

            // Wait for user

            Console.ReadKey();
        }
    }
}
