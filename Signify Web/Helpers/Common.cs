using System;
using System.Globalization;
using System.IO;
using BankMisr.Properties;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using BankMisr.Reporting;
using BankMisr;

namespace BanqueMisr
{

    public class Common : TestHelper
    {
        internal Settings Settings = Settings.Default;

        public enum LocalizationKeys
        {
            RequestSubmittedSuccessfullyMessage,
            CountryName
        }

        public enum LogFiles
        {
            RequestsLogFile,
            IssuesLogFile,
            CommandsLogFile
        }

        public string LocalizedValueOf(Enum value)
        {
            return Resources.ResourceManager.GetString(value.ToString(), new CultureInfo(Settings.Language.ToString()));
        }
    }
}