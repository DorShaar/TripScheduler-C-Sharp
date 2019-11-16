using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using TripScheduler.Configuration;

namespace Composition
{
    public class TripSchedulerServiceProvider
    {
        private readonly IServiceProvider mServiceProvider;

        public TripSchedulerServiceProvider()
        {
            mServiceProvider = CreateServiceProvider();
        }

        private IServiceProvider CreateServiceProvider()
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            RegisterConfiguration(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private void RegisterConfiguration(ServiceCollection serviceCollection)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

            // Adds YAML settings later
            configurationBuilder.AddYamlFile(@"config\Config.yaml", optional: false);

            IConfiguration configuration = configurationBuilder.Build();

            // Binds between IConfiguration to ChannelsOptions and RankingStrategyOptions.
            serviceCollection.Configure<ChannelsOptions>(configuration);
            serviceCollection.Configure<RankingStrategyOptions>(configuration);
            serviceCollection.AddOptions();
        }

        public IOptions<ChannelsOptions> GetChannelOptions()
        {
            return mServiceProvider.GetService<IOptions<ChannelsOptions>>();
        }

        public IOptions<RankingStrategyOptions> GetRankingStrategyOptions()
        {
            return mServiceProvider.GetService<IOptions<RankingStrategyOptions>>();
        }
    }
}