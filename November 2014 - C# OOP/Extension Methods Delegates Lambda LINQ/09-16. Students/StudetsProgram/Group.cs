
namespace StudetsProgram
{
    public class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group(int group, string department)
        {
            this.GroupNumber = group;
            this.DepartmentName = department;
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set
            {
                this.groupNumber = value;
            }
        }
        public string DepartmentName
        {
            get { return this.departmentName; }
            set
            {
                this.departmentName = value;
            }
        }
    }
}