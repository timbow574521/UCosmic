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
    public partial class ResetPasswordFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ResetPassword.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ResetPassword", "  In order to sign into UCosmic.com after forgetting my password\r\n  As a UCosmic " +
                    "user\r\n  I want to reset my password using my email address", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "ResetPassword")))
            {
                UCosmic.Www.Mvc.Areas.Identity.ResetPasswordFeature.FeatureSetup(null);
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
        
        public virtual void ResetPasswordSucceedsAfterReceivingSecretConfirmationCode(string browser, string emailAddress, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UsingFreshExamplePasswords"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Reset Password succeeds after receiving secret confirmation code", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 9
    testRunner.Given(string.Format("I am using the {0} browser", browser));
#line 10
    testRunner.And("I am not signed on");
#line 11
    testRunner.And("I am starting from the Sign On page");
#line 13
    testRunner.When(string.Format("I type \"{0}\" into the Email Address text field", emailAddress));
#line 14
    testRunner.And("I click the \"Next >>\" submit button");
#line 15
    testRunner.Then("I should see the Enter Password page");
#line 16
    testRunner.And("I should see an \"I forgot my password\" link");
#line 18
    testRunner.When("I click the \"I forgot my password\" link");
#line 19
    testRunner.Then("I should see the Forgot Password page");
#line 20
    testRunner.And(string.Format("I should see \"{0}\" in the Email Address text field", emailAddress));
#line 21
    testRunner.And("I should see a \"Cancel\" link");
#line 24
    testRunner.When("I click the \"Cancel\" link");
#line 25
    testRunner.Then("I should see the Enter Password page");
#line 26
    testRunner.When("I click the \"I forgot my password\" link");
#line 27
    testRunner.Then("I should see the Forgot Password page");
#line 30
    testRunner.When("I type \"\" into the Email Address text field");
#line 31
    testRunner.And("I click the \"Send Confirmation Email\" submit button");
#line 32
    testRunner.Then("I should still see the Forgot Password page");
#line 33
    testRunner.And("I should see the Required error message for the Email Address text field");
#line 36
    testRunner.When("I type \"invalid email\" into the Email Address text field");
#line 37
    testRunner.And("I click the \"Send Confirmation Email\" submit button");
#line 38
    testRunner.Then("I should still see the Forgot Password page");
#line 39
    testRunner.And("I should see the Invalid error message for the Email Address text field");
#line 42
    testRunner.When("I type \"test@gmail.com\" into the Email Address text field");
#line 43
    testRunner.And("I click the \"Send Confirmation Email\" submit button");
#line 44
    testRunner.Then("I should still see the Forgot Password page");
#line 45
    testRunner.And("I should see the \'test@gmail.com not found\' error message for the Email Address t" +
                    "ext field");
#line 48
    testRunner.When(string.Format("I type \"{0}\" into the Email Address text field", emailAddress));
#line 49
    testRunner.And("I click the \"Send Confirmation Email\" submit button");
#line 50
    testRunner.Then("I should see the Confirm Email Ownership page");
#line 51
    testRunner.And(string.Format("I should see the flash feedback message \"A password reset email has been sent to " +
                        "{0}.\"", emailAddress));
#line 54
    testRunner.When("I click the \"Confirm Email Address\" submit button");
#line 55
    testRunner.Then("I should see the Required error message for the Confirmation Code text field");
#line 58
    testRunner.When("I type \"test\" into the Confirmation Code text field");
#line 59
    testRunner.And("I click the \"Confirm Email Address\" submit button");
#line 60
    testRunner.Then("I should see the Invalid error message for the Confirmation Code text field");
#line 63
    testRunner.When("I receive mail with the subject \"Password reset instructions for UCosmic.com\"");
#line 64
    testRunner.And("I type the mailed code into the Confirmation Code text field");
#line 65
    testRunner.And("I click the \"Confirm Email Address\" submit button");
#line 66
    testRunner.Then("I should see the Reset Password page");
#line 67
    testRunner.And("I should see the flash feedback message \"Your email address has been confirmed. P" +
                    "lease reset your password now.\"");
#line 70
    testRunner.When("I click the \"Reset Password\" submit button");
#line 71
    testRunner.Then("I should still see the Reset Password page");
#line 72
    testRunner.And("I should see the Required error message for the Password text field");
#line 73
    testRunner.And("I should see the Required error message for the Password Confirmation text field");
#line 76
    testRunner.When("I type \"pass\" into the Password text field");
#line 77
    testRunner.And("I click the \"Reset Password\" submit button");
#line 78
    testRunner.Then("I should still see the Reset Password page");
#line 79
    testRunner.But("I should see the \'Too Short\' error message for the Password text field");
#line 80
    testRunner.And("I should see the Required error message for the Password Confirmation text field");
#line 83
    testRunner.When("I type \"password\" into the Password text field");
#line 84
    testRunner.And("I click the \"Reset Password\" submit button");
#line 85
    testRunner.Then("I should still see the Reset Password page");
#line 86
    testRunner.But("I should not see any error messages for the Password text field");
#line 87
    testRunner.And("I should see the Required error message for the Password Confirmation text field");
#line 90
    testRunner.When("I type \"pass\" into the Password Confirmation text field");
#line 91
    testRunner.And("I click the \"Reset Password\" submit button");
#line 92
    testRunner.Then("I should still see the Reset Password page");
#line 93
    testRunner.But("I should not see any error messages for the Password text field");
#line 94
    testRunner.And("I should see the \'No Match\' error message for the Password Confirmation text fiel" +
                    "d");
#line 97
    testRunner.When("I type \"password\" into the Password Confirmation text field");
#line 98
    testRunner.And("I click the \"Reset Password\" submit button");
#line 99
    testRunner.Then("I should see the Enter Password page");
#line 100
    testRunner.And("I should see the flash feedback message \"You can now use your new password to sig" +
                    "n on.\"");
#line 103
    testRunner.When("I click the \"Sign On\" submit button");
#line 104
    testRunner.Then("I should still see the Enter Password page");
#line 105
    testRunner.And("I should see the Required error message for the Password text field");
#line 108
    testRunner.When("I type \"incorrect\" into the Password text field");
#line 109
    testRunner.And("I click the \"Sign On\" submit button");
#line 110
    testRunner.Then("I should still see the Enter Password page");
#line 111
    testRunner.And("I should see the \'Invalid with 4 remaining attempts\' error message for the Passwo" +
                    "rd text field");
#line 114
    testRunner.When("I type \"password\" into the Password text field");
#line 115
    testRunner.And("I click the \"Sign On\" submit button");
#line 116
    testRunner.Then("I should see the Personal Home page");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Reset Password succeeds after receiving secret confirmation code")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ResetPassword")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExamplePasswords")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Browser", "Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailAddress", "any1@usil.edu.pe")]
        public virtual void ResetPasswordSucceedsAfterReceivingSecretConfirmationCode_Chrome()
        {
            this.ResetPasswordSucceedsAfterReceivingSecretConfirmationCode("Chrome", "any1@usil.edu.pe", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Reset Password succeeds after receiving secret confirmation code")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ResetPassword")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExamplePasswords")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Browser", "Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailAddress", "any1@bjtu.edu.cn")]
        public virtual void ResetPasswordSucceedsAfterReceivingSecretConfirmationCode_Firefox()
        {
            this.ResetPasswordSucceedsAfterReceivingSecretConfirmationCode("Firefox", "any1@bjtu.edu.cn", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Reset Password succeeds after receiving secret confirmation code")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ResetPassword")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExamplePasswords")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MSIE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Browser", "MSIE")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EmailAddress", "any1@napier.ac.uk")]
        public virtual void ResetPasswordSucceedsAfterReceivingSecretConfirmationCode_MSIE()
        {
            this.ResetPasswordSucceedsAfterReceivingSecretConfirmationCode("MSIE", "any1@napier.ac.uk", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
