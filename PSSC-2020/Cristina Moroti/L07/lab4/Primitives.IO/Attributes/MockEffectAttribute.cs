using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Primitives.IO.Attributes
{
    public class MockEffectAttribute : Attribute
    {
        public object Effect { get; }

        public MockEffectAttribute(object effect)
        {
            Effect = effect;
        }
    }
}
