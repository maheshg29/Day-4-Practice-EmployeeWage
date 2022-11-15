namespace Day_4_Practice_EmployeeWage
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
           
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empWage)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;

                case IS_FULL_TIME:
                    empHrs = 8;
                    break;

                default:
                    empHrs = 0;
                    break;
            }


            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("EMP Wage : " + empWage);

        }
    }
}
