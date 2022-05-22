﻿using System;
using DesignPatterns.Patterns.Adapter;
using DesignPatterns.Patterns.Adapter.Models;
using DesignPatterns.Patterns.Decorator;
using DesignPatterns.Patterns.Mediator;
using DesignPatterns.Patterns.Observer;
using DesignPatterns.Patterns.Observer.Models;
using DesignPatterns.Patterns.Singleton;

namespace DesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			//TestSingleton();
			//TestMediator();
			//TestDecorator();
			TestAdapter();
            TestObserver();
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

		private static void TestDecorator()
		{
			var dataSource = new FIleDataSource();
			var compDecorator = new ComprssionDecarator(dataSource);
			var encDecorator = new EncryptionDecarator(compDecorator);


			var data = "qwewqeqw";


			encDecorator.WriteData(data);

			encDecorator.ReadData();

		}

		private static void TestAdapter()
		{
			var sqModel = new SquareModel { Width = 5 };
			var rModel = new RoundModel { Radius = 5 };

			var hole = new RoundHole { Radius = 5 };

			var adapter = new RoundModelAdapter(sqModel);

			// Console.WriteLine(hole.IsFits(sqModel)); 
			Console.WriteLine(hole.IsFits(rModel));
			Console.WriteLine(hole.IsFits(adapter));


		}

        
        private static void TestObserver()
        {
            var item = new ShopItem()
            {
                Name = "qwe",
                Price = 250,
                Description = "123123123123"
            };

            var publisher = new ShopItemPublisher(item);
            var obs1 = new EmaiSubscriber();
            var obs2 = new PhoneSubscriber();

            publisher.AddSubscriber(obs1);
            publisher.AddSubscriber(obs2);

            item.Price = 150;
            
            publisher.ChangeShopItem(item);
            // publisher.ChangeShopItem(new ShopItem(){Name = "123", Price = 1500, Description = "qwe"});

        }
	}
}
