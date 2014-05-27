using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arena
{
	public partial class ConnectSettings : Form
	{
		public ConnectSettings()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		public string IPAddress
		{
			get
			{
				return tbIPAddress.Text;
			}
		}

		public int Port
		{
			get
			{
				return (int)nudPort.Value;
			}
		}
	}
}
