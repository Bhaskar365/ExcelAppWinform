namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Thread t = new Thread(new ThreadStart(ThreadStart));
            t.IsBackground = false;
            t.ApartmentState = ApartmentState.STA;
            t.Start();

            Application.Run(new Form1());
        }

        private static void ThreadStart()
        {
            Thread.Sleep(1000);
            Application.Run(new Form2());
        }

    }
}