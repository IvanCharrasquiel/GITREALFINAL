using System;
using System.Collections.Generic;
using System.Linq;
using gitDefinitivo.Pages;
using Microsoft.Maui.Controls;

namespace gitDefinitivo;

 public partial class Maestro : ContentPage
{
    public Maestro()
    {
        InitializeComponent();
    }

    public static void NavigationToPage(ContentPage nuevaPagina)
    {
        App.FlyoutPage.Detail.Navigation.PushAsync(nuevaPagina);
    }


    public static void OcultarDetalles()
    {
        App.FlyoutPage.IsPresented = false;
    }

    
    private void GoToCafePage(object sender, EventArgs e)
    {

        NavigationToPage(new Cafe());

        OcultarDetalles();
    }

   

    private void GoToFutbolPage(object sender, EventArgs e)
    {

        NavigationToPage(new Futbol());

        OcultarDetalles();
    }
    private void GoToPaisesPage(object sender, EventArgs e)
    {

        NavigationToPage(new Paises());

        OcultarDetalles();
    }



    private void Programacion_Clicked(object sender, EventArgs e)
    {
        NavigationToPage(new ProgramacionPage());
        OcultarDetalles();
    }

}
