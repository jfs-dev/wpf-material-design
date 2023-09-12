using System.Windows;
using wpf_material_design.ViewModels;

namespace wpf_material_design.Views;

/// <summary>
/// Interaction logic for ClienteView.xaml
/// </summary>
public partial class ClienteView : Window
{
    ClienteViewModel _clienteViewModel = new();

    public ClienteView()
    {
        InitializeComponent();

        DataContext = _clienteViewModel;
    }

    private void ClienteWindow_Loaded(object sender, RoutedEventArgs e)
    {
        _clienteViewModel.Cliente.ValidateAll();
        
        NameTextBox.Focus();
    }

    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}
