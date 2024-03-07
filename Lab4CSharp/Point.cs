using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4CSharp
{
    internal class Point
    {
        protected int x;
        protected int y;
        protected int color;

        public Point()
        {
            x = 0;
            y = 0;
            color = 0;
        }
        public Point(int x, int y, int color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public void Print()
        {
            Console.WriteLine($"Координати точки x: {this.x} , y: {this.y}");
        }

        public void Move(int x1, int y1)
        {
            x += x1;
            y += y1;
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Color
        {
            get { return color; }
        }
public static Point operator ++(Point p)
    {
            p.x++;
            p.y++;
            return p;
    }

public static Point operator --(Point p)
    {
            p.x--;
            p.y--;
            return p;
    }

public static bool operator true(Point p)
        {
            return (p.x == p.y);
        }
public static bool operator false(Point p)
        {
            return !(p.x == p.y);
        }

public static Point operator +(Point p,int scalar)
        {
            p.x += scalar;
            p.y += scalar;
            return p;
        }

public static explicit operator string(Point p)
        {
            return $"x = {p.x}, y = {p.y}, color = {p.color}";
        }



public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return color;
                    default: throw new ArgumentOutOfRangeException("Index out of range.");

                }
            }
            set
            {

                switch (index)
                {
                    case 0: x = value;
                        break;
                    case 1: y = value;
                        break;
                    case 2: color = value;
                        break;
                        default: throw new ArgumentOutOfRangeException("Index out of range.");

                }
            }
        }

public static explicit operator Point(string s)
        {
            string[] parts = s.Trim('(', ')').Split(',');
            int x = int.Parse(parts[0]);
            int y = int.Parse(parts[1]);
            int color = int.Parse(parts[2]);
            return new Point(x, y, color);
        }


    }

}
