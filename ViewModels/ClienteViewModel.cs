using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using wpf_material_design.Models;

namespace wpf_material_design.ViewModels;

public partial class ClienteViewModel : ObservableObject
{
    [ObservableProperty]
    public Cliente cliente = new();

    [RelayCommand]
    public void Save()
    {
        Cliente.Id = Guid.NewGuid();
        Cliente.Nome = "Peter Parker";
        Cliente.Email = "peter.parker@marvel.com";
    }    
}
