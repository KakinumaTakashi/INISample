using INISample.setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace INISample
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Debug.WriteLine("Start");

            //
            SettingManager settingManager = new SettingManager("./INISample.ini");

            string key1Value = settingManager.getStringValue("test", "key1", "DEFAULT");
            System.Diagnostics.Debug.WriteLine("key1 : " + key1Value);

            int key2Value = settingManager.getIntValue("test", "key2", 0);
            System.Diagnostics.Debug.WriteLine("key2 : " + key2Value);

            //
            DatabaseSettings databaseSettings = new DatabaseSettings("./INISample.ini");

            System.Diagnostics.Debug.WriteLine("host : " + databaseSettings.getHost());
            System.Diagnostics.Debug.WriteLine("port : " + databaseSettings.getPort());
            System.Diagnostics.Debug.WriteLine("user : " + databaseSettings.getUser());
            System.Diagnostics.Debug.WriteLine("pass : " + databaseSettings.getPassword());


            System.Diagnostics.Debug.WriteLine("End");
        }
    }
}
