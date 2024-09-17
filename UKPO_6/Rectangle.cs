using System;

namespace UKPO_6
{
    public class Rectangle
    {
        private Point _leftUpper;
        private Point _rightLower;

        public Point LeftUpper
        {
            get { return _leftUpper; }
            set 
            { 
                if(_rightLower != null)
                {
                    if (value.X > _rightLower.X)
                        throw new ArgumentException("Левый угол не может быть правее правого", nameof(LeftUpper));
                    if (value.Y < _rightLower.Y)
                        throw new ArgumentException("Верхний угол не может быть ниже нижнего", nameof(LeftUpper));
                }
                _leftUpper = value; 
            }
        }

        public Point RightLower
        {
            get { return _rightLower; }
            set
            {
                if (_leftUpper != null)
                {
                    if (value.X < _leftUpper.X)
                        throw new ArgumentException("Правый угол не может быть левее левого", nameof(RightLower));
                    if (value.Y > _leftUpper.Y)
                        throw new ArgumentException("Нижний угол не может быть выше верхнего", nameof(RightLower));
                }
                _rightLower = value;
            }
        }

        public Rectangle(Point leftUpper, Point rightLower)
        {
            LeftUpper = leftUpper;
            RightLower = rightLower;
        }

        public double Heigth()
        {
            return _leftUpper.Y - _rightLower.Y;
        }
        public double Width()
        {
            return _rightLower.X - _leftUpper.X;
        }
        public double Perimeter()
        {
            return Width() + Heigth() * 2;
        }
        public double Square() 
        {
            return Width() * Heigth();
        }
    }
}
