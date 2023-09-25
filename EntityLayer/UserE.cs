﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer
{
    public class UserE:BaseE
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El campo Usuario es obligatorio.")]
        [Display(Name = "Usuario")]
        public string User { get; set; }

        [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
    }
}
