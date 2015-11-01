using System;
using System.Threading.Tasks;

namespace GoalDemo
{
	public interface IDataHelper
	{
		Task<bool> Authenticate();
	}
}

