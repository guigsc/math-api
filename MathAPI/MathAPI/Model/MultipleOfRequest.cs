using System.Collections.Generic;
using System.Text.RegularExpressions;
using FluentValidation;

namespace MathAPI.Model
{
    public class MultipleOfRequest
    {
        public IEnumerable<string> Numbers { get; set; }
    }

    public class MultipleOfRequestValidator : AbstractValidator<MultipleOfRequest>
    {
        public MultipleOfRequestValidator()
        {
            RuleForEach(x => x.Numbers)
                .NotNull()
                .NotEmpty()
                .WithMessage("Number at index {CollectionIndex} cannot be null or empty");

            Regex regex = new Regex("^-?[0-9]*$");
            RuleForEach(x => x.Numbers)
                .Matches(regex)
                .WithMessage("Input number at index {CollectionIndex} must only contain numbers (positive or negative)");
        }
    }
}
