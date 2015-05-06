using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiduMap.IOC
{
    public partial class navigation : System.Web.UI.Page
    {
        string API_URL = "http://api.map.baidu.com/telematics/v3/navigation";

        Dictionary<string, string> QueryStringAry = new Dictionary<string, string>();
        string strSN = "";
        string strAK = "";
        string strOrigin = "";
        string strDestination = "";
        string strRegion = "";
        string strOrigin_region="";
        string strDestination_region = "";
        string strRoute_type = "";
        string strWaypoints = "";
        string strOutput = "";
        string strCoord_type = "";
        string strOut_coord_type = "";
        string urlstr = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txt_ak.Text = BaiduKey.GetAK();
                txt_sk.Text = BaiduKey.GetSK();
            }
        }

        protected void BtnQry_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            strOrigin = txt_origin.Text;
            QueryStringAry.Add("origin", strOrigin);
            sb.Append("origin");
            sb.Append("=");
            sb.Append(strOrigin);
            sb.Append("&");

            strDestination= txt_destination.Text;
            QueryStringAry.Add("destination", strDestination);
            sb.Append("destination");
            sb.Append("=");
            sb.Append(strDestination);
            sb.Append("&");

            strRegion = txt_region.Text; //取Selected Text
            if (!String.IsNullOrEmpty(strRegion))
            {
                QueryStringAry.Add("region", strRegion);
                sb.Append("Region");
                sb.Append("=");
                sb.Append(strRegion);
                sb.Append("&");
            }

            strOrigin_region = txt_origin_region.Text; //取Selected Text
            if (!String.IsNullOrEmpty(strOrigin_region))
            {
                QueryStringAry.Add("origin_region", strOrigin_region);
                sb.Append("origin_region");
                sb.Append("=");
                sb.Append(strOrigin_region);
                sb.Append("&");
            }

            strDestination_region = txt_destination_region.Text; //取Selected Text
            if (!String.IsNullOrEmpty(strDestination_region))
            {
                QueryStringAry.Add("destination_region", strDestination_region);
                sb.Append("destination_region");
                sb.Append("=");
                sb.Append(strDestination_region);
                sb.Append("&");
            }

            strRoute_type = ddlRoute_type.SelectedItem.Value; //取Selected value
            if (!String.IsNullOrEmpty(strRoute_type))
            {
                QueryStringAry.Add("route_type", strRoute_type);
                sb.Append("route_type");
                sb.Append("=");
                sb.Append(strRoute_type);
                sb.Append("&");
            }

            strWaypoints = txt_waypoints.Text; //取Selected Text
            if (!String.IsNullOrEmpty(strWaypoints))
            {
                QueryStringAry.Add("waypoints", strWaypoints);
                sb.Append("waypoints");
                sb.Append("=");
                sb.Append(strWaypoints);
                sb.Append("&");
            }

            strOutput = ddlOutput.SelectedItem.Text; //取Selected Text
            if (!String.IsNullOrEmpty(strOutput))
            {
                QueryStringAry.Add("output", strOutput);
                sb.Append("output");
                sb.Append("=");
                sb.Append(strOutput);
                sb.Append("&");
            }

            strCoord_type = ddlCoord_type.SelectedItem.Value; //取Selected Value
            if (!String.IsNullOrEmpty(strCoord_type))
            {
                QueryStringAry.Add("corrd_type", strCoord_type);
                sb.Append("corrd_type");
                sb.Append("=");
                sb.Append(strCoord_type);
                sb.Append("&");
            }

            strOut_coord_type = ddlOut_Coord_type.SelectedItem.Value; //取Selected Value
            if (!String.IsNullOrEmpty(strOut_coord_type))
            {
                QueryStringAry.Add("out_coord_type", strOut_coord_type);
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

            urlstr = API_URL + "?" + sb.ToString();

            LiteralUrl.Text = urlstr;
        }
    }
}