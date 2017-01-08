using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Profile_Manager {
	static class Program {
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			if( !isElevated() ) {
				DialogResult dlgRes = MessageBox.Show(
					"It seems that the application does not have administrative privileges!",
					"Network Profile Manager",
					MessageBoxButtons.RetryCancel,
					MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button1
				);
				if( dlgRes == DialogResult.Retry ) {
					ProcessStartInfo psi= new ProcessStartInfo();
					psi.Verb = "runas";
					psi.UseShellExecute = true;
					psi.FileName = Application.ExecutablePath;
					Process.Start( psi );
				}
				Environment.Exit( 0 );
			}
			Application.Run( new mainForm() );
		}

		static private bool isElevated() {
			WindowsIdentity identity = WindowsIdentity.GetCurrent();
			WindowsPrincipal principal = new WindowsPrincipal(identity);
			return principal.IsInRole( WindowsBuiltInRole.Administrator );
		}
	}
}
