using System;
using Core.Features.Auth.Commands;
using Data.Interfaces;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace Tests
{
    public class SetupFixture : IDisposable
    {
        public IServiceCollection _services;
        public IConfiguration configuration;
        public IMediator Mediator { get; private set; }
        public Mock<IUnitOfWork> UnitOfWork { get; private set; }

        public SetupFixture()
        {
            UnitOfWork = new Mock<IUnitOfWork>();
            configuration = new ConfigurationBuilder().Build();
            _services = new ServiceCollection();
            _services.AddSingleton(configuration);
            _services.AddScoped(x => UnitOfWork);
            _services.AddMediatR(typeof(Login.Handler).Assembly);
            Mediator = _services.BuildServiceProvider().GetService<IMediator>();
        }

        public void Dispose()
        {
            Mediator = null!;
            _services.Clear();
            _services = null!;
        }
    }
}