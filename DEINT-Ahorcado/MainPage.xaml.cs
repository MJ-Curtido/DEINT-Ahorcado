using DEINT_Ahorcado.Model;

namespace DEINT_Ahorcado;

public partial class MainPage : ContentPage
{
	private Ahorcado ahorcado;
    private int count = 0;
	private String palabraSecreta;
	private String palabraGuion;
	private int contFallos;

    public MainPage()
	{
		InitializeComponent();
		ahorcado = new Ahorcado();
		
		BindingContext = ahorcado;

        palabraSecreta = ahorcado.getPalabraSecreta();
		palabraGuion = "";
		for (int i = 0; i < palabraSecreta.Length; i++)
		{
			palabraGuion += "_";
		}

		contFallos = 0;
    }

    private void Button_Clicked(object sender, EventArgs e)
	{
		Button btn = (Button)sender;

		if (!comprobarLetra(btn.Text[0]))
		{
			contFallos++;
			imgAhorcado.Source = "img" + contFallos + ".jpg";
		}

        btn.IsEnabled = false;
    }

	private Boolean comprobarLetra(Char letra)
	{
		Boolean esta = false;

		for (int i = 0; i < palabraSecreta.Length; i++)
		{
			if (palabraSecreta[i] == letra)
			{
				palabraGuion.Insert(i, letra + "").Remove(i + 1, 1);
				esta = true;
			}
		}

		return esta;
	}
}

