using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlackJackApp
{
    public partial class hovedside : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void button_SelectPlayers_Click(object sender, EventArgs e)
        {
            int s = 0;
            try
            {
                s = Int32.Parse(TextBox1.Text);
            }
            catch (Exception)
            {
                label_SelectPlayers.ForeColor = System.Drawing.Color.Red;

            }
            if (s > 0 && s <= 4)
            {

                Session["SelectedPlayers"] = TextBox1.Text;
                
                Server.Transfer("Board2.aspx");
            }
        }
    }
    
}