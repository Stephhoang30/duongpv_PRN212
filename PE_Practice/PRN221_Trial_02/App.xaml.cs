using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PRN221_Trial_02.Models;
using System.Configuration;
using System.Data;
using System.Windows;

namespace PRN221_Trial_02
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; set; } 
        public IConfiguration Configuration { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<MainWindow>();
            serviceCollection.AddScoped<Prn221Trial2Context>();
            ServiceProvider = serviceCollection.BuildServiceProvider();
            ServiceProvider.GetRequiredService<MainWindow>().Show(); 
        }
    }
     
}   
