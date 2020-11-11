using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Primitives.IO.Attributes
{
    public class SideEffectAttribute : Attribute
    {
        public Type Type { get; }

        public SideEffectAttribute(Type type)
        {
            Type = type;
        }
    }
}
