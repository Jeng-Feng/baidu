﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiduMap.URI
{
    public partial class geocoder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnDemo_Click(object sender, EventArgs e)
        {
            string urlstr = txt_url.Text;
            Response.Redirect(urlstr);
        }

  
    }
}