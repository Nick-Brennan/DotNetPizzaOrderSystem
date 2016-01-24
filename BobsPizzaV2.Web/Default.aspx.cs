using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BobsPizzaV2.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 0 && addressTextBox.Text.Length > 0 && zipTextBox.Text.Length > 0 && phoneTextBox.Text.Length > 0)
            {
                try
                {
                    Domain.OrderManager.AddNewOrder(BuildPizza());
                    Server.Transfer("success.aspx");
                }
                catch (Exception ex)
                {

                    warningLabel.Text = ex.Message;
                }
            }
            else { warningLabel.Text = "Please include a <b>Name</b>, <b>Address</b> with <b>Zip</b>, and <b>Phone</b> number with your order"; }
            
        }

        private DTO.DtoOrder BuildPizza()
        {
            DTO.DtoOrder pizza = new DTO.DtoOrder();

            pizza.Size = getPizzaSize();
            pizza.Crust = getPizzaCrust();
            pizza.Sausage = (sausageCheckBox.Checked) ? true : false;
            pizza.Pepperoni = (pepperoniCheckBox.Checked) ? true : false;
            pizza.Onions = (onionsCheckBox.Checked) ? true : false;
            pizza.GreenPeppers = (greenPeppersCheckBox.Checked) ? true : false;
            pizza.TotalCost = 0M;
            pizza.Name = nameTextBox.Text;
            pizza.Address = addressTextBox.Text;
            pizza.Zip = zipTextBox.Text;
            pizza.Phone = phoneTextBox.Text;
            pizza.PayementMethod = (cashRadioButton.Checked) ? DTO.Enums.PaymentType.Cash : DTO.Enums.PaymentType.Credit;
            pizza.Completed = false;

            return pizza;
        }

        private DTO.Enums.CrustType getPizzaCrust()
        {
            DTO.Enums.CrustType crust;
            if (!Enum.TryParse(crustDropDownList.SelectedValue.Trim(), out crust))
            {
                throw new Exception("Couldn't determine pizza CRUST type.");
            }
            return crust;
        }

        private DTO.Enums.SizeType getPizzaSize()
        {
            DTO.Enums.SizeType size;
            if(!Enum.TryParse(sizeDropDownList.SelectedValue.Trim(), out size))
            {
                throw new Exception("Couldn't determine pizza SIZE.");
            }
            return size;
        }

        protected void sizeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            warningLabel.Text = "";
            if(sizeDropDownList.SelectedIndex > 0 && crustDropDownList.SelectedIndex > 0)
            priceLabel.Text = String.Format("{0:C}", Domain.OrderManager.determinePrice(BuildPizza()));
        }
    }
}