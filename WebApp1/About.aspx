<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApp1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="aboutTitle">
        <div class="row my-4">
            <div class="col-12">
                <h1 id="aboutTitle" class="fw-bold">About TRAJJ Car Rentals</h1>
                <hr />
            </div>
        </div>
        <div class="row g-4">
            <div class="col-md-7">
                <h3>Who We Are</h3>
                <p>TRAJJ Car Rentals Jamaica is a locally owned and operated vehicle rental company committed to providing reliable, affordable, and convenient transportation solutions across Jamaica.</p>
                <p>Founded with a passion for customer service, we pride ourselves on offering a modern fleet of well-maintained vehicles and a booking experience that is fast, transparent, and hassle-free.</p>

                <h3 class="mt-4">Our Mission</h3>
                <p>To deliver an exceptional car rental experience to every customer — whether you are a tourist exploring the island, a business traveller on assignment, or a local needing short-term transportation.</p>

                <h3 class="mt-4">Why Choose TRAJJ?</h3>
                <ul>
                    <li>✅ Clean, inspected, and insured vehicles</li>
                    <li>✅ Transparent pricing — no hidden fees</li>
                    <li>✅ Flexible pickup and drop-off arrangements</li>
                    <li>✅ Friendly and knowledgeable staff</li>
                    <li>✅ Serving all parishes across Jamaica</li>
                </ul>
            </div>
            <div class="col-md-5">
                <div class="card border-0 shadow-sm p-4 bg-light">
                    <h4 class="fw-bold">Quick Facts</h4>
                    <ul class="list-unstyled mt-3">
                        <li class="mb-2">🏢 <strong>Based in:</strong> Jamaica</li>
                        <li class="mb-2">🚗 <strong>Fleet size:</strong> Growing selection of vehicles</li>
                        <li class="mb-2">📅 <strong>Operating hours:</strong> 7 AM – 10 PM daily</li>
                        <li class="mb-2">📞 <strong>Phone:</strong> <a href="tel:+18761234567">+1 (876) 123-4567</a></li>
                        <li class="mb-2">✉️ <strong>Email:</strong> <a href="mailto:info@trajjrentals.com">info@trajjrentals.com</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </main>
</asp:Content>

