using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class frmPizzaOrder: Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        private class PizzaOrderInfo {
            public string Size = "";
            public string CrustType = "";
            public string Toppings = "";
            public string WhereToEat = "";
            public float Price = 10;
        }
        PizzaOrderInfo PizzaOrder = new PizzaOrderInfo();

        /*private class PizzaPrices {
            static public byte SmallPizza = 5;
            static public byte MediumPizza = 10;
            static public byte LargePizza = 15;
            static public byte ThinCrust = 0;
            static public byte ThickCrust = 10;
            static public byte ExtraChees = 3;
            static public byte Mushrooms = 2;
            static public byte Tomatoes = 3;
            static public byte Onion = 2;
            static public byte Olives = 2;
            static public byte GreenPeppers = 1;
        }*/

        private void UpdateOrderSummary() {
            UpdateSize();
            UpdateCrustType();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        private float GetSelectedSizePrice() {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);
            else
                return Convert.ToSingle(rbLarge.Tag);

        }

        private float GetSelectedCrustTypePrice() {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);
            else
                return Convert.ToSingle(rbThickCrust.Tag);

        }

        private float CalculateToppingsPrice() {
            float ToppingsTotalPrice = 0;

            if (chkExtraChees.Checked) {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraChees.Tag);
            }
            
            if (chkMushrooms.Checked) {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkTomatoes.Checked) {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkOnion.Checked) {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkOlives.Checked) {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkGreenPeppers.Checked) {
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            return ToppingsTotalPrice;
        }

        private float CalculateTotalPrice() {
            return (GetSelectedSizePrice() + GetSelectedCrustTypePrice() + CalculateToppingsPrice()) * (float) nudHowManyPizza.Value;
        }

        private void UpdateTotalPrice() {
            float TotalPrice = CalculateTotalPrice();
            PizzaOrder.Price = TotalPrice;
            lblTotalPriceValue.Text = "$" + TotalPrice;
        }

        private void UpdateSize() {
            UpdateTotalPrice();

            if (rbSmall.Checked) {
                lblSizeValue.Text = "Small";
                PizzaOrder.Size = lblSizeValue.Text;
                return;
            }

            if (rbMedium.Checked) {
                lblSizeValue.Text = "Meduim";
                PizzaOrder.Size = lblSizeValue.Text;
                return;
            }

            if (rbLarge.Checked) {
                lblSizeValue.Text = "Large";
                PizzaOrder.Size = lblSizeValue.Text;
                return;
            }

        }

        private void UpdateCrustType() {
            UpdateTotalPrice();

            if (rbThinCrust.Checked) {
                lblCrustTypeValue.Text = "Thin Crust";
                PizzaOrder.CrustType = lblCrustTypeValue.Text;
                return;
            }

            if (rbThickCrust.Checked) {
                lblCrustTypeValue.Text = "Thick Crust";
                PizzaOrder.CrustType = lblCrustTypeValue.Text;
                return;
            }

        }

        private void UpdateToppings() {
            UpdateTotalPrice();
            string sToppings = "";

            if (chkExtraChees.Checked) {
                sToppings = "Extra Chees";
            }

            if (chkMushrooms.Checked) {
                sToppings += ", Mushrooms";
            }

            if (chkTomatoes.Checked) {
                sToppings += ", Tomatoes";
            }

            if (chkOnion.Checked) {
                sToppings += ", Onion";
            }

            if (chkOlives.Checked) {
                sToppings += ", Olives";
            }

            if (chkGreenPeppers.Checked) {
                sToppings += ", Green Peppers";
            }

            if (sToppings.StartsWith(",")) {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "") {
                sToppings = "No Toppings";
            }

            PizzaOrder.Toppings = sToppings;
            lblToppingsValues.Text = sToppings;

        }

        private void UpdateWhereToEat() {
            UpdateTotalPrice();

            if (rbEatIn.Checked) {
                lblWhereToEatValue.Text = "Eat In";
                PizzaOrder.WhereToEat = lblWhereToEatValue.Text;
                return;
            }

            if (rbTakeOut.Checked) {
                lblWhereToEatValue.Text = "Take Out";
                PizzaOrder.WhereToEat = lblWhereToEatValue.Text;
                return;
            }

        }

        private void ResetForm() {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;

            rbMedium.Checked = true;

            rbThinCrust.Checked = true;

            chkExtraChees.Checked = chkMushrooms.Checked = chkTomatoes.Checked = chkOnion.Checked = chkOlives.Checked = chkGreenPeppers.Checked = false;

            rbEatIn.Checked = true;
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e) {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e) {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e) {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e) {
            UpdateCrustType();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e) {
            UpdateCrustType();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e) {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e) {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e) {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e) {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e) {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e) {
            UpdateToppings();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e) {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e) {
            UpdateWhereToEat();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Are you sure do you want to make an order?", "Confirm Ortder", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK){
                MessageBox.Show("Order placed succussfuly?", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e) {
            ResetForm();
        }

        private void frmPizzaOrder_Load(object sender, EventArgs e) {
            UpdateOrderSummary();
        }

        private void nudHowManyPizza_ValueChanged(object sender, EventArgs e) {
            UpdateTotalPrice();
        }
    }
}
