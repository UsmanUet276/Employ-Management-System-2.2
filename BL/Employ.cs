using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BL
{
    internal class Employ
    {
        public Employ(string emp_nameA)
        {
            this.emp_nameA = emp_nameA;
        }
        public Employ(string emp_nameA,float emp_payA,float emp_rewardA,float emp_attendanceA,float emp_absenceA,float emp_deductA,int emp_rankA,int emp_comp_taskA,bool payA, int task1_timeA,int task2_timeA,int task3_timeA,int task4_timeA)
        {
            this.emp_nameA = emp_nameA;
            this.emp_payA = emp_payA;
            this.emp_rewardA = emp_rewardA;
            this.emp_attendanceA = emp_attendanceA;
            this.emp_absenceA = emp_absenceA;
            this.emp_deductA = emp_deductA;
            this.emp_rankA = emp_rankA;
            this.emp_comp_taskA = emp_comp_taskA;
            this.payA = payA;
        }
        public string emp_nameA;
        public float emp_payA;
        public float emp_rewardA;
        public float emp_attendanceA;
        public float emp_absenceA;
        public float emp_deductA;
        public int emp_rankA;
        public int emp_comp_taskA;
        public bool payA;
        public string task_1A;
        public string task_2A;
        public string task_3A;
        public string task_4A;
        public int task1_timeA;
        public int task2_timeA;
        public int task3_timeA;
        public int task4_timeA;
    }
}
