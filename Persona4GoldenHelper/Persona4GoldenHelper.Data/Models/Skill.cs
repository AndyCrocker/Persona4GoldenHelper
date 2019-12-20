﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Persona4GoldenHelper.Data.Models
{
    public class Skill
    {
        public string Name { get; set; }
        public string Effect { get; set; }
        public string Cost { get; set; }
        public List<SkillPersona> Personas { get; set; }

        public Skill(string name, string effect, string cost, List<SkillPersona> personas)
        {
            Name = name;
            Effect = effect;
            Cost = cost;
            Personas = personas;
        }
    }
}