﻿using System;
using System.Configuration;

namespace Spec.Web.Core.Config
{
    public class DriverConfig : ConfigurationElement
    {
        [ConfigurationProperty("PlatformName", IsRequired = false, DefaultValue = "")]
        public string PlatformName
        {
            get { return (String)this["PlatformName"]; }
            set { this["PlatformName"] = value; }
        }

        [ConfigurationProperty("PlatformVersion", IsRequired = false, DefaultValue = "")]
        public string PlatformVersion
        {
            get { return (String)this["PlatformVersion"]; }
            set { this["PlatformVersion"] = value; }
        }

        [ConfigurationProperty("BrowserName", IsRequired = true )]
        public string BrowserName
        {
            get { return (String)this["BrowserName"]; }
            set { this["BrowserName"] = value; }
        }

        [ConfigurationProperty("DeviceName", IsRequired = false, DefaultValue = "")]
        public string DeviceName
        {
            get { return (String)this["DeviceName"]; }
            set { this["DeviceName"] = value; }
        }

        [ConfigurationProperty("ServerUrl", IsRequired = true)]
        public string ServerUrl
        {
            get { return (String)this["ServerUrl"]; }
            set { this["ServerUrl"] = value; }
        }
    }
}