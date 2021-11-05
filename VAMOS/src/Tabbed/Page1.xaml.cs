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
                Descripcion = "Bloque de ciencias, donde puedes encontrar dos laboratios",
                Ubicacion = "Departamento de Ciencias Naturales",
                Url = "paisaje_natural"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 2",
                Descripcion = "Bloque de artÍstica, donde puedes encontrar aulas e instrumentos",
                Ubicacion = "Departamento de ArtÍstica",
                Url = "paisaje_natural"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 3",
                Descripcion = "Bloque de comercial, donde puedes encontrar nada XD",
                Ubicacion = "Departamento de Emprendimiento",
                Url = "paisaje_natural"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 4",
                Descripcion = "Bloque de industriales, donde puedes encontrar talleres de carpintería y de electronica",
                Ubicacion = "Departamento de Industriales",
                Url = "paisaje_natural"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 5-A",
                Descripcion = "Este bloque es una chimba porque si, 5",
                Ubicacion = "Departamento de Matemáticas",
                Url = "paisaje_natural"
            });

            Datos.Add(new Dates 
            {
                Name = "Bloque 5-B",
                Descripcion = "",
                Ubicacion = "Departamento de Matemáticas",
                Url = "paisaje_natural"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 6-A",
                Descripcion = "Este bloque es una chimba porque si, 6",
                Ubicacion = "Departamento de Español",
                Url = "paisaje_natural"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 6-B",
                Descripcion = "Este bloque es una chimba porque si, 6",
                Ubicacion = "Departamento de Español",
                Url = "paisaje_natural"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 7-A",
                Descripcion = "Este bloque es una chimba porque si, 7",
                Ubicacion = "Departamento de Religion",
                Url = "paisaje_natural"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 7-B",
                Descripcion = "Este bloque es una chimba porque si, 7",
                Ubicacion = "Departamento de Religion",
                Url = "paisaje_natural"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 8",
                Descripcion = "Este bloque es una chimba porque si, 8",
                Ubicacion = "La Biblioteca",
                Url = "paisaje_natural"
            });

            Datos.Add(new Dates
            {
                Name = "Bloque 9",
                Descripcion = "Este bloque es una chimba porque si, 9",
                Ubicacion = "Canchas",
                Url ="paisaje_natural"
            });

            BindingContext = this;
        }


        
        

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }

            Navigation.PushModalAsync(new DetailPage(e.Item as Dates));
        }
    }
}