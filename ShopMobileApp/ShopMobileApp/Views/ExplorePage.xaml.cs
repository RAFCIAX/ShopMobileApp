using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExplorePage : ContentPage
    {
        public ExplorePage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<Category> AllCategories { get => GetCategories(); }

        private List<Category> GetCategories()
        {
            var catList = new List<Category>();
            catList.Add(new Category { Image = "Mechanic.jpg", Title = "SCHEDULE AN APPOINTMENT", Caption = "Meet with specialist and fix ehatever you need" });
            catList.Add(new Category { Image = "Taxi.jpg", Title = "BOOK A RIDE", Caption = "Now easier than ever" });
            catList.Add(new Category { Image = "CarPartsCar.jpg", Title = "ORDER PARTS", Caption = "Access to our biggest warehouses" });
            catList.Add(new Category { Image = "CarRental.jpg", Title = "RENT A CAR", Caption = "Best quality, fully insured - satisaction guranteed" });
            return catList;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Warinig", "Service unavailible at the moment", "OK");
        }
    }

}