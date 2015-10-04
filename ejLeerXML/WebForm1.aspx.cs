using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace ejLeerXML
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            XmlTextReader TR = new XmlTextReader("C:\\Users\\u\\Visual Studio 2013\\ejLeerXML\\ejLeerXML\\definicion.xml"); //Crea un XmlTextReader abriendo el archivo
            string ultimaEtiqueta = ""; //cadena que almacena la ultima etiqueta
            while (TR.Read()) //ciclo mientras XmlTextReader está leendo
            {
                if (TR.NodeType == XmlNodeType.Element) //condicional cuando lee un tipo elemento
                {
                    txtlectura.Text += (new String(' ', TR.Depth * 3) + "<" + TR.Name + ">");
                    ultimaEtiqueta = TR.Name;
                    continue;
                }
                if (TR.NodeType == XmlNodeType.Text) //condicional cuando lee un tipo texto
                {
                    txtlectura.Text += TR.ReadContentAsString() + "</" + ultimaEtiqueta + ">";
                }
                else //de lo contrario, será un salto de línea
                    txtlectura.Text += "\r";
            }
        }

    }
}