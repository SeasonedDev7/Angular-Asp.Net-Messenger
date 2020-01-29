﻿using FluentValidation;

namespace ChatClient.Core.Models.Domain.Validation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.UserCode)
                .NotEmpty()
                .Length(6);

            RuleFor(user => user.DisplayName)
                .NotEmpty()
                .MinimumLength(2);

            RuleFor(user => user.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(user => user.PasswordHash)
                .NotEmpty();

            RuleFor(user => user.PasswordSalt)
                .NotEmpty();

            RuleFor(user => user.CreatedAt)
                .NotEmpty();
        }
    }
}