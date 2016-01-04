<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="Midterm3.aspx.cs" Inherits="LandiLab4Se426.Midterm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="mtp_one_wrapper">
        <div class="row">
            <div class="col-md-12">
                <div class="page-header text-center">
                    <h1 class="font_white">Problem 3</h1>
                    <p class="font_white"><!--{problem details}-->
                        You have open the xml file provided (Nutrition.xml) and output the following informatio.<br/>
                        The name and total calories of each food item that has more that 10 of vitamin A<br/>
                        The Name of all food that is a meat type. <br />
                        You will have one button and will output each set of data to a different control.
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
                            Height="300" Width="350" 
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