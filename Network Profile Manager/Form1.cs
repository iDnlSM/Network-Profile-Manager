using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Profile_Manager {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			ListNetworks();
		}

		private const string ProfilePath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles";
		private const string SignaturePath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures";

		private void ListNetworks() {
			listView1.Items.Clear();
			RegistryKey regKey = LocalMachine().OpenSubKey(ProfilePath);
			foreach( string subkey in regKey.GetSubKeyNames() ) {
				regKey = LocalMachine().OpenSubKey( ProfilePath + "\\" + subkey );
				ListViewItem profile = new ListViewItem();
				profile.Text = regKey.GetValue( "ProfileName", "NULL" ).ToString();
				profile.SubItems.Add( regKey.GetValue( "Description", "NULL" ).ToString() );
				switch( ( int )regKey.GetValue( "Category", -1 ) ) {
					case 0:
						profile.SubItems.Add( "Public" );
						break;
					case 1:
						profile.SubItems.Add( "Private" );
						break;
					case 2:
						profile.SubItems.Add( "Domain" );
						break;
				}
				switch( ( int )regKey.GetValue( "Managed", -1 ) ) {
					case 0:
						profile.SubItems.Add( "False" );
						break;
					case 1:
						profile.SubItems.Add( "True" );
						break;
				}
				profile.SubItems.Add( subkey );
				listView1.Items.Add( profile );
			}
		}

		private static RegistryKey LocalMachine() {
			//thanks to Aseem Gautam
			return RegistryKey.OpenBaseKey(
				RegistryHive.LocalMachine,
				Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32
			);
		}

		private void refreshToolStripMenuItem_Click( object sender, EventArgs e ) {
			ListNetworks();
			textBox1.Text = textBox2.Text = "";
			comboBox1.SelectedIndex = -1;
			checkBox1.CheckState = CheckState.Indeterminate;
			panel1.Enabled = false;
		}

		private void listView1_SelectedIndexChanged( object sender, EventArgs e ) {
			if( listView1.SelectedItems.Count > 0 ) {
				ListViewItem curItem = listView1.SelectedItems[ 0 ];
				textBox1.Text = curItem.Text;
				textBox2.Text = curItem.SubItems[ 1 ].Text;
				comboBox1.SelectedItem = curItem.SubItems[ 2 ].Text;
				checkBox1.Checked = curItem.SubItems[ 3 ].Text == "True" ? true : false;
				panel1.Enabled = true;
			} else {
				textBox1.Text = textBox2.Text = "";
				comboBox1.SelectedIndex = -1;
				checkBox1.CheckState = CheckState.Indeterminate;
				panel1.Enabled = false;
			}
		}

		private void gitHubToolStripMenuItem_Click( object sender, EventArgs e ) {
			Process.Start( "https://github.com/iDnlSM/Network-Profile-Manager" );
		}

		private void updateToolStripMenuItem_Click( object sender, EventArgs e ) {
			Process.Start( "https://github.com/iDnlSM/Network-Profile-Manager/releases/latest" );
		}

		private void button1_Click( object sender, EventArgs e ) {
			if( listView1.SelectedItems.Count > 0 ) {
				string subkey = listView1.SelectedItems[0].SubItems[4].Text;
				RegistryKey regKey = LocalMachine().OpenSubKey(ProfilePath + "\\" + subkey, true);
				regKey.SetValue( "ProfileName", textBox1.Text );
				regKey.SetValue( "Description", textBox2.Text );
				switch( comboBox1.SelectedItem.ToString() ) {
					case "Public":
						regKey.SetValue( "Category", 0 );
						break;
					case "Private":
						regKey.SetValue( "Category", 1 );
						break;
					case "Domain":
						regKey.SetValue( "Category", 2 );
						break;
				}
				regKey.SetValue( "Managed", checkBox1.Checked ? 1 : 0 );
			}
			ListNetworks();
		}

		private void deleteSelectedToolStripMenuItem_Click( object sender, EventArgs e ) {
			if( listView1.SelectedItems.Count > 0 ) {
				RegistryKey regKey = LocalMachine().OpenSubKey(ProfilePath, true);
				string subkey = listView1.SelectedItems[0].SubItems[4].Text;
				regKey.DeleteSubKey( subkey );
				if( listView1.SelectedItems[ 0 ].SubItems[ 3 ].Text == "True" ) {
					regKey = LocalMachine().OpenSubKey( SignaturePath + "\\Managed");
					foreach( string profile in regKey.GetSubKeyNames() ) {
						regKey = LocalMachine().OpenSubKey( SignaturePath + "\\Managed\\" + profile, true );
						if( regKey.GetValue( "ProfileGuid", "NULL" ).ToString() == subkey ) {
							regKey = LocalMachine().OpenSubKey( SignaturePath + "\\Managed", true );
							regKey.DeleteSubKey( profile );
						}
					}
				} else {
					regKey = LocalMachine().OpenSubKey( SignaturePath + "\\Unmanaged");
					foreach( string profile in regKey.GetSubKeyNames() ) {
						regKey = LocalMachine().OpenSubKey( SignaturePath + "\\Unmanaged\\" + profile, true );
						if( regKey.GetValue( "ProfileGuid", "NULL" ).ToString() == subkey ) {
							regKey = LocalMachine().OpenSubKey( SignaturePath + "\\Unmanaged", true );
							regKey.DeleteSubKey( profile );
						}
					}
				}
			}
			ListNetworks();
		}

		private void deleteCheckedToolStripMenuItem_Click( object sender, EventArgs e ) {
			foreach( ListViewItem curItem in listView1.CheckedItems ) {
				RegistryKey regKey = LocalMachine().OpenSubKey(ProfilePath, true);
				string subkey = curItem.SubItems[4].Text;
				regKey.DeleteSubKey( subkey );
				if( curItem.SubItems[ 3 ].Text == "True" ) {
					regKey = LocalMachine().OpenSubKey( SignaturePath + "\\Managed", true );
					foreach( string profile in regKey.GetSubKeyNames() ) {
						regKey = LocalMachine().OpenSubKey( SignaturePath + "\\Managed\\" + profile, true );
						if( regKey.GetValue( "ProfileGuid", "NULL" ).ToString() == subkey ) {
							regKey = LocalMachine().OpenSubKey( SignaturePath + "\\Managed" );
							regKey.DeleteSubKey( profile );
						}
					}
				} else {
					regKey = LocalMachine().OpenSubKey( SignaturePath + "\\Unmanaged", true );
					foreach( string profile in regKey.GetSubKeyNames() ) {
						regKey = LocalMachine().OpenSubKey( SignaturePath + "\\Unmanaged\\" + profile );
						if( regKey.GetValue( "ProfileGuid", "NULL" ).ToString() == subkey ) {
							regKey = LocalMachine().OpenSubKey( SignaturePath + "\\Unmanaged", true );
							regKey.DeleteSubKey( profile );
						}
					}
				}
				ListNetworks();
			}
		}
	}
}
