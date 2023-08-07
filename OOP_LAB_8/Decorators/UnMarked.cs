﻿using OOP_LAB_4.figures;
using System.Drawing.Drawing2D;

namespace OOP_LAB_4.Decorators
{
    public class UnMarked : Decorator
    {
        public UnMarked(Shape new_shape) : base(new_shape)
        {
            name = CONST_SHAPE.UnMarked;
        }

        public override void Draw(Graphics g)
        {
            decoratedShape.Draw(g);
            base.Draw(g);
        }
    }
}
