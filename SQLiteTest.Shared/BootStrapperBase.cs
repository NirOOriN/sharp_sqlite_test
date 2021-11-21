using Unity;

namespace SQLiteTest.Shared
{
    public abstract class BootStrapperBase
    {
        static BootStrapperBase()
        {
            Container = UniytHelper.Container;
            InitBase();
        }


        private static void InitBase()
        {

        }

        protected abstract void Init();

        protected static IUnityContainer Container { get; private set; }
    }
}
