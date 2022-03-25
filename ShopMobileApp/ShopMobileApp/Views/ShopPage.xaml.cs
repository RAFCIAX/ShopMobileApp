using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopPage : ContentPage
    {
        public ShopPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private Timer timer;

        public List<Banner> Banners { get => GetBanners(); }

        public List<Product> CollectionsList { get => GetCollections(); }

        public List<Product> TrendsList { get => GetTrends(); }



        private List<Banner> GetBanners()
        {
            var bannerList = new List<Banner>();
            bannerList.Add(new Banner { Heading = "Cars", Message = "NEW MODELS", Caption = "WIDE RANGE OF ITEMS", Image = "Cars.jpg" });
            bannerList.Add(new Banner { Heading = "Car Parts", Message = "UP TO 50% OFF", Caption = "FIND BEST OFFERS", Image = "CarParts.jpg" });
            bannerList.Add(new Banner { Heading = "Services", Message = "Best Quality", Caption = "SCHEDULE A SERVICE RIGHT NOW", Image = "Services.jpg" });
            return bannerList;
        }

        private List<Product> GetCollections()
        {
            var trendList = new List<Product>();
            trendList.Add(new Product { Image = "MPakPrzod.jpg", Name = "BMW E36 Front M Bumper", Price = "120.00" });
            trendList.Add(new Product { Image = "PaseoLamp.jpg", Name = "Toyota Paseo Rear Lamp", Price = "49.99" });
            trendList.Add(new Product { Image = "R34Hood.jpg", Name = "Nissan Skyline R34 Hood", Price = "225.00" });
            trendList.Add(new Product { Image = "R34Intercooler.jpg", Name = "Nissan Skyline R34 Intercooler Kit", Price = "445.00" });
            return trendList;
        }

        private List<Product> GetTrends()
        {
            var colList = new List<Product>();
            colList.Add(new Product { Image = "CastrolOil.jpg", Name = "Castrol Magnetic Oil 5W-40 ", Price = "64.99" });
            colList.Add(new Product { Image = "HonitonTools.jpg", Name = "Honiton Tool Set", Price = "149.99" });
            colList.Add(new Product { Image = "H7.jpg", Name = "H7 Light Bulb", Price = "7.99" });
            return colList;
        }

        protected override void OnAppearing()
        {
            timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds) { AutoReset = true, Enabled = true };
            timer.Elapsed += Timer_Elapsed;
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            timer?.Dispose();
            base.OnDisappearing();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (cvBanners.Position == 2)
                {
                    cvBanners.Position = 0;
                    return;
                }

                cvBanners.Position += 1;
            });
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemPage());
        }
    }

    public class Banner
    {
        public string Heading { get; set; }
        public string Message { get; set; }
        public string Caption { get; set; }
        public string Image { get; set; }
    }


    public class Product
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }    



}