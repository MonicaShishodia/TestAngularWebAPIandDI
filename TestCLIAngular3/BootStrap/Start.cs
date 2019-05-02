using System;
using Microsoft.Extensions.DependencyInjection;
using Abstraction;
using Core;
using Data;
using Microsoft.EntityFrameworkCore;
namespace BootStrap
{
    public class Start
    {
        public void SetDI(IServiceCollection container)
        {
            container.AddScoped<IUser, UserService>();
            //container.AddDbContext<TestDataContext.SampleContext>(options=>options.us);
            
        }
    }
}
