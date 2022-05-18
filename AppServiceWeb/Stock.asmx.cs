using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
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
        public string GetPriceById(string id)
        {
            string price="Erreur";
            SqlConnection cn = new SqlConnection(@"data source=.\sqlexpress;initial catalog= NorthWind;user id=sa;password=P@ssw0rd");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select unitprice from Products where Productid= @id", cn);
            cmd.Parameters.AddWithValue("@id", id);
            try { 
            var p = cmd.ExecuteScalar();
                if (p != null)
                    price = p.ToString();
                else
                    p = "id introuvable";
           }
            catch(Exception ex)
            {

            }
            cmd = null;
            cn.Close();
            cn = null;



            return price;
        }


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
