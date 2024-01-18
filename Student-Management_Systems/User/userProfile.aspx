<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="userProfile.aspx.cs" Inherits="Student_Management_Systems.User.userProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
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
                                    <h3>Your Profile</h3>
                                    <span>Account Status - </span>
                                    <asp:Label ID="Label1" runat="server" Text="Your Status" class="badge text-bg-success">Active</asp:Label>
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

                                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Contact Number" TextMode="Phone"></asp:TextBox>
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
                                        <div class="col-md-4">
                                            <label class="form-label">User ID</label>
                                            <div class="form-group">

                                                <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="User ID" TextMode="Number" ReadOnly="True"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-4">
                                            <label class="form-label">Old Password</label>

                                            <div class="form-group">
                                                <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="old password" TextMode="Password" ReadOnly="True"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-4">
                                            <label class="form-label">New Pssword</label>

                                            <div class="form-group">
                                                <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="new password" TextMode="Password"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div>
                                        <br />
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-8 mx-auto">
                                        <center>
                                            <div class="form-group">
                                                <asp:Button ID="Button2" runat="server" Text="Update" class="btn btn-primary" />
                                            </div>
                                        </center>

                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>

                <a href="../homePage.aspx"><<-- Back to Home</a>

            </div>
            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">

                                <center>
                                    <img src="../images/imgs/books1.png" width="80px" />
                                    <h4>Publisher List</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server"></asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
