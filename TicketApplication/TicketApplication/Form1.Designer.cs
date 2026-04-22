namespace TicketApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // ── Control Declarations ──────────────────────────────────────
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.lblSummaryContent = new System.Windows.Forms.Label();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();

            // ── lblTitle ─────────────────────────────────────────────────
            this.lblTitle.Text = "Ticket Application System";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(25, 70, 150);
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(220, 230, 250);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Size = new System.Drawing.Size(500, 55);

            // ── lblName ──────────────────────────────────────────────────
            this.lblName.Text = "Passenger Name:";
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(30, 80);
            this.lblName.Size = new System.Drawing.Size(150, 25);

            // ── txtName ──────────────────────────────────────────────────
            this.txtName.Name = "txtName";
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(200, 78);
            this.txtName.Size = new System.Drawing.Size(260, 27);

            // ── lblGender ────────────────────────────────────────────────
            this.lblGender.Text = "Gender:";
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(30, 125);
            this.lblGender.Size = new System.Drawing.Size(150, 25);

            // ── rbMale ───────────────────────────────────────────────────
            this.rbMale.Name = "rbMale";
            this.rbMale.Text = "Male";
            this.rbMale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbMale.Location = new System.Drawing.Point(200, 123);
            this.rbMale.Size = new System.Drawing.Size(80, 25);

            // ── rbFemale ─────────────────────────────────────────────────
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Text = "Female";
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbFemale.Location = new System.Drawing.Point(295, 123);
            this.rbFemale.Size = new System.Drawing.Size(85, 25);

            // ── lblAge ───────────────────────────────────────────────────
            this.lblAge.Text = "Age:";
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAge.Location = new System.Drawing.Point(30, 168);
            this.lblAge.Size = new System.Drawing.Size(150, 25);

            // ── txtAge ───────────────────────────────────────────────────
            this.txtAge.Name = "txtAge";
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAge.Location = new System.Drawing.Point(200, 166);
            this.txtAge.Size = new System.Drawing.Size(260, 27);

            // ── lblCategory ──────────────────────────────────────────────
            this.lblCategory.Text = "Travel Category:";
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(30, 211);
            this.lblCategory.Size = new System.Drawing.Size(150, 25);

            // ── cmbCategory ──────────────────────────────────────────────
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Location = new System.Drawing.Point(200, 209);
            this.cmbCategory.Size = new System.Drawing.Size(260, 27);
            this.cmbCategory.Items.AddRange(new object[] {
                "Category One",
                "Category Two",
                "Category Three"
            });

            // ── lblDistance ──────────────────────────────────────────────
            this.lblDistance.Text = "Distance (km):";
            this.lblDistance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDistance.Location = new System.Drawing.Point(30, 254);
            this.lblDistance.Size = new System.Drawing.Size(150, 25);

            // ── txtDistance ──────────────────────────────────────────────
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDistance.Location = new System.Drawing.Point(200, 252);
            this.txtDistance.Size = new System.Drawing.Size(260, 27);

            // ── btnCalculate ─────────────────────────────────────────────
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Text = "Calculate Ticket Price";
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(25, 70, 150);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.Location = new System.Drawing.Point(30, 305);
            this.btnCalculate.Size = new System.Drawing.Size(190, 38);
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;

            // ── btnClear ─────────────────────────────────────────────────
            this.btnClear.Name = "btnClear";
            this.btnClear.Text = "Clear Form";
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(210, 120, 20);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Location = new System.Drawing.Point(235, 305);
            this.btnClear.Size = new System.Drawing.Size(110, 38);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;

            // ── btnExit ──────────────────────────────────────────────────
            this.btnExit.Name = "btnExit";
            this.btnExit.Text = "Exit";
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(170, 35, 35);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(360, 305);
            this.btnExit.Size = new System.Drawing.Size(100, 38);
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;

            // ── pnlSummary ───────────────────────────────────────────────
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(235, 242, 255);
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Location = new System.Drawing.Point(30, 360);
            this.pnlSummary.Size = new System.Drawing.Size(440, 185);
            this.pnlSummary.Visible = false;

            // ── lblSummaryTitle ──────────────────────────────────────────
            this.lblSummaryTitle.Text = "Ticket Summary";
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(25, 70, 150);
            this.lblSummaryTitle.Location = new System.Drawing.Point(10, 10);
            this.lblSummaryTitle.Size = new System.Drawing.Size(415, 25);

            // ── lblSummaryContent ────────────────────────────────────────
            this.lblSummaryContent.Name = "lblSummaryContent";
            this.lblSummaryContent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSummaryContent.Location = new System.Drawing.Point(10, 42);
            this.lblSummaryContent.Size = new System.Drawing.Size(415, 135);

            // ── Add controls to Summary Panel ────────────────────────────
            this.pnlSummary.Controls.Add(this.lblSummaryTitle);
            this.pnlSummary.Controls.Add(this.lblSummaryContent);

            // ── Form1 Properties ─────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 565);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Application System";

            // ── Add all controls to Form ─────────────────────────────────
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlSummary);

            this.pnlSummary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // ── Control Field Declarations ────────────────────────────────────
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Label lblSummaryContent;
    }
}