using AutoMapper;
using System;
using System.Linq;
using System.Reflection;

namespace WarehouseMVC.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyMappingsFromAssemby(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingsFromAssemby(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(x => x.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
