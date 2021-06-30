﻿namespace DellFanManagement.App
{
    /// <summary>
    /// Just some string constants used when dealing with the ConfigurationStore class.
    /// </summary>
    class ConfigurationOption
    {
        /// <summary>
        /// Store the "operation mode".
        /// </summary>
        public static readonly ConfigurationOption OperationMode = new(ConfigurationOptionType.String, "OperationMode");

        /// <summary>
        /// Store the state of the "Tray icon" checkbox.
        /// </summary>
        public static readonly ConfigurationOption TrayIconEnabled = new(ConfigurationOptionType.Integer, "TrayIconEnabled");

        /// <summary>
        /// Store the state of the tray icon "Animated" checkbox.
        /// </summary>
        public static readonly ConfigurationOption TrayIconAnimationEnabled = new(ConfigurationOptionType.Integer, "TrayIconAnimationEnabled");

        /// <summary>
        /// Lower temperature threshold for consistency mode.
        /// </summary>
        public static readonly ConfigurationOption ConsistencyModeLowerTemperatureThreshold = new(ConfigurationOptionType.Integer, "ConsistencyModeLowerTemperatureThreshold");

        /// <summary>
        /// Upper temperature threshold for consistency mode.
        /// </summary>
        public static readonly ConfigurationOption ConsistencyModeUpperTemperatureThreshold = new(ConfigurationOptionType.Integer, "ConsistencyModeUpperTemperatureThreshold");

        /// <summary>
        /// RPM threshold for consistency mode.
        /// </summary>
        public static readonly ConfigurationOption ConsistencyModeRpmThreshold = new(ConfigurationOptionType.Integer, "ConsistencyModeRpmThreshold");

        /// <summary>
        /// Indicates whether this configuration option is for a "number" or a "string".
        /// </summary>
        public ConfigurationOptionType Type { get; private set; }

        /// <summary>
        /// Key, or basically the name of this configuration option.
        /// </summary>
        public string Key { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="type">What type of data is going to be stored.</param>
        /// <param name="key">Name of this configuration option.</param>
        private ConfigurationOption(ConfigurationOptionType type, string key)
        {
            Type = type;
            Key = key;
        }
    }
}
