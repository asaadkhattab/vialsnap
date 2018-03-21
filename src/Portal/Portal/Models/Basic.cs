﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientConsoleModel.Models
{
    public class Basic
    {
        public Basic()
        {
            Patients = new List<Patient>();
        }

        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<Patient> Patients { get; set; }
    }
}