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
    /// Método que al dar click en el botón enviar, dirá Hola + el nombre introducido
    /// en el cuadro de texto
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Enviar_Click(object sender, EventArgs e)
    {
        lblresultado.Text="Hola "+Texto.Text;
    }
}