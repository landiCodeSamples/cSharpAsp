<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Lab4.aspx.cs" Inherits="LandiLab4Se426.Lab4"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<!--{Page Content}...................................................................-->
<div class="centerAll clearfix ">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <h4>Generate Stock Quotes</h4>
                </div>
                <div class="panel-body">
                    <div class="form-group center-block">
                        <div class="row">
                            <div class="col-md-6">
                                <h3>Admin Results</h3>
                                <asp:TextBox ID="txtAdminResults" 
                                    runat="server" 
                                    CssClass="btn-block" 
                                    TextMode="MultiLine" 
                                    CausesValidation="false" ReadOnly="True">

                                </asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <h3>User Results</h3>
                                <asp:TextBox ID="txtUserResults" 
                                    runat="server" 
                                    CssClass="btn-block" 
                                    TextMode="MultiLine" 
                                    CausesValidation="false" ReadOnly="True">
                                </asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <h3>Enter Stock</h3>
                                <asp:TextBox ID="txtInput" runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:Button ID="btnGetResults" 
                                    runat="server" 
                                    Text="Submit" CausesValidation="false" 
                                    OnClick="btnGetResults_Click" />
                                <br/><br/>
                                <asp:Label ID="lblmessage" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
 <!--{End Page Content}..............................................................--> 
      
<!--{Modal Popups}...................................................................-->
<div id="aboutModal" class="modal fade">
    <div class="modal-dialog">
        <div class="modal-content text-justify help">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title">Lab 2 Using XPATH</h4>
            </div>
            <div class="modal-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="center-block">
                          
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!--{End Modal Popups}...............................................................-->
</asp:Content>