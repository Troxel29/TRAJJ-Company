<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApp1.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row justify-content-center my-5">
        <div class="col-md-7">
            <div class="card shadow-sm border-0">
                <div class="card-body p-4">
                    <h2 class="card-title text-center fw-bold mb-4">Create an Account</h2>

                    <asp:Label ID="lblError" runat="server" CssClass="alert alert-danger d-block" Visible="false"></asp:Label>
                    <asp:Label ID="lblSuccess" runat="server" CssClass="alert alert-success d-block" Visible="false"></asp:Label>

                    <div class="row g-3">
                        <div class="col-md-6">
                            <label class="form-label fw-semibold">First Name</label>
                            <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" placeholder="First name" MaxLength="50"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName"
                                ErrorMessage="First name is required." CssClass="text-danger small" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-md-6">
                            <label class="form-label fw-semibold">Last Name</label>
                            <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" placeholder="Last name" MaxLength="50"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName"
                                ErrorMessage="Last name is required." CssClass="text-danger small" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-md-6">
                            <label class="form-label fw-semibold">Username</label>
                            <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Choose a username" MaxLength="50"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername"
                                ErrorMessage="Username is required." CssClass="text-danger small" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-md-6">
                            <label class="form-label fw-semibold">Email Address</label>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="your@email.com" TextMode="Email" MaxLength="100"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                                ErrorMessage="Email is required." CssClass="text-danger small" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-md-6">
                            <label class="form-label fw-semibold">Password</label>
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Create a password" MaxLength="100"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                                ErrorMessage="Password is required." CssClass="text-danger small" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-md-6">
                            <label class="form-label fw-semibold">Confirm Password</label>
                            <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Repeat your password" MaxLength="100"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" ControlToValidate="txtConfirmPassword"
                                ErrorMessage="Please confirm your password." CssClass="text-danger small" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-md-6">
                            <label class="form-label fw-semibold">Phone Number</label>
                            <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="form-control" placeholder="+1 (876) 000-0000" MaxLength="20"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhoneNumber"
                                ErrorMessage="Phone number is required." CssClass="text-danger small" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-md-6">
                            <label class="form-label fw-semibold">Date of Birth</label>
                            <asp:TextBox ID="txtDateOfBirth" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvDOB" runat="server" ControlToValidate="txtDateOfBirth"
                                ErrorMessage="Date of birth is required." CssClass="text-danger small" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        <div class="col-12">
                            <label class="form-label fw-semibold">Address</label>
                            <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" placeholder="Your street address" MaxLength="255"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtAddress"
                                ErrorMessage="Address is required." CssClass="text-danger small" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="d-grid mt-4">
                        <asp:Button ID="btnRegister" runat="server" Text="Create Account" CssClass="btn btn-dark btn-lg" OnClick="btnRegister_Click" />
                    </div>

                    <hr class="my-3" />
                    <p class="text-center mb-0">Already have an account? <a href="Login">Login here</a></p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
