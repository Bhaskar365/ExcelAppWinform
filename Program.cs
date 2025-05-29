namespace WinFormsApp
{
    internal static class Program
    {

        static Form1 splashForm;
        static Form2 mainForm;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Thread t = new Thread(new ThreadStart(ThreadStart));
            t.IsBackground = false;
            t.ApartmentState = ApartmentState.STA;
            t.Start();

            Form1 frm = new Form1();
            

            Application.Run(new Form1());

            //splashForm = new Form1();
            //var splashThread = new Thread(new ThreadStart(
            //        () => Application.Run(splashForm)
            //    ));
            //splashThread.SetApartmentState(ApartmentState.STA);
            //splashThread.Start();

            //mainForm = new Form2();
            //mainForm.Load += mainForm_load;
            //Application.Run(mainForm);
        }

        private static void mainForm_load(object sender, EventArgs e) 
        {
            if (splashForm != null && !splashForm.Disposing && !splashForm.IsDisposed)
                splashForm.Invoke(new Action(()=>splashForm.Close()));

            mainForm.TopMost = true;
            mainForm.Activate();
            mainForm.TopMost = false;
        }

        private static void ThreadStart()
        {
            Thread.Sleep(1000);
            Application.Run(new Form2());
        }

    }
}