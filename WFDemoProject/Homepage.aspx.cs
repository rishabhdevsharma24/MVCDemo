using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DemoRepository.DataAccess;
using DemoRepository.Model;

namespace WFDemoProject
{
    public partial class Homepage : System.Web.UI.Page
    {
        Implemantation imp = new Implemantation();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<XpayDetails> lst = new List<XpayDetails>();
            lst = imp.Show_Record();
            GridView1.DataSource = lst;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            XpayDetails xp = new XpayDetails();
            xp.Id = Convert.ToInt32(TextBox1.Text);
            imp.Dlt_Record(xp);

         
            Button1_Click(sender, e);

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertUpdate.aspx");
        }
    }
}