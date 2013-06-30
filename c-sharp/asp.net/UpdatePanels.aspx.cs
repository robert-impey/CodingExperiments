using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdatePanels : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            onLoadLiteral.Text = DateTime.Now.ToString();
        }
    }

    protected void updateButton_Click(object sender, EventArgs e)
    {
        inUpdatePanelLiteral.Text = DateTime.Now.ToString();
    }

    protected void outsideUpdatePanelButton_Click(object sender, EventArgs e)
    {
        outsideUpdatePanelLiteral.Text = DateTime.Now.ToString();
    }
}