namespace Ejercicio_4;
///<Summary>
///<Createddate>2023/06/20</Createddate>
///<company>SandBox</company>
///<lastmodificationdate>2023/06/21</lastmodificationdate>
///<lastmodificationdescription>
///Agregar mensaje de error
///</lastmodificationdescription>
///<lastmodifierautor>Lorena vasquez</lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Constructor de la clase 
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}
	/// <summary>
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void CounterBtn_Clicked(object sender, EventArgs e)
	{
		//se coloca las variables n,c,cu para asi luego hacer la multipicacion, primero usando 
		//c que será el cuadrado y cu que sera al cubo.
		if (!string.IsNullOrEmpty(N.Text))
		{
			int n, c, cu;
			n = Convert.ToInt32(N.Text);
			

			c = (n * n);
			C.Text = Convert.ToString(c);
			cu = (n * n * n);
			Cu.Text = Convert.ToString(cu);
		}
		else
		{
			DisplayAlert("Error", "Introduce todos los numeros", "ok");
		}
	}
}

