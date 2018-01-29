using FluentValidation;

namespace forms_val.Models
{
    public class HomeModelValidator : AbstractValidator<FVHomeModel>
    {
        public HomeModelValidator()
        {
            RuleFor(r => r.RequiredString).NotEmpty();
            RuleFor(r => r.StringMinMaxLength).MinimumLength(5).MaximumLength(10);
            RuleFor(r => r.EmailAddress).EmailAddress();
            RuleFor(r => r.RegularExpression).Matches("[a-z]+");
            RuleFor(r => r.CreditCard).CreditCard();
            RuleFor(r => r.OptionalRangeNumeric).InclusiveBetween(5, 10);
            RuleFor(r => r.RequiredNumeric).NotEmpty();
            RuleFor(r => r.Date);
            RuleFor(r => r.DateTime);
            RuleFor(r => r.Time);
            RuleFor(r => r.Url);
            RuleFor(r => r.Currency);
            RuleFor(r => r.Upload).NotEmpty();
            RuleFor(r => r.Remote).NotEmpty();
            RuleFor(r => r.ConfirmPassword).Equal(r => r.Password);
        }
    }
}