namespace Calculator;
using System;

public partial class MainPage : ContentPage
{
	// int count = 0;
	string currentText;


	public MainPage()
	{
		InitializeComponent();

	}

	// private void OnCounterClicked(object sender, EventArgs e)
	// {
	// 	count++;

	// 	if (count == 1)
	// 		CounterBtn.Text = $"Clicked {count} time";
	// 	else
	// 		CounterBtn.Text = $"Clicked {count} times";

	// 	SemanticScreenReader.Announce(CounterBtn.Text);
	// }

	private void OnButtonClick(object sender, EventArgs e)
	{
		Console.WriteLine("Button Clicked");
		Button button = (Button)sender;
		Console.WriteLine("sender text: " + button.Text);
		
		currentText = button.Text;
		this.result.Text+= currentText;
	}
}

