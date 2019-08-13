using System.Runtime.CompilerServices;

namespace MirHelper
{
	public class MirQueueParameter
	{
		public string input_name
		{
			get;
			set;
		}

		public string value
		{
			[CompilerGenerated]
			get
			{
				return value;
			}
			[CompilerGenerated]
			set
			{
				this.value = value;
			}
		}
	}
}
