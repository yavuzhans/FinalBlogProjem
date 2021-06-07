using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalOdevimP.Entity;
namespace FinalOdevimP.AdminSayfalar
{
    public partial class Bloglar : System.Web.UI.Page
    {

        FinalBlogProjeEntities db = new FinalBlogProjeEntities(); 
        protected void Page_Load(object sender, EventArgs e)
        {
           if(Session["KULLANICI"]==null)
            {

                Response.Redirect("~/Login.Aspx");
            }
            else
            {
                Response.Write("Hoş Geldiniz" + Session["KULLANICI"].ToString());
            }
            Repeater1.DataSource = db.TBLBLOG.ToList();
            Repeater1.DataBind();
        }
    }
}