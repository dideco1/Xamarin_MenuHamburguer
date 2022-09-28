using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_MenuHamburguer.Models;

namespace Xamarin_MenuHamburguer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();
        }

        private async void banco_clicked(object sender, EventArgs e)
        {
            try
            {                

            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void analise_clicked(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void design_clicked(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void web_clicked(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void fundamentos_clicked(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void tecnicas_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    nome = "Técnicas de Programação e Algoritmo",

                    atribuicoesResponsabilidades = "~ Implementar algoritmos em linguagem de programação, utilizando" +
                    "ambientes de desenvolvimento de acordo com as necessidades",

                    valoresAtitudes = "~ Estimular a organização; ~ Incentivar atitudes de autonomia; ~ Fortalecer a persistência" +
                    "e o interesse na resolução de situações-problema"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
    }
}