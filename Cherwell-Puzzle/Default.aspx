<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cherwell_Puzzle._Default" MaintainScrollPositionOnPostback="true"%>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <b>Task provided:</b> <br /><br />
            1. The task, calculate the triangle coordinates for an image with right triangles such that <br />
            for a given row ( A - F ) and column ( 1 - 12 ) you can produce the layout provided. <br /><br />

            2. Give the vertex coordinates, calculate the row and column for the triangle.<br /><br />

            <b>Key elements: </b><br /> <br />
            Each non-hypotenuse side of the triagle is 10 pixels. <br /> <br />
            The grid is 60 pixels by 10 pixels <br /><br />



        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
    <asp:Panel ID="PColumnAndRow" runat="server" GroupingText="By Row and Column" BorderStyle="Solid" ForeColor="Black">
     What row is the triangle in:  <asp:DropDownList ID="ddlRow" runat="server"> </asp:DropDownList>
    <br />
    What column is the triangle in?  <asp:DropDownList ID="ddlColumn" runat="server"></asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btGetVertices" runat="server" Text="Get Vertices" OnClick="btGetVertices_Click" />
        <br />
        <br />
        <asp:Panel ID="pnAnswer" runat="server" Visible="false">
            The Vertices are: <br /><br />
            V1x, V1y = <asp:Label ID="lbV1" runat="server" Text=""></asp:Label><br />
            V2x, V2y = <asp:Label ID="lbV2" runat="server" Text=""></asp:Label><br />
            V3x, V3y =
            <asp:Label ID="lbV3" runat="server" Text=""></asp:Label>
            <br />
            <br />
            For the triangle in Row:&nbsp; <b><asp:Label ID="lbRow" runat="server" Text=""></asp:Label>&nbsp;</b>and Column:&nbsp; 
            <b><asp:Label ID="lbColumn" runat="server" Text=""></asp:Label></b> 
            
        </asp:Panel>
    </asp:Panel>
    <br />
    <asp:Panel ID="Vertices" runat="server" GroupingText="By Vertex" BorderStyle="Solid">
       
        <h1>Set One</h1>
        Vertex 1 X =<asp:TextBox ID="vertex1x" runat="server"></asp:TextBox>
        <br />        
        Vertex 1 Y=<asp:TextBox ID="vertex1y" runat="server"></asp:TextBox>
        <br />
        <h1>Set Two</h1>
        Vertex 2 X=<asp:TextBox ID="vertex2x" runat="server"></asp:TextBox>
        <br />       
        Vertex 2 Y=<asp:TextBox ID="vertex2y" runat="server"></asp:TextBox>
        <br />
        <h1>Set Three</h1>
        Vertex 3 X=<asp:TextBox ID="vertex3x" runat="server"></asp:TextBox>
        <br />
        Vertex 3 Y=<asp:TextBox ID="vertex3y" runat="server"></asp:TextBox>

        <br />
        <br />
        <br />
        <asp:Button ID="btGetRowColumn" runat="server" Text="Get Row & Column" OnClick="btGetRowColumn_Click" />
        <br />
        <br />
        <asp:Panel ID="pnAnswerRowCol" runat="server" Visible="true">
            The Vertices are: <br /><br />
            V1x, V1y = <asp:Label ID="v1" runat="server" Text=""></asp:Label><br />
            V2x, V2y = <asp:Label ID="v2" runat="server" Text=""></asp:Label><br />
            V3x, V3y = <asp:Label ID="v3" runat="server" Text=""></asp:Label>
            <br />
            <br />
            For the triangle in Row:&nbsp; <b><asp:Label ID="lbRowAnswer" runat="server" Text=""></asp:Label>&nbsp;</b>and Column:&nbsp; 
            <b><asp:Label ID="lbColumnAnswer" runat="server" Text=""></asp:Label></b> 
            
        </asp:Panel>
    </asp:Panel>
    
</asp:Content>
