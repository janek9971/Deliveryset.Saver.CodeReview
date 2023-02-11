using DeliverysetService.Library.Persistence.Models.Json;
using FluentValidation;

namespace DeliverysetService.Library.Validators;

public class DeliverysetPackageValidator : AbstractValidator<Package>
{
    public DeliverysetPackageValidator()
    {
        // some validation

    }
}