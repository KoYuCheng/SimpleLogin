using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            DateTime dt = DateTime.Now;

            if (Session["data"] == null)
            {
                Response.Write("<script>alert('登入時間過期!')</script>");
                Server.Transfer("Default.aspx");
            }

            String dd = Convert.ToString(Session["data"]);


            if (Request.Cookies[dd] != null)
            {

                tname.Text = Server.UrlDecode(Request.Cookies[dd]["name"]);
                ttel.Text = Server.UrlDecode(Request.Cookies[dd]["tel"]);
                tadd.Text = Server.UrlDecode(Request.Cookies[dd]["add"]);
                temail.Text = Server.UrlDecode(Request.Cookies[dd]["email"]);


            }
            else { tname.Text = ""; ttel.Text = ""; tadd.Text = ""; temail.Text = ""; }


        }
    }
    protected void btnchan_Click(object sender, EventArgs e)
    {
        //修改資料
            String dd = Convert.ToString(Session["data"]);
            Response.Cookies[dd]["name"] = Server.UrlEncode(tname.Text);
            Response.Cookies[dd]["tel"] = Server.UrlEncode(ttel.Text);
            Response.Cookies[dd]["add"] = Server.UrlEncode(tadd.Text);
            Response.Cookies[dd]["email"] = Server.UrlEncode(temail.Text);
            Response.Cookies[dd]["time"] = Server.UrlEncode(DateTime.Now.ToLongTimeString());   
    }
    protected void btnlogout_Click(object sender, EventArgs e)
    {
        //登出
        Response.Write("<script>alert('bye bye!')</script>");
        Session.Abandon();
        Server.Transfer("Default.aspx");
        
    }

}