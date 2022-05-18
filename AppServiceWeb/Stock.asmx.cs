using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AppServiceWeb
{
    /// <summary>
    /// Description résumée de Stock
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class Stock : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string lang="en")
        {
            string rep = "Hello World";
            if (lang == "fr")
                rep = "Bonjour le monde";
            else
                if (lang == "ar")
                    rep = "مرحبا بالعالم";
                else
                    if (lang == "es")
                        rep = "Hola el mundo";
            return rep;
        }
    }
}
