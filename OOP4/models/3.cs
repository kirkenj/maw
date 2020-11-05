namespace OOP4.CommonTasks
{
    class Task3
    {
        const string START_MSG = "Task 3: programm will say if the number will devide on element from the following array:";
        static int[] MAS = { 2, 3, 5, 7, 11, 17, 19 };
        public static void Run()
        {
            OutlnConsole.Print(START_MSG);
            OutlnConsole.Print(MAS);
            int inp = UserInput.AnInt("Input a number");
            foreach (int l in MAS)
            {
                if (inp % l == 0)
                {
                    OutlnConsole.Print($"The number can be devided on {l}");
                }
            }
        }
    }
}
