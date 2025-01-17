// <auto-generated/>
#pragma warning disable
using FluentValidation;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;
using Wolverine.Http.FluentValidation;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_validate_user
    public class POST_validate_user : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _options;
        private readonly FluentValidation.IValidator<WolverineWebApi.Validation.CreateUser> _validator_of_CreateUser_178908908;
        private readonly FluentValidation.IValidator<WolverineWebApi.Validation.CreateUser> _validator_of_CreateUser_125317156;
        private readonly Wolverine.Http.FluentValidation.IProblemDetailSource<WolverineWebApi.Validation.CreateUser> _problemDetailSource;

        public POST_validate_user(Wolverine.Http.WolverineHttpOptions options, [Lamar.Named("createUserValidator")] FluentValidation.IValidator<WolverineWebApi.Validation.CreateUser> validator_of_CreateUser_178908908, [Lamar.Named("passwordValidator")] FluentValidation.IValidator<WolverineWebApi.Validation.CreateUser> validator_of_CreateUser_125317156, Wolverine.Http.FluentValidation.IProblemDetailSource<WolverineWebApi.Validation.CreateUser> problemDetailSource) : base(options)
        {
            _options = options;
            _validator_of_CreateUser_178908908 = validator_of_CreateUser_178908908;
            _validator_of_CreateUser_125317156 = validator_of_CreateUser_125317156;
            _problemDetailSource = problemDetailSource;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var validatorList = new System.Collections.Generic.List<FluentValidation.IValidator<WolverineWebApi.Validation.CreateUser>>{_validator_of_CreateUser_178908908, _validator_of_CreateUser_125317156};
            var (user, jsonContinue) = await ReadJsonAsync<WolverineWebApi.Validation.CreateUser>(httpContext);
            if (jsonContinue == Wolverine.HandlerContinuation.Stop) return;
            var result = await Wolverine.Http.FluentValidation.Internals.FluentValidationHttpExecutor.ExecuteMany<WolverineWebApi.Validation.CreateUser>(validatorList, _problemDetailSource, user).ConfigureAwait(false);
            if (!(result is Wolverine.Http.WolverineContinue))
            {
                await result.ExecuteAsync(httpContext).ConfigureAwait(false);
                return;
            }

            var result_of_Post = WolverineWebApi.Validation.ValidatedEndpoint.Post(user);
            await WriteString(httpContext, result_of_Post);
        }

    }

    // END: POST_validate_user
    
    
}

