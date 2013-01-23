using System;

namespace Config
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new Configuration();

            Console.WriteLine("Config before loading:\n{0}", DumpConfig(config));
            Console.WriteLine();
            ConfigLoader.Load(@"Deploy.config", config);

            Console.WriteLine("Config after loading:\n{0}", DumpConfig(config));
        }

        private static string DumpConfig(Configuration config)
        {
            return string.Format("\tInstanceStringValue: {0}\n\tInstanceIntValue: {1}\n\tInstanceBoolValue: {2}\n\tCommentedOut: {3}\n\tStaticStringValue: {4}\n\tStaticIntValue: {5}\n\tStaticBoolValue: {6}", 
                                    config.InstanceStringValue, 
                                    config.InstanceIntValue, 
                                    config.InstanceBoolValue, 
                                    config.CommentedOut,
                                    Configuration.StaticStringValue,
                                    Configuration.StaticIntValue,
                                    Configuration.StaticBoolValue);
        }
    }
}
