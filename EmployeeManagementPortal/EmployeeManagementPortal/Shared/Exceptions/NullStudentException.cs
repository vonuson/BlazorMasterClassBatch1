using Xeptions;

namespace EmployeeManagementPortal.Shared.Exceptions
{
    public class NullStudentException : Xeption
    {
        public NullStudentException()
            : base(message: "Null student error occurred.") { }
    }
}
