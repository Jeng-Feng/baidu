<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="navigation.aspx.cs" Inherits="BaiduMap.IOC.navigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  
        車聯網API - 駕車檢索(Navigation)<br />
        根據傳入起訖點，查詢駕車路線方案。<br />
        <br />
  
        ak：<asp:TextBox ID="txt_ak" runat="server" Width="322px"></asp:TextBox>
        <br />
        sk：<asp:TextBox ID="txt_sk" runat="server" Width="323px"></asp:TextBox>
        <br />
        起點名稱或經緯度(origin)：<asp:TextBox ID="txt_origin" runat="server" Width="161px">南京师范大学</asp:TextBox>
        <br />
        終點名稱或經緯度(destination)：<asp:TextBox ID="txt_destination" runat="server" Width="161px">中国政法大学</asp:TextBox>
        <br />
        城市名稱或縣名{同城搜尋時必填} (region)：<asp:TextBox ID="txt_region" runat="server" Width="161px">南京</asp:TextBox>
        <br />
        起點所在城市或縣{跨城搜尋時必填} (origin_region)：<asp:TextBox ID="txt_origin_region" runat="server" Width="161px">南京</asp:TextBox>
        <br />
        終點所在城市或縣{跨城搜尋時必填} (destination_region)：<asp:TextBox ID="txt_destination_region" runat="server" Width="161px">北京</asp:TextBox>
        <br />
        路徑規劃方式(route_type)：<asp:DropDownList ID="ddlRoute_type" runat="server">
            <asp:ListItem Value="0">最少時間</asp:ListItem>
            <asp:ListItem Value="1">最短路徑</asp:ListItem>
            <asp:ListItem Value="2">不走高速</asp:ListItem>
        </asp:DropDownList>
        <br />
        途經點位集合｛以"|"分隔地址名稱或經緯度｝(waypoints)：<asp:TextBox ID="txt_waypoints" runat="server" Width="161px"></asp:TextBox>
        <br />
        輸出資料格式(output)：<asp:DropDownList ID="ddlOutput" runat="server">
            <asp:ListItem>json</asp:ListItem>
            <asp:ListItem>xml</asp:ListItem>
        </asp:DropDownList>
        <br />
        請求參數坐標類型(coord_type)：<asp:DropDownList ID="ddlCoord_type" runat="server">
            <asp:ListItem></asp:ListItem> 
            <asp:ListItem Value="wgs84">gps坐標</asp:ListItem>
            <asp:ListItem Value="bd09ll">百度經緯度坐標</asp:ListItem>
            <asp:ListItem Value="bd09mc">百度墨卡托坐標</asp:ListItem>
            <asp:ListItem Value="gcj02">中國國測局加密坐標</asp:ListItem>
        </asp:DropDownList>
        <br />
        返回結果坐標類型out_coord_type：<asp:DropDownList ID="ddlOut_Coord_type" runat="server">
            <asp:ListItem></asp:ListItem> 
            <asp:ListItem Value="bd09ll">百度經緯度坐標</asp:ListItem>
            <asp:ListItem Value="bd09mc">百度墨卡托坐標</asp:ListItem>
            <asp:ListItem Value="gcj02">中國國測局加密坐標</asp:ListItem>
        </asp:DropDownList>
        <br />
        返回值呼叫函數名稱(callback)：<asp:TextBox ID="txt_callback" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BtnQry" runat="server" OnClick="BtnQry_Click" Text="查詢" />
  

        <br />
        <br />

        <asp:Literal ID="LiteralUrl" runat="server"></asp:Literal>
        <br />
        <br />
        <asp:Button ID="btnCp" runat="server" OnClientClick="clipData()" Text="複製至剪貼簿" />

        <script type="text/javascript">
        function clipData() {
            window.clipboardData.setData('Text', '<%= this.LiteralUrl.Text%>');
        }
        </script>
  

        <br />
        <br />
        <div>http://codebeautify.org/online-json-editor</div>
  

    </form>
</body>
</html>
