using System;
using DesignPatterns.Patterns.Mediator;
using DesignPatterns.Patterns.Singleton;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestSingleton();
            TestMediator();
        }

        private static void TestMediator()
        {
            var feedbackForm = new FeedbackForm();
            feedbackForm.AnonymusCheckbox.Click();
            feedbackForm.AgreementToProcessPersonalDataCheckBox.Click();
            feedbackForm.FeedbackText.Text = "qwe";
            feedbackForm.FullNameText.Text = "dhkhgdfkgjkdfjgl";
            feedbackForm.SendButton.Click();
        }

        private static void TestSingleton()
        {
            var db1 = Database.GetInstance();
            var db2 = Database.GetInstance();
            Console.WriteLine(db1.Equals(db2));
            db1.ExecuteSqlExpression("SELECT * FROM Product");
        }
    }
}
