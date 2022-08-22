<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calc.aspx.cs" Inherits="Calculadora.Calc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div runat="server"   style="background-color:#007fcf; margin-left:25%; margin-top:5%;  width:600px;border-radius:10px; ">
       
          <br />
        <hr />

        <div class="container" style="margin-bottom:5%; margin-top:5px;" >
        <asp:Label runat="server"  style="margin-left:14%; color:white;  font-size:30pt; font-family:'Lucida Sans Unicode';"  >Calculadora</asp:Label>
           <div class="row">
        <asp:TextBox runat="server" CssClass="textbox"  ClientIDMode="Static" ID="num1" ></asp:TextBox>
        <asp:TextBox runat="server" CssClass="textbox"  ClientIDMode="Static" ID="num2" ></asp:TextBox>
            </div>
       </div>

        <style type="text/css">


            
           .textbox{
               margin-left:95px;
               margin-top:5%;
                width: 150px;
                border: none;
                border-radius:10px;
                height:50px;
                font-size:15pt;
            }

           .textbox:focus{
               border:none;

           }
            .button{
                width:100px;
                height:50px;
                margin-top:5%;
                margin-left:12%;
                color:white;
                border-color:white;
                background-color:transparent;
                border-radius:10px;
                font-size:20pt;
                text-align:center;
                font-family:'Lucida Sans Unicode';
                margin-bottom:10%;
            }
                .button:hover {
                    color: #007fcf;
                    background-color: white;
                    transition: .4s;
                }
        </style>


        <asp:Button runat="server" ClientIDMode="Static" OnClick="soma_Click" ID="soma" Text="+" CssClass="button" />

         <asp:Button runat="server" ClientIDMode="Static" ID="menos" OnClick="menos_Click" Text="-"  CssClass="button"/>

         <asp:Button runat="server" ClientIDMode="Static" ID="vezes" OnClick="vezes_Click" Text="*"  CssClass="button"/>

         <asp:Button runat="server" ClientIDMode="Static" ID="divi" Text="/" OnClick="divi_Click"  CssClass="button"/>

         <asp:Button runat="server" ClientIDMode="Static" ID="apagar" Text="C" OnClick="apagar_Click" CssClass="button"/>

          <asp:Label runat="server" ID="Result" ClientIDMode="Static" style="margin-left:10%; color:white;  font-size:20pt; font-family:'Lucida Sans Unicode';"  >Resultado</asp:Label>


        <br />
        <hr />
        <br />

    </div>
    

</asp:Content>
