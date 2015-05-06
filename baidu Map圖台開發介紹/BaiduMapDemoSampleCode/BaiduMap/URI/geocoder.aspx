<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="geocoder.aspx.cs" Inherits="BaiduMap.URI.geocoder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1025px;
            height: 475px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
  
        URI API - 地址解析<br />
        调用该接口可以在调起百度地图时，当前页面显示地址对应的坐标点。<br />
        服务地址<br />
        http://api.map.baidu.com/geocoder //PC&Webapp服务地址<br />
        <br />
        <img alt="" class="auto-style1" src="../image/geocoder.png" /><br />
        <asp:TextBox ID="txt_url" runat="server" Width="920px">http://api.map.baidu.com/geocoder?address=北京市海淀区上地信息路9号奎科科技大厦&output=html&src=yourCompanyName|yourAppName</asp:TextBox></br>
        <asp:Button ID="BtnDemo" runat="server" OnClick="BtnDemo_Click" Text="demo" /></br>

  
       

    </form>

    
</body>
</html>
