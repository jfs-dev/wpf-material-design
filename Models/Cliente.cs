using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace wpf_material_design.Models;

public class Cliente : ObservableValidator
{
    private Guid _id = Guid.Empty;
    private string _nome = string.Empty;
    private string _email = string.Empty;

    [Key]
    [Required()]
    public Guid Id { get => _id; set => SetProperty(ref _id, value, true); }

    [Required(ErrorMessage = "Favor informar o nome!")]
    [MinLength(3, ErrorMessage = "Favor informar pelo menos {1} caracteres!")]
    public string Nome { get => _nome; set => SetProperty(ref _nome, value, true); }

    [Required(ErrorMessage = "Favor informar o e-mail!")]
    [EmailAddress(ErrorMessage = "Favor informar um e-mail válido!")]
    public string Email { get => _email; set => SetProperty(ref _email, value, true); }

    public void ValidateAll()
    {
        ValidateAllProperties();
    }
}
