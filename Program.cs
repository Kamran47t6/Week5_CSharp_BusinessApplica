using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospital_1;
namespace hospital_1
{
    internal class Program
    {
        static List<Patient> list = new List<Patient>();
       static Hospital h = new Hospital(0, 0, 0, 0, 0, 0, 0);
        static void Main(string[] args)
        {
            Welcome();
            int choice;
            while (true)
            {
                Console.Clear();
                choice = Menu();
                if (choice == 1)
                {
                    AddPatient();
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    CheckPoint();
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    DeletePatient();
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    UpdatePatient();
                    Console.ReadKey();
                }

                else if (choice == 5)
                {
                    ViewPatient();
                    Console.ReadKey();
                }
                else if (choice == 6)
                {
                    AddDoctor();
                    Console.ReadKey();
                }
                else if (choice == 7)
                {
                    ViewDoctor();
                    Console.ReadKey();
                }
                else if (choice == 8)
                {
                    PatientsInWards();
                    Console.ReadKey();
                }
            }
        }
        static void Welcome()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Welcome to Hospital Management System ");
            Console.WriteLine("--------------------------------------");
        }
        static int Menu()
        {
            Console.WriteLine("Press 1 for ADD PAtient :");
            Console.WriteLine("Press 2 for Patient CheckUp :");
            Console.WriteLine("Press 3 for Delete Patient :");
            Console.WriteLine("Press 4 for Updata Patient : ");
            Console.WriteLine("Press 5 for View Patient :");
            Console.WriteLine("Press 6 to Add Doctor :");
            Console.WriteLine("Press 7 for View List of Available Doctors");
            Console.WriteLine("press 8 to View Record of Admit Patients in Hopital Wards :");
            int choise = int.Parse(Console.ReadLine());
            return choise;
        }
        static Patient AddPatient()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------ ADD PATIENT ----------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Enter Patient Name :");
            string pname = Console.ReadLine();
            Console.WriteLine("Enter Patient ID :");
            int pid = int.Parse(Console.ReadLine());
            Console.WriteLine("Eter Patient Age:");
            int page = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Patient City:");
            string pcity = Console.ReadLine();
            Console.WriteLine("Enter Patient Disese :");
            string pdisese = Console.ReadLine();
            Console.WriteLine("Patient Added Successfully.....");
            Patient patient = new Patient(pname, pid, page,pcity,pdisese);
            list.Add(patient);
            return patient;
        }    
        static void CheckPoint()
        {
            bool check = false;
            Console.WriteLine("----- --------------------");
            Console.WriteLine("------- Emergency ------- ");
            Console.WriteLine("----- --------------------");
            Console.WriteLine("Enter Patient ID to check whether to refer the Patient :");
            int patid = int.Parse(Console.ReadLine());
            foreach(Patient p in list)
            {
                if (p.PatientID == patid)
                {
                    check = true;
                    if(p.PatientDisease=="Heart Problem" || p.PatientDisease == "heart problem" || p.PatientDisease == "heart attack" || p.PatientDisease == "Heart Attack")
                    {
                        Console.WriteLine("Quickly refer to Cardialogy Ward .....");
                        h.AddToCardialogy();
                    }
                    else if(p.PatientDisease=="Accident" || p.PatientDisease=="accident")
                    {
                        Console.WriteLine("Quickly refer to Surgical Ward .....");
                        h.AddToSurgicalWard();
                    }
                    else if(p.PatientDisease=="Covid" || p.PatientDisease == "covid")
                    {
                        Console.WriteLine("Quickly refer to Covid Ward .....");
                        h.AddToCovidWard();
                    }
                    else if(p.PatientDisease=="Dengue" || p.PatientDisease == "dengue")
                    {
                        Console.WriteLine("Quickly refer to Dengue Ward .....");
                        h.AddToDengueWard();
                    }
                    else if(p.PatientDisease=="Fracture" || p.PatientDisease=="BloodPressure")
                    {
                        Console.WriteLine("Quickly refer to General Ward .....");
                        h.AddToGeneralWard();
                    }
                    else if(p.PatientDisease=="Critical" || p.PatientDisease=="critical" || p.PatientDisease == "BloodShoot")
                    {
                        Console.WriteLine("Quickly refer to Emergency Ward .....");
                        h.AddToEmergencyWard();
                    }
                    else if(p.PatientDisease=="Dead" || p.PatientDisease == "dead")
                    {
                        Console.WriteLine("Sorry !!! Patient is no more.......");
                        h.Expire();
                    }
                    else
                    {

                        h.AddToEmergencyWard();
                    }
                }
             

            }
            if (check == false)
            {
                Console.WriteLine("Sorry ! No record found of this ID.....");
            }
          
        }
        static void ViewPatient()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------ VIEW PATIENT ----------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Patient Name  Patient ID  Patient Age  Patient City Patient Disease");
            foreach (Patient data in list)
            {
                data.Display();
            }
         
        }
        static void AddDoctor()
        {
            Console.WriteLine("-------- ADD Doctor -------");
            Console.WriteLine("Enter Doctor Name :");
            string docName = Console.ReadLine();
            Console.WriteLine("Enter Doctor ID :");
            int docID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Doctor Specialization :");
            String docSpecilizaion = Console.ReadLine();
            Console.WriteLine("Enter Duty hous :");
            int docDutyHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Shift Type (Day/Night):");
            string docShift = Console.ReadLine();   
            for (int i = 0; i != -1; i++)
            {
            if(docShift=="Day" || docShift=="Night" || docShift == "day" || docShift == "night")
            {
                Console.WriteLine("Doctor Data Added Successfully .....");
                  
                
                    break;
            }
            else
            {
                Console.WriteLine("Inavlid input.....");
                Console.WriteLine("Please enter correct shift type :");
            }
            }

            Doctor doctor = new Doctor(docName, docID, docSpecilizaion, docDutyHour, docShift);
            Doctor.DocList.Add(doctor);
        }
        static void ViewDoctor()
        {
            Console.WriteLine("------ Registered Doctors -----");
            Console.WriteLine("Doctor Name \t Doctor ID \t Doctor Specializaation \t Doctor Shift");
            foreach(Doctor data in Doctor.DocList)
            {
                Console.WriteLine(data.DoctorName + "                " + data.DoctorID + "                 " + data.DoctorSpecialization + "                " + data.DoctDutyShift);
            }
            
        }
        static void PatientsInWards()
        {
           
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("----- Patients in Differnet Wards -----");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Emergency Ward | Surgical Ward | Dengue Ward | General Ward | Covid Ward | Cardialogy Ward");
            Console.WriteLine(h.HospitalEmergencyWard + " " + h.HospitalSurgicalWard + " " + h.HospitalDengueWard + " " + h.HospitalGeneralWard + " " + h.HospitalCovidWard + " " + h.HospitalCardialogyWard);
        }
        static void DeletePatient()
        {
            Console.WriteLine("-------- DELETE Patient ---------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Enter the ID of the patient to Delete :");
            int patid = int.Parse(Console.ReadLine());
            Patient patientToRemove = list.Find(p => p.PatientID == patid);
                if (patientToRemove != null)
                {
                    list.Remove(patientToRemove);
                    Console.WriteLine("Patient Deleted Successfully.....");
                }
                else
                {
                    Console.WriteLine("Patient Not Found .....");
                }
            Console.ReadKey();
        }
        static void UpdatePatient()
        {
            Console.WriteLine("-------- UPDATE Patient ---------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Enter the ID of the patient to Update :");
            int patid = int.Parse(Console.ReadLine());
            Patient patientToUpdate = list.Find(p => p.PatientID == patid);
            if (patientToUpdate != null)
            {
                Console.WriteLine("Enter the Patient Name :");
                string pname = Console.ReadLine();
                Console.WriteLine("Enter the Patient ID :");
                int Pid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Patient Age :");
                int page = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Patient City :");
                string pcity = Console.ReadLine();
                Console.WriteLine("Enter the Patient Disease :");
                string pdise = Console.ReadLine();
                patientToUpdate.PatientName = pname;
                patientToUpdate.PatientID = Pid;
                patientToUpdate.PatientAge = page;
                patientToUpdate.PatientCity = pcity;
                patientToUpdate.PatientDisease = pdise;
                Console.WriteLine("Patient Updated Successfully ......");
            }
            else
            {
                Console.WriteLine("No Data Found .....");
            }
          
        }
           
        }

    } 

