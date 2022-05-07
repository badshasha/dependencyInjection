// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;

namespace dependencyInjection
{
    class program {

        public static void Main(String[] args) {

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<SimpleClass>();

            var provider = serviceCollection.BuildServiceProvider();
            var obj1 = provider.GetService<SimpleClass>();
            var obj2 = provider.GetService<SimpleClass>();

            Console.WriteLine($"{obj1.RandomNumber()}");
            Console.WriteLine($"{obj2.RandomNumber()}");
        }
    }
}
