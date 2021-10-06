using Microsoft.Extensions.DependencyInjection;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.Factory;
using OrderProcessing.BusinessRuleEngine.ConsoleApp.RuleStrategies.Definitions;
using System;
using System.Collections.Generic;

namespace OrderProcessing.BusinessRuleEngine.ConsoleApp
{
    public class OrderProcessing
    {
        private static IServiceProvider _serviceProvider;

        public static void Main()
        {
            try
            {
                // Registered required services in Dependency Injection Container.
                RegisterServices();

                OrderProcessingEngine();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void RegisterServices()
        {
            var serviceCollection = new ServiceCollection()
                .AddScoped(_ =>
                {
                    return new BusinessRuleStrategyRegistry
                    (
                        new List<IBusinessRuleStrategy>()
                        {
                            new ShippingRuleStrategy(),
                            new RoyaltyDepartmentStrategy(),
                            new ActiviateMembershipStrategy(),
                            new UpgradeMembershipStrategy(),
                            new ActivateOrUpgradeMembershipStrategy(),
                            new FreeVideoShippingRuleStrategy(),
                            new CommissionPaymentRuleStrategy()
                        }
                    );
                });

            serviceCollection.AddScoped<OrderProcessingRuleEngine, OrderProcessingRuleEngine>();

            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private static void OrderProcessingEngine()
        {
            var orderProcessingRuleEngine = _serviceProvider.GetService<OrderProcessingRuleEngine>();

            var toBePrint = orderProcessingRuleEngine.ProcessPayment(PaymentType.ActivateMembership);

            Console.WriteLine(toBePrint);
            Console.ReadLine();
        }
    }
}
