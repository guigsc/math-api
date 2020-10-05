using System.Collections.Generic;
using MathAPI.MultipleOf.Result;

namespace MathAPI.MultipleOf
{
    public abstract class MultipleOf
    {
        public abstract bool IsMultiple(string number);
        public virtual IEnumerable<IsMultipleResult> IsMultiple(IEnumerable<string> numbers)
        {
            List<IsMultipleResult> results = new List<IsMultipleResult>();

            foreach (var number in numbers)
            {
                bool isMultiple = IsMultiple(number);

                results.Add(new IsMultipleResult
                {
                     Number = number,
                     IsMultiple = isMultiple
                });
            }

            return results;
        }
    }
}
