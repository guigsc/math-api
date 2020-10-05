using System.Collections.Generic;
using MathAPI.MultipleOf.Result;

namespace MathAPI.Model
{
    public class MultipleOfResponse
    {
        public IEnumerable<IsMultipleResult> Result { get; set; }
    }
}
