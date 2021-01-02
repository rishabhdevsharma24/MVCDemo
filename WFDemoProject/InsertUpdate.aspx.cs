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
    public partial class InsertUpdate : System.Web.UI.Page
    {
        Implemantation imp = new Implemantation();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            XpayDetails xp = new XpayDetails();
            string Name = Convert.ToString(TextBox1.Text);
            decimal Amount = Convert.ToDecimal(TextBox2.Text);
            string Description = Convert.ToString(TextBox3.Text);
            string TermAndCondition = Convert.ToString(TextBox4.Text);
            xp.Name = Name;
            xp.Amount = Amount;
            xp.Description = Description;
            xp.TermAndCondition = TermAndCondition;
            imp.Insert_record(xp);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            XpayDetails xp = new XpayDetails();
            string Name = Convert.ToString(TextBox1.Text);
            decimal Amount = Convert.ToDecimal(TextBox2.Text);
            string Description = Convert.ToString(TextBox3.Text);
            string TermAndCondition = Convert.ToString(TextBox4.Text);
            int Id = Convert.ToInt32(TextBox5.Text);
            xp.Name = Name;
            xp.Amount = Amount;
            xp.Description = Description;
            xp.TermAndCondition = TermAndCondition;
            xp.Id = Id;
            imp.Update_Record(xp);
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}