<%@ Page Title="Services" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Services.aspx.cs" Inherits="WebApp1.Services" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="servicesTitle">
        <div class="row my-4">
            <div class="col-12">
                <h1 id="servicesTitle" class="fw-bold">Our Services</h1>
                <hr />
                <asp:Label ID="lblinfo" runat="server" CssClass="alert alert-info d-block mb-3" Visible="false"></asp:Label>
            </div>
        </div>

        <div class="row g-4">
            <div class="col-md-4">
                <div class="card h-100 shadow-sm">
                    <div class="card-body p-4">
                        <h5 class="card-title fw-bold">🚗 Economy Cars</h5>
                        <p class="card-text text-muted">Budget-friendly options perfect for city driving and short trips. Great fuel efficiency and easy parking.</p>
                        <p class="fw-bold text-dark">From $45/day</p>
                        <a href="Login" class="btn btn-dark btn-sm">Book Now</a>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="card h-100 shadow-sm">
                    <div class="card-body p-4">
                        <h5 class="card-title fw-bold">🏎️ Premium Cars</h5>
                        <p class="card-text text-muted">Stylish, comfortable vehicles for business travel or special occasions. Enjoy the luxury experience.</p>
                        <p class="fw-bold text-dark">From $80/day</p>
                        <a href="Login" class="btn btn-dark btn-sm">Book Now</a>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="card h-100 shadow-sm">
                    <div class="card-body p-4">
                        <h5 class="card-title fw-bold">🚙 SUVs &amp; Vans</h5>
                        <p class="card-text text-muted">Spacious vehicles ideal for family trips, group travel, and island exploration. Room for everyone and everything.</p>
                        <p class="fw-bold text-dark">From $65/day</p>
                        <a href="Login" class="btn btn-dark btn-sm">Book Now</a>
                    </div>
                </div>
            </div>
        </div>

        <div class="row mt-5">
            <div class="col-12 text-center">
                <h4>Need help choosing? <a href="Contact">Contact us</a> and our team will assist you.</h4>
            </div>
        </div>
    </main>
</asp:Content>

