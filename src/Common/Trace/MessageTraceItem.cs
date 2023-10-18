// -----------------------------------------------------------------------
// <copyright file="MessageTraceItem.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace IsIT.B2B.Common.Trace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.Xml;
    using System.Xml.Xsl;

    /// <summary>
    /// SOAP XML/HTML
    /// </summary>
    public class MessageTraceItem
    {
        /// <summary>
        /// Gets or sets the request XML.
        /// </summary>
        /// <value>
        /// The request XML.
        /// </value>
        public string RequestXml { get; set; }

        public string ResponseXml { get; set; }

        public string RequestHtml
        {
            get
            {
                return this.XmlToHtml(RequestXml);
            }
        }

        public string ResponseHtml
        {
            get
            {
                return this.XmlToHtml(ResponseXml);
            }
        }
        public string XmlToHtml(string xml)
        {
            if ((xml == null) || (xml.Trim().Length == 0)) return "";

            var s = new StringReader(Properties.Resources.XMLXSLT);

            var xr = XmlReader.Create(s);
            var xct = new XslCompiledTransform();
            xct.Load(xr);

            var sb = new StringBuilder();
            var xw = XmlWriter.Create(sb);

            var tr = new StringReader(xml);
            var xmlData = XmlReader.Create(tr);
            if (xw != null) xct.Transform(xmlData, xw);

            return sb.ToString();
        }   

    }
}
