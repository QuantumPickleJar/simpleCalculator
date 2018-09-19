using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace simpleCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String strMonth = mthEntry.Text;
            String strYear = yrEntry.Text;
            String strDay = dayEntry.Text;

            int iMonth, iDay, iYear;
            iMonth = int.Parse(strMonth);
            iDay = int.Parse(strDay);
            iYear = int.Parse(strYear);

            DateTime birthDate = new DateTime(iYear, iMonth, iDay);
            //System.DateTime birthDate = new System.DateTime(iYear, iMonth, iYear);
            //what we would use if we didn't have "using System;"


            var age = DateTime.Now - birthDate; //in this instance, 'age' will turn into variable type TimeSpan 
                                                //var determines what datatype is most appropariate
                                                //DateTime.Today;

            int numDays = age.Days;
            int totYears = numDays / 365;

        }
    }
}
