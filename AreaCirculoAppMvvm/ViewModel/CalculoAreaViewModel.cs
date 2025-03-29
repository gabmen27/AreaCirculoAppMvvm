

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AreaCirculoAppMvvm.ViewModel
{
    public partial class CalculoAreaViewModel : ObservableObject
    {
        [ObservableProperty]
        private double radio;

        [ObservableProperty]
        private double resultado;
        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {
            try
            {
                if (Radio < 0)
                {
                    Alerta("ADVERTENCIA", "El Radio no puede ser negativo");
                }
                else
                {
                    Resultado = (Radio*Radio) * Math.PI;
                }
            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }
        }

        [RelayCommand]
        private void Limpiar() {
            Radio = 0;
            Resultado = 0;
        }
    }
}
