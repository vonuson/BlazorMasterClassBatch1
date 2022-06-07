using Xeptions;

namespace EmployeeManagementPortal.Shared.Exceptions
{
    public class InvalidStudentException : Xeption
    {
        public InvalidStudentException()
            : base(message: "Invalid student error occurred, please fix the errors and try again.")
        { }

        public InvalidStudentException(Exception innerException)
            : base(message: "Invalid student error occurred, please fix the errors and try again.",
                  innerException,
                  innerException.Data)
        { }
    }
}
