using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace lab4.Primitives.IO.Mocking
{
    public class EffectOverride
    {
        public object Case { get; }
        public object CaseType { get; }
        public MethodInfo MethodInfo { get; }
        public object Target { get; }

        public EffectOverride(object @case, MethodInfo methodInfo, object target)
        {
            this.Case = @case;
            CaseType = @case.GetType();
            this.MethodInfo = methodInfo;
            Target = target;
        }
    }
}
