﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientConsoleModel.Models
{
    public class Physician
    {
        public Physician()
        {
            Patients = new List<PatientPhysician>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<PatientPhysician> Patients { get; set; }
    }
}
