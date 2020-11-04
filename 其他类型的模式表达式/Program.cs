using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 其他类型的模式表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle() { Radius = 7 });
            shapes.Add(new Square() { Side = 5 });
            shapes.Add(new Triangle() { Height = 4 });
            var nullSquare = (Square)null;
            shapes.Add(nullSquare);

            foreach (var shape in shapes)
            {
                switch (shape)
                {
                    case Circle circle:
                        
                }
            }
        }
    }
    public abstract class Shape { }//抽象类
    public class Square : Shape//
    {
        public double Side { get; set; }//属性
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
    }
    public class Triangle : Shape
    {
        public double Height { get; set; }
    }

    
}
