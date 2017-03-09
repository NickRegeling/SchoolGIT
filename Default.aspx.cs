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

    protected void btnMaakKaart_Click(object sender, EventArgs e)
    {
        //Het maken van variabelen
        string Naam, Geslacht, Hobby, Opleiding;
        //Vullen van variabelen met een textbox/geselecteerde values/tekst
        Naam = txtNaam.Text;
        Geslacht = rbGeslacht.SelectedValue;
        Opleiding = cbOpleiding.SelectedValue;
        Hobby = "hobby: ";
        if (chkHobby.SelectedValue=="1")
        {
            Hobby += "Gamen";
        }
        if (chkHobby.SelectedValue=="2")
        {
            Hobby += "Programmeren";
        }
        //Het schrijven van de variabelen naar de browser
        Response.Write("Naam: " + Naam + "<br />");
        Response.Write(Hobby + "<br />");
        Response.Write("Opleiding; " + Opleiding + "<br />");
        Response.Write("Geslacht: " + Geslacht + "<br />");
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string Form;

        
        if (rbForm.SelectedValue=="1")
        {
            Panel1.Visible = true;
        }

        if (rbForm.SelectedValue=="2")
        {
            Panel1.Visible = false;
        }
    }
}