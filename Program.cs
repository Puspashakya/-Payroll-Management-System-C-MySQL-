using System;
using System.Windows.Forms;

namespace PayrollSystemNet8;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new frm_login());
    }
}
