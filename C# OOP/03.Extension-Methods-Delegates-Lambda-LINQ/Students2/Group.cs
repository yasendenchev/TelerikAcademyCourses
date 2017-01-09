using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students2
{
    public class Group
    {
        private int groupNum;
        private string deptName;


        public Group(int groupNum, string deptName)
        {
            this.groupNum = groupNum;
            this.deptName = deptName;
        }

        public int GroupNum
        {
            get
            {
                return this.groupNum;
            }

            set
            {
                this.groupNum = value;
            }
        }

        public string DeptName
        {
            get
            {
                return this.deptName;
            }

            set
            {
                this.deptName = value;
            }
        }
    }
}
