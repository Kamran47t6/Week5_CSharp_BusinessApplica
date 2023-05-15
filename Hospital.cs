using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_1
{
   public class Hospital
    {
        public  int HospitalEmergencyWard=0;
        public  int HospitalSurgicalWard=0;
        public  int HospitalDengueWard=0;
        public  int HospitalGeneralWard=0;
        public  int HospitalCovidWard=0;
        public  int HospitalCardialogyWard=0;
        public  int Hospital_PatDeadBody;
        public Hospital(int HospitalEmergency, int HospitalSurgical, int HospitalDengue, int HospitalGeneral, int HospitalCovid, int HospitalCardialogy, int Hospital_PatDeadBod)
        {
            HospitalEmergencyWard = HospitalEmergency;
            HospitalSurgicalWard = HospitalSurgical;
            HospitalDengueWard = HospitalDengue;
            HospitalGeneralWard = HospitalGeneral;
            HospitalCovidWard = HospitalCovid;
            HospitalCardialogyWard = HospitalCardialogy;
            Hospital_PatDeadBody = Hospital_PatDeadBod;
        }
        public void AddToEmergencyWard()
        {
            HospitalEmergencyWard++;
        }
        public void AddToSurgicalWard()
        {
            HospitalSurgicalWard++;
        }
        public void AddToDengueWard()
        {
            HospitalDengueWard++;
        }
        public void AddToGeneralWard()
        {
            HospitalGeneralWard++;

        }
        public void AddToCovidWard()
        {
            HospitalCovidWard++;
        } 
        public void AddToCardialogy()
        {
            HospitalCardialogyWard++;
        }
        public void Expire()
        {
            Hospital_PatDeadBody++;
        }
        

        
       

    }
}
