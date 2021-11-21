using SQLiteTest.Shared;
using Unity;

namespace Test.SqLite.OnConsole
{
    internal class BootStrapper : BootStrapperBase
    {
        private static BootStrapper Instance = new();

        public static void Start()
        {
            Instance.Init();
        }

        protected override void Init()
        {
            
        }
    }
}
