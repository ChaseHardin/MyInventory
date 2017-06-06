using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyInventory.API.Tests.Context;
using MyInventory.API.Tests.Infrastructure;
using TechTalk.SpecFlow;

namespace MyInventory.API.Tests.Steps
{
    [Binding]
    public sealed class JsonSteps
    {
        private static readonly JsonGetter JsonGetter = new JsonGetter(new Dictionary<string, string>
        {
        });

        [Then(@"the JSON at '(.*)' should be '(.*)'")]
        public void ThenTheJsonAtShouldBe(string jsonSelector, string expected)
        {
            var expectedWithSubstitutions = MyInventoryFeatureContext.Get().SubstitueKeys(expected);
            var jsonSelectorWithSubstitues = MyInventoryFeatureContext.Get().SubstitueKeys(jsonSelector);
            var actual = JsonGetter.GetProperty(HttpContext.Get().Json, jsonSelectorWithSubstitues);
            Assert.AreEqual(
                expectedWithSubstitutions,
                actual.ToString(),
                string.Format("Does not equal expected value at {0}", jsonSelector));
        }
    }
}
