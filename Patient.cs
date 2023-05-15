using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_1
{
   public class Patient
    {
        public string PatientName;
        public int PatientID;
        public int PatientAge;
        public string PatientCity;
        public string PatientDisease;
        public string Patient_EnterTime;
       /* public List<Patient> StorePatient = new List<Patient>();*/
        public Patient(string PatientName, int PatientID, int PatientAge,string PatientCity,string PatientDisese)
        {
            this.PatientName = PatientName;
            this.PatientID = PatientID;
            this.PatientAge = PatientAge;
            this.PatientCity = PatientCity;
            this.PatientDisease = PatientDisese;
        }
        public void Display()
        {
            Console.WriteLine(PatientName + $"\t" + PatientID + "\t   " + PatientAge + "\t   "+ PatientCity + "\t   "+ PatientDisease +"   ");
        }
    }
}
