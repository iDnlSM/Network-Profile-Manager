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
	public partial class mainForm : Form {
		public mainForm() {
			InitializeComponent();
		}

		private void gitHubToolStripMenuItem_Click( object sender, EventArgs e ) {
			Process.Start( "https://github.com/iDnlSM/Network-Profile-Manager" );
		}

		private void updateToolStripMenuItem_Click( object sender, EventArgs e ) {
			Process.Start( "https://github.com/iDnlSM/Network-Profile-Manager/releases/latest" );
		}

		private void ListProfiles() {
			tb_profilenName.Text = "";
			tb_profileDescription.Text = "";
			mod_container.Enabled = false;
			profile_list.Items.Clear();
			foreach( Utils.NetworkProfile CurProfile in Utils.GetProfiles() ) {
				ListViewItem item = new ListViewItem();
				item.Text = CurProfile.Name;
				item.SubItems.Add( CurProfile.Description );
				switch( CurProfile.Category ) {
					case 0:
						item.SubItems.Add( "Public" );
						break;
					case 1:
						item.SubItems.Add( "Private" );
						break;
					case 2:
						item.SubItems.Add( "Domain" );
						break;
				}
				item.SubItems.Add( CurProfile.Managed ? "True" : "False" );
				item.SubItems.Add( CurProfile.SubKey );
				item.SubItems.Add( CurProfile.SignatureSubKey );
				profile_list.Items.Add( item );
			}
		}

		private void refreshToolStripMenuItem_Click( object sender, EventArgs e ) {
			ListProfiles();
		}

		private void deleteSelectedToolStripMenuItem_Click( object sender, EventArgs e ) {
			foreach( ListViewItem item in profile_list.SelectedItems ) {
				Utils.NetworkProfile profile = new Utils.NetworkProfile();
				profile.Name = item.Text;
				profile.Description = item.SubItems[ 1 ].Text;
				switch( item.SubItems[ 2 ].Text ) {
					case "Public":
						profile.Category = 0;
						break;
					case "Private":
						profile.Category = 1;
						break;
					case "Domain":
						profile.Category = 2;
						break;
				}
				profile.Managed = item.SubItems[ 3 ].Text == "True" ? true : false;
				profile.SubKey = item.SubItems[ 4 ].Text;
				profile.SignatureSubKey = item.SubItems[ 5 ].Text;
				profile.Delete();
			}
			ListProfiles();
		}

		private void deleteCheckedToolStripMenuItem_Click( object sender, EventArgs e ) {
			foreach( ListViewItem item in profile_list.CheckedItems ) {
				Utils.NetworkProfile profile = new Utils.NetworkProfile();
				profile.Name = item.Text;
				profile.Description = item.SubItems[ 1 ].Text;
				switch( item.SubItems[ 2 ].Text ) {
					case "Public":
						profile.Category = 0;
						break;
					case "Private":
						profile.Category = 1;
						break;
					case "Domain":
						profile.Category = 2;
						break;
				}
				profile.Managed = item.SubItems[ 3 ].Text == "True" ? true : false;
				profile.SubKey = item.SubItems[ 4 ].Text;
				profile.SignatureSubKey = item.SubItems[ 5 ].Text;
				profile.Delete();
			}
			ListProfiles();
		}

		private void profile_list_SelectedIndexChanged( object sender, EventArgs e ) {
			if( profile_list.SelectedItems.Count > 0 ) {
				tb_profilenName.Text = profile_list.SelectedItems[ 0 ].Text;
				tb_profileDescription.Text = profile_list.SelectedItems[ 0 ].SubItems[ 1 ].Text;
				cb_Category.SelectedItem = profile_list.SelectedItems[ 0 ].SubItems[ 2 ].Text;
				mod_container.Enabled = true;
			} else {
				tb_profilenName.Text = "";
				tb_profileDescription.Text = "";
				mod_container.Enabled = false;
			}
		}

		private void btn_save_Click( object sender, EventArgs e ) {
			if( profile_list.SelectedItems.Count > 0 ) {
				ListViewItem item = profile_list.SelectedItems[0];
				Utils.NetworkProfile profile = new Utils.NetworkProfile();
				profile.Name = tb_profilenName.Text;
				profile.Description = tb_profileDescription.Text;
				switch( cb_Category.SelectedItem.ToString() ) {
					case "Public":
						profile.Category = 0;
						break;
					case "Private":
						profile.Category = 1;
						break;
					case "Domain":
						profile.Category = 2;
						break;
				}
				profile.Managed = item.SubItems[ 3 ].Text == "True" ? true : false;
				profile.SubKey = item.SubItems[ 4 ].Text;
				profile.SignatureSubKey = item.SubItems[ 5 ].Text;
				profile.Save();
			}
			ListProfiles();
		}
	}
}
