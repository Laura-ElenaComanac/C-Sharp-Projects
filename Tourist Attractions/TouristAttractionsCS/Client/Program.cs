using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristAttractions.model;
using log4net;
using log4net.Config;
using System.Windows.Forms;
using TouristAttractionsCS.controller;
using TouristAttractionsCS;
using Networking;
using Services;

namespace TouristAttractionsCSharp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            IService server = new ServerObjectProxy("127.0.0.1", 55555);

            LoginForm loginForm = new LoginForm();
            loginForm.setService(server);
            loginForm.Text = "Login";

            TripsForm tripsForm = new TripsForm();
            loginForm.setTripsForm(tripsForm);

            tripsForm.Text = "Trips";
            tripsForm.setService(server);
            tripsForm.SetLogin(loginForm);

            Application.Run(loginForm);
            
        }
    }
}
