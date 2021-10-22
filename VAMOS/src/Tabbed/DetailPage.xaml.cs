using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VAMOS.src.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Dates product)
        {
            InitializeComponent();
            LabelName.Text = product.Name;
            LabelPrice.Text = product.Descripcion.ToString();
        }
    }
}