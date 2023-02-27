using Providers.Abstractions;
using Providers.Providers.OutputProviderCreators;
using Services.Services;
using System.Reflection;
using Vehicles.Abstractions;
using Vehicles.Extensions;

namespace ConsoleApp
{
    public class Application
    {
        public static void Main()
        {
            try
            {
                IOutputProviderCreator outputProviderCreator = new ConsoleOutputProviderCreator();
                IOutputProvider outputProvider = outputProviderCreator.CreateOutputProvider();
                var asm = Assembly.LoadFrom("Vehicles.dll"); //переменные созданы для облегчённой отладки
                var vehicles = InstanceService.GetInstances<Vehicle>(asm);
                if (vehicles != null)
                    outputProvider.Write(vehicles.SortTypesByAscending());
                else
                    Console.WriteLine("List is empty!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}