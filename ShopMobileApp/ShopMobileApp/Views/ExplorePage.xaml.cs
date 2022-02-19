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
            catList.Add(new Category { Image = "BluzaElpolakoMiejskiTy.jpg", Title = "SUMMER COLLECTION", Caption = "BEST DISCOUNT THIS SEASON" });
            catList.Add(new Category { Image = "BluzaElpolakoMiejskiTy.jpg", Title = "WOMEN'S CLOTHING", Caption = "UP TO 50% OFF ON EVERY ITEM" });
            catList.Add(new Category { Image = "BluzaElpolakoMiejskiTy.jpg", Title = "ELEGANT CLOTHINGS", Caption = "UNIQUE COLLECTIONS AND STYLES" });
            return catList;
        }
    }

}