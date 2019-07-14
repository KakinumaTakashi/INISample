using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INISample.setting
{
    public class IniSampleSettings : SettingManager
    {
        private const string INI_FILENAME = "./INISample.ini";

        public IniSampleSettings()
            : base(INI_FILENAME)
        {
        }

    }
}
