using BetterMediator.Controls;
using BetterMediator.Mediators;

TextBox userName = new();
TextBox password = new();
CheckBox agreement = new();
Button signUp = new();

Mediator mediator = new(userName, password, agreement, signUp);

userName.Text = "Zahra";
password.Text = "Password";
agreement.IsChecked = false;
signUp.Click();
