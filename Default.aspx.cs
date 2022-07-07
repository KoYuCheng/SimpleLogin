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
    protected void Button1_Click(object sender, EventArgs e)
    {
        String[] acc = new String[5];
        String[] pass = new String[5];

        acc[0] = "a";
        acc[1] = "b";
        acc[2] = "c";
        acc[3] = "d";
        acc[4] = "e";
        pass[0] = "111";
        pass[1] = "222";
        pass[2] = "333";
        pass[3] = "444";
        pass[4] = "555";
        Boolean check = true;
        for (int i = 0; i < 5; i++) {
            if (tetacc.Text == acc[i] && tetpass.Text == pass[i])
            {
                //Session.Timeout = 1;
                check = true; 
                Session["data"] = tetacc.Text;
                Session["time"] = DateTime.Now;
                break; 
            }
            else
            {
                check = false;
                Label1.Visible = true;
                Label1.Text = "帳號密碼輸入錯誤!";
            }
        }
        if (check == true)
        {
            //Server.Transfer("Default2.aspx",true);
            Response.Redirect("Default2.aspx");
        }
           
       
    }
    protected void btnclean_Click(object sender, EventArgs e)
    {
        //清除
        Label1.Visible = false;
        tetacc.Text = string.Empty;
        tetpass.Text = string.Empty;
    }
}