using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace IsIT.B2B.DoPaymentTest.UIData
{
	[DataObject]
	public class Language
	{
		string _id;
		string _text;

		internal Language(string id, string text)
		{
			Id = id;
			Text = text;
		}

		public string Id { get { return _id; } internal set { _id = value; } }
		public string Text { get { return _text; } internal set { _text = value; } }

		public static IList<Language> GetLanguages()
		{
			IList<Language> languages = new List<Language>();
			languages.Add(new Language("ISL", "Icelandic"));
			languages.Add(new Language("ENG", "English"));
			return languages;
		}
	}
}
