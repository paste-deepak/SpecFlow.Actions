﻿using OpenQA.Selenium.Firefox;

namespace SpecFlow.Actions.Selenium.DriverOptions
{
    public class FirefoxDriverOptions : IDriverOptions
    {
        private readonly FirefoxOptions _firefoxOptions;

        public FirefoxDriverOptions()
        {
            _firefoxOptions = new FirefoxOptions();
        }

        public dynamic Value => _firefoxOptions;

        public bool ImplementsArgs => true;

        public void AddAdditionalCapability(string capabilityName, object capabilityValue)
        {
            _firefoxOptions.AddAdditionalCapability(capabilityName, capabilityValue, true);
        }

        public void AddArguments(params string[] argumentsToAdd)
        {
            _firefoxOptions.AddArguments(argumentsToAdd);
        }
    }
}