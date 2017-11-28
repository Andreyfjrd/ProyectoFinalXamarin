using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalXamrin.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinalXamrin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPage : ContentPage
    {
        public class Datos
        {
            public string Img { get; set; }

            public string Nombre { get; set; }
        }

        List<Datos> lista;

        public CarouselPage()
        {
            InitializeComponent();
            
            lista = new List<Datos>
            {
                new Datos
                {
                    Img = "montaña.jpg",
                    Nombre = "Montaña"
                },

                new Datos
                {
                    Img = "cuidad.jpg",
                    Nombre = "Ciudad"
                },

                new Datos
                {
                    Img = "cuidad2.jpg",
                    Nombre = "Ciudad"
                }
               
            };


           
        }
   
    }
}