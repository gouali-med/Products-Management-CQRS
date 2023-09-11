using FluentValidation;

namespace Application.Features.Posts.Commands.CreatePost
{
    public class CreateCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
            
            RuleFor(p => p.Content)
                .NotEmpty()
                .NotNull();
        }
    }
}
