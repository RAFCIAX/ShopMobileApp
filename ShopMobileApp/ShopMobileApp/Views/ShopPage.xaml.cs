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
    public partial class ShopPage : ContentPage
    {
        public ShopPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<Banner> Banners { get => GetBanners(); }


        private List<Banner> GetBanners()
        {
            var bannerList = new List<Banner>();
            bannerList.Add(new Banner { Heading = "SUMMER COLLECTION", Message = "40% Discount", Caption = "BEST DISCOUNT THIS SEASON", Image = "WIPP.png" });
            bannerList.Add(new Banner { Heading = "WOMEN'S CLOTHINGS", Message = "UP TO 50% OFF", Caption = "GET 50% OFF ON EVERY ITEM", Image = "WIP.png" });
            bannerList.Add(new Banner { Heading = "ELEGANT COLLECTION", Message = "20% Discount", Caption = "UNIQUE COMBINATIONS OF ITEMS", Image = "WIPP.png" });
            return bannerList;
        }
    }

    public class Banner
    {
        public string Heading { get; set; }
        public string Message { get; set; }
        public string Caption { get; set; }
        public string Image { get; set; }
    }
}