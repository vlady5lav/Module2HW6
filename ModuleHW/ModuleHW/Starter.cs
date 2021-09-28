using Microsoft.Extensions.DependencyInjection;

namespace ModuleHW
{
    public class Starter
    {
        private App _app;

        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IConfigService, ConfigService>()
                .AddSingleton<ITaxiStationService, TaxiStationService>()
                .AddTransient<ICarsProvider, CarsProvider>()
                .AddTransient<ICarsService, CarsService>()
                .AddTransient<IConfigProvider, ConfigProvider>()
                .AddTransient<ITaxiStationProvider, TaxiStationProvider>()
                .AddTransient<App>()
                .BuildServiceProvider();

            _app = serviceProvider.GetService<App>();
            _app.Start();
        }
    }
}
