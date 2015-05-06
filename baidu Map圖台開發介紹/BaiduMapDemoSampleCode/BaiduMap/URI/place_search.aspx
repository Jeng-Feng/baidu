<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="place_search.aspx.cs" Inherits="BaiduMap.URI.place_search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1492px;
            height: 2000px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
  
        URI API - POI(點位)搜尋<br />
        <br />
        <img alt="" class="auto-style1" src="../image/poi_search.png" /><br />
        <asp:TextBox ID="txt_url" runat="server" Width="1270px">http://api.map.baidu.com/place/search?query=海底捞&location=31.204055632862,121.41117785465&radius=1000&region=上海&output=html&src=yourCompanyName|yourAppName</asp:TextBox></br>
        <asp:Button ID="BtnDemo" runat="server" OnClick="BtnDemo_Click" Text="demo" /></br>
        
       

    </form>

    
</body>
</html>
