using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    public partial class ReviewExercise1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Total(object sender, EventArgs e)
        {
            const decimal Shipping_Cost = 0.35m;

            int quantity;
            int distance;
            decimal shippingCost;
            decimal shippingFee;
            try
            {
                quantity = Convert.ToInt32(txtQuan.Text);
                distance = Convert.ToInt32(txtDist.Text);
                shippingFee = Convert.ToDecimal(ddlShipType.SelectedValue);

                shippingCost = quantity * distance * (Shipping_Cost + shippingFee);
                txtShipFee.Text = ddlShipType.SelectedValue;
                txtShipCost.Text = String.Format("{0:c}", shippingCost);
            }
            catch(FormatException fe)
            {                
                txtDist.ForeColor = System.Drawing.Color.Red;
                txtDist.Text = "Invalid character";
                txtQuan.ForeColor = System.Drawing.Color.Red;
                txtQuan.Text = "Invalid character";

            }
        }
    }
}