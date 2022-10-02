using System;
using System.Configuration;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Notepad.Properties
{
    internal partial class Settings
    {
        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]
        public MoreSettings MoreSettings
        {
            get
            {
                var moreSettings = ((MoreSettings)this["MoreSettings"]);

                if (moreSettings == null)
                {
                    this["MoreSettings"] = moreSettings = new MoreSettings();
                }

                return moreSettings;
            }
        }
    }


}

namespace Notepad.Properties
{


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {

        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Lucida Console, 9.75pt")]
        public global::System.Drawing.Font CurrentFont
        {
            get
            {
                return ((global::System.Drawing.Font)(this["CurrentFont"]));
            }
            set
            {
                this["CurrentFont"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsStatusBarVisible
        {
            get
            {
                return ((bool)(this["IsStatusBarVisible"]));
            }
            set
            {
                this["IsStatusBarVisible"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0, 0, 0")]
        public global::System.Drawing.Rectangle WindowPosition
        {
            get
            {
                return ((global::System.Drawing.Rectangle)(this["WindowPosition"]));
            }
            set
            {
                this["WindowPosition"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("&f")]
        public string Header
        {
            get
            {
                return ((string)(this["Header"]));
            }
            set
            {
                this["Header"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Page &p")]
        public string Footer
        {
            get
            {
                return ((string)(this["Footer"]));
            }
            set
            {
                this["Footer"] = value;
            }
        }
    }
}

namespace Notepad
{
    [Serializable]
    public class MoreSettings
    {
        public PrinterSettings PrinterSettings { get; set; }
        public PageSettings PageSettings { get; set; }
    }

    public class StartNote
    {
        [STAThread]
        public void startNotepad()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            var notepad = new Forms.Notepad();

            var commandLine = Environment.CommandLine.Trim();

            var filename = (string)null;

            if (commandLine.StartsWith("\""))
            {
                var closingQuoteIndex = commandLine.IndexOf('\"', 1);

                if (closingQuoteIndex < (commandLine.Length - 1))
                {
                    filename = commandLine.Substring(closingQuoteIndex + 1).Trim();
                }
            }
            else
            {
                var firstSpaceIndex = commandLine.IndexOf(' ', 1);

                if (firstSpaceIndex != -1)
                {
                    filename = commandLine.Substring(firstSpaceIndex + 1).Trim();
                }
            }

            if (filename != null)
            {
                notepad.Open(filename);
            }

            notepad.Show();
        }
    }
}