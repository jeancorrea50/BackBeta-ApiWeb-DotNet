﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BackBeta.Domain.Dto.User
{
    public class AtualizarUsuarioDto
    {
        [Required(ErrorMessage = "Id é um campo obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email é um campo obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }
    }
}
