using Dtwo.API.View.Components.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dtwo.API.View.Components
{
    public static class ComponentResolver
    {
        private static IDictionary<Type, Type> m_componentMappings = new Dictionary<Type, Type>();

        public static void Init(Assembly componentAsm)
        {
            FindAndRegisterMap(componentAsm);
        }

        private static void FindAndRegisterMap(Assembly componentAsm)
        {
            Dictionary <Type, Type> componentMappings = new();

            try
            {
                foreach (var type in componentAsm.GetTypes())
                {
                    if (!type.FullName.Contains("Dtwo") || type.IsAbstract || !type.IsClass)
                        continue;

                    var interfaces = type.GetInterfaces();
                    foreach (var i in interfaces)
                    {
                        var baseInterface = i.GetInterfaces().FirstOrDefault(b => b == typeof(IComponent));
                        if (baseInterface != null)
                        {
                            Type interfaceType = i.IsGenericType ? i.GetGenericTypeDefinition() : i;
                            if (!componentMappings.ContainsKey(interfaceType))
                            {
                                componentMappings.Add(interfaceType, type);
                            }
                            // Ensure we handle also non-generic interfaces
                            if (i.IsGenericType && !componentMappings.ContainsKey(i))
                            {
                                componentMappings.Add(i, type);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                LogManager.LogError("Error while loading components : " + e.Message);
                Debug.WriteLine("Error while loading components : " + e.Message);
            }

            Debug.WriteLine("Component mappings found : " + componentMappings.Count);
            m_componentMappings = componentMappings;
        }

        public static T? ResolveComponent<T>() where T : IComponent
        {
            Type requestedType = typeof(T);
            // Try with exact type first
            if (m_componentMappings.TryGetValue(requestedType, out var componentType))
            {
                Debug.WriteLine("Add component");
                return (T)Activator.CreateInstance(componentType);
            }
            // If the exact type fails and it's a generic type, try with the generic type definition
            if (requestedType.IsGenericType && m_componentMappings.TryGetValue(requestedType.GetGenericTypeDefinition(), out componentType))
            {
                Debug.WriteLine("Add component");
                return (T)Activator.CreateInstance(componentType.MakeGenericType(requestedType.GetGenericArguments()));
            }

            Debug.WriteLine("Missing component : " + requestedType.FullName);
            LogManager.LogError("Missing component : " + requestedType.FullName);
            return default;
        }
    }
}
