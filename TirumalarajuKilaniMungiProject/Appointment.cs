using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirumalarajuKilaniMungiProject
{
    //created by TirumalarajuKilaniMungi
    //This class is for storing the appointment objects
    public class Appointment:IAppointment
    {

        private string doctorId;
        private string appointmentDate;
        private string appointmentDay;
        private string appointmentTime;
        private string appointmentType;
        public string appointmentDescription { get; set; }
        public string emergencyDescription { get; set; }
        public string patientId { get; set; }
        
        public string slotId { get; set; }

        public string appointmentId { get; set; }
        public Appointment(string doctorId, string appointmentDate, string appointmentDay, string appointmentTime, string appointmentType)
        {
            this.doctorId = doctorId;
            this.appointmentDate = appointmentDate;
            this.appointmentDay = appointmentDay;
            this.appointmentTime = appointmentTime;
            this.appointmentType = appointmentType;
        }

        public string GetDoctorId()
        {
            return doctorId;
        }

        public string GetAppointmentDate()
        {
            return appointmentDate;
        }

        public string GetAppointmentDay()
        {
            return appointmentDay;
        }

        public string GetAppointmentTime()
        {
            return appointmentTime;
        }

        public string GetAppointmentType()
        {
            return appointmentType;
        }

        public string GenerateRandomIdForAppointment()
        {
            Random rnd = new Random();
            int appRandId = rnd.Next(10000000, 99999999);
            return ("APT" + appRandId);
        }

    }
}
