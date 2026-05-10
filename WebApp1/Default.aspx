<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%-- Hero Section --%>
    <div class="hero-section text-center py-5 my-4 rounded">
        <h1 class="display-4 fw-bold text-dark">Welcome to TRAJJ Car Rentals</h1>
        <p class="lead text-muted">Your trusted car rental service in Jamaica. Affordable rates, quality vehicles, exceptional service.</p>
        <div class="mt-4">
            <a href="Services" class="btn btn-dark btn-lg me-2">Browse Cars</a>
            <a href="Register" class="btn btn-outline-dark btn-lg">Get Started</a>
        </div>
    </div>

    <%-- Features Section --%>
    <div class="row g-4 my-2">
        <div class="col-md-4">
            <div class="card h-100 shadow-sm">
                <div class="card-body text-center p-4">
                    <div class="feature-icon mb-3">🚗</div>
                    <h5 class="card-title fw-bold">Wide Selection</h5>
                    <p class="card-text text-muted">Choose from our fleet of well-maintained vehicles — from economy to premium models — to suit every budget and occasion.</p>
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="card h-100 shadow-sm">
                <div class="card-body text-center p-4">
                    <div class="feature-icon mb-3">💰</div>
                    <h5 class="card-title fw-bold">Competitive Rates</h5>
                    <p class="card-text text-muted">We offer transparent, affordable daily rental rates with no hidden fees. Great value for both short and long-term rentals.</p>
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="card h-100 shadow-sm">
                <div class="card-body text-center p-4">
                    <div class="feature-icon mb-3">📞</div>
                    <h5 class="card-title fw-bold">24/7 Support</h5>
                    <p class="card-text text-muted">Our team is available around the clock to assist you with bookings, roadside assistance, and any questions you may have.</p>
                </div>
            </div>
        </div>
    </div>

    <%-- CTA Section --%>
    <div class="row my-5">
        <div class="col-12 text-center">
            <h2 class="fw-bold">Ready to hit the road?</h2>
            <p class="text-muted">Register today and book your first rental in minutes.</p>
            <a href="Login" class="btn btn-dark btn-lg">Login to Book Now</a>
        </div>
    </div>

</asp:Content>

