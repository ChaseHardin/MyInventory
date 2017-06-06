using MyInventory.API.Tests.Infrastructure;
using MyInventory.Data.Models;
using TechTalk.SpecFlow;

namespace MyInventory.API.Tests.Context
{
    public class MyInventoryFeatureContext
    {
        private readonly Substituter _substituter = new Substituter();

        public Inventory Inventory { get; set; }

        public MyInventoryFeatureContext AddSubstitute(string key, string value)
        {
            _substituter.AddSubstitute(key, value);
            return this;
        }

        public string SubstitueKeys(string s)
        {
            return _substituter.SubstitueKeys(s);
        }

        private MyInventoryFeatureContext() { }

        public static MyInventoryFeatureContext Get()
        {
            MyInventoryFeatureContext ctx;
            return ScenarioContext.Current.TryGetValue(out ctx) ? ctx : NewContext();
        }

        private static MyInventoryFeatureContext NewContext()
        {
            var ctx = new MyInventoryFeatureContext();
            ScenarioContext.Current.Set(ctx);
            return ctx;
        }
    }
}