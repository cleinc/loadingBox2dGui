using CoPick;
using CoPick.Logging;
using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace loadingBox2dGui.models.ProductionRecord
{
    public class ProductionRecordRepositoryMariaDb : IProductionRecordRepository
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        private const string _databaseName = "resultData";
        private string _connectionString;
        public ProductionRecordRepositoryMariaDb(string connectionString) => _connectionString = connectionString;
        public static string GetConnectionString()
        {
            var encryptedString = ConfigurationManager.ConnectionStrings["MariaDB"]?.ConnectionString;
             var connectionString = ConnectionStringHelper.GetConnectionString(DatabaseType.Maria, "127.0.0.1", "root", _databaseName, encryptedString);
            if (connectionString != null)
            {
                return connectionString;
            }
            else
            {
                Console.WriteLine($"Failed Retrieving ConnectionString for Production Record");
                return null;
            }
        }

        public void AddProductionRecord(ProductionRecord record)
        {
            try
            {
                int changedRowNum = -1;
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sqlQuery = "INSERT INTO ProductionRecord " +
                    "(productionDateTime, bodyNumber, carType, carName, sequenceNumber, screenShotImagePath, inspectionResult, Tx, Ty, Rz) " +
                    "VALUES (@ProductionDateTime, @BodyNumber, @CarType, @CarName, @SequenceNumber, @ScreenShotImagePath, @InspectionResult, @Tx, @Ty, @Rz)";
                    changedRowNum = conn.Execute(sqlQuery, record);
                }
                Logger.Debug($"Save Production Record To MariaDB Succeed: {changedRowNum} Rows Changed");
            }
            catch (Exception ex)
            {
                Logger.Warning(ex.Message);
                Logger.Warning("Save Production Record To MariaDB Failed");
            }
        }

        public int CreateDatabaseIfNotExists()
        {
            try
            {
                var temporaryString = "Server=127.0.0.1;Uid=root;pwd=clebrain511;";
                using (MySqlConnection conn = new MySqlConnection(temporaryString))
                {
                    string query = $"CREATE DATABASE IF NOT EXISTS {_databaseName}";
                    conn.Open();
                    int changedRowNum = conn.Execute(query);
                    LogHelper.Logger.Debug("Create Database Succeeded");
                    return changedRowNum;
                }
            }
            catch (InvalidOperationException invalidOpsException)
            {
                Logger.Error($"Database creation failed. The connection does not exist. Error: {invalidOpsException}");
                return -2;
            }
            catch (Exception ex)
            {
                Logger.Error($"Database creation failed. The connection is not open. Error: {ex}");
                return -2;
            }
        }

        public int CreateTableProductionRecordIfNotExistsForProductionRecord()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    string query = "CREATE TABLE IF NOT EXISTS ProductionRecord(" +
                                   "id INT NOT NULL AUTO_INCREMENT," +
                                   "productionDateTime DATETIME NOT NULL," +
                                   "bodyNumber VARCHAR(12) NOT NULL," +
                                   "carType INT NOT NULL," +
                                   "carName VARCHAR(50) NOT NULL," +
                                   "sequenceNumber VARCHAR(10) NOT NULL," +
                                   "screenShotImagePath TEXT," +
                                   "inspectionResult INT NOT NULL," +
                                   "Tx FLOAT NOT NULL," +
                                   "Ty FLOAT NOT NULL," +
                                   "Rz FLOAT NOT NULL," +
                                   "PRIMARY KEY (id));";
            
                    conn.Open();
                    int changedRowNum = conn.Execute(query);
                    LogHelper.Logger.Debug("Create Table Succeeded");
                    return changedRowNum;
                }
            }
            catch (InvalidOperationException invalidOpsException)
            {
                Logger.Error($"Database creation failed. The connection does not exist. Error: {invalidOpsException}");
                return -2;
            }
            catch (Exception ex)
            {
                Logger.Error($"Database creation failed. The connection is not open. Error: {ex}");
                return -2;
            }
        }

        public List<string> GetCarNames()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT DISTINCT CarName FROM ProductionRecord";
                    return conn.Query<string>(sqlQuery).AsList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string GetCarType(int carType)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT carType FROM ProductionRecord WHERE carType=@CarType";
                    return conn.Query<string>(sqlQuery, new { CarType = carType }).First();
                }
            }
            catch
            {
                return null;
            }
        }

        public List<ProductionRecord> GetProductionRecordByBodyNumber(string bodyNumber)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM ProductionRecord" +
                                      " WHERE bodyNumber = @BodyNumber";
                    return conn.Query<ProductionRecord>(sqlQuery, new { BodyNumber = bodyNumber }).AsList();
                }
            }
            catch
            {
                return null;
            }
        }

        public List<ProductionRecord> GetProductionRecordByCarType(int carType)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM ProductionRecord" +
                                      " WHERE carType = @CarType";
                    return conn.Query<ProductionRecord>(sqlQuery, new { CarType = carType }).AsList();
                }
            }
            catch
            {
                return null;
            }
        }

        public List<ProductionRecord> GetProductionRecordByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM ProductionRecord " +
                                      "WHERE productionDateTime >= @StartDate AND productionDateTime < @EndDate";
                    return conn.Query<ProductionRecord>(sqlQuery, new { StartDate = startDate, EndDate = endDate.AddDays(1) }).AsList();
                }
            }
            catch
            {
                return null;
            }
        }

        public List<ProductionRecord> GetProductionRecordByMultipleCondition(DateTime startDate,
                                                                      DateTime endDate,
                                                                      List<InspectionResult> productionResults,
                                                                      string carName = null,
                                                                      string[] sequenceNumber = null,
                                                                      string bodyNumber = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductionRecord> GetProductionRecordBySequenceNumber(string sequenceNumber)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM ProductionRecord" +
                                      " WHERE sequenceNumber = @SequenceNumber";
                    return conn.Query<ProductionRecord>(sqlQuery, new { SequenceNumber = sequenceNumber }).AsList();
                }
            }
            catch
            {
                return null;
            }
        }

        public List<ProductionRecord> GetRecords(int desiredCount = -1)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM ProductionRecord ORDERED BY productionDateTime DESC LIMIT @DesiredCount";
                    return conn.Query<ProductionRecord>(sqlQuery, new { DesiredCount = desiredCount }).AsList();
                }
            }
            catch
            {
                return null;
            }
        }

        public List<ProductionRecord> GetRecordsByResult(DateTime? startDate, InspectionResult result)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    int inspectionResult = (int) result;
                    string sqlQuery = "SELECT * FROM ProductionRecord " +
                                      $"WHERE inspectionResult = {inspectionResult} AND productionDateTime >= @StartDate " +
                                      "ORDER BY productionDateTime DESC";

                    if (startDate == null)
                    {
                        startDate = new DateTime(1000, 1, 1); 
                    }

                    return conn.Query<ProductionRecord>(sqlQuery, new { StartDate = startDate }).AsList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}