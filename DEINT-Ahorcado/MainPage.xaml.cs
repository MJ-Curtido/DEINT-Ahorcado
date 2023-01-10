using DEINT_Ahorcado.Model;

namespace DEINT_Ahorcado;

public partial class MainPage : ContentPage
{
	Ahorcado ahorcado;
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		ahorcado = new Ahorcado();

		BindingContext = ahorcado;
    }

	private void Button_Clicked(object sender, EventArgs e)
	{

	}
}

