using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    public abstract class Employee
    {
        // next element in chain or responsibility
        protected Employee supervisor;
        public void setNextSupervisor(Employee supervisor)
        {
            this.supervisor = supervisor;
        }
        public abstract void applyLeave(string employeeName, int numberofDaysLeave);
    }
    public class TeamLeader : Employee
    {
        // TeamLeader can only approve upto 10 days of leave
        private int MAX_LEAVES_CAN_APPROVE = 10;
        public override void applyLeave(string employeeName, int numberofDaysLeave)
        {
            // check if TeamLeader can process this request
            if (numberofDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                ApproveLeave(employeeName, numberofDaysLeave);
            }
            // if TeamLeader can't process the LeaveRequest then pass on to the supervisor(ProjectLeader)
            // so that he can process
            else
            {
                supervisor.applyLeave(employeeName, numberofDaysLeave);
            }
        }
        private void ApproveLeave(string employeeName, int numberofDaysLeave)
        {
            Console.WriteLine("TeamLeader approved " + numberofDaysLeave + " days " + "Leave for the employee : "
                            + employeeName);
        }
    }
    class ProjectLeader : Employee
    {
        // ProjectLeader can only approve upto 20 days of leave
        private int MAX_LEAVES_CAN_APPROVE = 20;
        public override void applyLeave(string employeeName, int numberofDaysLeave)
        {
            // check if ProjectLeader can process this request
            if (numberofDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                ApproveLeave(employeeName, numberofDaysLeave);
            }
            // if ProjectLeader can't process the LeaveRequest then pass on to the supervisor(HR) 
            // so that he can process
            else
            {
                supervisor.applyLeave(employeeName, numberofDaysLeave);
            }
        }
        private void ApproveLeave(string employeeName, int numberofDaysLeave)
        {
            Console.WriteLine("ProjectLeader approved " + numberofDaysLeave + " days " + "Leave for the employee : "
                            + employeeName);
        }
    }
    public class HR : Employee
    {
        // HR can only approve upto 30 days of leave
        private int MAX_LEAVES_CAN_APPROVE = 30;
        public override void applyLeave(string employeeName, int numberofDaysLeave)
        {
            if (numberofDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                ApproveLeave(employeeName, numberofDaysLeave);
            }
            else
            {
                Console.WriteLine("Leave application suspended, Please contact HR");
            }
        }
        private void ApproveLeave(string employeeName, int numberofDaysLeave)
        {
            Console.WriteLine("HR approved " + numberofDaysLeave + " days " + "Leave for the employee : "
                            + employeeName);
        }
    }
    class ChainOfResponRealTimeExample
    {
        static void Main(string[] args)
        {
            TeamLeader teamLeader = new TeamLeader();
            ProjectLeader projectLeader = new ProjectLeader();
            HR hr = new HR();
            teamLeader.setNextSupervisor(projectLeader);
            projectLeader.setNextSupervisor(hr);
            teamLeader.applyLeave("Anurag", 9);
            Console.WriteLine();
            teamLeader.applyLeave("Pranaya", 18);
            Console.WriteLine();
            teamLeader.applyLeave("Priyanka", 30);
            Console.WriteLine();
            teamLeader.applyLeave("Ramesh", 50);
            Console.Read();
        }
    }
}
