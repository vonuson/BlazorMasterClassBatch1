using EmployeeManagementPortal.Client.Bases;
using EmployeeManagementPortal.Client.Shared;
using EmployeeManagementPortal.Shared.Exceptions;
using EmployeeManagementPortal.Shared.Models;
using EmployeeManagementPortal.Shared.Validations;
using Microsoft.AspNetCore.Components;
using System.Collections;

namespace EmployeeManagementPortal.Client.Components
{
    public partial class StudentRegistrationComponent : ComponentBase
    {
        public ComponentState State { get; set; }

        public Student Student { get; set; }

        public IDictionary ValidationData { get; set; }

        public TextBoxBase FirstNameTextBox { get; set; }

        public TextBoxBase LastNameTextBox { get; set; }
        
        public DropDownBase<StudentGender> StudentGenderDropDown { get; set; }

        public DatePickerBase DateOfBirthPicker { get; set; }

        public ButtonBase RegisterStudentButton { get; set; }

        public LabelBase ErrorLabel { get; set; }

        public void RegisterStudent()
        {
            try
            {
                StudentValidation.ValidateStudent(Student);
                this.ValidationData = null;
                this.ErrorLabel.SetValue("");
            }
            catch (InvalidStudentException invalidStudentException)
            {
                this.ValidationData = invalidStudentException.Data;
                this.ErrorLabel.SetValue(invalidStudentException.Message);
            }
            finally
            {
                StateHasChanged();
            }
        }

        protected override void OnInitialized()
        {
            this.Student = new Student();
            this.State = ComponentState.Content;
        }
    }
}
