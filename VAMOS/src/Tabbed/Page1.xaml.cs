using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Peasone.otf", Alias = "Peasone")]
[assembly: ExportFont("Roboto-Light.ttf", Alias = "Roboto_light")]
[assembly: ExportFont("Roboto-Regular.ttf", Alias = "Roboto_regular")]
namespace VAMOS.src.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public IList<Dates> Datos { get; private set; }
        public Page1()
        {
            InitializeComponent();
            Datos = new List<Dates>();

            Datos.Add(new Dates
            {
                Name = "Bloque 1",
                Ubicacion = "Departamento de Ciencias Naturales",
                Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ8fZY6Y1vPk_vncjvu3hojMjX5eQA0cqFRWg&usqp=CAU"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 2",
                Ubicacion = "Departamento de ArtÍstica",
                Url = "https://images-ext-2.discordapp.net/external/7Rr3SkIEpaTVm3HswrnfJGhdoUewlKHGbxH9VmZNGMo/https/mott.pe/noticias/wp-content/uploads/2018/03/C%25C3%25B3mo-lograr-fotos-con-profundidad-de-campo-usando-cualquier-c%25C3%25A1mara-profundidad2.jpg"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 3",
                Ubicacion = "Departamento de Emprendimiento",
                Url = "https://images-ext-2.discordapp.net/external/7Rr3SkIEpaTVm3HswrnfJGhdoUewlKHGbxH9VmZNGMo/https/mott.pe/noticias/wp-content/uploads/2018/03/C%25C3%25B3mo-lograr-fotos-con-profundidad-de-campo-usando-cualquier-c%25C3%25A1mara-profundidad2.jpg"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 4",
                Ubicacion = "Departamento de Industriales",
                Url = "https://images-ext-2.discordapp.net/external/7Rr3SkIEpaTVm3HswrnfJGhdoUewlKHGbxH9VmZNGMo/https/mott.pe/noticias/wp-content/uploads/2018/03/C%25C3%25B3mo-lograr-fotos-con-profundidad-de-campo-usando-cualquier-c%25C3%25A1mara-profundidad2.jpg"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 5",
                Ubicacion = "Departamento de Matemáticas",
                Url = "https://images-ext-2.discordapp.net/external/7Rr3SkIEpaTVm3HswrnfJGhdoUewlKHGbxH9VmZNGMo/https/mott.pe/noticias/wp-content/uploads/2018/03/C%25C3%25B3mo-lograr-fotos-con-profundidad-de-campo-usando-cualquier-c%25C3%25A1mara-profundidad2.jpg"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 6",
                Ubicacion = "Departamento de Español",
                Url = "https://images-ext-2.discordapp.net/external/7Rr3SkIEpaTVm3HswrnfJGhdoUewlKHGbxH9VmZNGMo/https/mott.pe/noticias/wp-content/uploads/2018/03/C%25C3%25B3mo-lograr-fotos-con-profundidad-de-campo-usando-cualquier-c%25C3%25A1mara-profundidad2.jpg"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 7",
                Ubicacion = "Departamento de Religion",
                Url = "https://images-ext-2.discordapp.net/external/7Rr3SkIEpaTVm3HswrnfJGhdoUewlKHGbxH9VmZNGMo/https/mott.pe/noticias/wp-content/uploads/2018/03/C%25C3%25B3mo-lograr-fotos-con-profundidad-de-campo-usando-cualquier-c%25C3%25A1mara-profundidad2.jpg"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 8",
                Ubicacion = "La Biblioteca",
                Url = "https://images-ext-2.discordapp.net/external/7Rr3SkIEpaTVm3HswrnfJGhdoUewlKHGbxH9VmZNGMo/https/mott.pe/noticias/wp-content/uploads/2018/03/C%25C3%25B3mo-lograr-fotos-con-profundidad-de-campo-usando-cualquier-c%25C3%25A1mara-profundidad2.jpg"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 9",
                Ubicacion = "Canchas",
                Url = "https://images-ext-2.discordapp.net/external/7Rr3SkIEpaTVm3HswrnfJGhdoUewlKHGbxH9VmZNGMo/https/mott.pe/noticias/wp-content/uploads/2018/03/C%25C3%25B3mo-lograr-fotos-con-profundidad-de-campo-usando-cualquier-c%25C3%25A1mara-profundidad2.jpg"
            });

            BindingContext = this;
        }


        

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert(e.SelectedItem.ToString(), "XD", "Ok");
            
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}