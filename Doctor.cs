using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_1
{
  public class Doctor
    {
        public static List<Doctor> DocList = new List<Doctor>();
        public string DoctorName;
        public int DoctorID;
        public string DoctorSpecialization;
        public int DoctorDuty_Hour;
        public string DoctDutyShift;
        public Doctor(string DoctorName, int DoctorID,string DoctorSpecialization, int DoctorDuty_Hour, string DoctDutyShift)
        {
            this.DoctorName = DoctorName;
            this.DoctorID = DoctorID;
            this.DoctorSpecialization = DoctorSpecialization;
            this.DoctorDuty_Hour = DoctorDuty_Hour;
            this.DoctDutyShift = DoctDutyShift;
        }

    }
}
