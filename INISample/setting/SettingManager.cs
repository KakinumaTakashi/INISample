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
        /// <summary>
        /// 設定値最大長
        /// </summary>
        private const int MAX_LENGTH = 256;

        /// <summary>
        /// DLLインポート
        /// </summary>
        /// <param name="lpApplicationName"></param>
        /// <param name="lpKeyName"></param>
        /// <param name="lpDefault"></param>
        /// <param name="lpReturnedstring"></param>
        /// <param name="nSize"></param>
        /// <param name="lpFileName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(
            string lpApplicationName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedstring,
            int nSize,
            string lpFileName);

        /// <summary>
        /// DLLインポート
        /// </summary>
        /// <param name="lpApplicationName"></param>
        /// <param name="lpKeyName"></param>
        /// <param name="lpstring"></param>
        /// <param name="lpFileName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(
            string lpApplicationName,
            string lpKeyName,
            string lpstring,
            string lpFileName);

        /// <summary>
        /// INIファイル名
        /// </summary>
        private string iniFileName;


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="filename">INIファイル名</param>
        protected SettingManager(string filename)
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
        protected string getStringValue(string section, string key, string defaultValue)
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
        /// 設定する。
        /// </summary>
        /// <param name="section">セクション名</param>
        /// <param name="key">キー名</param>
        /// <param name="value">設定値</param>
        protected void setStringValue(string section, string key, string value)
        {
            WritePrivateProfileString(
                section,
                key,
                value,
                this.iniFileName
            );
        }

        /// <summary>
        /// 設定を取得する。
        /// </summary>
        /// <param name="section">セクション名</param>
        /// <param name="key">キー名</param>
        /// <param name="defaultValue">デフォルト値</param>
        /// <returns>セクション・キーの設定値</returns>
        protected int getIntValue(string section, string key, int defaultValue)
        {
            return Convert.ToInt32(this.getStringValue(section, key, Convert.ToString(defaultValue)));
        }

        protected void setIntValue(string section, string key, int value)
        {
            this.setStringValue(section, key, Convert.ToString(value));
        }

        /// <summary>
        /// 設定を取得する。
        /// </summary>
        /// <param name="section">セクション名</param>
        /// <param name="key">キー名</param>
        /// <param name="defaultValue">デフォルト値</param>
        /// <returns>セクション・キーの設定値</returns>
        protected double getDoubleValue(string section, string key, double defaultValue)
        {
            return Convert.ToDouble(this.getStringValue(section, key, Convert.ToString(defaultValue)));
        }

        protected void setDoubleValue(string section, string key, double value)
        {
            this.setStringValue(section, key, Convert.ToString(value));
        }

        /// <summary>
        /// 設定を取得する。
        /// </summary>
        /// <param name="section">セクション名</param>
        /// <param name="key">キー名</param>
        /// <param name="defaultValue">デフォルト値</param>
        /// <returns>セクション・キーの設定値</returns>
        protected bool getBooleanValue(string section, string key, bool defaultValue)
        {
            return Convert.ToBoolean(this.getStringValue(section, key, Convert.ToString(defaultValue)));
        }

        protected void setBooleanValue(string section, string key, bool value)
        {
            this.setStringValue(section, key, Convert.ToString(value));
        }

    }
}
