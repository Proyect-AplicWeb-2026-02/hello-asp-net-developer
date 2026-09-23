using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

public static class GreetDeveloperAssembler
{
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? entity)
    {
        return new GreetDeveloperResponse(entity.Id, entity.GetFullName(),
            $"{entity.FirstName} {entity.LastName}");
    }
}