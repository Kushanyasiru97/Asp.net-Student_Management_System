<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="userSignup.aspx.cs" Inherits="Student_Management_Systems.User.userSignup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="../images/imgs/sign-up.png" width="150px" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>User Signup</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label class="form-label">Full Name</label>
                                <div class="form-group">

                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Full Name"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label class="form-label">Date of Birth</label>

                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Date of Birth" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label class="form-label">Contact Number</label>
                                <div class="form-group">

                                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Contact Number" TextMode="Number"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label class="form-label">Email Address</label>

                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Email ID" TextMode="Email"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">

                                <label class="form-label">Address</label>
                                <div class="form-group">

                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Address" TextMode="MultiLine"></asp:TextBox>
                                </div>

                                <div class="row">
                                    <div class="col">
                                        <span class="badge badge-info badge-pill">Login Credentials</span>
                                    </div>

                                    <div class="row">
                                        <div class="col-md-6">
                                            <label class="form-label">User ID</label>
                                            <div class="form-group">

                                                <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="User ID"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <label class="form-label">password</label>

                                            <div class="form-group">
                                                <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="password" TextMode="Password"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>


                                </div>

                                <br />

                                <div class="d-grid gap-2">
                                    <asp:Button ID="Button1" runat="server" Text="Sign Up" class="btn btn-success" OnClick="Button1_Click" />
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
