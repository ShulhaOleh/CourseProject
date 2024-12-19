using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hospital
{
    public class DatabaseHelper
    {
        private string connectionString = 
            "Server=localhost;" +
            "Database=clinic;" +
            "User ID=root;" +
            "Password=Oleh_Shulha;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public MySqlParameter CreateParameter(string parameterName, object value)
        {
            return new MySqlParameter(parameterName, value ?? DBNull.Value);
        }

        public DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Помилка виконання SQL-запиту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }
        public int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"SQL-помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }



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

        public DataTable GetMedicalRecordsByPatientID(int patientID)
        {
            string query = @"
            SELECT 
                PatientID, 
                HealthStatus AS 'Стан здоров''я', 
                Notes AS 'Примітки' 
            FROM MedicalRecords 
            WHERE PatientID = @PatientID";

            var parameters = new[] { CreateParameter("@PatientID", patientID) };
            return ExecuteQuery(query, parameters);
        }



        public DataTable GetMedicalRecordsByAmbulatoryCardID(int ambulatoryCardID)
        {
            string query = @"
            SELECT 
                AmbulatoryCardID AS 'ID картки',
                PatientID AS 'ID пацієнта', 
                EntryDate AS 'Дата запису'
            FROM AmbulatoryCards
            WHERE AmbulatoryCardID = @AmbulatoryCardID";

            var parameters = new[] { CreateParameter("@AmbulatoryCardID", ambulatoryCardID) };
            return ExecuteQuery(query, parameters);
        }



        public DataTable ExecuteSelectQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                command.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка виконання SQL-запиту: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        public DataTable GetAllAmbulatoryCards()
        {
            string query = @"
        SELECT 
            AmbulatoryCardID AS 'ID картки', 
            PatientID AS 'ID пацієнта', 
            RecordID AS 'ID запису', 
            EntryDate AS 'Дата запису' 
        FROM AmbulatoryCards";
            return ExecuteQuery(query);
        }

        public DataTable SearchAmbulatoryCards(string keyword)
        {
            string query = @"
            SELECT 
                AmbulatoryCardID AS 'ID картки', 
                PatientID AS 'ID пацієнта', 
                RecordID AS 'ID запису', 
                EntryDate AS 'Дата запису' 
            FROM AmbulatoryCards 
            WHERE PatientID LIKE @keyword";
            var parameters = new[] { CreateParameter("@keyword", "%" + keyword + "%") };
            return ExecuteQuery(query, parameters);
        }

        public void AddMedicalRecord(int patientID, string healthStatus, string notes, DateTime recordDate)
        {
            try
            {
                string queryInsertAmbulatoryCard =
                    "INSERT INTO AmbulatoryCards (PatientID, EntryDate) VALUES (@PatientID, @EntryDate);" +
                    "SELECT LAST_INSERT_ID();";

                string queryInsertMedicalRecord =
                    "INSERT INTO MedicalRecords (AmbulatoryCardID, HealthStatus, Notes) " +
                    "VALUES (@AmbulatoryCardID, @HealthStatus, @Notes);";

                var ambulatoryCardID = ExecuteScalar<int>(
                    queryInsertAmbulatoryCard,
                    new[]
                    {
                        CreateParameter("@PatientID", patientID),
                        CreateParameter("@EntryDate", recordDate)
                    });

                ExecuteNonQuery(
                    queryInsertMedicalRecord,
                    new[]
                    {
                        CreateParameter("@AmbulatoryCardID", ambulatoryCardID),
                        CreateParameter("@HealthStatus", healthStatus),
                        CreateParameter("@Notes", notes)
                    });
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка під час додавання запису: {ex.Message}");
            }
        }


        public T ExecuteScalar<T>(string query, params MySqlParameter[] parameters)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return (T)Convert.ChangeType(result, typeof(T));
                    }
                    else
                    {
                        throw new InvalidOperationException("Запит не повернув жодного значення.");
                    }
                }
            }
        }




        public void UpdateMedicalRecord(int recordID, string healthStatus, string notes)
        {
            string query = "UPDATE MedicalRecords SET HealthStatus = @HealthStatus, Notes = @Notes WHERE RecordID = @RecordID";
            var parameters = new[]
            {
                CreateParameter("@HealthStatus", healthStatus),
                CreateParameter("@Notes", notes),
                CreateParameter("@RecordID", recordID)
            };

            ExecuteQuery(query, parameters);
        }

        public void DeleteMedicalRecord(int recordID)
        {
            try
            {
                string queryMedicalRecord =
                    "DELETE FROM MedicalRecords WHERE RecordID = @RecordID";

                string queryAmbulatoryCard =
                    "DELETE FROM AmbulatoryCards WHERE AmbulatoryCardID = " +
                    "(SELECT AmbulatoryCardID FROM MedicalRecords WHERE RecordID = @RecordID)";

                ExecuteNonQuery(queryMedicalRecord, new[] { CreateParameter("@RecordID", recordID) });

                ExecuteNonQuery(queryAmbulatoryCard, new[] { CreateParameter("@RecordID", recordID) });
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка під час видалення запису: {ex.Message}");
            }
        }







        public DataTable GetMedicalRecords(string search)
        {
            string query = "SELECT * FROM MedicalRecords";
            if (!string.IsNullOrEmpty(search))
            {
                query += " WHERE HealthStatus LIKE @search OR Notes LIKE @search";
            }
            
            var parameters = new MySqlParameter[]
            {
        new MySqlParameter("@search", $"%{search}%")
            };

            return ExecuteQuery(query, parameters);
        }

        public DataTable GetAllMedicalRecords()
        {
            string query = "SELECT * FROM MedicalRecords";
            return ExecuteQuery(query);
        }

        public DataTable SearchMedicalCards(string keyword)
        {
            string query = @"
            SELECT 
                p.PatientID AS 'ID пацієнта',
                CONCAT(p.LastName, ' ', p.FirstName) AS 'ФІ пацієнта',
                a.EntryDate AS 'Дата запису',
                m.HealthStatus AS 'Статус здоров\'я',
                m.Notes AS 'Примітка'
            FROM MedicalRecords m
            INNER JOIN AmbulatoryCards a ON m.AmbulatoryCardID = a.AmbulatoryCardID
            INNER JOIN Patients p ON a.PatientID = p.PatientID
            WHERE p.LastName LIKE @search OR p.FirstName LIKE @search 
            OR m.HealthStatus LIKE @search OR m.Notes LIKE @search";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@search", $"%{keyword}%")
            };
            return ExecuteQuery(query, parameters);
        }

        public DataTable GetAllMedicalCards()
        {
            string query = @"
            SELECT 
                p.PatientID AS 'ID пацієнта',
                CONCAT(p.LastName, ' ', p.FirstName) AS 'ФІ пацієнта',
                a.EntryDate AS 'Дата запису',
                m.HealthStatus AS 'Статус здоров\'я',
                m.Notes AS 'Примітка'
            FROM MedicalRecords m
            INNER JOIN AmbulatoryCards a ON m.AmbulatoryCardID = a.AmbulatoryCardID
            INNER JOIN Patients p ON a.PatientID = p.PatientID";
            return ExecuteQuery(query);
        }

        public List<dynamic> GetPatients()
        {
            string query = "SELECT PatientID, CONCAT(LastName, ' ', FirstName) AS FullName FROM Patients";
            DataTable table = ExecuteQuery(query);

            return table.AsEnumerable()
                .Select(row => new
                {
                    PatientID = row.Field<int>("PatientID"),
                    FullName = row.Field<string>("FullName")
                }).ToList<dynamic>();
        }



    }
}
