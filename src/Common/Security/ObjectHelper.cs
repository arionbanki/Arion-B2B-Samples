using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace IsIT.B2B.Common.Security
{
	public class ObjectHelper
	{
		public static object CloneObject(object obj)
		{
			Type t = obj.GetType();
			object newObject = Activator.CreateInstance(t);

			PropertyInfo[] properties = t.GetProperties(BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.DeclaredOnly | BindingFlags.Instance);
			PropertyInfo[] newProperties = t.GetProperties(BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.DeclaredOnly | BindingFlags.Instance);

			int i = 0;
			foreach (PropertyInfo p in properties)
			{
				newProperties[i++].SetValue(newObject, p.GetValue(obj, null), null);
			}
			return newObject;
		}
	}
}
