using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Data;
using System.Net;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        DataTable dt;

        void GetJSONFromUrl()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://covid19.ddc.moph.go.th/api/Deaths/round-1to2-line-list");

                dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
                
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void แสดงข้อมูล_Click(object sender, EventArgs e)
        {
            
            GetJSONFromUrl();
        }

        protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GetJSONFromUrl();
        }
    }
}