using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.IO.Packaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TirumalarajuKilaniMungiProject
{
    //created by TirumalarajuKilaniMungi
    //This class acts as an intermediate class between Data Access Class and Form Class
    //In this class we model the queries as per the request from the form class. Then call the Data Access Class and get the data from the Data Access Class and Pass the output back to the form class.
    internal class DrConsultIntermediary
    {

        //Decalring property to hold error
        public string dbError { get; set; }
        private DrConsultDataClass drConsultData;
        public DrConsultIntermediary()
        {
            drConsultData = new DrConsultDataClass();
        }//ctor

        //Method to retrieve doctors based on pincode and specilization
        public DataSet getDoctorsBasedOnCriteria(String specilization, String pinCode)
        {
            String sqlStatement = $"select d.Id,d.FirstName + ' ' + d.LastName AS [Doctor Name], c.ClinicName as [Hospital Name], c.ClinicAddress as [Address], d.Specilization from UserDetails d join Clinic c on d.Id = c.DoctorId and d.Specilization = '{specilization}' and c.ClinicPincode = '{pinCode}';";
            try
            {
                return drConsultData.ExecuteQuery(sqlStatement);
            }
            catch (Exception ex)
            {

                dbError = ex.Message;
                return null;

            }//try/catch

        }//end getDoctorsBasedOnCriteria

        public DataSet getDoctorSlots(String doctorId, string appointmentDate)
        {
            string sqlStatement = $"select * from dbo.Slots where DoctorId = '{doctorId}' and Isbooked = 0 and Date = '{appointmentDate}';";
            


            try
            {
                DrConsultDataClass drConsultData = new DrConsultDataClass();
                return drConsultData.ExecuteQuery(sqlStatement);
            }
            catch (Exception ex)
            {

                dbError = ex.Message;
                return null;
            }//try/catch
        }//end getDoctorSlots

        public DataSet GetSlotId(string doctorId, string appointmentDate, int time)
        {
            string sqlStatement = $"select * from dbo.Slots where DoctorId = '{doctorId}' and Date = '{appointmentDate}' and Time = {time};";


            try
            {
                DrConsultDataClass drConsultData = new DrConsultDataClass();
                return drConsultData.ExecuteQuery(sqlStatement);
            }
            catch (Exception ex)
            {

                dbError = ex.Message;
                return null;
            }//try/catch
        }

        //Method to register a new patient
        public int RegisterPatient(Patients patient)
        {
            // string sqlQuery = $"insert into [dbo].[UserDetails] values ('{patient.firstName}','{patient.lastName}','{patient.phoneNumber}','{patient.email}','{patient.address}','P','')";

            string sqlQuery = "Insert into [dbo].[userDetails] values (@Id,@FirstName,@LastName,@PhoneNumber,@EmailId,@Address,@UserType,@Specilization);";

            SqlParameter param1 = new SqlParameter("@Id", SqlDbType.Text);
            SqlParameter param2 = new SqlParameter("@FirstName", SqlDbType.Text);
            SqlParameter param3 = new SqlParameter("@LastName", SqlDbType.Text);
            SqlParameter param4 = new SqlParameter("@PhoneNumber", SqlDbType.Text);
            SqlParameter param5 = new SqlParameter("@EmailId", SqlDbType.Text);
            SqlParameter param6 = new SqlParameter("@Address", SqlDbType.Text);
            SqlParameter param7 = new SqlParameter("@UserType", SqlDbType.Text);
            SqlParameter param8 = new SqlParameter("@Specilization", SqlDbType.Text);

            //Supplying Values

            param1.Value = patient.id;
            param2.Value = patient.firstName;
            param3.Value = patient.lastName;
            param4.Value = patient.phoneNumber;
            param5.Value = patient.email;
            param6.Value = patient.address;
            param7.Value = "P";
            param8.Value = "null"; 

            try
            {
                return drConsultData.ExecuteNonQuery(sqlQuery, CommandType.Text, param1, param2, param3, param4, param5, param6, param7,param8);
            }
            catch (Exception ex)
            {
                dbError = ex.Message;
                return -1;
            }


        }

        //Method to make a new appointment
        public int MakeAppointment(Appointment appointmentDetails, Patients patientDetails)
        {

            SqlParameter param1 = new SqlParameter("@SlotId", SqlDbType.Int);
            SqlParameter param2 = new SqlParameter("@PatientId", SqlDbType.Text);
            SqlParameter param3 = new SqlParameter("@DoctorId", SqlDbType.Text);
            SqlParameter param4 = new SqlParameter("@AppointmentType", SqlDbType.Text);
            SqlParameter param5 = new SqlParameter("@AppointmentDay", SqlDbType.Text);
            SqlParameter param6 = new SqlParameter("@AppointmentTime", SqlDbType.Text);
            SqlParameter param7 = new SqlParameter("@IsCancelledByDoctor", SqlDbType.Int);
            SqlParameter param8 = new SqlParameter("@IsCancelledByPatient", SqlDbType.Int);
            SqlParameter param9 = new SqlParameter("@IsAppointmentClosed", SqlDbType.Int);
            SqlParameter param10 = new SqlParameter("@IssueDescription", SqlDbType.Text);
            SqlParameter param11 = new SqlParameter("@EmergencyIssueDescription", SqlDbType.Text);
            SqlParameter param12 = new SqlParameter("@TotalBill", SqlDbType.Text);
            SqlParameter param13 = new SqlParameter("@AppointmentDate", SqlDbType.Date);
            SqlParameter param14 = new SqlParameter("@Id", SqlDbType.Text);

            param2.Value = patientDetails.id;
            param3.Value = appointmentDetails.GetDoctorId();
            param4.Value = appointmentDetails.GetAppointmentType();
            param5.Value = appointmentDetails.GetAppointmentDay();
            param7.Value = 0;
            param8.Value = 0;
            param9.Value = 0;
            param10.Value = appointmentDetails.appointmentDescription;
            param12.Value = "0";
            param13.Value = appointmentDetails.GetAppointmentDate();
            param14.Value = appointmentDetails.appointmentId;
            string sqlQuery = "";
            sqlQuery = "Insert into [dbo].[Appointments] values (@Id,@SlotId,@PatientId,@DoctorId,@AppointmentType,@AppointmentDay,@AppointmentTime,@IsCancelledByDoctor,@IsCancelledByPatient,@IsAppointmentClosed,@IssueDescription,@EmergencyIssueDescription,@TotalBill,@AppointmentDate);";
            try
            {
                if(appointmentDetails.GetAppointmentType() == "REG")
                {
                    param11.Value = "null";
                    param1.Value = Int32.Parse(appointmentDetails.slotId);
                    param6.Value = appointmentDetails.GetAppointmentTime();
                }
                else
                {     
                    param11.Value = appointmentDetails.emergencyDescription;
                    param1.Value = -1;
                    param6.Value = "null";
                }
                return drConsultData.ExecuteNonQuery(sqlQuery, CommandType.Text, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13,param14);

            }
            catch (Exception ex)
            {
                dbError = ex.Message;
                return -1;
            }

        }

        public int UpdateSlots(int slotId)
        {
            SqlParameter param1 = new SqlParameter("@Id",SqlDbType.Int);
            param1.Value = slotId;
            String updateQuery = "update Slots set IsBooked = 1 where Id = @Id";
            param1.Value = slotId;
            try
            {
                return drConsultData.ExecuteNonQuery(updateQuery, CommandType.Text, param1);
            }
            catch (Exception ex)
            {
                dbError= ex.Message;
                return -1;
            }   

        }

        public int ValidatePatient(string appId, string fname)
        {
            string sqlQuery = $"select u.FirstName as FirstName from Appointments a join UserDetails u on a.PatientId = u.Id and a.Id = '{appId}'";

           DataSet ds = drConsultData.ExecuteQuery(sqlQuery);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (fname.Equals(ds.Tables[0].Rows[0][0].ToString()))
                {
                    return 1;
                }
            }
            
            return 0;
        }

        public DataSet getAppointmentDetails(String appId)
        {
            String sqlQuery = $"select a.Id,a.AppointmentDate,a.AppointmentTime,a.IssueDescription,p.firstName,p.LastName,d.FirstName,d.LastName,c.ClinicAddress,a.AppointmentType,a.TotalBill,a.SlotId,p.Id,d.Id from Appointments a join UserDetails p on p.Id = a.PatientId join UserDetails d on d.Id = a.DoctorId join Clinic c on c.doctorId = a.doctorId where a.Id = '{appId}' and a.IsCancelledByDoctor = 0 and IsCancelledByPatient =0;";

            DataSet ds = drConsultData.ExecuteQuery(sqlQuery);
            return ds;
        }

        public int cancelAppointment(string appId, string slotId,string userType)
        {

            string appQuery = "Update Appointments set IsCancelledByPatient = 1 where Id = @appId";
            SqlParameter param1 = new SqlParameter("@appId", SqlDbType.VarChar);
            param1.Value = appId;

            int appRes = drConsultData.ExecuteNonQuery(appQuery, CommandType.Text, param1);
            int slotRes;
            if (userType == "REG")
            {
                string slotQuery = "Update Slots set IsBooked = 0 where Id = @slotId";
                SqlParameter param2 = new SqlParameter("@slotId", SqlDbType.Int);
                param2.Value = Int32.Parse(slotId);

                slotRes = drConsultData.ExecuteNonQuery(slotQuery, CommandType.Text, param2);
            }
            else
            {
                slotRes = 1;
            }

            if(appRes > 0 && slotRes > 0)
            {
                return 1;
            }
            return -1;
        }

        public int validateDoctor(string doctorID, string fname)
        {
            string validDoctor = $"select FirstName from Userdetails where Id = '{doctorID}'";

            DataSet ds = drConsultData.ExecuteQuery(validDoctor);
            if (ds.Tables[0].Rows[0][0].ToString() == fname)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public DataSet getAllPatients(string doctorId)
        {
            string getAllPatients = $"select * from Appointments a join UserDetails p on a.PatientId = p.Id join UserDetails d on a.DoctorId =d.Id where a.DoctorId = '{doctorId}'";
            DataSet ds = drConsultData.ExecuteQuery(getAllPatients);
            return ds;
        }

        public int acceptEmergencyAppointment(string appId)
        {
            string sqlQuery = $"Update Appointments set AppointmentTime = '11:00 AM - 12:00 PM' where Id = @appId";
            SqlParameter param1 = new SqlParameter("@appID", SqlDbType.VarChar);
            param1.Value = appId;
            return drConsultData.ExecuteNonQuery(sqlQuery,CommandType.Text,param1);
        }

        public int addPrescription(string doctorId, string patientId,string drugname, string drugIns)
        {
            string insQuery = "insert into Prescription (DoctorId,PatientId,DrugName,DrugInstructions,PrescriptionDate) values (@DoctorId,@PatientId,@DrugName,@DrugInstructions,@PrescriptionDate);";
            SqlParameter param1 = new SqlParameter("@DrugName",SqlDbType.Text);
            SqlParameter param2 = new SqlParameter("@DrugInstructions",SqlDbType.Text);
            SqlParameter param3 = new SqlParameter("@PrescriptionDate",SqlDbType.Text);
            SqlParameter param4 = new SqlParameter("@DoctorId",SqlDbType.Text);
            SqlParameter param5 = new SqlParameter("@PatientId",SqlDbType.Text);

            param1.Value = drugname;
            param2.Value = drugIns;
            param3.Value = DateTime.Now.ToString("MM/dd/yyyy");
            param4.Value = doctorId;
            param5.Value = patientId;

           return drConsultData.ExecuteNonQuery(insQuery,CommandType.Text,param1,param2,param3,param4,param5);
        }

        public DataSet getPrescription(string pId, string dId)
        {
            string queryGetPres = $"select PrescriptionDate,DrugName,DrugInstructions from Prescription where DoctorId = '{dId}' and PatientId = '{pId}';";

            return drConsultData.ExecuteQuery(queryGetPres);
        }

        public int AddBill(int totalBill,string appId)
        {
            String insTotalBill = totalBill.ToString();

            string query = "update Appointments set TotalBill = @Bill where Id = @appId";

            SqlParameter param1 = new SqlParameter("@Bill",SqlDbType.VarChar);
            SqlParameter param2 = new SqlParameter("@appId", SqlDbType.VarChar);

            param1.Value = insTotalBill;
            param2.Value = appId;

            return drConsultData.ExecuteNonQuery(query, CommandType.Text, param1, param2);

        }

    }//class
}//namespace
