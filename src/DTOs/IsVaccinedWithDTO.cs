﻿using System.Collections.Generic;

namespace VacunaAPI.DTOs
{
    public class IsVaccinatedWithDTO
    {
        public string Identification { get; set; }
        public bool IsImmunized { get; set; }
        public bool IsValidated { get; set; }
        public List<ImmunizationDTO> Immunizations { get; set; }
    }
}
