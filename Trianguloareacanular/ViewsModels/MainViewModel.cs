using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trianguloareacanular.ViewsModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _A;

        [ObservableProperty]
        private double _B;
        [ObservableProperty]
        private double _C;

        [ObservableProperty]
        private string? _area;

        [RelayCommand]
        public void CalcularArea()
        {


            double s = (A + B + C) / 2;
            double area = Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            Area = area.ToString("F2");



        }


    }
}
