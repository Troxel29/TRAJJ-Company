<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApp1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="contactTitle">
        <div class="row my-4">
            <div class="col-12">
                <h1 id="contactTitle" class="fw-bold">Contact Us</h1>
                <hr />
            </div>
        </div>

        <div class="row g-4">
            <div class="col-md-6">
                <h4>Get in Touch</h4>
                <p class="text-muted">We are here to help. Reach us by phone, email, or visit our office.</p>

                <address class="mt-3">
                    <strong>TRAJJ Car Rentals Jamaica</strong><br />
                    123 Knutsford Boulevard<br />
                    Kingston 5, Jamaica<br />
                    <abbr title="Phone">P:</abbr> <a href="tel:+18761234567">+1 (876) 123-4567</a>
                </address>

                <address class="mt-3">
                    <strong>Email:</strong><br />
                    <a href="mailto:info@trajjrentals.com">info@trajjrentals.com</a><br />
                    <strong>Bookings:</strong><br />
                    <a href="mailto:bookings@trajjrentals.com">bookings@trajjrentals.com</a>
                </address>

                <p class="mt-3"><strong>Operating Hours:</strong><br />
                    Monday – Saturday: 7:00 AM – 10:00 PM<br />
                    Sunday: 8:00 AM – 6:00 PM
                </p>
            </div>
            <div class="col-md-6">
                <div class="card shadow-sm border-0 p-4 bg-light">
                    <h5 class="fw-bold mb-3">Quick Links</h5>
                    <ul class="list-unstyled">
                        <li class="mb-2"><a href="Services" class="text-dark">→ Browse our vehicle fleet</a></li>
                        <li class="mb-2"><a href="Register" class="text-dark">→ Create an account</a></li>
                        <li class="mb-2"><a href="Login" class="text-dark">→ Login to book a car</a></li>
                        <li class="mb-2"><a href="About" class="text-dark">→ Learn more about us</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </main>
</asp:Content>

