namespace Config
{
    /// <summary>
    /// Sample configuration class
    /// Contains static and instance properties of various types
    /// </summary>
    public class Configuration
    {
        public string InstanceStringValue { get; set; }

        public static string StaticStringValue { get; set; }

        public int InstanceIntValue { get; set; }

        public static int StaticIntValue { get; set; }

        public bool InstanceBoolValue { get; set; }

        public static bool StaticBoolValue { get; set; }

        public string CommentedOut { get; set; }

        /// <summary>
        /// Set some defaults for the static props
        /// </summary>
        static Configuration()
        {
            StaticStringValue = "Not set";
            StaticIntValue = -1;
            StaticBoolValue = false;
        }

        /// <summary>
        /// Set some defaults for the instance props
        /// </summary>
        public Configuration()
        {
            InstanceStringValue = "Not set";
            InstanceIntValue = -1;
            InstanceBoolValue = false;
            CommentedOut = "Not set";
        }
    }
}