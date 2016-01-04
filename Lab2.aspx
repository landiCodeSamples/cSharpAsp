<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Lab2.aspx.cs" Inherits="LandiLab4Se426.Lab2" %>

   <asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="centerAll clearfix ">
            <div class="row">
                <div class="col-sm-6 col-md-6 col-lg-6">
                    <div class="panel panel-info">
                        <div class="panel-heading">
                            <h4>Generate Invoice Options</h4>
                        </div>
                    <div class="panel-body">
                        <div class="form-group center-block">
                            <asp:Button ID="btnBillInfo" runat="server" CssClass="btn-block" 
                                    CausesValidation="false" OnClick="btnBillInfo_Click" Text="Billing Info" />

                            <asp:Button ID="btnShipOnly" runat="server" CssClass="btn-block" 
                                    CausesValidation="false" OnClick="btnShipOnly_Click" Text="Shipping Info" />

                            <asp:Button ID="btnItemOnly" runat="server" CssClass="btn-block" 
                                    CausesValidation="false" OnClick="btnItemOnly_Click" Text="Item Info" />

                            <asp:Button ID="btnTotalItems" runat="server" CssClass="btn-block" 
                                    CausesValidation="false" OnClick="btnTotalItems_Click" Text="Total Items" />

                            <asp:Button ID="btnTotalCost" runat="server" CssClass="btn-block" 
                                    CausesValidation="false" OnClick="btnTotalCost_Click" Text="Total Cost" />

                                <asp:Button ID="btnshowAll" runat="server" CssClass="btn-block" 
                                    CausesValidation="false" OnClick="btnshowAll_Click" Text="Show All" />                              
                        </div>
                    </div> 
                </div>
                </div>
                <div class="col-sm-6 col-md-6 col-lg-6">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <h4>Billing Information</h4>
                        </div>
                        <div class="panel-body">
                            
                            <asp:Label ID="lblBinf" runat="server" Text=""></asp:Label>
                        </div>                    
                    </div>
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <h4>Shipping Information</h4>
                        </div>
                        <div class="panel-body">
                            
                            <asp:Label ID="lblSi" runat="server" Text=""></asp:Label>
                        </div>                    
                    </div>
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <h4>Item Information</h4>
                        </div>
                        <div class="panel-body">
                            
                            <asp:Label ID="lblInf" runat="server" Text=""></asp:Label>
                        </div>                    
                    </div>
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <h4>Total Items Purchased</h4>
                        </div>
                        <div class="panel-body">
                            
                            <asp:Label ID="lblTip" runat="server" Text=""></asp:Label>
                        </div>                    
                    </div>
                    <div class="panel panel-success">
                        <div class="panel-heading">
                            <h4>Total Order Cost</h4>
                        </div>
                        <div class="panel-body">
                            
                            <asp:Label ID="lblToc" runat="server" Text=""></asp:Label>
                        </div>                    
                    </div>
                </div>
            </div>
        </div>
 
    

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
                            <p>
                            For this lab you will create an invoice based on an XML file.  You need to use XPath statements to parse out the information 
                                – if you simply walk through the file line by line, or something equivalent to that technique, you will receive no credit 
                                for this lab.  If you aren’t sure if you are using the proper technique for this lab, please show me what you are doing so 
                                I can make sure. 
                            </p>
                            <p>
                            The invoice will be based on the OrderInfo.xml file that will be provided via Canvas.
                            The invoice needs to have the following sections:
                            Billing Information
                            Shipping Information
                            Item Information – with customer options if applicable
                            There are to be two additional line items, these are to be determined via one XPath statement each, do not loop through your code to determine the values.
                            Number of items bought
                            Total cost of the order
                            You may choose the output format of the invoice but it is to be presentable (i.e. carriage returns, look logical, etc.).
                            </p>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
        </div>
</asp:Content>