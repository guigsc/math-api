using System.Collections.Generic;
using MathAPI.MultipleOf.Result;

namespace MathAPI.MultipleOf.Interfaces
{
    public interface IMultipleOf
    {
        bool IsMultiple(string number);
        IEnumerable<IsMultipleResult> IsMultiple(IEnumerable<string> numbers);
    }
}
