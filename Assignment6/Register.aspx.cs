using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAServiceReference;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        CAServiceClient cas = new CAServiceClient();
        PersonLite pl = new PersonLite();
        pl.LastName = lastnameTextBox.Text;
        pl.FirstName = firstnameTextBox.Text;
        pl.Email = EmailTextBox.Text;
        pl.Apartment = ApartmentTextBox.Text;
        pl.Street = StreetTextBox.Text;
        pl.City = CityTextBox.Text;
        pl.State = StateTextBox.Text;
        pl.ZipCode = ZipTextBox.Text;
        pl.HomePhone = HomeTextBox.Text;
        pl.WorkPhone = WorkTextBox.Text;
        pl.Password = PasswordTextBox.Text;
        bool result = cas.RegisterPerson(pl);
        if(result)
        {
            ResultLabel.Text = "You are Registered";
        }
        else
        {
            ResultLabel.Text = "Something went wrong";
        }


    }
}