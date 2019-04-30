using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;

namespace GenericFluent
{
    public class ProcessValidate<T, S>
    {
        public readonly IValidator<T> _firstValidate;
        public readonly IValidator<S> _secondValidate;

        public ProcessValidate(IValidator<T> firstValidate, IValidator<S> secondValidator)
        {
            _firstValidate = firstValidate;
            _secondValidate = secondValidator;
        }

        /// <summary>
        /// Esse método é responsável por realizar uma validação base
        /// quanto uma validação específica        
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public IEnumerable<ValidationResult> Validate(T first)
        {
            var result = new List<ValidationResult>()
            {
                _firstValidate.Validate(first),
                _secondValidate.Validate(first)
            };

            return result;
        }
    }
}
