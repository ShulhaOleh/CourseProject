using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Hospital
{
    public class DatabaseHelper
    {
        private string connectionString = 
            "Server=localhost;" +
            "Database=clinic;" +
            "User ID=root;" +
            "Password=Oleh_Shulha;";

        public DataTable GetPatientsData()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT PatientID, LastName, FirstName, DateOfBirth, Gender, PhoneNumber FROM Patients;";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Помилка бази даних: " + ex.Message);
            }
            return dt;
        }


        public DataTable SearchPatients(string keyword)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    SELECT 
                        PatientID AS 'ID пацієнта', 
                        LastName AS 'Прізвище', 
                        FirstName AS 'Ім''я', 
                        DateOfBirth AS 'Дата народження', 
                        Gender AS 'Стать', 
                        PhoneNumber AS 'Номер телефону'
                    FROM Patients";

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query += @" WHERE LastName LIKE @keyword 
                                 OR FirstName LIKE @keyword 
                                 OR PhoneNumber LIKE @keyword";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(keyword))
                        {
                            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Помилка при пошуку: " + ex.Message);
            }
            return dt;
        }

        public Doctor GetDoctorFromDatabase(int doctorID)
        {
            Doctor doctor = null;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    SELECT 
                        DoctorID, 
                        FirstName, 
                        LastName, 
                        DateOfBirth, 
                        Specialty
                    FROM Doctors 
                    WHERE DoctorID = @DoctorID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@DoctorID", doctorID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                doctor = new Doctor
                                {
                                    ID = reader.GetInt32("DoctorID"),
                                    FirstName = reader.GetString("FirstName"),
                                    LastName = reader.GetString("LastName"),
                                    DateOfBirth = reader.GetDateTime("DateOfBirth"),
                                    Specialty = reader.GetString("Specialty")
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Помилка при отриманні даних лікаря: " + ex.Message);
            }

            return doctor;
        }




    }
}
