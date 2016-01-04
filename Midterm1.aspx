<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="Midterm1.aspx.cs" Inherits="LandiLab4Se426.Midterm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="mtp_one_wrapper">
        <div class="row">
            <div class="col-md-12">
                <div class="page-header text-center">
                    <h1 class="font_white">Problem 1</h1>
                    <p class="font_white"><!--{problem details}-->
                        You have been hired to work on a banking solution for a client. For this project,<br/> 
                        you will access a webservice and will return the total amount of money in all accounts. 
                        Webservice address: http://http://54.172.157.94/BankWebService/BankService.asmx
                    </p><!--{end problem details}-->
                </div>
            </div>
        </div>
        <div class="row"><!--{main content section}-->
            <div class="col-md-12">
                <div class="result_box center-block">
                    <div class="form-group text-center">
                        <asp:TextBox ID="txtShowResults"
                            runat="server" 
                            Height="300" Width="250" 
                            BackColor="LightGray"
                            TextMode="MultiLine" 
                            CausesValidation="false" 
                            ReadOnly="true" 
                            Wrap="true">
                        </asp:TextBox>
                        <br/><br/>
                        <asp:Button ID="btnGetResults"
                            runat="server" 
                            Text="Submit" 
                            CausesValidation="false" 
                            CssClass="btn-danger" 
                            OnClick="btnGetResults_Click"
                        />
                   </div>
                </div>
            </div>
        </div><!--{end main content}-->
    </div>
</asp:Content>
