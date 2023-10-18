using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Services.Protocols;

namespace IsIT.B2B.Common.Security
{
	public class ExceptionHandler
	{
		public static string GetMessage(Exception ex)
		{
			string message = string.Empty;
			if (ex is SoapException)
			{
				SoapException e = (SoapException)ex;
				if (e.Detail != null)
				{
					message = string.Format("{0}\n{1}", e.Message, e.Detail.InnerXml);
				}
				else
				{
					message = e.Message;
				}
			}
			else
			{
				message = ex.Message;
			}

			if (ex.InnerException != null)
			{
				message += "\nInnerException: " + ex.InnerException.Message;
			}
			return message;
		}
	}
}
