﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Calculator.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Calculator", Description="\tI want to check the basic functionality of calculator in programmer mode", SourceFile="CalculatorOperations.feature", SourceLine=0)]
    public partial class CalculatorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CalculatorOperations.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Calculator", "\tI want to check the basic functionality of calculator in programmer mode", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void AddingTwoNumbers(string @case, string a, string b, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "addition"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding two numbers", @__tags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("I have a calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When(string.Format("I add two numbers {0} and {1}", a, b), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.Then(string.Format("The result should be {0} on the screen", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Adding two numbers, all positive", new string[] {
                "addition"}, SourceLine=10)]
        public virtual void AddingTwoNumbers_AllPositive()
        {
            this.AddingTwoNumbers("all positive", "60", "30", "90", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Adding two numbers, all negative", new string[] {
                "addition"}, SourceLine=10)]
        public virtual void AddingTwoNumbers_AllNegative()
        {
            this.AddingTwoNumbers("all negative", "-60", "-305", "-365", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Adding two numbers, positive and negative", new string[] {
                "addition"}, SourceLine=10)]
        public virtual void AddingTwoNumbers_PositiveAndNegative()
        {
            this.AddingTwoNumbers("positive and negative", "88", "-12", "76", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Adding two numbers, any number and zero", new string[] {
                "addition"}, SourceLine=10)]
        public virtual void AddingTwoNumbers_AnyNumberAndZero()
        {
            this.AddingTwoNumbers("any number and zero", "-5", "0", "-5", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddingThreeNumbers(string @case, string a, string b, string c, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "addition"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding three numbers", @__tags);
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("I have a calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.When(string.Format("I add three numbers {0} and {1} and {2}", a, b, c), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then(string.Format("The result should be {0} on the screen", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Adding three numbers, all positive", new string[] {
                "addition"}, SourceLine=23)]
        public virtual void AddingThreeNumbers_AllPositive()
        {
            this.AddingThreeNumbers("all positive", "60", "30", "9", "99", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Adding three numbers, all negative", new string[] {
                "addition"}, SourceLine=23)]
        public virtual void AddingThreeNumbers_AllNegative()
        {
            this.AddingThreeNumbers("all negative", "-60", "-305", "-10", "-375", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Adding three numbers, positive and negative", new string[] {
                "addition"}, SourceLine=23)]
        public virtual void AddingThreeNumbers_PositiveAndNegative()
        {
            this.AddingThreeNumbers("positive and negative", "88", "-12", "100", "176", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Adding three numbers, any number and zero", new string[] {
                "addition"}, SourceLine=23)]
        public virtual void AddingThreeNumbers_AnyNumberAndZero()
        {
            this.AddingThreeNumbers("any number and zero", "-5", "0", "5", "0", ((string[])(null)));
#line hidden
        }
        
        public virtual void MultiplyingTwoNumbers(string @case, string a, string b, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "multiplication"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiplying two numbers", @__tags);
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
 testRunner.Given("I have a calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
 testRunner.When(string.Format("I multiply two numbers {0} and {1}", a, b), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then(string.Format("The result should be {0} on the screen", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Multiplying two numbers, all positive", new string[] {
                "multiplication"}, SourceLine=36)]
        public virtual void MultiplyingTwoNumbers_AllPositive()
        {
            this.MultiplyingTwoNumbers("all positive", "60", "30", "1800", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Multiplying two numbers, positive and negative", new string[] {
                "multiplication"}, SourceLine=36)]
        public virtual void MultiplyingTwoNumbers_PositiveAndNegative()
        {
            this.MultiplyingTwoNumbers("positive and negative", "-88", "12", "-1056", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Multiplying two numbers, any number and zero", new string[] {
                "multiplication"}, SourceLine=36)]
        public virtual void MultiplyingTwoNumbers_AnyNumberAndZero()
        {
            this.MultiplyingTwoNumbers("any number and zero", "-5", "0", "0", ((string[])(null)));
#line hidden
        }
        
        public virtual void MultiplyingThreeNumbers(string @case, string a, string b, string c, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "multiplication"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiplying three numbers", @__tags);
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
 testRunner.Given("I have a calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
 testRunner.When(string.Format("I multiply three numbers {0} and {1} and {2}", a, b, c), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then(string.Format("The result should be {0} on the screen", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Multiplying three numbers, all positive", new string[] {
                "multiplication"}, SourceLine=48)]
        public virtual void MultiplyingThreeNumbers_AllPositive()
        {
            this.MultiplyingThreeNumbers("all positive", "60", "30", "9", "16200", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Multiplying three numbers, positive and negative", new string[] {
                "multiplication"}, SourceLine=48)]
        public virtual void MultiplyingThreeNumbers_PositiveAndNegative()
        {
            this.MultiplyingThreeNumbers("positive and negative", "-88", "12", "9", "-9504", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Multiplying three numbers, any numbers and zero", new string[] {
                "multiplication"}, SourceLine=48)]
        public virtual void MultiplyingThreeNumbers_AnyNumbersAndZero()
        {
            this.MultiplyingThreeNumbers("any numbers and zero", "-5", "0", "50", "0", ((string[])(null)));
#line hidden
        }
        
        public virtual void SubtractingTwoNumbers(string @case, string a, string b, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "subtraction"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subtracting two numbers", @__tags);
#line 54
this.ScenarioSetup(scenarioInfo);
#line 55
 testRunner.Given("I have a calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 56
 testRunner.When(string.Format("I subtract two numbers {0} and {1}", a, b), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.Then(string.Format("The result should be {0} on the screen", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subtracting two numbers, all positive", new string[] {
                "subtraction"}, SourceLine=60)]
        public virtual void SubtractingTwoNumbers_AllPositive()
        {
            this.SubtractingTwoNumbers("all positive", "60", "30", "30", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subtracting two numbers, positive and negative", new string[] {
                "subtraction"}, SourceLine=60)]
        public virtual void SubtractingTwoNumbers_PositiveAndNegative()
        {
            this.SubtractingTwoNumbers("positive and negative", "-88", "12", "-100", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subtracting two numbers, any number and zero", new string[] {
                "subtraction"}, SourceLine=60)]
        public virtual void SubtractingTwoNumbers_AnyNumberAndZero()
        {
            this.SubtractingTwoNumbers("any number and zero", "-5", "0", "-5", ((string[])(null)));
#line hidden
        }
        
        public virtual void SubtractingThreeNumbers(string @case, string a, string b, string c, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "subtraction"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subtracting three numbers", @__tags);
#line 66
this.ScenarioSetup(scenarioInfo);
#line 67
 testRunner.Given("I have a calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
 testRunner.When(string.Format("I subtract three numbers {0} and {1} and {2}", a, b, c), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then(string.Format("The result should be {0} on the screen", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subtracting three numbers, all positive", new string[] {
                "subtraction"}, SourceLine=72)]
        public virtual void SubtractingThreeNumbers_AllPositive()
        {
            this.SubtractingThreeNumbers("all positive", "60", "30", "9", "21", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subtracting three numbers, positive and negative", new string[] {
                "subtraction"}, SourceLine=72)]
        public virtual void SubtractingThreeNumbers_PositiveAndNegative()
        {
            this.SubtractingThreeNumbers("positive and negative", "-88", "12", "100", "-200", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subtracting three numbers, any number and zero", new string[] {
                "subtraction"}, SourceLine=72)]
        public virtual void SubtractingThreeNumbers_AnyNumberAndZero()
        {
            this.SubtractingThreeNumbers("any number and zero", "-5", "0", "5", "-10", ((string[])(null)));
#line hidden
        }
        
        public virtual void DividingTwoNumbers(string @case, string a, string b, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "division"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dividing two numbers", @__tags);
#line 78
this.ScenarioSetup(scenarioInfo);
#line 79
 testRunner.Given("I have a calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
 testRunner.When(string.Format("I divide two numbers {0} and {1}", a, b), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.Then(string.Format("The result should be {0} on the screen", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Dividing two numbers, bigger divider residual is zero", new string[] {
                "division"}, SourceLine=84)]
        public virtual void DividingTwoNumbers_BiggerDividerResidualIsZero()
        {
            this.DividingTwoNumbers("bigger divider residual is zero", "60", "30", "2", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Dividing two numbers, smaller divider result is zero", new string[] {
                "division"}, SourceLine=84)]
        public virtual void DividingTwoNumbers_SmallerDividerResultIsZero()
        {
            this.DividingTwoNumbers("smaller divider result is zero", "60", "305", "0", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Dividing two numbers, bigger divider residual is non zero", new string[] {
                "division"}, SourceLine=84)]
        public virtual void DividingTwoNumbers_BiggerDividerResidualIsNonZero()
        {
            this.DividingTwoNumbers("bigger divider residual is non zero", "60", "13", "4", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Dividing two numbers, divider is zero", new string[] {
                "division"}, SourceLine=84)]
        public virtual void DividingTwoNumbers_DividerIsZero()
        {
            this.DividingTwoNumbers("divider is zero", "0", "10", "0", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Dividing two numbers, two equal numbers", new string[] {
                "division"}, SourceLine=84)]
        public virtual void DividingTwoNumbers_TwoEqualNumbers()
        {
            this.DividingTwoNumbers("two equal numbers", "10000", "10000", "1", ((string[])(null)));
#line hidden
        }
        
        public virtual void DividingByZero(string @case, string a, string b, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "division_not_allowed"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dividing by zero", @__tags);
#line 92
this.ScenarioSetup(scenarioInfo);
#line 93
 testRunner.Given("I have a calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 94
 testRunner.When(string.Format("I divide two numbers {0} and {1}", a, b), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then("The result of division by zero is not allowed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Dividing by zero, divisior is zero", new string[] {
                "division_not_allowed"}, SourceLine=98)]
        public virtual void DividingByZero_DivisiorIsZero()
        {
            this.DividingByZero("divisior is zero", "88", "0", "Cannot divide by zero", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion