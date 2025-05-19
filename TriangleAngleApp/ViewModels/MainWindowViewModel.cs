using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Globalization;

namespace TriangleAngleApp.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string sideA;

    [ObservableProperty]
    private string sideB;

    [ObservableProperty]
    private string result;

    [RelayCommand]
    private void Calculate()
    {
        try
        {
            double a = double.Parse(SideA, CultureInfo.InvariantCulture);
            double b = double.Parse(SideB, CultureInfo.InvariantCulture);

            if (a <= 0 || b <= 0)
            {
                Result = "Катети мають бути додатними числами.";
                return;
            }

            double c = Math.Sqrt(a * a + b * b);
            double angleA1 = Math.Asin(a / c) * (180 / Math.PI);
            double angleA2 = Math.Asin(b / c) * (180 / Math.PI);

            Result = $"Гіпотенуза: {c:F2}\nКут A1: {angleA1:F2}°\nКут A2: {angleA2:F2}°";
        }
        catch (FormatException)
        {
            Result = "Введіть коректні числові значення.";
        }
    }
}
