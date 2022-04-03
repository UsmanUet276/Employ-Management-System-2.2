using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EMS.BL;


namespace EMS
{
    internal class Program
    {
        // end of arrays
        // initializing scalar variables
        static string loginusername = " ";
        static int a = 0;
        static string st = " ";
        static string path = "user.txt";

        // end of scalar variables
        static void Main(string[] args)
        {
            List<Login> userList = new List<Login>();
            List<Employ> employList = new List<Employ>();
            storeArray(employList , userList);
            string i = " ", j = " ";
            string user = " ";
            string pass = " ";
            string role = " ";
            while (true) // STARTING FIRST WHILE LOOP
            {
                Console.Clear();
                head();          // ADDING HEADER
                i = loginMenu(userList); // SAVING VALUE OF FUNCTION IN A string
                if (i == "ADMIN")
                {
                    while (true)
                    {
                        clearscreen();
                        head();
                        j = adInterface();
                        clearscreen();
                        head();
                        if (j == "1") // STARTING MOST NESTED IF
                        {
                            string ind = " ";
                            Console.WriteLine("Main Menu > Add User");
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Enter username of User : ");
                            user = Console.ReadLine();
                            while (true)
                            {

                                Console.Write("Enter password of User : ");
                                pass = Console.ReadLine();
                                if (pass.Length >= 8)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("password must be 8 digit or long.");
                                    Console.Write("Enter any key to continue : ");
                                    Console.Read();
                                    Console.Clear();
                                }
                            }
                            Console.Write("Enter role of User : ");
                            role = Console.ReadLine();
                            addUser(user, pass,  role,  ind , employList , userList);
                        }                  // END OF MOST NESTED IF
                        else if (j == "2") // STARTING MOST NESTED ELSE IF
                        {
                            addEmployRank(employList);
                        }                  // END MOST NESTED ELSE IF
                        else if (j == "3") // STARTING MOST NESTED ELSE IF
                        {
                            releasePay(employList);
                        }                  // END MOST NESTED ELSE IF
                        else if (j == "4") // STARTING MOST NESTED ELSE IF
                        {
                            empReward(employList);
                        }                  // END MOST NESTED ELSE IF
                        else if (j == "5") // STARTING MOST NESTED ELSE IF
                        {
                            empAttendance(employList);
                        }                  // END MOST NESTED ELSE IF
                        else if (j == "6") // STARTING MOST NESTED ELSE IF
                        {
                            empDeductions(employList);
                        }                  // END MOST NESTED ELSE IF
                        else if (j == "7") // STARTING MOST NESTED ELSE IF
                        {
                            empRemove(employList , userList);
                        }
                        else if (j == "8") // STARTING MOST NESTED ELSE IF
                        {
                            Console.WriteLine("Main Menu > Employ List");
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Srno\t Name\t Rank");
                            displayEmploy(employList);
                        }                  // END MOST NESTED ELSE IF
                        else if (j == "9") // STARTING MOST NESTED ELSE IF
                        {
                            Console.WriteLine("Main Menu > Assighn Tasks / Duties");
                            Console.WriteLine("-----------------------------------------");
                            empTasks(employList);
                        }                   // END MOST NESTED ELSE IF
                        else if (j == "10") // STARTING MOST NESTED ELSE IF
                        {
                            Console.WriteLine("Main Menu > Changes by Employ.");
                            Console.WriteLine("----------------------------");
                            empChanges(userList);
                        }                   // END MOST NESTED ELSE IF
                        else if (j == "11") // STARTING MOST NESTED ELSE IF
                        {
                            Console.WriteLine("Main Menu > Employ Performance.");
                            Console.WriteLine("----------------------------");
                            empCompletedTasks(employList);
                        }                   // END MOST NESTED ELSE IF
                        else if (j == "12") // STARTING MOST NESTED ELSE IF
                        {
                            Console.WriteLine("Main Menu > Change Password of employ.");
                            Console.WriteLine("----------------------------");
                            changeEmpPass(userList);
                        }                   // END MOST NESTED ELSE IF
                        else if (j == "13") // STARTING MOST NESTED ELSE IF
                        {
                            Console.WriteLine("Main Menu > Give Promotion.");
                            Console.WriteLine("----------------------------");
                            empPromotion(employList);
                        } // END MOST NESTED ELSE IF
                        else if (j == "14")
                        {
                            break;
                        }
                        else // STARTING MOST NESTED ELSE
                        {
                            Console.Write("Enter valid value");
                        }               // END MOST NESTED ELSE
                    }                   // end of nested while
                }                       // END if
                else if (i == "EMPLOY") // START OF ELSE IF
                {
                    while (true) // START OF NESTED WHILE
                    {
                        clearscreen();
                        head();
                        j = empInterface();
                        clearscreen();
                        head();
                        if (j == "1") // STARTING MOST NESTED ELSE IF
                        {
                            Console.WriteLine("Main Menu > Change Password");
                            Console.WriteLine("----------------------------------");
                            changePass(userList);
                        }                  // END MOST NESTED IF
                        else if (j == "2") // STARTING MOST NESTED ELSE IF
                        {
                            Console.WriteLine("Main Menu > View salary");
                            Console.WriteLine("----------------------------------");
                            viewSalary(employList);
                        }                  // END MOST NESTED ELSE IF
                        else if (j == "3") // STARTING MOST NESTED Console.WriteLine(
                        {
                            Console.WriteLine("Main Menu > View Grant / Reward or Bonus.");
                            Console.WriteLine("--------------------------------------------");
                            viewReward(employList);
                        }                  // END MOST NESTED ELSE IF
                        else if (j == "4") // STARTING MOST NESTED ELSE IF
                        {
                            Console.WriteLine("Main Menu > View Attendance.");
                            Console.WriteLine("--------------------------------");
                            viewAttendance(employList);
                        }                  // END MOST NESTED ELSE IF
                        else if (j == "5") // STARTING MOST NESTED ELSE IF
                        {
                            Console.WriteLine("Main Menu > View Deductions.");
                            Console.WriteLine("--------------------------------");
                            viewDeduct(employList);
                        }                  // END MOST NESTED ELSE IF
                        else if (j == "6") // STARTING MOST NESTED ELSE IF
                        {
                            Console.WriteLine("Main menu > View assighned Tasks / Duties.");
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("No. task\t\ttime");
                            viewTask(employList);
                        }                  // END MOST NESTED ELSE IF
                        else if (j == "7") // STARTING MOST NESTED ELSE IF
                        {
                            Console.WriteLine("Main menu > Completed Tasks / Duties.");
                            Console.WriteLine("-----------------------------------------");
                            enterCompTask(employList);
                        }                  // END MOST NESTED ELSE IF
                        else if (j == "8") // STARTING MOST NESTED ELSE IF
                        {
                            Console.WriteLine("Main menu > View your Balance.");
                            Console.WriteLine("-----------------------------------------");
                            viewBalance(employList);
                        }                  // END MOST NESTED ELSE IF
                        else if (j == "9") // STARTING MOST NESTED ELSE IF
                        {
                            Console.WriteLine("Main menu > See your Status.");
                            Console.WriteLine("-----------------------------------------");
                            viewStatus(employList);
                        }                   // END MOST NESTED ELSE IF
                        else if (j == "10") // STARTING MOST NESTED ELSE IF
                        {
                            break;
                        }    // END MOST NESTED ELSE IF
                        else // STARTING MOST NESTED ELSE
                        {
                            Console.Write("Enter valid value.");
                        } // END MOST NESTED ELSE
                    }     // END OF NESTED WHILE
                }         // END OF ELSE IF
                else if (i == "EXIT")
                {
                    storeFile(employList , userList);
                    Console.WriteLine("Thank You For Using!");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter correct user name or password.");
                    Console.Write("Press any key to continue : ");
                    Console.Read();
                    Console.Clear();
                }
            }
        }
        static void head() // HEADER FILE
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("*              EMPLOY MANAGEMENT SYSTEM               *");
            Console.WriteLine("*******************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        static void clearscreen() // TO CLEAR SCREEN
        {
            Console.Write("Enter any key to continue : ");
            Console.Read();
            Console.Read();
            Console.Read();
            Console.Clear();
        }
        static string loginMenu(List<Login> userList)
        { //________Get user credentials and check whether user is present in
            char s;
            string tempName = " ";
            string e = "EXIT";
            Console.WriteLine("LOGIN MENU.");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Login.");
            Console.WriteLine("2. Exit.");
            Console.Write("Enter one option : ");
            s = (char)Console.Read();
            Console.Read();
            Console.Read();

            Console.Clear();
            if (s == '1')
            {
                head();
                Console.WriteLine("Enter user name : ");
                tempName = Console.ReadLine();
                Console.WriteLine("Enter Password : ");
                string tempRoll = Console.ReadLine();
                for (int x = 0; x < userList.Count; x++)
                {
                    if (userList[x].usernameA == tempName && userList[x].passwordA == tempRoll)
                    {
                        loginusername = tempName;
                        return userList[x].rolesA;
                    }
                }
            }
            else if (s == '2')
            {
                return e;
            }
            return "no";
        }
        static string adInterface() // ADMIN MAIN MENU
        {
            string admin_employ = " ";
            Console.WriteLine("Main Menu.");
            Console.WriteLine("--------------");
            Console.WriteLine("Select one of the following.");
            Console.WriteLine("1.  Add User.");
            Console.WriteLine("2.  Add Employ rank.");
            Console.WriteLine("3.  Release Pay.");
            Console.WriteLine("4.  Grant / Reward or Bonus.");
            Console.WriteLine("5.  Attendance.");
            Console.WriteLine("6.  Deductions.");
            Console.WriteLine("7.  Remove Employ.");
            Console.WriteLine("8.  Employ List.");
            Console.WriteLine("9.  Assighn Tasks / Duties.");
            Console.WriteLine("10. Changes by Employ.");
            Console.WriteLine("11. Employ Performance.");
            Console.WriteLine("12. Change Password of employ.");
            Console.WriteLine("13. Give promotion.");
            Console.WriteLine("14. LogOut.");
            Console.Write("Select one option : ");
            admin_employ = Console.ReadLine();
            return admin_employ;
        }
        static string empInterface() // EMPLOY MAIN MENU
        {
            string admin_employ = " ";
            Console.WriteLine("Main Menu.");
            Console.WriteLine("--------------");
            Console.WriteLine("Select one of the following.");
            Console.WriteLine("1.  Change password.");
            Console.WriteLine("2.  View salary.");
            Console.WriteLine("3.  View Grant / Reward or Bonus.");
            Console.WriteLine("4.  View Attendance.");
            Console.WriteLine("5.  View Deductions.");
            Console.WriteLine("6.  View Assigned Tasks / Duties.");
            Console.WriteLine("7.  Completed Tasks / Duties.");
            Console.WriteLine("8.  View your Balance.");
            Console.WriteLine("9.  View your Full Status.");
            Console.WriteLine("10. LogOut.");
            Console.Write("Select one option : ");
            admin_employ = Console.ReadLine();
            return admin_employ;
        }
        static void addEmployRank(List<Employ> employList) // adding employ rank
        {
            string user;
            Console.WriteLine("Main Menu > Add Employ rank.");
            Console.WriteLine("-----------------------------");
            Console.Write("Enter Employ username : ");
            user = Console.ReadLine();
            for (int i = 0; i < employList.Count; i++)
            {
                if (employList[i].emp_nameA == user) // checking position of employ in array
                {
                    Console.Write("Enter Employ rank : ");
                    st = Console.ReadLine();
                    if (isNumber(st))
                    {
                        employList[i].emp_rankA = int.Parse(st); // entering rank
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                }
            }
        }
        static void addUser(string user, string pass, string role, string ipass , List<Employ> employList , List<Login> userList) // adding user
        {
            if (ipass == " ")
            {
                ipass = pass;
            }
            if (role == "EMPLOY") // if admin want to add employ
            {
                Employ temp1 = new Employ(user);
                employList.Add(temp1);
            }
            Login temp = new Login(user, pass, role , ipass);
            userList.Add(temp);
        }
        static void releasePay(List<Employ> employList) // releasing pay of employ
        {
            string username = " ";
            Console.WriteLine("Main Menu > Release Pay");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Enter username of employ : ");
            username = Console.ReadLine();
            for (int y = 0; y < employList.Count; y++)
            {
                employList[y].payA = false;
                if (username == employList[y].emp_nameA) // checking position of employ
                {
                    Console.Write("Enter pay of Employ : ");
                    st = Console.ReadLine();
                    if (isNumber(st))
                    {
                        employList[y].emp_payA = int.Parse(st);
                        employList[y].payA = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                }
            }
        }
        static void empReward(List<Employ> employList) // giving reward to employ
        {
            string username = " ";
            Console.WriteLine("Main Menu > Grant / Reward or Bonus.");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Enter username of employ : ");
            username = Console.ReadLine();
            for (int y = 0; y < employList.Count; y++)
            {
                if (username == employList[y].emp_nameA)
                {
                    Console.Write("Enter Reward of Employ " + y + 1 + " : ");
                    st = Console.ReadLine();
                    if (isNumber(st))
                    {
                        employList[y].emp_rewardA = int.Parse(st);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                }
            }
        }
        static void empAttendance(List<Employ> employList) // attendance of employ
        {
            string username = " ";
            Console.WriteLine("Main Menu > Attendance");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Enter username of employ : ");
            username = Console.ReadLine();
            for (int y = 0; y < employList.Count; y++)
            {
                if (username == employList[y].emp_nameA)
                {
                    Console.Write("Enter how many days out 0f 30 employ 1 present : ");
                    st = Console.ReadLine();
                    if (isNumber(st))
                    {
                        employList[y].emp_attendanceA = int.Parse(st);
                        employList[y].emp_absenceA = 30 - employList[y].emp_attendanceA; // calculating absent days out of 30
                        Console.WriteLine("employ is absent {0} day(s).", employList[y].emp_absenceA);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                }
            }
        }
        static void empDeductions(List<Employ> employList) // deductions in employ pay
        {
            string username = " ";
            Console.WriteLine("Main Menu > Deductions");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Enter username of employ : ");
            username = Console.ReadLine();
            for (int y = 0; y < employList.Count; y++)
            {
                employList[y].emp_deductA = employList[y].emp_absenceA * 100; // calculating fine due to absence
                if (username == employList[y].emp_nameA)
                {
                    Console.WriteLine("employ is absent {0} day(s).", employList[y].emp_absenceA);
                    Console.WriteLine("Employ deductions : {0}", employList[y].emp_deductA);
                }
            }
        }
        static void empRemove(List<Employ> employList , List<Login> userList) // removing employ
        {
            string username = " ";
            char i = ' ';
            Console.WriteLine("Main Menu > Remove Employ.");
            Console.WriteLine("----------------------------");
            Console.Write("Enter username of employ : ");
            username = Console.ReadLine();
            Console.Write("Do you wanna remove employ(y or n) : ");
            i = (char)Console.Read();

            if (i == 'y') // STARTING IF
            {
                for (int y = 0; y < employList.Count; y++)
                {
                    if (username == employList[y].emp_nameA)
                    {
                        employList.RemoveAt(y);
                        Console.WriteLine("Employ removed.");
                        break;
                    }
                }
                for (int y = 0; y < userList.Count; y++)
                {
                    if (username == userList[y].usernameA && userList[y].rolesA == "EMPLOY") // checking position of employ in array
                    {
                        userList.RemoveAt(y);
                    }
                }
            }
        }
        static void displayEmploy(List<Employ> employList) // display employ with respect to their rank
        {
            int temp = 0;
            string temp1;
            float temp3;
            for (int x = 0; x < employList.Count; x++) // sorting w.r.t employ rank
            {
                for (int y = 0; y < employList.Count - 1; y++)
                {
                    if (employList[y].emp_rankA < employList[y + 1].emp_rankA) // Descending order
                    {
                        temp = employList[y].emp_rankA;
                        employList[y].emp_rankA = employList[y + 1].emp_rankA;
                        employList[y + 1].emp_rankA = temp;

                        temp1 = employList[y].emp_nameA;
                        employList[y].emp_nameA = employList[y + 1].emp_nameA;
                        employList[y + 1].emp_nameA = temp1;

                        temp1 = employList[y].task_1A;
                        employList[y].task_1A = employList[y + 1].task_1A;
                        employList[y + 1].task_1A = temp1;

                        temp1 = employList[y].task_2A;
                        employList[y].task_2A = employList[y + 1].task_2A;
                        employList[y + 1].task_2A = temp1;

                        temp1 = employList[y].task_3A;
                        employList[y].task_3A = employList[y + 1].task_3A;
                        employList[y + 1].task_3A = temp1;

                        temp1 = employList[y].task_4A;
                        employList[y].task_4A = employList[y + 1].task_4A;
                        employList[y + 1].task_4A = temp1;

                        temp3 = employList[y].emp_payA;
                        employList[y].emp_payA = employList[y + 1].emp_payA;
                        employList[y + 1].emp_payA = temp3;

                        temp3 = employList[y].emp_rewardA;
                        employList[y].emp_rewardA = employList[y + 1].emp_rewardA;
                        employList[y + 1].emp_rewardA = temp3;

                        temp3 = employList[y].emp_attendanceA;
                        employList[y].emp_attendanceA = employList[y + 1].emp_attendanceA;
                        employList[y + 1].emp_attendanceA = temp3;

                        temp3 = employList[y].emp_absenceA;
                        employList[y].emp_absenceA = employList[y + 1].emp_absenceA;
                        employList[y + 1].emp_absenceA = temp3;

                        temp3 = employList[y].emp_deductA;
                        employList[y].emp_deductA = employList[y + 1].emp_deductA;
                        employList[y + 1].emp_deductA = temp3;

                        temp = employList[y].task1_timeA;
                        employList[y].task1_timeA = employList[y + 1].task1_timeA;
                        employList[y + 1].task1_timeA = temp;

                        temp = employList[y].task2_timeA;
                        employList[y].task2_timeA = employList[y + 1].task2_timeA;
                        employList[y + 1].task2_timeA = temp;

                        temp = employList[y].task3_timeA;
                        employList[y].task3_timeA = employList[y + 1].task3_timeA;
                        employList[y + 1].task3_timeA = temp;

                        temp = employList[y].task4_timeA;
                        employList[y].task4_timeA = employList[y + 1].task4_timeA;
                        employList[y + 1].task4_timeA = temp;

                        temp = employList[y].emp_comp_taskA;
                        employList[y].emp_comp_taskA = employList[y + 1].emp_comp_taskA;
                        employList[y + 1].emp_comp_taskA = temp;
                    }
                }
            }
            for (int x = 0; x < employList.Count; x++)
            {
                Console.WriteLine(x + 1 + ".  \t" + employList[x].emp_nameA + "\t" + employList[x].emp_rankA);
            }
        }
        static void empTasks(List<Employ> employList) // assign tasks to employ
        {
            string task_1, task_2, task_3, task_4;
            int task1_time, task2_time, task3_time, task4_time;
            string username = " ";
            Console.Write("Enter username of employ : ");
            username = Console.ReadLine();

            Console.Write("Enter task 1 : ");
            task_1 = Console.ReadLine();
            Console.Write("Enter Task 1 time : ");
            task1_time = int.Parse(Console.ReadLine());
            Console.Write("Enter task 2 : ");
            task_2 = Console.ReadLine();
            Console.Write("Enter Task 2 time : ");
            task2_time = int.Parse(Console.ReadLine());
            Console.Write("Enter task 3 : ");
            task_3 = Console.ReadLine();
            Console.Write("Enter Task 3 time : ");
            task3_time = int.Parse(Console.ReadLine());
            Console.Write("Enter task 4 : ");
            task_4 = Console.ReadLine();
            Console.Write("Enter Task 4 time : ");
            task4_time = int.Parse(Console.ReadLine());
            for (int y = 0; y < employList.Count; y++)
            {
                if (username == employList[y].emp_nameA)
                {
                    employList[y].task_1A = task_1;
                    employList[y].task_2A = task_2;
                    employList[y].task_3A = task_3;
                    employList[y].task_4A = task_4;
                    employList[y].task1_timeA = task1_time;
                    employList[y].task2_timeA = task2_time;
                    employList[y].task3_timeA = task3_time;
                    employList[y].task4_timeA = task4_time;
                }
            }
        }
        static void empChanges(List<Login> userList) // see changes by employ
        {
            string username = " ";
            int c = 0;

            Console.Write("Enter username of required employ : ");
            username = Console.ReadLine();
            for (int x = 0; x < userList.Count; x++)
            {
                if (userList[x].usernameA == username && userList[x].initialPassA != userList[x].passwordA)
                {
                    Console.WriteLine("Employ changed his password to : {0}", userList[x].passwordA);
                    userList[x].initialPassA = userList[x].passwordA;
                    c++;
                    break;
                }
            }
            if (c == 0)
            {
                Console.WriteLine("No changes by employ.");
            }
        }
        static void empCompletedTasks(List<Employ> employList) // Completed tasks by employ
        {
            string username = " ";
            Console.Write("Enter user name of employ : ");
            username = Console.ReadLine();
            Console.Write("No of task completed by employ : ");
            for (int x = 0; x < employList.Count; x++)
            {
                if (employList[x].emp_nameA == username)
                {

                    if (employList[x].emp_comp_taskA != 0)
                    {
                        Console.WriteLine(employList[x].emp_comp_taskA);
                    }
                    else
                    {
                        Console.WriteLine("Nil");
                    }
                    break;
                }
            }
        }
        static void changeEmpPass(List<Login> userList) // Changing password of employ
        {
            string pass;
            string username = " ";
            char x = ' ';
            Console.Write("Enter user name of employ : ");
            username = Console.ReadLine();
            Console.Write("Do you wanna change password of employ (y or n) : ");
            x = (char)Console.Read();
            for (int i = 0; i < userList.Count; i++)
            {
                if (x == 'y' && userList[i].usernameA == username && userList[i].rolesA == "EMPLOY")
                {
                    while (true)
                    {
                        Console.Write("Enter password of User : ");
                        pass = Console.ReadLine();
                        if (pass.Length >= 8)
                        {
                            userList[i].passwordA = pass;
                            userList[i].initialPassA = userList[i].passwordA;
                            Console.WriteLine("Password updated!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("password must be 8 digit or long.");
                            Console.Write("Enter any key to continue : ");
                            Console.Read();
                            Console.Clear();
                        }
                    }
                    break;
                }
            }
        }
        static void empPromotion(List<Employ> employList) // promotion of employ
        {
            string username = " ";
            Console.Write("Enter user name : ");
            username = Console.ReadLine();
            for (int i = 0; i < employList.Count; i++)
            {
                if (employList[i].emp_nameA == username)
                {
                    Console.Write("Enter new employ rank : ");
                    st = Console.ReadLine();
                    if (isNumber(st))
                    {
                        employList[i].emp_rankA = int.Parse(st);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                    break;
                }
            }
        }
        static void changePass(List<Login> userList) // Employ can change his password by this function
        {
            string pass;
            string previous_pass = " ";
            int c = 0;
            Console.Write("Enter Previous Password : ");
            previous_pass = Console.ReadLine();
            for (int z = 0; z < userList.Count; z++)
            {
                if (previous_pass == userList[z].passwordA && userList[z].usernameA == loginusername) // STARTING IF
                {
                    while (true)
                    {
                        Console.Write("Enter password of User : ");
                        pass = Console.ReadLine();
                        if (pass.Length >= 8)
                        {
                            userList[z].passwordA = pass;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("password must be 8 digit or long.");
                            Console.Write("Enter any key to continue : ");
                            Console.Read();
                            Console.Clear();
                        }
                    }

                    Console.WriteLine("Password updated.");
                    c++;
                    break;
                } // END IF
            }
            if (c == 0)
            {
                Console.WriteLine("You entered wrong password.");
            }
        }
        static void viewSalary(List<Employ> employList) // employ view his salary
        {
            a = 0;
            for (int x = 0; x < employList.Count; x++)
            {
                if (loginusername == employList[x].emp_nameA && employList[x].payA == true)
                {
                    Console.WriteLine("Your salary status : {0}", employList[x].emp_payA);
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("NO data entered yet");
            }
        }
        static void viewReward(List<Employ> employList) // employ can view his reward
        {
            a = 0;
            for (int x = 0; x < employList.Count; x++)
            {
                if (loginusername == employList[x].emp_nameA)
                {
                    Console.WriteLine("Your Grant / Reward or bonus : {0}", employList[x].emp_rewardA);
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("NO data entered yet");
            }
        }
        static void viewAttendance(List<Employ> employList) // employ can view his attendance
        {
            a = 0;
            for (int x = 0; x < employList.Count; x++)
            {
                if (loginusername == employList[x].emp_nameA)
                {
                    Console.WriteLine("Your attendance : {0}", employList[x].emp_attendanceA);
                    Console.WriteLine("Your absence out of 30 : {0}", employList[x].emp_absenceA);
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("NO data entered yet");
            }
        }
        static void viewDeduct(List<Employ> employList) // employ can view his attendance
        {
            a = 0;
            for (int x = 0; x < employList.Count; x++)
            {
                if (loginusername == employList[x].emp_nameA)
                {
                    Console.WriteLine("Your deduction in salary : {0}", employList[x].emp_deductA);
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("NO data entered yet");
            }
        }
        static void viewTask(List<Employ> employList) // employ can view assigned tasks by admin
        {
            a = 0;
            for (int x = 0; x < employList.Count; x++)
            {
                if (loginusername == employList[x].emp_nameA)
                {
                    Console.WriteLine("1. {0} \t\t {1}", employList[x].task_1A, employList[x].task1_timeA);
                    Console.WriteLine("2. {0} \t\t {1}", employList[x].task_2A, employList[x].task2_timeA);
                    Console.WriteLine("3. {0} \t\t {1}", employList[x].task_3A, employList[x].task3_timeA);
                    Console.WriteLine("4. {0} \t\t {1}", employList[x].task_4A, employList[x].task4_timeA);
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("NO data entered yet");
            }
        }
        static void enterCompTask(List<Employ> employList) // Number of completed tasks
        {
            a = 0;
            for (int x = 0; x < employList.Count; x++)
            {
                if (loginusername == employList[x].emp_nameA)
                {
                    Console.Write("Enter no of completed tasks : ");
                    st = Console.ReadLine();
                    if (isNumber(st))
                    {
                        employList[x].emp_comp_taskA = int.Parse(st);
                        a++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                }
            }
            if (a == 0)
            {
                Console.WriteLine("NO data entered yet");
            }
        }
        static void viewBalance(List<Employ> employList) // Employ can see his Balance
        {
            a = 0;
            for (int x = 0; x < employList.Count; x++)
            {
                if (loginusername == employList[x].emp_nameA)
                {
                    float balance = employList[x].emp_payA + employList[x].emp_rewardA - employList[x].emp_deductA;
                    Console.WriteLine("Your balance : {0}", balance);
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("NO data entered yet");
            }
        }
        static void viewStatus(List<Employ> employList) // employ can view his full status
        {
            a = 0;
            for (int x = 0; x < employList.Count; x++)
            {
                if (loginusername == employList[x].emp_nameA)
                {
                    Console.WriteLine("Your Salary : {0}", employList[x].emp_payA);
                    Console.WriteLine("Your rank : {0}", employList[x].emp_rankA);
                    Console.WriteLine("Your bonus : {0}", employList[x].emp_rewardA);
                    Console.WriteLine("your deductions : {0}", employList[x].emp_deductA);
                    float balance = employList[x].emp_payA + employList[x].emp_rewardA - employList[x].emp_deductA;
                    Console.WriteLine("Your balance : {0}", balance);
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("NO data entered yet");
            }
        }
        static string getParse(string abc, int num) // to seperate data read from file
        {
            int commaCount = 0;
            string item = "";
            for (int y = 0; y < abc.Length; y++)
            {
                if (abc[y] == ',')
                {
                    commaCount = commaCount + 1;
                }
                else if (commaCount == num)
                {
                    item = item + abc[y];
                }
            }
            return item;
        }
        static void storeArray(List<Employ> employList , List<Login> userList) // to store data from file t array
        {
            string us, pass, rol, ipass = " ";
            int rnk;
            float emp_pay, emp_reward, emp_attendance, emp_absence, emp_deduct;
            int task1_time;
            int task2_time, task3_time, task4_time, emp_comp_task;
            bool payannounce;
            StreamReader fp = new StreamReader(path);
            string line = " ";
            while ((line = fp.ReadLine()) != null)
            {
                us = getParse(line, 0);
                pass = getParse(line, 1);
                rol = getParse(line, 2);
                if (rol == "EMPLOY")
                {
                    rnk = int.Parse(getParse(line, 3));
                    emp_pay = int.Parse(getParse(line, 4));
                    emp_reward = int.Parse(getParse(line, 5));
                    emp_attendance = int.Parse(getParse(line, 6));
                    emp_absence = int.Parse(getParse(line, 7));
                    emp_deduct = int.Parse(getParse(line, 8));
                    task1_time = int.Parse(getParse(line, 9));
                    task2_time = int.Parse(getParse(line, 10));
                    task3_time = int.Parse(getParse(line, 11));
                    task4_time = int.Parse(getParse(line, 12));
                    emp_comp_task = int.Parse(getParse(line, 13));
                    payannounce = Convert.ToBoolean(getParse(line, 18));
                    Employ employList1 = new Employ(us, emp_pay, emp_reward, emp_attendance, emp_absence,emp_deduct, rnk, emp_comp_task,payannounce, task1_time, task2_time, task3_time, task4_time);
                    employList1.task_1A = getParse(line, 14);
                    employList1.task_2A = getParse(line, 15);
                    employList1.task_3A = getParse(line, 16);
                    employList1.task_4A = getParse(line, 17);
                    employList.Add(employList1);
                    ipass = getParse(line, 19);
                }
                addUser( us, pass,  rol,  ipass , employList , userList);
            }
            fp.Close();
        }
        static void storeFile(List<Employ> employList , List<Login> userList) // to store data in file
        {
            StreamWriter newfile = new StreamWriter(path);
            for (int z = 0; z < userList.Count; z++)
            {
                newfile.Write(userList[z].usernameA + "," + userList[z].passwordA + "," + userList[z].rolesA);
                if (userList[z].rolesA == "EMPLOY")
                {
                    for (int y = 0; y < employList.Count; y++)
                    {
                        if (userList[z].usernameA == employList[y].emp_nameA)
                        {
                            newfile.Write("," + employList[y].emp_rankA + "," + employList[y].emp_payA + "," + employList[y].emp_rewardA + "," + employList[y].emp_attendanceA);
                            newfile.Write("," + employList[y].emp_absenceA + "," + employList[y].emp_deductA + "," + employList[y].task1_timeA + "," + employList[y].task2_timeA + "," + employList[y].task3_timeA);
                            newfile.Write("," + employList[y].task4_timeA + "," + employList[y].emp_comp_taskA + "," + employList[y].task_1A + "," + employList[y].task_2A + "," + employList[y].task_3A + "," + employList[y].task_4A + "," + employList[y].payA);
                            newfile.Write("," + userList[z].initialPassA);
                        }
                    }
                }
                if (z < userList.Count - 1)
                {
                    newfile.WriteLine();
                }
            }
            newfile.Flush();
            newfile.Close();
        }
        static bool isNumber(string line)
        {
            bool flag = true;

            for (int i = 0; i < line.Length; i++)
            {
                if (!(line[i] >= 48 && line[i] <= 57))
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

