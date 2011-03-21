// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.5.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace SimpleCqrs.EventStore.SqlServer.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Insert events")]
    public partial class InsertEventsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "InsertEvents.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Insert events", "In order to add events to my SQL Server event store\nAs a Simple CQRS developer\nI " +
                    "want to pass an array of events and have them added to the appropriate table", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            this.FeatureBackground();
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
#line 7
 testRunner.Given("the connection string to my database is", "Data Source=DEGWCAUTHOND2\\SQLEXPRESS;Initial Catalog=test;Integrated Security=Tru" +
                    "e;MultipleActiveResultSets=True;", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Insert one domain event")]
        public virtual void InsertOneDomainEvent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Insert one domain event", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "EventDate",
                        "3/20/2010 3:01:04 AM"});
            table1.AddRow(new string[] {
                        "AggregateRootId",
                        "8312E92C-DF1C-4970-A9D5-6414120C3CF7"});
            table1.AddRow(new string[] {
                        "Sequence",
                        "2"});
#line 13
 testRunner.Given("I have a SomethingHappenedEvent to be added to the store with the following value" +
                    "s", ((string)(null)), table1);
#line 18
 testRunner.And("that event will serialize to \'Serialized Object\'");
#line 19
 testRunner.When("I add the domain events to the store");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "EventDate",
                        "Sequence",
                        "AggregateRootId"});
            table2.AddRow(new string[] {
                        "3/20/2010 3:01:04 AM",
                        "2",
                        "8312E92C-DF1C-4970-A9D5-6414120C3CF7"});
#line 20
 testRunner.Then("I should have the following events in the database", ((string)(null)), table2);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Insert two domain events")]
        public virtual void InsertTwoDomainEvents()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Insert two domain events", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "EventDate",
                        "3/20/2010 3:01:04 AM"});
            table3.AddRow(new string[] {
                        "AggregateRootId",
                        "8312E92C-DF1C-4970-A9D5-6414120C3CF7"});
            table3.AddRow(new string[] {
                        "Sequence",
                        "2"});
#line 25
 testRunner.Given("I have a SomethingHappenedEvent to be added to the store with the following value" +
                    "s", ((string)(null)), table3);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "EventDate",
                        "4/24/2010 3:01:04 AM"});
            table4.AddRow(new string[] {
                        "AggregateRootId",
                        "C3579C12-C29B-4F65-8D83-B79AC5C85718"});
            table4.AddRow(new string[] {
                        "Sequence",
                        "4"});
#line 30
 testRunner.Given("I have a SomethingElseHappenedEvent to be added to the store with the following v" +
                    "alues", ((string)(null)), table4);
#line 35
 testRunner.When("I add the domain events to the store");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "EventId",
                        "EventDate",
                        "Sequence",
                        "Data",
                        "AggregateRootId"});
            table5.AddRow(new string[] {
                        "1",
                        "3/20/2010 3:01:04 AM",
                        "2",
                        "Data1",
                        "8312E92C-DF1C-4970-A9D5-6414120C3CF7"});
            table5.AddRow(new string[] {
                        "2",
                        "4/24/2010 3:01:04 AM",
                        "4",
                        "Data2",
                        "C3579C12-C29B-4F65-8D83-B79AC5C85718"});
#line 36
 testRunner.Then("I should have the following events in the database", ((string)(null)), table5);
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
