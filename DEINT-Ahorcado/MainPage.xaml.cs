using DEINT_Ahorcado.Model;

namespace DEINT_Ahorcado;

public partial class MainPage : ContentPage
{
	private Ahorcado ahorcado;
    private int count = 0;
	private String palabraSecreta;
	private String palabraSecretaSeparada;
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

        palabraGuion = String.Join(" ", palabraGuion.ToCharArray());

        lblGuiones.Text = palabraGuion;

        palabraSecretaSeparada =  String.Join(" ", palabraSecreta.ToCharArray());

        contFallos = 0;
    }

    private void Button_Clicked(object sender, EventArgs e)
	{
		Button btn = (Button)sender;

		if (!comprobarLetra(btn.Text[0]))
		{
			contFallos++;
			imgAhorcado.Source = "img" + contFallos + ".jpg";

			if (contFallos == 6)
			{
				juegoTerminado();
				lblFin.Text = "Has perdido :(";
				lblGuiones.Text = palabraSecretaSeparada;
			}

            lblNumErrores.Text = "Fallos: " + contFallos;
        }
		else
		{
			lblGuiones.Text = palabraGuion;

			if (comprobarGanado())
			{
                juegoTerminado();
                lblFin.Text = "Has ganado :)";
            }
		}

        btn.IsEnabled = false;
    }

	private Boolean comprobarLetra(Char letra)
	{
		Boolean esta = false;

		for (int i = 0; i < palabraSecretaSeparada.Length; i++)
		{
			if (palabraSecretaSeparada[i] == letra)
			{
                palabraGuion = palabraGuion.Insert(i, letra + "").Remove(i + 1, 1);
				esta = true;
			}
		}

		return esta;
	}

	public void juegoTerminado()
	{
        foreach (Button boton in flex.Children)
        {
            if (boton != null)
            {
                boton.IsEnabled = false;
            }
        }
    }

	public Boolean comprobarGanado()
	{
		Boolean ganado = true;

		for (int i = 0; i < palabraGuion.Length; i++)
		{
			if (palabraGuion[i] == '_')
			{
				ganado = false;
			}
		}

		return ganado;
	}
}

