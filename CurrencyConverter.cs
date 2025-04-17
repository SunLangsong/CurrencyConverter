using System;

namespace Homework;

    public partial class CurrencyConverter : Form
    {
        private Label labelTitle;
        private TextBox textBoxUSD;
        private ComboBox comboBoxCurrency;
        private Button btnConvert;
        private Label labelResult;

        public CurrencyConverter()
        {
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Label for Title
            labelTitle = new Label
            {
                Text = "USD Currency Converter",
                AutoSize = true,
                Location = new System.Drawing.Point(50, 20),
                Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold)
            };
            this.Controls.Add(labelTitle);

            // TextBox for USD input
            textBoxUSD = new TextBox
            {
                Location = new System.Drawing.Point(50, 60),
                Width = 200
            };
            this.Controls.Add(textBoxUSD);

            // ComboBox for selecting currency
            comboBoxCurrency = new ComboBox
            {
                Location = new System.Drawing.Point(50, 100),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            comboBoxCurrency.Items.AddRange(new string[]
            {
                "Euro (EUR)", "Australian Dollar (AUD)", "Canadian Dollar (CAD)",
                "Chinese Yuan (CNY)", "British Pound (GBP)", "Hong Kong Dollar (HKD)",
                "Japanese Yen (JPY)", "Korean Won (KRW)", "Singapore Dollar (SGD)",
                "Taiwan Dollar (TWD)"
            });
            this.Controls.Add(comboBoxCurrency);

            // Button to perform conversion
            btnConvert = new Button
            {
                Text = "Convert",
                Location = new System.Drawing.Point(50, 140),
                Width = 200
            };
            btnConvert.Click += new EventHandler(btnConvert_Click);
            this.Controls.Add(btnConvert);

            // Label to display the result
            labelResult = new Label
            {
                Text = "Result: ",
                AutoSize = true,
                Location = new System.Drawing.Point(50, 180),
                Font = new System.Drawing.Font("Arial", 12)
            };
            this.Controls.Add(labelResult);

            // Set the form's properties
            this.Text = "Currency Converter";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 300);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double usd = double.Parse(textBoxUSD.Text);
                double result = 0;
                string selectedCurrency = comboBoxCurrency.SelectedItem.ToString();

                switch (selectedCurrency)
                {
                    case "Euro (EUR)":
                        result = usd * 0.8172;
                        break;
                    case "Australian Dollar (AUD)":
                        result = usd * 1.3128;
                        break;
                    case "Canadian Dollar (CAD)":
                        result = usd * 1.2704;
                        break;
                    case "Chinese Yuan (CNY)":
                        result = usd * 6.5338;
                        break;
                    case "British Pound (GBP)":
                        result = usd * 0.7368;
                        break;
                    case "Hong Kong Dollar (HKD)":
                        result = usd * 7.7524;
                        break;
                    case "Japanese Yen (JPY)":
                        result = usd * 130.233;
                        break;
                    case "Korean Won (KRW)":
                        result = usd * 1092.0500;
                        break;
                    case "Singapore Dollar (SGD)":
                        result = usd * 1.3254;
                        break;
                    case "Taiwan Dollar (TWD)":
                        result = usd * 28.118;
                        break;
                }

                labelResult.Text = $"Result: {result:N2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value.");
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new CurrencyConverter());
    }
}

