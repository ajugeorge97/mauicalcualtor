namespace Calculator;
using System;

public partial class MainPage : ContentPage
{
	// int count = 0;
	private string currentText;
	private List<string> myList = new List<string>();
	private string Operator;
	private string frstNum;
	private string seconNum;


	public MainPage()
	{
		InitializeComponent();

	}


	private void OnButtonClick(object sender, EventArgs e)
	{
		Console.WriteLine("Button Clicked");
		Button button = (Button)sender;
		// Console.WriteLine("sender text: " + button.Text);
		
		currentText = button.Text;
		if (Operator == null)
		{
			this.frstNum+=currentText;
			Console.WriteLine("frstNum: " + frstNum);
			this.result.Text+= currentText;
		}
		else if (Operator != null)
		{
			this.seconNum = currentText;
			string result = this.Calculate(this.frstNum, this.seconNum, this.Operator).ToString();
			this.result.Text= result;
			this.frstNum = result;
			this.Operator = null;
			}
		
		
	}


	private double Calculate(string frstNum, string seconNum, string Operator)
	{
		double result = 0;
		float frst = Convert.ToFloat(frstNum);
		double secon = Convert.ToDouble(seconNum);
		if (Operator == "+")
		{
			result = frst + secon;
		}
		else if (Operator == "-")
		{
			result = frst - secon;
		}
		else if (Operator == "*")
		{
			result = frst * secon;
		}
		else if (Operator == "/")
		{
			result = frst / secon;
		}
		return result;
	}


	private void OnCalculate(object sender, EventArgs e)
	{
		// Console.WriteLine("Calculate Clicked");
		// this.myList.Add(this.result.Text);
		// Console.WriteLine("myList: " + myList[0]);

	}

	private void OnOperatorClick(object sender, EventArgs e)
	{
		Console.WriteLine("Operator Clicked");
		Button button = (Button)sender;
		
		Operator = button.Text;
		this.Operator= Operator;
		this.result.Text+= Operator;
	}

	private void OnClear(object sender, EventArgs e)
	{
		Console.WriteLine("Clear Clicked");
		this.result.Text = "";
		this.frstNum = "";
		this.seconNum = "";
		this.Operator = null;
		
	}

}

