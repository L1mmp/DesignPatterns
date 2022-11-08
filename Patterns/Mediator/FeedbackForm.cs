using DesignPatterns.Patterns.Mediator.Abstrations;
using DesignPatterns.Patterns.Mediator.Models;
using System;

namespace DesignPatterns.Patterns.Mediator
{
	public class FeedbackForm : UIMediator
	{
		public Button SendButton;
		public Checkbox AnonymusCheckbox;
		public Checkbox AgreementToProcessPersonalDataCheckBox;
		public TextBox FeedbackText;
		public TextBox FullNameText;
		public FeedbackForm()
		{
			SendButton = new Button(this);
			AnonymusCheckbox = new Checkbox(this)
			{
				isChecked = true
			};
			FeedbackText = new TextBox(this);
			AgreementToProcessPersonalDataCheckBox = new Checkbox(this)
			{
				Visible = false
			};
			FullNameText = new TextBox(this)
			{
				Visible = false
			};
		}

		public override void Notify(UIComponent sender, string message)
		{
			if (sender == AnonymusCheckbox)
			{
				if (!AnonymusCheckbox.isChecked)
				{
					FullNameText.Visible = true;
					AgreementToProcessPersonalDataCheckBox.Visible = true;
				}
				else
				{
					FullNameText.Visible = false;
					AgreementToProcessPersonalDataCheckBox.Visible = false;
				}
			}
			if (sender == SendButton)
			{
				if (ValidateFeedbackData())
				{
					SendFeedback();
				}
			}
		}

		private bool ValidateFeedbackData()
		{
			if (!AgreementToProcessPersonalDataCheckBox.isChecked && !AnonymusCheckbox.isChecked)
			{
				Console.WriteLine("Подтвердите согласие на обработку персональных данных");
				return false;
			}
			else if (string.IsNullOrWhiteSpace(FullNameText.Text))
			{
				Console.WriteLine("ФИО должно быть заполнено");
				return false;
			}
			else if (string.IsNullOrWhiteSpace(FeedbackText.Text))
			{
				Console.WriteLine("Пустой отзыв будет не очень полезен)");
				return false;
			}
			else
			{
				return true;
			}
		}

		private void SendFeedback()
		{
			Console.WriteLine($"Ваш отзыв отправлен:\n{FeedbackText.Text}.\n{FullNameText.Text} благодарим за обратную связь!"); ;
		}
	}
}