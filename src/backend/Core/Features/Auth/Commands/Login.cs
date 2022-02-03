using AutoMapper;
using Core.Interfaces;
using Data.DTOs;
using Data.Interfaces;
using MediatR;

namespace Core.Features.Auth.Commands
{
    public class Login
    {
        public class Query : IRequest<AuthResponse>
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class Handler : IRequestHandler<Query, AuthResponse>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IAuthService _authService;
            private readonly IMapper _mapper;

            public Handler(IUnitOfWork unitOfWork, IAuthService authService, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _authService = authService;
                _mapper = mapper;
            }

            public async Task<AuthResponse> Handle(Query query, CancellationToken cancellationToken)
            {
                var userFromDb = await _unitOfWork.AppUsers.GetByEmailAsync(query.Email, cancellationToken);

                if (userFromDb is null)
                    throw new Exception($"Could not find user: { query.Email }");

                var passwordIsCorrect = _authService
                    .CorrectPassword(query.Password, userFromDb.PasswordHash, userFromDb.PasswordSalt);

                if (!passwordIsCorrect) throw new Exception($"Password for user { query.Email } is incorrect");

                var authResponse = new AuthResponse
                {
                    Token = _authService.CreateToken(userFromDb),
                    User = _mapper.Map<AppUserDTO>(userFromDb)
                };

                return authResponse;
            }
        }
    }
}