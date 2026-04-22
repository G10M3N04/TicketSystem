using System.Globalization;

namespace TicketApplication
{
    public partial class Form1 : Form
    {
        private static readonly CultureInfo ZAR = CultureInfo.GetCultureInfo("en-ZA");

        public Form1()
        {
            InitializeComponent();

            // Summary label: fixed area with wrapped lines (panel output per spec).
            lblSummaryContent.AutoSize = false;

            btnCalculate.Click += BtnCalculate_Click;
            btnClear.Click += BtnClear_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnCalculate_Click(object? sender, EventArgs e)
        {
            if (!TryGetInputs(out var name, out var genderLabel, out var age, out var categoryLabel, out var distanceKm, out var error))
            {
                MessageBox.Show(this, error, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal finalPrice = CalculateTicketPrice(age, genderLabel, categoryLabel, distanceKm);

            lblSummaryContent.Text =
                $"Passenger name: {name}{Environment.NewLine}" +
                $"Gender: {genderLabel}{Environment.NewLine}" +
                $"Age: {age}{Environment.NewLine}" +
                $"Category: {categoryLabel}{Environment.NewLine}" +
                $"Distance: {distanceKm.ToString("0.##", CultureInfo.CurrentCulture)} km{Environment.NewLine}" +
                $"Final ticket price: {finalPrice.ToString("C", ZAR)}";

            pnlSummary.Visible = true;
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtDistance.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            cmbCategory.SelectedIndex = cmbCategory.Items.Count > 0 ? 0 : -1;

            lblSummaryContent.Text = string.Empty;
            pnlSummary.Visible = false;
        }

        private void BtnExit_Click(object? sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Reads UI values and validates them per project rules (non-empty name, numeric age/distance, selections).
        /// </summary>
        private bool TryGetInputs(
            out string name,
            out string genderLabel,
            out int age,
            out string categoryLabel,
            out decimal distanceKm,
            out string errorMessage)
        {
            name = string.Empty;
            genderLabel = string.Empty;
            age = 0;
            categoryLabel = string.Empty;
            distanceKm = 0m;
            errorMessage = string.Empty;

            name = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                errorMessage = "Please enter the passenger name.";
                return false;
            }

            if (!rbMale.Checked && !rbFemale.Checked)
            {
                errorMessage = "Please select a gender (Male or Female).";
                return false;
            }

            genderLabel = rbMale.Checked ? "Male" : "Female";

            if (cmbCategory.SelectedIndex < 0 || cmbCategory.SelectedItem is null)
            {
                errorMessage = "Please select a travel category.";
                return false;
            }

            categoryLabel = cmbCategory.SelectedItem.ToString() ?? string.Empty;

            if (!int.TryParse(txtAge.Text.Trim(), NumberStyles.Integer, CultureInfo.CurrentCulture, out age))
            {
                errorMessage = "Age must be a whole number.";
                return false;
            }

            if (age < 0 || age > 120)
            {
                errorMessage = "Please enter a realistic age (0–120).";
                return false;
            }

            if (!decimal.TryParse(txtDistance.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out distanceKm))
            {
                errorMessage = "Distance must be a numeric value.";
                return false;
            }

            if (distanceKm < 0)
            {
                errorMessage = "Distance cannot be negative.";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Category rate × distance, then age &lt; 12 = free, else female = 50% discount (per business rules).
        /// </summary>
        private static decimal CalculateTicketPrice(int age, string genderLabel, string categoryLabel, decimal distanceKm)
        {
            decimal ratePerKm = GetRatePerKm(categoryLabel);
            decimal price = ratePerKm * distanceKm;

            // Discount rule: under 12 travels free.
            if (age < 12)
                return 0m;

            // Gender rule: female passengers receive 50% off the calculated price.
            if (string.Equals(genderLabel, "Female", StringComparison.OrdinalIgnoreCase))
                price *= 0.5m;

            return decimal.Round(price, 2, MidpointRounding.AwayFromZero);
        }

        private static decimal GetRatePerKm(string categoryLabel)
        {
            if (string.Equals(categoryLabel, "Category One", StringComparison.OrdinalIgnoreCase))
                return 20m;
            if (string.Equals(categoryLabel, "Category Two", StringComparison.OrdinalIgnoreCase))
                return 35m;
            if (string.Equals(categoryLabel, "Category Three", StringComparison.OrdinalIgnoreCase))
                return 50m;

            return 0m;
        }
    }
}
