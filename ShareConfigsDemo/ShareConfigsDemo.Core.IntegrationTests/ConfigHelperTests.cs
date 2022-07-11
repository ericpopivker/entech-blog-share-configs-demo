using NUnit.Framework;

using ShareConfigsDemo.Core;

namespace ShareConfigsDemo.Core.IntegrationTests
{
    public class ConfigHelperTests
    {
    [Test]
    [TestCase(Env.Development, "DevelopmentValue1")]
    [TestCase(Env.IntegrationTests, "IntegrationTestsValue1")]
    [TestCase(Env.Staging, "StagingValue1")]
    [TestCase(Env.Production, "ProductionValue1")]
    public void Load_ValidEnv_Key1ValueIsBasedOnEnv(Env env, string key1Value)
    {
        var config = ConfigHelper.Load(env);
        Assert.AreEqual(key1Value, config.GetSection("Key1").Value);
    }
    }
}
