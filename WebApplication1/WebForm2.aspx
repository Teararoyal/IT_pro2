<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>


    <form id="form1" runat="server">
        <div>

            
            <h1>ข้อมูลผู้เสียชีวิตระลอก 1 ถึงระลอก 2 (ตั้งแต่ 12/01/2020 – 31/03/2021)</h1>
            
            <asp:Button ID="แสดงข้อมูล" runat="server" Text="แสดงข้อมูล" OnClick="แสดงข้อมูล_Click" />
            <asp:GridView runat="server" ID="GridView1" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging">
                <Columns>
                    <asp:BoundField DataField="province" HeaderText="จังหวัด" />
                    <asp:BoundField DataField="age" HeaderText="อายุ" />
                    <asp:BoundField DataField="occupation" HeaderText="อาชีพ" />
                    <asp:BoundField DataField="death_cluster" HeaderText="สถานที่" />
                    <asp:BoundField DataField="update_date" DataFormatString="{0:dd MMM yyyy}" HeaderText="วันที่" />
                </Columns>
            </asp:GridView>
            
        </div>
    </form>
</body>
</html>

