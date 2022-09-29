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
                var c = new componente
                {
                    Nome = "Banco de Dados I",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

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
                var c = new componente
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

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
                var c = new componente
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

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
                var c = new componente
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

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
                var c = new componente
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

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
                    Nome = "Técnicas de Programação e Algoritmo",

                    AtribuicoesResponsabilidades = "~ Implementar algoritmos em linguagem de programação, utilizando" +
                    "ambientes de desenvolvimento de acordo com as necessidades",

                    ValoresAtitudes = "~ Estimular a organização; \n ~ Incentivar atitudes de autonomia;\n ~ Fortalecer a persistência" +
                    "e o interesse na resolução de situações-problema"
                };
                await Navigation.PushAsync(new VerComponente(c));

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void port_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Língua Portuguesa, Literatura e Comunicação Profissional",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando a terminologia técnico-científica da área com" +
                    "autonomia, clareza e precisão.",

                    ValoresAtitudes = "~ Incentivar o diálogo e a interlocução \n" +
                    "~ Estimular o interesse na resolução de situações-problema \n" +
                    "~ Responsabilizar-se pela produção, realização e divulgação de informações"
                };

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void ingles_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "Língua Estrangeira Moderna - Inglês e Comunicação Profissional",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua estrangeira utilizando o vocabulário e a terminologia" +
                    "técnico-cientifica da área",

                    ValoresAtitudes = ""
                };

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void geo_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void mat_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void bio_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void quimica_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void hist_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void fisica_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void filoso_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void socio_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void artes_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
        private async void educacao_clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new componente
                {
                    Nome = "",

                    AtribuicoesResponsabilidades = "",

                    ValoresAtitudes = ""
                };

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }
    }
}