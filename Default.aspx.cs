using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{   
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// Método que al dar click en el botón enviar, dirá Hola + el nombre introducido + el apellido
    /// en caso de que tanto el campo de nombre como el de apellido no está vacío
    /// en el cuadro de texto
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Enviar_Click(object sender, EventArgs e)
    {
        bool hayError=false;
        //lblresultado.Text="Hola "+Texto.Text+" "+Request.Form["Apellidos"];
        if (string.IsNullOrEmpty(Nombre.Text))
        {
            label1error.Text = ("Error, el nombre no puede estar en blanco");
            hayError = true;
        }
        else
        {
            label1error.Text = ("");
        }
        if (string.IsNullOrEmpty(Apellidos.Text))
        {
            label2error.Text = ("Error, los apellidos no pueden estar en blanco");
            hayError = true;
        }
        else
        {
            label2error.Text = ("");
        }
        if (!hayError)
        {
            lblresultado.Text = "Hola " + Nombre.Text + " " + Apellidos.Text;
        }
    }
}