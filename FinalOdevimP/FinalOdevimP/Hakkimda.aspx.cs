using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalOdevimP.Entity;
namespace FinalOdevimP
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        FinalBlogProjeEntities db = new FinalBlogProjeEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBLHAKKIMIZDA.ToList();
            Repeater1.DataBind();

        }
    }
}