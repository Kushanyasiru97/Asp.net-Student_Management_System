<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="userLogin.aspx.cs" Inherits="Student_Management_Systems.User.userLogin" %>

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
                                    <img src="../images/imgs/generaluser.png" width="150px" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>User Login</h3>
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

                                <label class="form-label">User ID</label>
                                <div class="form-group">

                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="User ID"></asp:TextBox>

                                    <label class="form-label">Password</label>

                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="password" TextMode="Password"></asp:TextBox>
                                    </div>
                                    <br />
                                    <div class="d-grid gap-2">
                                        <asp:Button ID="Button1" runat="server" Text="Login" class="btn btn-primary" OnClick="Button1_Click"/>
                                    </div>
                                    <br />
                                    <div class="form-group d-grid gap-2">
                                        <a href="userSignup.aspx">
                                            <input id="Button2" type="button" value="Sign Up" class="btn btn-info" /></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <a href="../homePage.aspx"><<-- Back to Home</a>

            </div>
        </div>
    </div>
</asp:Content>
