using System.ComponentModel;

namespace EnumSelectListMvcHelpers.Models
{
	public enum UserType
	{
		[Description("Visitor (Not logged in)")]
		Visitor = 1,
		[Description("Non-depositing player (Created account, no deposits)")]
		NonDepositor,
		[Description("Single depositing player")]
		DepositedOnce,
		[Description("Twice depositing player")]
		DepositedTwice,
		[Description("Regular depositing player (Has 3 or more deposits)")]
		Regular,
		[Description("Lapsed Regular (Not logged in for the past 12 weeks)")]
		LapsedRegular,
		[Description("Lapsed Non-Depositor (Not deposited, not logged in for the past 12 weeks)")]
		LapsedNonDepositor
	}
}