using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INISample.setting
{
    /// <summary>
    /// [Databese]セクションを管理するクラス。
    /// </summary>
    public class DatabaseSettings : IniSampleSettings
    {
        private const string INI_SECTION = "Databese";

        public string getHost()
        {
            return getStringValue(INI_SECTION, "host", null);
        }

        public int getPort()
        {
            return getIntValue(INI_SECTION, "port", -1);
        }

        public string getUser()
        {
            return getStringValue(INI_SECTION, "user", null);
        }

        public string getPassword()
        {
            return getStringValue(INI_SECTION, "password", null);
        }
    }
}
