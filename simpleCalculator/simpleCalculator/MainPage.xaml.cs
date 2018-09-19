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


        }
    }
}
