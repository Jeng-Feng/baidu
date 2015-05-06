using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiduMap.IOC
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string API_URL = "http://api.map.baidu.com/telematics/v3/travel_city";
        
        Dictionary<string, string> QueryStringAry = new Dictionary<string, string>();
        string strSN = "";
        string strAK = "";
        string strLocation = "";
        string strDay = "";
        string strOutput = "";
        string strCoord_type = "";
        string strOut_coord_type = "";
        string urlstr = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
          if(!IsPostBack ){
              txt_ak.Text = BaiduKey.GetAK();
              txt_sk.Text = BaiduKey.GetSK();
          }
        }

        protected void BtnQry_Click(object sender, EventArgs e)
        {

      
            StringBuilder sb = new StringBuilder();

            strLocation = txt_location.Text;
            QueryStringAry.Add("location", strLocation);
            sb.Append("location");
            sb.Append("=");
            sb.Append(strLocation);
            sb.Append("&");

            strDay = ddlDay.SelectedItem.Text;
            if (!String.IsNullOrEmpty(strDay))
            {
                QueryStringAry.Add("day", strDay);
                sb.Append("day");
                sb.Append("=");
                sb.Append(strDay);
                sb.Append("&");
            }

            strOutput = ddlOutput.SelectedItem.Text; //取Selected Text
            if (!String.IsNullOrEmpty(strOutput))
            {
                QueryStringAry.Add("Output", strOutput);
                sb.Append("output");
                sb.Append("=");
                sb.Append(strOutput);
                sb.Append("&");
            }

            strCoord_type = ddlCoord_type.SelectedItem.Value; //取Selected Value
            if (!String.IsNullOrEmpty(strCoord_type))
            {
                QueryStringAry.Add("Corrd_type", strCoord_type);
                sb.Append("corrd_type");
                sb.Append("=");
                sb.Append(strCoord_type);
                sb.Append("&");
            }

            strOut_coord_type = ddlOut_Coord_type.SelectedItem.Value; //取Selected Value
            if (!String.IsNullOrEmpty(strOut_coord_type)) 
            {
                QueryStringAry.Add("Out_coord_type", strOut_coord_type);
                sb.Append("out_coord_type");
                sb.Append("=");
                sb.Append(strOut_coord_type);
                sb.Append("&");
            }

            strSN = AKSNCaculater.CaculateAKSN(strAK, txt_sk.Text, API_URL, QueryStringAry);

            //querystring 參數ak=?&sn=? 要放在最後
            strAK = txt_ak.Text;
            QueryStringAry.Add("ak", strAK);
            sb.Append("ak");
            sb.Append("=");
            sb.Append(strAK);
            sb.Append("&");
            
            sb.Append("sn");
            sb.Append("=");
            sb.Append(strSN);
            sb.Append("&");
            sb.Remove(sb.Length - 1, 1); //去除querystring 最後的&符號

            urlstr = urlstr = API_URL + "?" + sb.ToString();

            LiteralUrl.Text = urlstr;
        }
   
    }
}