using System;

namespace BackBeta.Domain.Dto.User
{
    public class AtualizarUsuarioResultadoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
