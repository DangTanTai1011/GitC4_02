using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap20_12.Models
{
    internal class Lecture:User
    {
		private int msGV;

		public int MSGV
		{
			get { return msGV; }
			set { msGV = value; }
		}

	}
}
