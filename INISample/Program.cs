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
            TestSettings testSettings = new TestSettings();

            System.Diagnostics.Debug.WriteLine("String : " + testSettings.getString());
            System.Diagnostics.Debug.WriteLine("Int    : " + testSettings.getInt());
            System.Diagnostics.Debug.WriteLine("Double : " + testSettings.getDouble());
            System.Diagnostics.Debug.WriteLine("Boolean: " + testSettings.getBoolean());

            //
            DatabaseSettings databaseSettings = new DatabaseSettings();

            System.Diagnostics.Debug.WriteLine("host : " + databaseSettings.getHost());
            System.Diagnostics.Debug.WriteLine("port : " + databaseSettings.getPort());
            System.Diagnostics.Debug.WriteLine("user : " + databaseSettings.getUser());
            System.Diagnostics.Debug.WriteLine("pass : " + databaseSettings.getPassword());

            //
            WriteSettings writeSettings = new WriteSettings();

            writeSettings.setString("__AAA__");
            writeSettings.setInt(987);
            writeSettings.setDouble(123.456);
            writeSettings.setBoolean(true);

            System.Diagnostics.Debug.WriteLine("End");
        }
    }
}
