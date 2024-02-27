using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActuArte.Models;

public class UsuariosDTO
{
    public int idUsuario {get; set;}

    public string? nombreUsuario {get; set;}

    public string? passwordUsuario {get; set;}
}