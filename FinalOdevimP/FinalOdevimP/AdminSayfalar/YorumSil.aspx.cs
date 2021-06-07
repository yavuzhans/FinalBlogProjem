using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalOdevimP.Entity;
namespace FinalOdevimP.AdminSayfalar
{
    public partial class YorumSil : System.Web.UI.Page
    {
        FinalBlogProjeEntities db = new FinalBlogProjeEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["YORUMID"]);
            var yorum = db.TBLYORUM.Find(x);
            db.TBLYORUM.Remove(yorum);
            db.SaveChanges();
            Response.Redirect("Yorumlar.Aspx");

        }
    }
}