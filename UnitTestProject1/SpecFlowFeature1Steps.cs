using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.obj
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        string TestPassageDataEntreStep;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            //ScenarioContext.Current.Pending();
            TestPassageDataEntreStep = "valeur une";
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            if (TestPassageDataEntreStep == "valeur une")
                TestPassageDataEntreStep = "valeur deux";
            else
                TestPassageDataEntreStep = "valeur trois";
        }
        
        [Then(@"the result shouldt be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.IsTrue(TestPassageDataEntreStep == "valeur deux", "La valeur vaux: "+TestPassageDataEntreStep);
        }

        [Then(@"toujours (.*) vrai")]
        public void ThenAlwaysTrue(int p0)
        {
            Assert.IsTrue(p0==2);
        }

        [Then(@"toujours (.*) faux")]
        public void ThenAlwaysFalse(int p0)
        {
            Assert.IsTrue(false, "oups les carottes sont cuites");
        }
    }
}
