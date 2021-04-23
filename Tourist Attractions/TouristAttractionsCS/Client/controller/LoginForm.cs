using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouristAttractions.model;
using TouristAttractionsCS.controller;
using Services;
using TouristAttractionsCS.utils;

namespace TouristAttractionsCS
{
    public partial class LoginForm : Form
    {
        public IService service;

        TripsForm tripsForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        public void setTripsForm(TripsForm tripsForm)
        {
            this.tripsForm = tripsForm;
        }

        public void bookedTrip(IEnumerable<Trip> trips)
        {
            throw new NotImplementedException();
        }

        public void setService(IService service)
        {
            this.service = service;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            AgencyUser agencyUser;

            service.Login(new AgencyUser(-1, usernameTextBox.Text, passwordTextBox.Text), tripsForm);

            agencyUser = service.SearchAgencyUserByUserNameAndPassword(usernameTextBox.Text, passwordTextBox.Text);

            if (agencyUser != null)
                showTripsDialog(agencyUser);
            else
                MessageBox.Show("This Agency User doesn't exist!", "Error");
        }

        private void showTripsDialog(AgencyUser agencyUser)
        {
            try
            {
                tripsForm.SetAgencyUser(agencyUser);
                tripsForm.Show();
                tripsForm.updateRows();
                tripsForm.update();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }
    }
}
