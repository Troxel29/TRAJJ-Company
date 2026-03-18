namespace TRAJJ_Company;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        ModernizeUI();
    }

    private void ModernizeUI()
    {
        // Set modern form properties
        this.Text = "TRAJJ Company - Modern Dashboard";
        this.BackColor = Color.FromArgb(245, 245, 245);
        this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        this.StartPosition = FormStartPosition.CenterScreen;

        // Create main panel with rounded corners effect
        var mainPanel = new Panel
        {
            Location = new Point(20, 20),
            Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 40),
            BackColor = Color.White,
            BorderStyle = BorderStyle.None
        };

        // Add shadow effect (simulated)
        mainPanel.Paint += MainPanel_Paint;

        // Header section
        var headerPanel = new Panel
        {
            Location = new Point(0, 0),
            Size = new Size(mainPanel.Width, 100),
            BackColor = Color.FromArgb(63, 81, 181) // Modern blue
        };

        var headerLabel = new Label
        {
            Text = "Welcome to TRAJJ Company",
            Location = new Point(30, 20),
            Size = new Size(400, 30),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 18F, FontStyle.Bold)
        };

        var subHeaderLabel = new Label
        {
            Text = "Your modern business management solution",
            Location = new Point(30, 55),
            Size = new Size(400, 25),
            ForeColor = Color.WhiteSmoke,
            Font = new Font("Segoe UI", 11F, FontStyle.Regular)
        };

        headerPanel.Controls.AddRange(new Control[] { headerLabel, subHeaderLabel });

        // Content area
        var contentPanel = new Panel
        {
            Location = new Point(0, 100),
            Size = new Size(mainPanel.Width, mainPanel.Height - 100),
            BackColor = Color.White
        };

        // Action buttons with modern styling
        var dashboardButton = CreateModernButton("Dashboard", new Point(30, 30));
        dashboardButton.Click += DashboardButton_Click;

        var reportsButton = CreateModernButton("Reports", new Point(200, 30));
        reportsButton.Click += ReportsButton_Click;

        var settingsButton = CreateModernButton("Settings", new Point(370, 30));
        settingsButton.Click += SettingsButton_Click;

        // Feature cards
        var featuresLabel = new Label
        {
            Text = "Quick Actions",
            Location = new Point(30, 120),
            Size = new Size(200, 25),
            Font = new Font("Segoe UI", 14F, FontStyle.Bold),
            ForeColor = Color.FromArgb(63, 81, 181)
        };

        var card1 = CreateFeatureCard("Analytics", "View business insights and metrics", new Point(30, 160));
        var card2 = CreateFeatureCard("Inventory", "Manage your product inventory", new Point(250, 160));
        var card3 = CreateFeatureCard("Customers", "Customer relationship management", new Point(470, 160));

        contentPanel.Controls.AddRange(new Control[] {
            dashboardButton, reportsButton, settingsButton,
            featuresLabel, card1, card2, card3
        });

        mainPanel.Controls.AddRange(new Control[] { headerPanel, contentPanel });
        this.Controls.Add(mainPanel);

        // Handle form resize
        this.Resize += Form1_Resize;
    }

    private Button CreateModernButton(string text, Point location)
    {
        var button = new Button
        {
            Text = text,
            Location = location,
            Size = new Size(150, 45),
            FlatStyle = FlatStyle.Flat,
            BackColor = Color.FromArgb(63, 81, 181),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 10F, FontStyle.Bold),
            Cursor = Cursors.Hand
        };

        button.FlatAppearance.BorderSize = 0;
        button.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 107, 192);
        button.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 63, 159);

        return button;
    }

    private Panel CreateFeatureCard(string title, string description, Point location)
    {
        var card = new Panel
        {
            Location = location,
            Size = new Size(200, 120),
            BackColor = Color.FromArgb(250, 250, 250),
            BorderStyle = BorderStyle.FixedSingle
        };

        var titleLabel = new Label
        {
            Text = title,
            Location = new Point(15, 15),
            Size = new Size(170, 20),
            Font = new Font("Segoe UI", 12F, FontStyle.Bold),
            ForeColor = Color.FromArgb(63, 81, 181)
        };

        var descLabel = new Label
        {
            Text = description,
            Location = new Point(15, 40),
            Size = new Size(170, 60),
            Font = new Font("Segoe UI", 9F, FontStyle.Regular),
            ForeColor = Color.Gray
        };

        card.Controls.AddRange(new Control[] { titleLabel, descLabel });
        return card;
    }

    private void MainPanel_Paint(object? sender, PaintEventArgs e)
    {
        if (sender is Panel panel)
        {
            // Draw a subtle shadow effect
            using (var pen = new Pen(Color.FromArgb(20, 0, 0, 0), 1))
            {
                e.Graphics.DrawRectangle(pen, 2, 2, panel.Width - 1, panel.Height - 1);
            }
        }
    }

    private void Form1_Resize(object? sender, EventArgs e)
    {
        if (this.Controls.Count > 0 && this.Controls[0] is Panel mainPanel)
        {
            mainPanel.Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 40);
            if (mainPanel.Controls.Count > 1 && mainPanel.Controls[1] is Panel contentPanel)
            {
                contentPanel.Size = new Size(mainPanel.Width, mainPanel.Height - 100);
            }
        }
    }

    private void DashboardButton_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Dashboard functionality coming soon!", "TRAJJ Company",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ReportsButton_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Reports functionality coming soon!", "TRAJJ Company",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void SettingsButton_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Settings functionality coming soon!", "TRAJJ Company",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
