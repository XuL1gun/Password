namespace MauiApp1;

public partial class MainPage : ContentPage
{
	private int _password = 99999;
	private string _charpass = "*****";
	private bool _passwordChanged = true;

	public MainPage()
	{
		InitializeComponent();
        DisplayLabel.Text = _charpass;
		DisplayLabel.Text += "\n";
    }
	private void DigitClicked(object sender, EventArgs e)
	{
		if (_passwordChanged)
			DisplayLabel.Text += (sender as Button).Text;
    }

	private void EqualsClicked(object sender, EventArgs e)
	{
		if (_passwordChanged && DisplayLabel.Text.Split("\n").Last() != "")
		{
			if ((Convert.ToInt32(DisplayLabel.Text.Split('\n').Last()) == _password))
			{
				DisplayLabel.Text = "Пароль введен правильно";
				_passwordChanged = false;
			}
			else
			{
				DisplayLabel.Text = "Пароль неверный. Введите заново.";
				DisplayLabel.Text += "\n";
				DisplayLabel.Text += _charpass;
				DisplayLabel.Text += "\n";
			}
		}
	}

	private void ClearClicked(object sender, EventArgs e)
	{
		DisplayLabel.Text = _charpass;
		DisplayLabel.Text += "\n";
		_passwordChanged = true;
	}
}

