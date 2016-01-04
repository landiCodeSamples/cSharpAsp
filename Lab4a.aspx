<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Lab4a.aspx.cs" Inherits="LandiLab4Se426.Lab4a" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"></asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!--{Page Content}...................................................................-->
<div class="centerAll clearfix ">
    <div class="row">
        <div class="col-md-6">
            <div class="panel panel-warning">
                <div class="panel-heading">
                    <h4>Lab 4a Generate 10 day forcast for boston</h4>
                </div>
                <div class="panel-body">
                    <div class="form-group text-center">
                        <div class="row">                      
                            <div class="col-md-12"> 
                                                         
                                    <asp:TextBox ID="txtDisplayResults" 
                                        runat="server" Height="400" Width="400" BackColor="LightGray"
                                        TextMode="MultiLine" 
                                        CausesValidation="false" 
                                        ReadOnly="true" 
                                        Wrap="true">
                                    </asp:TextBox>
                                   
                                </div>    
                            </div>                  
                            <div class="row">
                                <div class="col-md-12">
                                    <asp:Button ID="btnGet7Day" 
                                        runat="server" 
                                        Text="Submit" 
                                        CausesValidation="false" 
                                        CssClass="btn-danger" 
                                        OnClick="btnGet7Day_Click" 
                                        />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        <div class="col-md-6">
            <div class="panel panel-success">
                <div class="panel-heading">
                    <h4>Lab 4a part 2 Get zipcodes</h4>
                </div>
                <div class="panel-body">
                    <div class="form-group text-center">
                        <div class="row">                      
                            <div class="col-md-12"> 
                                                         
                                    <asp:TextBox ID="txtDisplayGeoResults" 
                                        runat="server" Height="400" Width="400" BackColor="LightGray"
                                        TextMode="MultiLine" 
                                        CausesValidation="false" 
                                        ReadOnly="true" 
                                        Wrap="true">
                                    </asp:TextBox>
                                   
                                </div>    
                            </div>                  
                            <div class="row">
                                <div class="col-md-12">
                                    <asp:TextBox ID="txtUserZip" 
                                        runat="server" 
                                        CausesValidation="false" 
                                        placeholder="Enter Zip Code" 
                                        CssClass="input-sm">
                                    </asp:TextBox>
                                    <asp:Button ID="btnGetgeo" 
                                        runat="server" 
                                        Text="Cites by zip" 
                                        CausesValidation="false" 
                                        CssClass="btn-danger" 
                                        OnClick="getGeo_Click" 
                                        />
                                    <asp:Button ID="btnGetNearBy" 
                                        runat="server" 
                                        Text="Nearby Cites" 
                                        CausesValidation="false" 
                                        CssClass="btn-danger" 
                                        OnClick="btnGetNearBy_Click" 
                                        />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
<!--{End Page Content}...............................................................--> 

<!--{Modal Popups}...................................................................-->
<div id="aboutModal" class="modal fade">
    <div class="modal-dialog">
        <div class="modal-content text-justify help">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title">Lab4a</h4>
            </div>
            <div class="modal-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="center-block">
                            <p><img src="../img/abtLab4a.PNG" class="img-responsive" alt="" /></p>
                            <p><img src="../img/abtLab4a2.PNG" class="img-responsive" alt="" /></p>  
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!--{End Modal Popups}...............................................................-->
</asp:Content>