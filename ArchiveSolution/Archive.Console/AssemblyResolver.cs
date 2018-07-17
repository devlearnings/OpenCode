using System.Collections.Generic;
using System.Reflection;
using System.Web.Http.Dispatcher;

namespace Archive.Console
{
    public class AssembliesResolver : IAssembliesResolver
    {
        public ICollection<Assembly> GetAssemblies()
        {
            ICollection<Assembly> baseAssemblies = new List<Assembly>();
            var controllersAssembly = Assembly.LoadFrom(@"Archive.Api.dll");
            baseAssemblies.Add(controllersAssembly);
            return baseAssemblies;
        }
    }
}
