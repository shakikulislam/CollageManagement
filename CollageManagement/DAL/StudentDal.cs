using System.Configuration;
using System.Data.SqlClient;
using CollageManagement.Models;

namespace CollageManagement.DAL
{
    public class StudentDal
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        private static SqlConnection _sqlConnection=new SqlConnection(_connectionString);
        private static SqlCommand _sqlCommand=new SqlCommand("",_sqlConnection);
        private static SqlDataReader _sqlDataReader;

        public bool Add(Student student)
        {

            var _querry = "INSERT INTO Students WHERE(Name,Address,ContactNo,RollNo,RegNo,DepartmentId)VALUES('" +
                             student.Name + "','" + student.Address + "','" + student.ContactNo + "'" +
                             ",'" + student.RollNo + "','" + student.RegNo + "','" + student.DepartmentId + "')";
            _sqlConnection.Open();
            _sqlCommand.CommandText = _querry;
            _sqlConnection.Close();
            var isExecute = _sqlCommand.ExecuteNonQuery();
            return isExecute > 0 ? true : false;
        }

        public bool GetRollNo(Student student)
        {
            var _querry = "SELECT *FROM Students WHERE RollNo='" + student.RollNo + "'";
            _sqlCommand.CommandText = _querry;
            _sqlDataReader = _sqlCommand.ExecuteReader();
            return _sqlDataReader.Read() ? true : false;
        }
    }
}