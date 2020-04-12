using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DB;
using WebApp.DB.Interface;
using WebApp.Service;
using WebApp.Service.Interface;

namespace WebApp.CrossCutting
{
    public class SimpleInjectorConfiguration
    {
        static Func<Type, object> GetInstance;

        public static void Register(Container container)
        {
            container.Register<iClienteRepository, ClienteRepository>(Lifestyle.Scoped);
            container.Register<iClienteService, ClienteService>(Lifestyle.Scoped);

            GetInstance = (t) => { return container.GetInstance(t); };
        }

        public static T Get<T>() where T : class { return (T)GetInstance(typeof(T)); }
    }
}
