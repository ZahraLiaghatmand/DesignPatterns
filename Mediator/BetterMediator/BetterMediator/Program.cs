using BetterMediator.Controls;
using BetterMediator.Mediator;
using BetterMediator.Mediators;

List<IMediator> observers = new();
TextBox userName = new(observers);
TextBox password = new(observers);
CheckBox agreement = new(observers);
Button signUp = new();

Mediator mediator = new(userName, password, agreement, signUp);

userName.Text = "Zahra";
password.Text = "Password";
agreement.IsChecked = true;
signUp.Click();
