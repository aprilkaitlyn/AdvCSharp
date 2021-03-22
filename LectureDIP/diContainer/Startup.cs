using System;
using Microsoft.Extensions.DependencyInjection; //need to add

namespace DIPLecture
{
    public class Startup //dependency injection container
    {
        public static IServiceProvider ConfigureService()
        {
            var provider = new ServiceCollection() //assigns all dependencies for interfaces?
                .AddSingleton<IPerson, Person>()
                .AddSingleton<IChore, Chore>()
                .AddSingleton<ILogger, Logger>()
                .AddSingleton<IEmailer, Emailer>()
                .BuildServiceProvider();

            return provider;
        }
    }
}
