using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Profile_Manager {
	public static class Utils {

		public static string ProfilePath {
			get {
				return @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles";
			}
		}
		public static string SignaturePath {
			get {
				return @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures";
			}
		}

		public static RegistryKey LocalMachine {
			get {
				return RegistryKey.OpenBaseKey(
					RegistryHive.LocalMachine,
					Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32
				);
			}
		}

		public static NetworkProfile[] GetProfiles() {
			RegistryKey regKey = Utils.LocalMachine.OpenSubKey(Utils.ProfilePath);
			List<Utils.NetworkProfile> profiles = new List<Utils.NetworkProfile>();
			foreach( string subKey in regKey.GetSubKeyNames() ) {
				var rk = Utils.LocalMachine.OpenSubKey(Utils.ProfilePath + "\\" + subKey);
				var profile = new Utils.NetworkProfile();
				profile.SubKey = subKey;
				profile.Name = rk.GetValue( "ProfileName" ).ToString();
				profile.Description = rk.GetValue( "Description" ).ToString();
				profile.Category = ( int )rk.GetValue( "Category" );
				profile.Managed = ( int )rk.GetValue( "Managed" ) == 1 ? true : false;
				rk = LocalMachine.OpenSubKey( Utils.SignaturePath + "\\" + ( profile.Managed ? "Managed" : "Unmanaged" ) );
				foreach( string sk in rk.GetSubKeyNames() ) {
					rk = LocalMachine.OpenSubKey( Utils.SignaturePath + "\\" + ( profile.Managed ? "Managed\\" : "Unmanaged\\" ) + sk );
					if( rk.GetValue( "ProfileGuid" ).ToString() == profile.SubKey ) {
						profile.SignatureSubKey = sk;
					}
				}
				profiles.Add( profile );
			}
			return profiles.ToArray();
		}

		public class NetworkProfile {
			public string Name { get; set; }
			public string Description { get; set; }
			public int Category { get; set; }
			public bool Managed { get; set; }
			public string SubKey { get; set; }
			public string SignatureSubKey { get; set; }


			public void Save() {
				RegistryKey regKey = Utils.LocalMachine.OpenSubKey(Utils.ProfilePath + "\\" + this.SubKey, true);
				regKey.SetValue( "ProfileName", this.Name );
				regKey.SetValue( "Description", this.Description );
				regKey.SetValue( "Category", this.Category );
			}

			public void Delete() {
				RegistryKey regKey = Utils.LocalMachine.OpenSubKey( ProfilePath, true );
				regKey.DeleteSubKey( this.SubKey );
				regKey = Utils.LocalMachine.OpenSubKey( SignaturePath + ( this.Managed ? "\\Managed" : "\\Unmanaged" ), true );
				regKey.DeleteSubKey( this.SignatureSubKey );
			}
		}
	}
}