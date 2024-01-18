<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="adminLogin.aspx.cs" Inherits="Student_Management_Systems.Admin.adminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="../images/imgs/adminuser.png" width="150px"/>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Admin Login</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">

                                <label class="form-label">Admin email</label>
                                <div class="form-group">

                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Admin ID"></asp:TextBox>

                                    <label class="form-label">Password</label>

                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="password" TextMode="Password"></asp:TextBox>
                                    </div>
                                    <br />
                                    <div class="form-group d-grid gap-2">
                                        <asp:Button ID="Button1" runat="server" Text="Login" class="btn btn-primary btn-md btn-block" OnClick="Button1_Click"/>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <a href="../homePage.aspx"><<-- Back to Home</a>
                
            </div>
    </div>
</asp:Content>
