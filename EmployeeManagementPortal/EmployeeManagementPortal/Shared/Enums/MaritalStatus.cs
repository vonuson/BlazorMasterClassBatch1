using System.ComponentModel;

namespace EmployeeManagementPortal.Shared.Enums
{
	public enum MaritalStatus
	{
		[Description("Single")]
		Single,

		[Description("Anulled")]
		Annulled,

		[Description("Common-Law")]
		CommonLaw,

		[Description("Dissolved Civil Partnership")]
		DissolvedCivilPartnership,

		[Description("Divorced")]
		Divorced,

		[Description("Married")]
		Married,

		[Description("Not disclosed")]
		NotDisclosed,

		[Description("Separated")]
		Separated,

		[Description("Surviving Civil Partner")]
		SurvivingCivilPartner,

		[Description("Widowed")]
		Widowed
	}
}
