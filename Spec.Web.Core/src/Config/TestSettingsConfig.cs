﻿using System.Configuration;

namespace Spec.Web.Core.Config
{
    public class TestSettingsConfig : ConfigurationSection
    {
        [ConfigurationProperty("LocalDriver")]
        public LocalDriverConfig LocalDriver
        {
            get { return (LocalDriverConfig)this["LocalDriver"]; }
            set { this["LocalDriver"] = value; }
        }

        [ConfigurationProperty("SauceLabsDriver")]
        public SauceLabsDriverConfig SauceLabsDriver
        {
            get { return (SauceLabsDriverConfig)this["SauceLabsDriver"]; }
            set { this["SauceLabsDriver"] = value; }
        }

        [ConfigurationProperty("BrowserStackDriver")]
        public BrowserStackDriverConfig BrowserStackDriver
        {
            get { return (BrowserStackDriverConfig)this["BrowserStackDriver"]; }
            set { this["BrowserStackDriver"] = value; }
        }
    }
}
