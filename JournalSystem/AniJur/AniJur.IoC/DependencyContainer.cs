using AniJur.Domain.Core.Bus;
using AniJur.Infra.Bus;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniJur.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //Subsriptions
            ////services.AddTransient<TransferEventHandler>();

            //Domain Events
            ////services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();


            //Domain Banking Commands
            ////services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Application Services
            ////services.AddTransient<IAccountService, AccountService>();
            ////services.AddTransient<ITransferService, TransferService>();

            //Data
            ////services.AddTransient<IAccountRepository, AccountRepository>();
            ////services.AddTransient<ITransferRepository, TransferRopository>();
            ////services.AddTransient<BankingDbContext>();
            ////services.AddTransient<TransferDbContext>();

        }
    }
}
