using System.ComponentModel;

namespace EmployeeManagementPortal.Shared.Enums
{
	public enum Relationship
	{
		[Description("Adult Child")]
		AdultChild,

		[Description("Child")]
		Child,

		[Description("Domestic Partner Adult")]
		DomesticPartnerAdult,

		[Description("Domestic Partner Child")]
		DomesticPartnerChild,

		[Description("Employee")]
		Employee,

		[Description("Estate")]
		Estate,

		[Description("ExDomestic Partner")]
		ExDomesticPartner,

		[Description("ExSpouse")]
		ExSpouse,

		[Description("Foster Child")]
		FosterChild,

		[Description("Friend")]
		Friend,

		[Description("Grand Parent")]
		GrandParent,

		[Description("Grandchild")]
		Grandchild,

		[Description("Great Grand Parent")]
		GreatGrandParent,

		[Description("Great Grandchild")]
		GreatGrandchild,

		[Description("In-Law")]
		InLaw,

		[Description("Neighbor")]
		Neighbor,

		[Description("Other")]
		Other,

		[Description("Other Child")]
		OtherChild,

		[Description("Other Relative")]
		OtherRelative,

		[Description("Parent")]
		Parent,

		[Description("Parent In-Law")]
		ParentInLaw,

		[Description("Partner")]
		Partner,

		[Description("Recognized Child")]
		RecognizedChild,

		[Description("Roommate")]
		Roommate,

		[Description("Self")]
		Self,

		[Description("Sibling")]
		Sibling,

		[Description("Spouse")]
		Spouse,

		[Description("Step Parent")]
		StepParent,

		[Description("Step Child")]
		StepChild,

		[Description("US Same-Sex Spouse")]
		UsSameSexSpouse,

		[Description("Ward")]
		Ward
	}
}
