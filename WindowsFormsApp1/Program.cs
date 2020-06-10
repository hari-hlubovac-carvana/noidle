namespace WindowsFormsApp1
{
    using System;
    using System.Windows.Forms;

    static class Program
    {
        [STAThread]
        static void Main()
        {
            KeepAlive.PowerUtilities.PreventPowerSave();

            Application.Run();
        }
    }
}
