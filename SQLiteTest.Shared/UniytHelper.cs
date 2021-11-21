using Unity;
using Unity.Resolution;

namespace SQLiteTest.Shared
{
    public static class UniytHelper
    {
        static UniytHelper() => Container = new UnityContainer();

        public static void Reset()
        {
            Container?.Dispose();
            Container = new UnityContainer();
        }

        public static T Resolve<T>(params ResolverOverride[] overrides) => Container.Resolve<T>(overrides);

        public static T Resolve<T>(string name, params ResolverOverride[] overrides) => Container.Resolve<T>(name, overrides);

        public static IUnityContainer Container { get; private set; }
    }
}
