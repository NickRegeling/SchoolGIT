using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private int beoordeling = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnMaakSom_Click(object sender, EventArgs e)
    {


        int max = Int32.Parse(txtMax.Text);
        Random generator = new Random();

        foreach (Label l in this.Controls[3].Controls.OfType<Label>().Where(label => label.ID.Contains("som")))
        {
            l.Text = Convert.ToString(generator.Next(max) + 1);
        }
    }



    protected void btnAntwoord_Click(object sender, EventArgs e)
    {
        int getal1 = Int32.Parse(som1.Text);
        int getal2 = Int32.Parse(som2.Text);
        int getal3 = Int32.Parse(som3.Text);
        int getal4 = Int32.Parse(som4.Text);
        int getal5 = Int32.Parse(som5.Text);

        processDate(getal1, 1, lbl1, ant1);
        processDate(getal2, 2, lbl2, ant2);
        processDate(getal3, 3, lbl3, ant3);
        processDate(getal4, 4, lbl4, ant4);
        processDate(getal5, 5, lbl5, ant5);

        lblcijfer.Text = "Uw cijfer is : " + Convert.ToString(beoordeling * 2);
    }

    private void processDate(int cijfer, int x, Label label, TextBox field)
    {
        if (cijfer * x == Int32.Parse(field.Text))
        {
            label.Text = "Goed";
            field.ReadOnly = true;
            beoordeling++;
        }
        else
        {
            label.Text = "Fout";
        }
    }

    protected void btnrefresh_Click(object sender, EventArgs e)
    {
        Response.Redirect(Request.RawUrl);
    }
}