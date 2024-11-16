using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationHW1
{
    class Program
    {
        class Doctor
        {
            public string name { get; set; }
            public string branch { get; set; }

            public List<Patient> Patients { get; set; }

            public Doctor(string name, string branch)
            {
                this.name = name;
                this.branch = branch;
                Patients = new List<Patient>();
            }
            public void addPatient(Patient patient)
            {
                if (!Patients.Contains(patient))
                {
                    Patients.Add(patient);
                }
            }

        }
        class Patient
        {
            public string name { get; set; }
            public string tcNo { get; set; }
            public Doctor assignedDoctor { get; private set; }
            public Patient(string name, string tcNo)
            {
                this.name = name;
                this.tcNo = tcNo;
            }
            public void AssignDoctor(Doctor doctor)
            {
                if (assignedDoctor != doctor) 
                {
                    assignedDoctor = doctor;
                    doctor.addPatient(this); 
                }
            }

        }
        static void Main(string[] args)
        {


        }
    }
}
