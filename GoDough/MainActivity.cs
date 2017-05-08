using Android.App;
using Android.Widget;
using Android.OS;
using System;
using OxyPlot.Xamarin.Android;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace GoDough
{
    [Activity(Label = "GoDough", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Spinner categories;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            categories = FindViewById<Spinner>(Resource.Id.spinner1);
            categories.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(categories_ItemSelected);

            PlotView view = FindViewById<PlotView>(Resource.Id.plot_view);
            CreateChart pieChart = new CreateChart();
            view.Model = pieChart.Model1;

            var adapter1 = ArrayAdapter.CreateFromResource(this, Resource.Array.spending_categories, Android.Resource.Layout.SimpleSpinnerItem);
            categories.Adapter = adapter1;
            
        }

        private void categories_ItemSelected(object sender, EventArgs e) 
        {
            Spinner spinner = (Spinner)sender;
        }   

    }
}

