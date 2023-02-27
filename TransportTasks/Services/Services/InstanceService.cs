using System.Reflection;

namespace Services.Services
{
    public static class InstanceService
    {
        public static IEnumerable<T> GetInstances<T>(Assembly assembly)
        {
            try
            {
                var types = assembly.GetTypes();
                var list = new List<T>();
                foreach (var type in types)
                {
                    if (!type.IsInterface && !type.IsAbstract && type.IsSubclassOf(typeof(T)))
                        list.Add((T)Activator.CreateInstance(type));
                }
                return list;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}