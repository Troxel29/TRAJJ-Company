<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp1.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row justify-content-center my-5">
        <div class="col-md-5">
            <div class="card shadow-sm border-0">
                <div class="card-body p-4">
                    <h2 class="card-title text-center fw-bold mb-4">Login</h2>

                    <asp:Label ID="lblError" runat="server" CssClass="alert alert-danger d-block" Visible="false"></asp:Label>

                    <div class="mb-3">
                        <label for="txtUsername" class="form-label fw-semibold">Username</label>
                        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter your username" MaxLength="50"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername"
                            ErrorMessage="Username is required." CssClass="text-danger small" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="mb-3">
                        <label for="txtPassword" class="form-label fw-semibold">Password</label>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter your password" MaxLength="100"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                            ErrorMessage="Password is required." CssClass="text-danger small" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>

                    <div class="d-grid mt-4">
                        <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-dark btn-lg" OnClick="btnLogin_Click" />
                    </div>

                    <hr class="my-3" />
                    <p class="text-center mb-0">Don't have an account? <a href="Register">Register here</a></p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
