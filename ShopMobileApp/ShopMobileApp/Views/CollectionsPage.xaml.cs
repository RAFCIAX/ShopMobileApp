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
    public partial class CollectionsPage : ContentPage
    {
        

        public CollectionsPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<Category> MyCollections { get => GetCollections(); }

        private List<Category> GetCollections()
        {
            var colList = new List<Category>();
            colList.Add(new Category { Image = "MPakPrzod.jpg", Title = "BMW E36 Front M Bumper", Price = "120.00" });
            colList.Add(new Category { Image = "PaseoLamp.jpg", Title = "Toyota Paseo Rear Lamp", Price = "49.99" });
            colList.Add(new Category { Image = "R34Hood.jpg", Title = "Nissan Skyline R34 Hood", Price = "225.00" });
            colList.Add(new Category { Image = "R34Intercooler.jpg", Title = "Nissan Skyline R34 Intercooler Kit", Price = "445.00" });
            colList.Add(new Category { Image = "CastrolOil.jpg", Title = "Castrol Magnetic Oil 5W-40 ", Price = "64.99" });
            colList.Add(new Category { Image = "HonitonTools.jpg", Title = "Honiton Tool Set", Price = "149.99" });
            colList.Add(new Category { Image = "H7.jpg", Title = "H7 Light Bulb", Price = "7.99" });
            colList.Add(new Category { Image = "JR11.jpg", Title = "JR11 Rims", Price = "125.00"});
            colList.Add(new Category { Image = "Engine2JZSwap.jpg", Title = "2JZ Engine Swap", Price = "1100.00"});
            colList.Add(new Category { Image = "HertzAudio.jpg", Title = "Hertz Car Audio Speakers", Price = "78.99"});
            colList.Add(new Category { Image = "JR12.jpg", Title = "JR12 Rims", Price = "112.00"});
            colList.Add(new Category { Image = "ShellOil.jpg", Title = "Shell Helix Ultra 5W-40 Engine Oil", Price = "45.00"});
            colList.Add(new Category { Image = "Rollcage.jpg", Title = "BMW E36 Rollcage", Price = "139.99"});
            colList.Add(new Category { Image = "JR3.jpg", Title = "JR3 Rims", Price = "99.99"});
            colList.Add(new Category { Image = "TurboKit.png", Title = "RB26DETT Turbo Kit", Price = "215.00"});
            colList.Add(new Category { Image = "JRX5.jpg", Title = "JRX5 Rims", Price = "119.99"});
            colList.Add(new Category { Image = "M52B28Swap.jpg", Title = "BMW M52B28 Engine Swap", Price = "89.99"});
            colList.Add(new Category { Image = "R34Suspension.jpg", Title = "Nissan Skyline R34 Suspension Kit", Price = "211.00"});
            colList.Add(new Category { Image = "ValvolineOil.jpg", Title = "Valvoline Premium 10W-30 Engine Oil", Price = "68.99"});
            colList.Add(new Category { Image = "MPakPrzod.jpg", Title = "BMW E36 Front M Bumper", Price = "120.00" });
            colList.Add(new Category { Image = "PaseoLamp.jpg", Title = "Toyota Paseo Rear Lamp", Price = "49.99" });
            colList.Add(new Category { Image = "R34Hood.jpg", Title = "Nissan Skyline R34 Hood", Price = "225.00" });
            colList.Add(new Category { Image = "R34Intercooler.jpg", Title = "Nissan Skyline R34 Intercooler Kit", Price = "445.00" });
            colList.Add(new Category { Image = "CastrolOil.jpg", Title = "Castrol Magnetic Oil 5W-40 ", Price = "64.99" });
            colList.Add(new Category { Image = "HonitonTools.jpg", Title = "Honiton Tool Set", Price = "149.99" });
            colList.Add(new Category { Image = "H7.jpg", Title = "H7 Light Bulb", Price = "7.99" });
            colList.Add(new Category { Image = "JR11.jpg", Title = "JR11 Rims", Price = "125.00"});
            colList.Add(new Category { Image = "Engine2JZSwap.jpg", Title = "2JZ Engine Swap", Price = "1100.00"});
            colList.Add(new Category { Image = "HertzAudio.jpg", Title = "Hertz Car Audio Speakers", Price = "78.99"});
            colList.Add(new Category { Image = "JR12.jpg", Title = "JR12 Rims", Price = "112.00"});
            colList.Add(new Category { Image = "ShellOil.jpg", Title = "Shell Helix Ultra 5W-40 Engine Oil", Price = "45.00"});
            colList.Add(new Category { Image = "Rollcage.jpg", Title = "BMW E36 Rollcage", Price = "139.99"});
            colList.Add(new Category { Image = "JR3.jpg", Title = "JR3 Rims", Price = "99.99"});
            colList.Add(new Category { Image = "TurboKit.png", Title = "RB26DETT Turbo Kit", Price = "215.00"});
            colList.Add(new Category { Image = "JRX5.jpg", Title = "JRX5 Rims", Price = "119.99"});
            colList.Add(new Category { Image = "M52B28Swap.jpg", Title = "BMW M52B28 Engine Swap", Price = "89.99"});
            colList.Add(new Category { Image = "R34Suspension.jpg", Title = "Nissan Skyline R34 Suspension Kit", Price = "211.00"});
            colList.Add(new Category { Image = "ValvolineOil.jpg", Title = "Valvoline Premium 10W-30 Engine Oil", Price = "68.99"});
            //colList.Add(new Category { Image = "", Title = "", Price = ""});


            return colList;
        }
    }

    public class Category
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public string Price { get; set; }
    }
}