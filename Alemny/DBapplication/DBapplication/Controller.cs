using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int InsertStudent(string fname, string lname, char gender, int age, string email, string phonNo, string pass, string region, string city)
        {
            string query = "INSERT INTO Student (Fname, Lname, Gender, Age, Email, PhoneNO, Passwrd, Region, City) " + "Values ('" + fname + "','" + lname + "','" + gender + "'," + age + ",'" + email + "','" + phonNo + "','" + pass + "','" + region + "','" + city + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable checkauth(string email, string password)
        {
            string query = "SELECT Email FROM Student where Email='" + email + "' AND Passwrd ='" + password + "' ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable checkauthAdmin(string email, string password)
        {
            string query = "SELECT Email FROM Admin where Email='" + email + "' AND Passwrd ='" + password + "' ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable checkauthInt(string email, string password)
        {
            string query = "SELECT Email FROM Instructor where Email='" + email + "' AND Passwrd ='" + password + "' ;";
            return dbMan.ExecuteReader(query);
        }
        public int InsertInstructor(string fname, string lname, char gender, int age, string email, string phonNo, string pass, string region, string city)
        {
            string query = "INSERT INTO Instructor (Fname, Lname, Gender, Age, Email, PhoneNO, Passwrd, Region, City) " + "Values ('" + fname + "','" + lname + "','" + gender + "'," + age + ",'" + email + "','" + phonNo + "','" + pass + "','" + region + "','" + city + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertSlot(int id, string date, string region, string time)
        {
            string query = "INSERT INTO Slots (Instructor_ID, Tm, Dt, Region) VALUES (" + id + ",'" + time + "','" + date + "','" + region + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetPrevSessionsInst()
        {
            string query = "Select * FROM Session WHERE Session_Status = 'Reserved';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetStudentTickets()
        {
            string query = "Select * FROM Student_Ticket;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetTicketDetails(int id)
        {
            string query = "SELECT * FROM Student_Ticket Where STicket_ID = " + id + ";";
            return dbMan.ExecuteReader(query);

        }
        public DataTable GetSlotsDate(int id)
        {
            string query = "Select Dt FROM Slots WHERE Instructor_ID = " + id + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSlotsTime(string date)
        {
            string query = "Select Tm FROM Slots WHERE Dt = " + date + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable checkauthinst(string email, string password)
        {
            string query = "SELECT Email FROM Instructor where Email='" + email + "' AND Passwrd ='"+ password+"';";
            return dbMan.ExecuteReader(query);
        }
        public object GetWallet(string Mail)
        {
            string query= "SELECT Wallet FROM Student WHERE Email = '" + Mail + "';";
            return dbMan.ExecuteScalar(query);
        }

        public object GetInstId(string Mail)
        {
            string query = "SELECT ID FROM Instructor WHERE Email = '" + Mail + "';";
            return dbMan.ExecuteScalar(query);
        }
        public object GetLevl(string Mail)
        {
            string query = "SELECT Lvl FROM Student WHERE Email = '" + Mail + "';";
            return dbMan.ExecuteScalar(query);
        }
        public object Getrate(string Mail)
        {
            string query = "SELECT Rating FROM Student WHERE Email = '" + Mail + "';";
            return dbMan.ExecuteScalar(query);
        }

        public int InsertGuardian(string fname, string lname, int Std_ID, string relationship, string email, string phonNo)
        {
            string query = "INSERT INTO Guardian (Fname, Lname,Student_ID, Relationship, Email, PhonoNo ) VALUES ('" + fname + "','" + lname + "','" + Std_ID + "','" + relationship + "','" + email + "','" + phonNo + "');";
            return dbMan.ExecuteNonQuery(query);
        }

    }
}
