using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INISample.setting
{
    /// <summary>
    /// [write]セクションを管理するクラス。
    /// </summary>
    public class WriteSettings : IniSampleSettings
    {
        private const string INI_SECTION = "write";

        public void setString(string value)
        {
            setStringValue(INI_SECTION, "String", value);
        }

        public void setInt(int value)
        {
            setIntValue(INI_SECTION, "int", value);
        }

        public void setDouble(double value)
        {
            setDoubleValue(INI_SECTION, "double", value);
        }

        public void setBoolean(bool value)
        {
            setBooleanValue(INI_SECTION, "bool", value);
        }
    }
}
