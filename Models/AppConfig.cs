using System.Collections.Generic;
using SNIBypassGUI.Consts;

namespace SNIBypassGUI.Models
{
    /// <summary>
    /// Root configuration object serialized to JSON.
    /// </summary>
    public class AppConfig
    {
        public BackgroundConfig Background { get; set; } = new();
        public ProgramConfig Program { get; set; } = new();
        public AdvancedConfig Advanced { get; set; } = new();

        /// <summary>
        /// Stores the state of proxy switches (SectionName -> IsEnabled).
        /// </summary>
        public Dictionary<string, bool> ProxySettings { get; set; } = [];

        /// <summary>
        /// Stores temporary data like DNS backups.
        /// </summary>
        public Dictionary<string, AdapterBackupInfo> TemporaryData { get; set; } = [];
    }

    public class AdapterBackupInfo
    {
        public List<string> IPv4Servers { get; set; } = [];
        public List<string> IPv6Servers { get; set; } = [];
        public bool IsIPv4Auto { get; set; }
        public bool IsIPv6Auto { get; set; }
    }

    public class BackgroundConfig
    {
        public int ChangeInterval { get; set; } = 15;
        public string ChangeMode { get; set; } = ConfigConsts.SequentialMode;
        public List<string> ImageOrder { get; set; } = [];
    }

    public class ProgramConfig
    {
        public string ThemeMode { get; set; } = ConfigConsts.LightMode;
        public string SpecifiedAdapter { get; set; } = "";
        public bool AutoSwitchAdapter { get; set; } = true;
        public bool AutoCheckUpdate { get; set; } = true;
        public bool CloseToTrayOnClose { get; set; } = true;
        public bool EnableBackground { get; set; } = true;
    }

    public class AdvancedConfig
    {
        public bool DebugMode { get; set; } = false;
        public bool GUIDebug { get; set; } = false;
        public bool AcrylicDebug { get; set; } = false;
    }
}
