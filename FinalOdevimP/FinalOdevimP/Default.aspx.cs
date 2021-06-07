using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalOdevimP.Entity;

namespace FinalOdevimP
{
    public partial class Default : System.Web.UI.Page
    {
        FinalBlogProjeEntities db = new FinalBlogProjeEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var bloglar = db.TBLBLOG.ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();


            var bloglar2 = db.TBLKATEGORI.ToList();
            Repeater2.DataSource = bloglar2;
            Repeater2.DataBind();

            var bloglar3 = db.TBLBLOG.Take(3).ToList();
            Repeater3.DataSource = bloglar3;
            Repeater3.DataBind();

            var bloglar4 = db.TBLYORUM.Take(7).ToList();
            Repeater4.DataSource = bloglar4;
            Repeater4.DataBind();


        }
    }
}