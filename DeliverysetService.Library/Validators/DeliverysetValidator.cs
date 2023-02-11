using DeliverysetService.Library.Persistence.Models.Json;
using FluentValidation;

namespace DeliverysetService.Library.Validators;

public class DeliverysetValidator : AbstractValidator<Deliveryset>
{
    public DeliverysetValidator()
    {
        // some validation
    }
}