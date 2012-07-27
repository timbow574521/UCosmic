﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.17626
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UCosmic.Www.Mvc.Areas.Identity
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class UpdateMyNameFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UpdateName.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Update My Name", "  In order to control what UCosmic says about me\r\n  As a UCosmic user\r\n  I want t" +
                    "o update my name", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Update My Name")))
            {
                UCosmic.Www.Mvc.Areas.Identity.UpdateMyNameFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Display and select example Salutation and Suffix values after clicking down arrow" +
            " buttons")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Update My Name")]
        public virtual void DisplayAndSelectExampleSalutationAndSuffixValuesAfterClickingDownArrowButtons()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display and select example Salutation and Suffix values after clicking down arrow" +
                    " buttons", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 8
    testRunner.Given("I am signed in as any1@usil.edu.pe");
#line 9
    testRunner.And("I am starting from the Personal Home page");
#line 12
    testRunner.When("I click the autocomplete dropdown arrow button for the Salutation combo field");
#line 13
    testRunner.Then("I should see an autocomplete dropdown menu item \"Dr.\" for the Salutation combo fi" +
                    "eld");
#line 14
    testRunner.When("I click the autocomplete dropdown menu item \"Dr.\" for the Salutation combo field");
#line 15
    testRunner.Then("I should see \"Dr.\" in the Salutation text field");
#line 18
    testRunner.When("I click the autocomplete dropdown arrow button for the Salutation combo field");
#line 19
    testRunner.Then("I should see an autocomplete dropdown menu item \"Mr.\" for the Salutation combo fi" +
                    "eld");
#line 20
    testRunner.When("I click the autocomplete dropdown menu item \"Mr.\" for the Salutation combo field");
#line 21
    testRunner.Then("I should see \"Mr.\" in the Salutation text field");
#line 24
    testRunner.When("I click the autocomplete dropdown arrow button for the Salutation combo field");
#line 25
    testRunner.Then("I should see an autocomplete dropdown menu item \"Ms.\" for the Salutation combo fi" +
                    "eld");
#line 26
    testRunner.When("I click the autocomplete dropdown menu item \"Ms.\" for the Salutation combo field");
#line 27
    testRunner.Then("I should see \"Ms.\" in the Salutation text field");
#line 30
    testRunner.When("I click the autocomplete dropdown arrow button for the Salutation combo field");
#line 31
    testRunner.Then("I should see an autocomplete dropdown menu item \"Prof.\" for the Salutation combo " +
                    "field");
#line 32
    testRunner.When("I click the autocomplete dropdown menu item \"Prof.\" for the Salutation combo fiel" +
                    "d");
#line 33
    testRunner.Then("I should see \"Prof.\" in the Salutation text field");
#line 36
    testRunner.When("I click the autocomplete dropdown arrow button for the Salutation combo field");
#line 37
    testRunner.Then("I should see an autocomplete dropdown menu item \"[None]\" for the Salutation combo" +
                    " field");
#line 38
    testRunner.When("I click the autocomplete dropdown menu item \"[None]\" for the Salutation combo fie" +
                    "ld");
#line 39
    testRunner.Then("I should see \"\" in the Salutation text field");
#line 42
    testRunner.When("I click the autocomplete dropdown arrow button for the Suffix combo field");
#line 43
    testRunner.Then("I should see an autocomplete dropdown menu item \"Esq.\" for the Suffix combo field" +
                    "");
#line 44
    testRunner.When("I click the autocomplete dropdown menu item \"Esq.\" for the Suffix combo field");
#line 45
    testRunner.Then("I should see \"Esq.\" in the Suffix text field");
#line 48
    testRunner.When("I click the autocomplete dropdown arrow button for the Suffix combo field");
#line 49
    testRunner.Then("I should see an autocomplete dropdown menu item \"Jr.\" for the Suffix combo field");
#line 50
    testRunner.When("I click the autocomplete dropdown menu item \"Jr.\" for the Suffix combo field");
#line 51
    testRunner.Then("I should see \"Jr.\" in the Suffix text field");
#line 54
    testRunner.When("I click the autocomplete dropdown arrow button for the Suffix combo field");
#line 55
    testRunner.Then("I should see an autocomplete dropdown menu item \"PhD\" for the Suffix combo field");
#line 56
    testRunner.When("I click the autocomplete dropdown menu item \"PhD\" for the Suffix combo field");
#line 57
    testRunner.Then("I should see \"PhD\" in the Suffix text field");
#line 60
    testRunner.When("I click the autocomplete dropdown arrow button for the Suffix combo field");
#line 61
    testRunner.Then("I should see an autocomplete dropdown menu item \"Sr.\" for the Suffix combo field");
#line 62
    testRunner.When("I click the autocomplete dropdown menu item \"Sr.\" for the Suffix combo field");
#line 63
    testRunner.Then("I should see \"Sr.\" in the Suffix text field");
#line 66
    testRunner.When("I click the autocomplete dropdown arrow button for the Suffix combo field");
#line 67
    testRunner.Then("I should see an autocomplete dropdown menu item \"[None]\" for the Suffix combo fie" +
                    "ld");
#line 68
    testRunner.When("I click the autocomplete dropdown menu item \"[None]\" for the Suffix combo field");
#line 69
    testRunner.Then("I should see \"\" in the Suffix text field");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Display example Salutation and Suffix values by typing matching text info fields")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Update My Name")]
        public virtual void DisplayExampleSalutationAndSuffixValuesByTypingMatchingTextInfoFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display example Salutation and Suffix values by typing matching text info fields", ((string[])(null)));
#line 71
this.ScenarioSetup(scenarioInfo);
#line 73
    testRunner.Given("I am signed in as any1@usil.edu.pe");
#line 74
    testRunner.And("I am starting from the Personal Home page");
#line 77
    testRunner.When("I type \"[\" into the Salutation text field");
#line 78
    testRunner.Then("I should not see an autocomplete dropdown menu item \"[None]\" for the Salutation c" +
                    "ombo field");
#line 81
    testRunner.When("I type \"D\" into the Salutation text field");
#line 82
    testRunner.Then("I should see an autocomplete dropdown menu item \"Dr.\" for the Salutation combo fi" +
                    "eld");
#line 85
    testRunner.When("I type \"Dr.\" into the Salutation text field");
#line 86
    testRunner.Then("I should not see an autocomplete dropdown menu item \"Dr.\" for the Salutation comb" +
                    "o field");
#line 89
    testRunner.When("I type \"M\" into the Salutation text field");
#line 90
    testRunner.Then("I should see an autocomplete dropdown menu item \"Mr.\" for the Salutation combo fi" +
                    "eld");
#line 91
    testRunner.And("I should see an autocomplete dropdown menu item \"Ms.\" for the Salutation combo fi" +
                    "eld");
#line 94
    testRunner.When("I type \"Mr\" into the Salutation text field");
#line 95
    testRunner.Then("I should see an autocomplete dropdown menu item \"Mr.\" for the Salutation combo fi" +
                    "eld");
#line 96
    testRunner.And("I should not see an autocomplete dropdown menu item \"Ms.\" for the Salutation comb" +
                    "o field");
#line 99
    testRunner.When("I type \"[\" into the Suffix text field");
#line 100
    testRunner.Then("I should not see an autocomplete dropdown menu item \"[None]\" for the Suffix combo" +
                    " field");
#line 103
    testRunner.When("I type \"Es\" into the Suffix text field");
#line 104
    testRunner.Then("I should see an autocomplete dropdown menu item \"Esq.\" for the Suffix combo field" +
                    "");
#line 105
    testRunner.And("I should not see an autocomplete dropdown menu item \"Sr.\" for the Suffix combo fi" +
                    "eld");
#line 108
    testRunner.When("I type \"Esq.\" into the Suffix text field");
#line 109
    testRunner.Then("I should not see an autocomplete dropdown menu item \"Esq.\" for the Suffix combo f" +
                    "ield");
#line 112
    testRunner.When("I type \"P\" into the Suffix text field");
#line 113
    testRunner.Then("I should see an autocomplete dropdown menu item \"PhD\" for the Suffix combo field");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Generate Display Name and then revert back to user entered Display Name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Update My Name")]
        public virtual void GenerateDisplayNameAndThenRevertBackToUserEnteredDisplayName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate Display Name and then revert back to user entered Display Name", ((string[])(null)));
#line 115
this.ScenarioSetup(scenarioInfo);
#line 117
    testRunner.Given("I am signed in as any1@usil.edu.pe");
#line 118
    testRunner.And("I am starting from the Personal Home page");
#line 121
    testRunner.When("I uncheck the Automatically Generate Display Name check box");
#line 122
    testRunner.And("I type \"Test Display Name\" into the Display Name text field");
#line 123
    testRunner.And("I type \"\" into the Salutation text field");
#line 124
    testRunner.And("I type \"\" into the First Name text field");
#line 125
    testRunner.And("I type \"\" into the Middle Name Or Initial text field");
#line 126
    testRunner.And("I type \"\" into the Last Name text field");
#line 127
    testRunner.And("I type \"\" into the Suffix text field");
#line 128
    testRunner.And("I check the Automatically Generate Display Name check box");
#line 129
    testRunner.Then("I should see \"\" in the Display Name text field");
#line 130
    testRunner.When("I uncheck the Automatically Generate Display Name check box");
#line 131
    testRunner.Then("I should see \"Test Display Name\" in the Display Name text field");
#line 134
    testRunner.When("I type \"Dr.\" into the Salutation text field");
#line 135
    testRunner.And("I check the Automatically Generate Display Name check box");
#line 136
    testRunner.Then("I should see \"Dr.\" in the Display Name text field");
#line 137
    testRunner.When("I uncheck the Automatically Generate Display Name check box");
#line 138
    testRunner.Then("I should see \"Test Display Name\" in the Display Name text field");
#line 141
    testRunner.When("I type \"\" into the Salutation text field");
#line 142
    testRunner.And("I type \"Any\" into the First Name text field");
#line 143
    testRunner.And("I check the Automatically Generate Display Name check box");
#line 144
    testRunner.Then("I should see \"Any\" in the Display Name text field");
#line 145
    testRunner.When("I uncheck the Automatically Generate Display Name check box");
#line 146
    testRunner.Then("I should see \"Test Display Name\" in the Display Name text field");
#line 149
    testRunner.When("I type \"\" into the First Name text field");
#line 150
    testRunner.And("I type \"Single\" into the Middle Name Or Initial text field");
#line 151
    testRunner.And("I check the Automatically Generate Display Name check box");
#line 152
    testRunner.Then("I should see \"Single\" in the Display Name text field");
#line 153
    testRunner.When("I uncheck the Automatically Generate Display Name check box");
#line 154
    testRunner.Then("I should see \"Test Display Name\" in the Display Name text field");
#line 157
    testRunner.When("I type \"\" into the Middle Name Or Initial text field");
#line 158
    testRunner.And("I type \"One\" into the Last Name text field");
#line 159
    testRunner.And("I check the Automatically Generate Display Name check box");
#line 160
    testRunner.Then("I should see \"One\" in the Display Name text field");
#line 161
    testRunner.When("I uncheck the Automatically Generate Display Name check box");
#line 162
    testRunner.Then("I should see \"Test Display Name\" in the Display Name text field");
#line 165
    testRunner.When("I type \"\" into the Last Name text field");
#line 166
    testRunner.And("I type \"PhD\" into the Suffix text field");
#line 167
    testRunner.And("I check the Automatically Generate Display Name check box");
#line 168
    testRunner.Then("I should see \"PhD\" in the Display Name text field");
#line 169
    testRunner.When("I uncheck the Automatically Generate Display Name check box");
#line 170
    testRunner.Then("I should see \"Test Display Name\" in the Display Name text field");
#line 173
    testRunner.When("I type \"Dr.\" into the Salutation text field");
#line 174
    testRunner.And("I type \"Any\" into the First Name text field");
#line 175
    testRunner.And("I type \"Single\" into the Middle Name Or Initial text field");
#line 176
    testRunner.And("I type \"One\" into the Last Name text field");
#line 177
    testRunner.And("I type \"PhD\" into the Suffix text field");
#line 178
    testRunner.And("I check the Automatically Generate Display Name check box");
#line 179
    testRunner.Then("I should see \"Dr. Any Single One PhD\" in the Display Name text field");
#line 180
    testRunner.When("I uncheck the Automatically Generate Display Name check box");
#line 181
    testRunner.Then("I should see \"Test Display Name\" in the Display Name text field");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Update fails when Display Name is empty")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Update My Name")]
        public virtual void UpdateFailsWhenDisplayNameIsEmpty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update fails when Display Name is empty", ((string[])(null)));
#line 183
this.ScenarioSetup(scenarioInfo);
#line 185
    testRunner.Given("I am signed in as any1@usil.edu.pe");
#line 186
    testRunner.And("I am starting from the Personal Home page");
#line 188
    testRunner.When("I uncheck the Automatically Generate Display Name check box");
#line 189
    testRunner.And("I type \"\" into the Display Name text field");
#line 190
    testRunner.And("I click the \"Save Changes\" submit button");
#line 192
    testRunner.Then("I should still see the Personal Home page");
#line 193
    testRunner.And("I should see the Required error message for the Display Name text field");
#line 194
    testRunner.And("I should see \"\" in the Display Name text field");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void UpdateChangesPersonNameFields(string browser, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UsingFreshExamplePersonNameForAny1AtUsil"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update changes person name fields", @__tags);
#line 197
this.ScenarioSetup(scenarioInfo);
#line 199
    testRunner.Given(string.Format("I am using the {0} browser", browser));
#line 200
    testRunner.And("I am signed in as any1@usil.edu.pe");
#line 201
    testRunner.And("I am starting from the Personal Home page");
#line 203
    testRunner.When("I uncheck the Automatically Generate Display Name check box");
#line 204
    testRunner.And("I type \"Test Display Name 1\" into the Display Name text field");
#line 205
    testRunner.And("I type \"\" into the Salutation text field");
#line 206
    testRunner.And("I type \"\" into the First Name text field");
#line 207
    testRunner.And("I type \"\" into the Middle Name Or Initial text field");
#line 208
    testRunner.And("I type \"\" into the Last Name text field");
#line 209
    testRunner.And("I type \"\" into the Suffix text field");
#line 210
    testRunner.And("I click the \"Save Changes\" submit button");
#line 212
    testRunner.Then("I should see the Personal Home page");
#line 213
    testRunner.And("I should see the flash feedback message \"Your info was successfully updated.\"");
#line 214
    testRunner.And("I should see \"Test Display Name 1\" in the Display Name text field");
#line 215
    testRunner.And("I should see \"\" in the Salutation text field");
#line 216
    testRunner.And("I should see \"\" in the First Name text field");
#line 217
    testRunner.And("I should see \"\" in the Middle Name Or Initial text field");
#line 218
    testRunner.And("I should see \"\" in the Last Name text field");
#line 219
    testRunner.And("I should see \"\" in the Suffix text field");
#line 221
    testRunner.When("I type \"\" into the Display Name text field");
#line 222
    testRunner.And("I type \"Dr.\" into the Salutation text field");
#line 223
    testRunner.And("I type \"Adam\" into the First Name text field");
#line 224
    testRunner.And("I type \"B.\" into the Middle Name Or Initial text field");
#line 225
    testRunner.And("I type \"West\" into the Last Name text field");
#line 226
    testRunner.And("I type \"Sr.\" into the Suffix text field");
#line 227
    testRunner.And("I check the Automatically Generate Display Name check box");
#line 228
    testRunner.Then("I should see \"Dr. Adam B. West Sr.\" in the Display Name text field");
#line 230
    testRunner.When("I click the \"Save Changes\" submit button");
#line 231
    testRunner.Then("I should see the Personal Home page");
#line 232
    testRunner.And("I should see the flash feedback message \"Your info was successfully updated.\"");
#line 233
    testRunner.And("I should see \"Dr. Adam B. West Sr.\" in the Display Name text field");
#line 234
    testRunner.And("the Automatically Generate Display Name check box should be checked");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Update changes person name fields")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Update My Name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExamplePersonNameForAny1AtUsil")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Browser", "Chrome")]
        public virtual void UpdateChangesPersonNameFields_Chrome()
        {
            this.UpdateChangesPersonNameFields("Chrome", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Update changes person name fields")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Update My Name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExamplePersonNameForAny1AtUsil")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Browser", "Firefox")]
        public virtual void UpdateChangesPersonNameFields_Firefox()
        {
            this.UpdateChangesPersonNameFields("Firefox", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Update changes person name fields")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Update My Name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExamplePersonNameForAny1AtUsil")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MSIE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Browser", "MSIE")]
        public virtual void UpdateChangesPersonNameFields_MSIE()
        {
            this.UpdateChangesPersonNameFields("MSIE", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
