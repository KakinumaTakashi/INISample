using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace INISample.setting
{
    public class SettingManager
    {
        private const int MAX_LENGTH = 256;

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(
            string lpApplicationName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedstring,
            int nSize,
            string lpFileName);

        //[DllImport("kernel32.dll")]
        //private static extern int WritePrivateProfileString(
        //    string lpApplicationName,
        //    string lpKeyName,
        //    string lpstring,
        //    string lpFileName);

        private string iniFileName;


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="filename">INIファイル名</param>
        public SettingManager(string filename)
        {
            this.iniFileName = filename;
        }

        /// <summary>
        /// 設定を取得する。
        /// </summary>
        /// <param name="section">セクション名</param>
        /// <param name="key">キー名</param>
        /// <param name="defaultValue">デフォルト値</param>
        /// <returns>セクション・キーの設定値</returns>
        public string getStringValue(string section, string key, string defaultValue)
        {
            StringBuilder sb = new StringBuilder(MAX_LENGTH);

            GetPrivateProfileString(
                section,
                key,
                defaultValue,
                sb,
                sb.Capacity,
                this.iniFileName
            );

            return sb.ToString();
        }

        /// <summary>
        /// 設定を取得する。
        /// </summary>
        /// <param name="section">セクション名</param>
        /// <param name="key">キー名</param>
        /// <param name="defaultValue">デフォルト値</param>
        /// <returns>セクション・キーの設定値</returns>
        public int getIntValue(string section, string key, int defaultValue)
        {
            return Convert.ToInt32(this.getStringValue(section, key, Convert.ToString(defaultValue)));
        }

        /// <summary>
        /// 設定を取得する。
        /// </summary>
        /// <param name="section">セクション名</param>
        /// <param name="key">キー名</param>
        /// <param name="defaultValue">デフォルト値</param>
        /// <returns>セクション・キーの設定値</returns>
        public double getDoubleValue(string section, string key, double defaultValue)
        {
            return Convert.ToDouble(this.getStringValue(section, key, Convert.ToString(defaultValue)));
        }

        /// <summary>
        /// 設定を取得する。
        /// </summary>
        /// <param name="section">セクション名</param>
        /// <param name="key">キー名</param>
        /// <param name="defaultValue">デフォルト値</param>
        /// <returns>セクション・キーの設定値</returns>
        public bool getBooleanValue(string section, string key, bool defaultValue)
        {
            return Convert.ToBoolean(this.getStringValue(section, key, Convert.ToString(defaultValue)));
        }
    }
}
