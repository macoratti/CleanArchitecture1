using MediatR;

namespace CleanArchitecture.Application.UseCases.DeleteUser;

public sealed record DeleteUserRequest(Guid Id)
                  : IRequest<DeleteUserResponse>;
