using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INISample.setting
{
    /// <summary>
    /// データベース設定を管理するクラス。
    /// </summary>
    public class TestSettings : IniSampleSettings
    {
        private const string INI_SECTION = "test";

        public string getString()
        {
            return getStringValue(INI_SECTION, "String", null);
        }

        public int getInt()
        {
            return getIntValue(INI_SECTION, "int", -1);
        }

        public double getDouble()
        {
            return getDoubleValue(INI_SECTION, "double", 0);
        }

        public bool getBoolean()
        {
            return getBooleanValue(INI_SECTION, "bool", false);
        }
    }
}
