using System;
using CollageManagement.DAL;
using CollageManagement.Models;

namespace CollageManagement.BLL
{
    public class StudentBll
    {
        StudentDal _studentDal=new StudentDal();
        public bool Add(Student student)
        {
            var isRollNoExist = _studentDal.GetRollNo(student);
            if (isRollNoExist)
            {
                throw new Exception("Sorry!! This Roll No Already Exist !!");
            }
            var isAdded = _studentDal.Add(student);
            return isAdded;
        }

        public bool GetRollNo(Student student)
        {
            var isFind = _studentDal.GetRollNo(student);
            return isFind;
        }
    }
}