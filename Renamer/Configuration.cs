/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-07-31
 * Time: 19:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml;

namespace Renamer
{
	/// <summary>
	/// Description of Configuration.
	/// </summary>
	public sealed class Configuration
	{
		private static Configuration instance = new Configuration();
		private static XmlDocument document;

		public static Configuration Value {
			get {
				return instance;
			}
		}
		
		public string GetValue(string key)
		{
			return Configuration.document.GetElementsByTagName(key)[0].InnerText;
		}
		
		public void UpdateValue(string key, string value)
		{
			Configuration.document.GetElementsByTagName(key)[0].InnerText = value;
		}
		
		public void Save()
		{
			Configuration.document.Save("configuration.xml");
		}
		
		private Configuration()
		{
			Configuration.document = new XmlDocument();
			Configuration.document.Load("configuration.xml");
		}
	}
}
