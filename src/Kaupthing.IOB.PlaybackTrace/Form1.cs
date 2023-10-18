using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Kaupthing.IOB.PlaybackTrace.Properties;
using Microsoft.Web.Services3.Addressing;
using Microsoft.Web.Services3.Messaging;
using Microsoft.Web.Services3;
using System.IO;
using System.Web.Services.Protocols;

namespace Kaupthing.IOB.PlaybackTrace
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void SendButton_Click(object sender, EventArgs e)
		{
			Settings.Default.Save();

			Uri serverURI = new Uri(IOBUrlTextBox.Text);
			SoapEnvelope envelope = new SoapEnvelope();
			envelope.LoadXml(textBox1.Text);


			try
			{
				EndpointReference destination = new EndpointReference(serverURI);

				SoapSender soapSender = new SoapSender(destination);
				soapSender.Send(envelope);

				MessageBox.Show("Message is valid");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error:\n"+GetErrorMessage(ex), ex.GetType().Name);
			}
		}

		private void BrowseButton_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			using (FileStream xmlStream = File.OpenRead(openFileDialog1.FileName))
			{
				using (TextReader reader = new StreamReader(xmlStream))
				{
					textBox1.Text = reader.ReadToEnd();
				}
			}
		}



		public static string GetErrorMessage(Exception ex)
		{
			if (ex is SoapException)
			{
				SoapException e = (SoapException)ex;
				if (e.Detail != null)
				{
					return string.Format("{0}\n{1}", e.Message, e.Detail.InnerXml);
				}
				else
				{
					return e.Message;
				}
			}
			else
			{
				return ex.Message;
			}
		}
	}
}
