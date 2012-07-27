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
namespace UCosmic.Www.Mvc.Areas.InstitutionalAgreements
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class GenerateSummaryDescriptionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GenerateSummaryDescription.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Generate Summary Description", "  In order to identity agreements in a list\r\n  As an Institutional Agreement Mana" +
                    "ger\r\n  I want to automatically generate a summary description using Participants" +
                    ", Agreement Type, and Current Status", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Generate Summary Description")))
            {
                UCosmic.Www.Mvc.Areas.InstitutionalAgreements.GenerateSummaryDescriptionFeature.FeatureSetup(null);
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
        
        public virtual void FeatureBackground()
        {
#line 6
#line 8
    testRunner.Given("I am signed in as manager1@uc.edu");
#line 9
    testRunner.And("I am starting from the Institutional Agreement Management page");
#line hidden
        }
        
        public virtual void GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenAddingAnAgreement(string orNot, string term, string participant, string agreementType, string status, string generationExpected, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UsingFreshExampleUcInstitutionalAgreementData"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate summary description based on participants, type, and status when adding " +
                    "an agreement", @__tags);
#line 12
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 14
   testRunner.When("I click the \"Add a new agreement\" link");
#line 15
   testRunner.Then("I should see the Institutional Agreement Add page");
#line 17
   testRunner.When(string.Format("I type \"{0}\" into the Participant Search text field", term));
#line 18
   testRunner.Then(string.Format("I should{0} see an autocomplete dropdown menu item \"{1}\" for the Participant Sear" +
                        "ch combo field", orNot, participant));
#line 19
   testRunner.And(string.Format("I should{0} click the autocomplete dropdown menu item \"{1}\" for the Participant S" +
                        "earch combo field", orNot, participant));
#line 20
   testRunner.And(string.Format("I should{0} see an item for \"{1}\" in the Participants list", orNot, participant));
#line 22
   testRunner.When(string.Format("I type \"{0}\" into the Agreement Type text field", agreementType));
#line 23
   testRunner.And(string.Format("I type \"{0}\" into the Current Status text field", status));
#line 24
   testRunner.And("I check the Automatically Generate Summary Description check box");
#line 25
   testRunner.Then(string.Format("I should see \"{0}\" in the Summary Description text field", generationExpected));
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Generate summary description based on participants, type, and status when adding " +
            "an agreement")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Generate Summary Description")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExampleUcInstitutionalAgreementData")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OrNot", "n\'t")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Term", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Participant", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AgreementType", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GenerationExpected", "Institutional Agreement between University of Cincinnati and...")]
        public virtual void GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenAddingAnAgreement_Variant0()
        {
            this.GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenAddingAnAgreement("n\'t", "", "", "", "", "Institutional Agreement between University of Cincinnati and...", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Generate summary description based on participants, type, and status when adding " +
            "an agreement")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Generate Summary Description")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExampleUcInstitutionalAgreementData")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OrNot", "n\'t")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Term", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Participant", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AgreementType", "Activity Agreement")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GenerationExpected", "Activity Agreement between University of Cincinnati and...")]
        public virtual void GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenAddingAnAgreement_Variant1()
        {
            this.GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenAddingAnAgreement("n\'t", "", "", "Activity Agreement", "", "Activity Agreement between University of Cincinnati and...", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Generate summary description based on participants, type, and status when adding " +
            "an agreement")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Generate Summary Description")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExampleUcInstitutionalAgreementData")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OrNot", "n\'t")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Term", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Participant", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AgreementType", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status", "Dead")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GenerationExpected", "Institutional Agreement between University of Cincinnati and... - Status is Dead")]
        public virtual void GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenAddingAnAgreement_Variant2()
        {
            this.GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenAddingAnAgreement("n\'t", "", "", "", "Dead", "Institutional Agreement between University of Cincinnati and... - Status is Dead", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Generate summary description based on participants, type, and status when adding " +
            "an agreement")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Generate Summary Description")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExampleUcInstitutionalAgreementData")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OrNot", "n\'t")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Term", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Participant", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AgreementType", "Memorandum of Understanding")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status", "Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GenerationExpected", "Memorandum of Understanding between University of Cincinnati and... - Status is A" +
            "ctive")]
        public virtual void GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenAddingAnAgreement_Variant3()
        {
            this.GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenAddingAnAgreement("n\'t", "", "", "Memorandum of Understanding", "Active", "Memorandum of Understanding between University of Cincinnati and... - Status is A" +
                    "ctive", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Generate summary description based on participants, type, and status when adding " +
            "an agreement")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Generate Summary Description")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExampleUcInstitutionalAgreementData")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OrNot", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Term", "alf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Participant", "Alfred University (SUNY)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AgreementType", "Memorandum of Understanding")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status", "Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GenerationExpected", "Memorandum of Understanding between University of Cincinnati and Alfred Universit" +
            "y (SUNY) - Status is Active")]
        public virtual void GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenAddingAnAgreement_Variant4()
        {
            this.GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenAddingAnAgreement("", "alf", "Alfred University (SUNY)", "Memorandum of Understanding", "Active", "Memorandum of Understanding between University of Cincinnati and Alfred Universit" +
                    "y (SUNY) - Status is Active", ((string[])(null)));
        }
        
        public virtual void GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenEditingAnAgreement(string orNot, string term, string participant, string agreementType, string status, string generationExpected, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UsingFreshExampleUcInstitutionalAgreementData"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate summary description based on participants, type, and status when editing" +
                    " an agreement", @__tags);
#line 36
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 38
   testRunner.When("I click the \"Agreement, UC 02 test\" link");
#line 39
   testRunner.Then("I should see the Institutional Agreement Edit page");
#line 41
   testRunner.When(string.Format("I type \"{0}\" into the Participant Search text field", term));
#line 42
   testRunner.Then(string.Format("I should{0} see an autocomplete dropdown menu item \"{1}\" for the Participant Sear" +
                        "ch combo field", orNot, participant));
#line 43
   testRunner.And(string.Format("I should{0} click the autocomplete dropdown menu item \"{1}\" for the Participant S" +
                        "earch combo field", orNot, participant));
#line 44
   testRunner.And(string.Format("I should{0} see an item for \"{1}\" in the Participants list", orNot, participant));
#line 46
   testRunner.When(string.Format("I type \"{0}\" into the Agreement Type text field", agreementType));
#line 47
   testRunner.And(string.Format("I type \"{0}\" into the Current Status text field", status));
#line 48
   testRunner.And("I check the Automatically Generate Summary Description check box");
#line 49
   testRunner.Then(string.Format("I should see \"{0}\" in the Summary Description text field", generationExpected));
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Generate summary description based on participants, type, and status when editing" +
            " an agreement")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Generate Summary Description")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExampleUcInstitutionalAgreementData")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OrNot", "n\'t")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Term", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Participant", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AgreementType", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GenerationExpected", "Institutional Agreement between University of Cincinnati and...")]
        public virtual void GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenEditingAnAgreement_Variant0()
        {
            this.GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenEditingAnAgreement("n\'t", "", "", "", "", "Institutional Agreement between University of Cincinnati and...", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Generate summary description based on participants, type, and status when editing" +
            " an agreement")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Generate Summary Description")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExampleUcInstitutionalAgreementData")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OrNot", "n\'t")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Term", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Participant", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AgreementType", "Activity Agreement")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GenerationExpected", "Activity Agreement between University of Cincinnati and...")]
        public virtual void GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenEditingAnAgreement_Variant1()
        {
            this.GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenEditingAnAgreement("n\'t", "", "", "Activity Agreement", "", "Activity Agreement between University of Cincinnati and...", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Generate summary description based on participants, type, and status when editing" +
            " an agreement")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Generate Summary Description")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExampleUcInstitutionalAgreementData")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OrNot", "n\'t")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Term", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Participant", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AgreementType", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status", "Dead")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GenerationExpected", "Institutional Agreement between University of Cincinnati and... - Status is Dead")]
        public virtual void GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenEditingAnAgreement_Variant2()
        {
            this.GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenEditingAnAgreement("n\'t", "", "", "", "Dead", "Institutional Agreement between University of Cincinnati and... - Status is Dead", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Generate summary description based on participants, type, and status when editing" +
            " an agreement")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Generate Summary Description")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExampleUcInstitutionalAgreementData")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OrNot", "n\'t")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Term", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Participant", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AgreementType", "Memorandum of Understanding")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status", "Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GenerationExpected", "Memorandum of Understanding between University of Cincinnati and... - Status is A" +
            "ctive")]
        public virtual void GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenEditingAnAgreement_Variant3()
        {
            this.GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenEditingAnAgreement("n\'t", "", "", "Memorandum of Understanding", "Active", "Memorandum of Understanding between University of Cincinnati and... - Status is A" +
                    "ctive", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Generate summary description based on participants, type, and status when editing" +
            " an agreement")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Generate Summary Description")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UsingFreshExampleUcInstitutionalAgreementData")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OrNot", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Term", "alf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Participant", "Alfred University (SUNY)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:AgreementType", "Memorandum of Understanding")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status", "Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GenerationExpected", "Memorandum of Understanding between University of Cincinnati and Alfred Universit" +
            "y (SUNY) - Status is Active")]
        public virtual void GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenEditingAnAgreement_Variant4()
        {
            this.GenerateSummaryDescriptionBasedOnParticipantsTypeAndStatusWhenEditingAnAgreement("", "alf", "Alfred University (SUNY)", "Memorandum of Understanding", "Active", "Memorandum of Understanding between University of Cincinnati and Alfred Universit" +
                    "y (SUNY) - Status is Active", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
