using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConfigurationHandler
{
    public class ConfigHandler
    {
        private static string ConfigJSONstring = System.IO.File.ReadAllText(@"C:\Temp\VSTestConfiguration\Config.json");

        public static object ReadConfigValue(string configkey)
        {
            //var des = JsonConvert.SerializeObject(new Configuration()
            //{
            //    configlist = new List<ConfigObject>()
            //    { new ConfigObject(){ key = "x", value = "h"},
            //      new ConfigObject(){ key = "y", value = "t"}
            //    }

            //});
           

            var config = JsonConvert.DeserializeObject<Configuration>(ConfigJSONstring);
            string configvalue = "";

            configvalue = config.configlist.FirstOrDefault(c => c.key.ToLower() == configkey.ToLower()).value;

            return configvalue;
        }
    }

    public class Configuration
    {
        public List<ConfigObject> configlist;
    }

    public class ConfigObject
    {
       public  string key;
       public  string value;
    }
}
