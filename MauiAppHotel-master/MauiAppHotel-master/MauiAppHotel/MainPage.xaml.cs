using System;

namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            // Validação simples para não permitir datas passadas
            if (e.NewDate < DateTime.Now.Date)
            {
                DisplayAlert("Data inválida", "Selecione uma data futura.", "OK");
                ((DatePicker)sender).Date = DateTime.Now.Date; // Reseta para a data atual
            }
            else
            {
                // Lógica adicional para datas válidas, se necessário
            }
        }
    }
}