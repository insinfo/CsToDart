using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using CsToDartTranspiler;
using KineApps.Common.Diagnostics;

namespace A;

internal static class E
{
	private const string m_A = "strings.dart";

	internal static string A(b P_0, string P_1)
	{
		string directoryName = Path.GetDirectoryName(P_1);
		string path = Path.Combine(directoryName, "MultilingualResources");
		bool flag = false;
		if (Directory.Exists(path))
		{
			string[] files = Directory.GetFiles(path, "*.xlf", SearchOption.TopDirectoryOnly);
			if (files.Count() > 0)
			{
				bool flag2 = true;
				HashSet<string> hashSet = new HashSet<string>();
				string[] array = files;
				foreach (string text in array)
				{
					try
					{
						(string, string) tuple = A(text);
						string fileName = Path.GetFileName(P_0.a(text, tuple.Item1));
						hashSet.Add(fileName);
						if (flag2)
						{
							string text2 = Path.Combine(directoryName, "strings.dart");
							P_0.A(text2, tuple.Item2);
							flag = true;
						}
					}
					catch (Exception exception)
					{
						Log.Exception(exception, "TranslateXlfFiles", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\StringResourcesTranslator\\StringResourcesTranslator.cs", 55);
					}
					flag2 = false;
				}
				P_0.A().Dependencies.Add("flutter");
				P_0.A().Dependencies.Add("flutter_localizations");
				P_0.A().Dependencies.Add("intl_translation");
				string text3 = A(hashSet);
				P_0.B("update_strings.bat", text3);
			}
		}
		if (!flag)
		{
			return null;
		}
		return "src/strings.dart";
	}

	private static (string arb, string dartCode) A(string P_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("{");
		_ = 0 + 1;
		e e2 = new e();
		using (XmlReader reader = XmlReader.Create(P_0))
		{
			XDocument xDocument = XDocument.Load(reader);
			XNamespace @namespace = xDocument.Root.Name.Namespace;
			XElement xElement = xDocument.Descendants(@namespace + "file").FirstOrDefault();
			if (xElement != null)
			{
				string value = xElement.Attribute("target-language").Value;
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(16, 1, stringBuilder2);
				handler.AppendLiteral("  \"_locale\": \"");
				handler.AppendFormatted(value);
				handler.AppendLiteral("\",");
				stringBuilder2.AppendLine(ref handler);
			}
			XElement xElement2 = xDocument.Descendants(@namespace + "body").FirstOrDefault();
			if (xElement2 != null)
			{
				XElement xElement3 = xElement2.Descendants(@namespace + "group").FirstOrDefault();
				if (xElement3 != null)
				{
					foreach (XElement item2 in xElement3.Descendants(@namespace + "trans-unit"))
					{
						string text = Util.ToCamelCase(item2.Attribute("id").Value);
						Log.Message("name=" + text, "TranslateXlfFile", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\StringResourcesTranslator\\StringResourcesTranslator.cs", 110);
						if (!(text == "resourceFlowDirection") && !(text == "resourceLanguage"))
						{
							string text2 = string.Empty;
							string text3 = string.Empty;
							string text4 = string.Empty;
							string text5 = string.Empty;
							try
							{
								text2 = B(item2.Descendants(@namespace + "source").FirstOrDefault()?.Value);
							}
							catch (Exception exception)
							{
								Log.Exception(exception, "TranslateXlfFile", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\StringResourcesTranslator\\StringResourcesTranslator.cs", 129);
							}
							XElement xElement4 = item2.Descendants(@namespace + "target").FirstOrDefault();
							if (xElement4 != null)
							{
								text5 = xElement4.Attribute("state").Value;
								text3 = B(xElement4.Value);
							}
							XElement xElement5 = item2.Descendants(@namespace + "note").FirstOrDefault();
							if (xElement5 != null)
							{
								text4 = B(xElement5.Value);
							}
							A(stringBuilder, text, text3, text4, text5);
							e2.A(text, text2, text4);
						}
					}
					while (stringBuilder[stringBuilder.Length - 1] != '}')
					{
						stringBuilder.Remove(stringBuilder.Length - 1, 1);
					}
					stringBuilder.AppendLine();
				}
			}
		}
		stringBuilder.AppendLine("}");
		string item = e2.A();
		return (stringBuilder.ToString(), item);
	}

	private static void A(StringBuilder P_0, string P_1, string P_2, string P_3, string P_4)
	{
		P_1 = a(P_1);
		P_2 = a(P_2);
		P_3 = a(P_3);
		P_4 = a(P_4);
		StringBuilder stringBuilder = P_0;
		StringBuilder stringBuilder2 = stringBuilder;
		StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 2, stringBuilder);
		handler.AppendLiteral("  \"");
		handler.AppendFormatted(P_1);
		handler.AppendLiteral("\": \"");
		handler.AppendFormatted(P_2);
		handler.AppendLiteral("\",");
		stringBuilder2.AppendLine(ref handler);
		stringBuilder = P_0;
		StringBuilder stringBuilder3 = stringBuilder;
		handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder);
		handler.AppendLiteral("  \"@");
		handler.AppendFormatted(P_1);
		handler.AppendLiteral("\": {");
		stringBuilder3.AppendLine(ref handler);
		stringBuilder = P_0;
		StringBuilder stringBuilder4 = stringBuilder;
		handler = new StringBuilder.AppendInterpolatedStringHandler(22, 1, stringBuilder);
		handler.AppendLiteral("    \"description\": \"");
		handler.AppendFormatted(P_3);
		handler.AppendLiteral("\",");
		stringBuilder4.AppendLine(ref handler);
		P_0.AppendLine("    \"type\": \"text\",");
		P_0.AppendLine("    \"placeholders\": {},");
		stringBuilder = P_0;
		StringBuilder stringBuilder5 = stringBuilder;
		handler = new StringBuilder.AppendInterpolatedStringHandler(15, 1, stringBuilder);
		handler.AppendLiteral("    \"state\": \"");
		handler.AppendFormatted(P_4);
		handler.AppendLiteral("\"");
		stringBuilder5.AppendLine(ref handler);
		P_0.AppendLine("  },");
		P_0.AppendLine();
	}

	private static string a(string P_0)
	{
		StringBuilder stringBuilder = new StringBuilder(P_0.Length);
		foreach (char c2 in P_0)
		{
			switch (c2)
			{
			case '/':
				stringBuilder.AppendFormat("{0}{1}", '\\', '/');
				break;
			case '\\':
				stringBuilder.AppendFormat("{0}{0}", '\\');
				break;
			case '"':
				stringBuilder.AppendFormat("{0}{1}", '\\', '"');
				break;
			default:
				stringBuilder.Append(c2);
				break;
			}
		}
		return stringBuilder.ToString();
	}

	private static string B(string P_0)
	{
		if (P_0 != null)
		{
			P_0 = P_0.Replace("\r", "\\r");
			P_0 = P_0.Replace("\n", "\\n");
		}
		return P_0;
	}

	private static string A(ISet<string> P_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("call flutter pub pub run intl_translation:extract_to_arb --output-dir=lib\\i18n\\ lib\\src\\strings.dart");
		stringBuilder.Append("call flutter pub pub run intl_translation:generate_from_arb --output-dir=lib/i18n --no-use-deferred-loading lib\\src\\strings.dart");
		foreach (string item in P_0)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder2);
			handler.AppendLiteral(" lib\\i18n\\");
			handler.AppendFormatted(item);
			stringBuilder2.Append(ref handler);
		}
		return stringBuilder.ToString();
	}
}
internal class e
{
	private const string m_A = "\r\nimport 'dart:async';\r\n\r\nimport 'package:intl/intl.dart';\r\nimport 'package:flutter/widgets.dart';\r\n\r\nimport '../i18n/messages_all.dart';\r\n\r\n// ignore_for_file: non_constant_identifier_names\r\nclass Strings {\r\n  Strings(Locale locale) : _localeName = locale.toString();\r\n\r\n  final String _localeName;\r\n\r\n  static Future<Strings> load(Locale locale) async {\r\n    await initializeMessages(locale.toString());\r\n    return Strings(locale);\r\n  }\r\n\r\n  static Strings of(BuildContext context) {\r\n    return Localizations.of<Strings>(context, Strings);\r\n  }\r\n<STRING_GETTERS>\r\n}\r\n";

	private readonly StringBuilder m_A = new StringBuilder();

	public void A(string P_0, string P_1, string P_2)
	{
		P_1 = A(P_1);
		P_2 = A(P_2);
		this.m_A.AppendLine();
		StringBuilder stringBuilder = this.m_A;
		StringBuilder stringBuilder2 = stringBuilder;
		StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(28, 1, stringBuilder);
		handler.AppendLiteral("  String ");
		handler.AppendFormatted(P_0);
		handler.AppendLiteral("() => Intl.message(");
		stringBuilder2.AppendLine(ref handler);
		stringBuilder = this.m_A;
		StringBuilder stringBuilder3 = stringBuilder;
		handler = new StringBuilder.AppendInterpolatedStringHandler(6, 1, stringBuilder);
		handler.AppendLiteral("    r");
		handler.AppendFormatted(P_1);
		handler.AppendLiteral(",");
		stringBuilder3.AppendLine(ref handler);
		stringBuilder = this.m_A;
		StringBuilder stringBuilder4 = stringBuilder;
		handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder);
		handler.AppendLiteral("    name: \"");
		handler.AppendFormatted(P_0);
		handler.AppendLiteral("\",");
		stringBuilder4.AppendLine(ref handler);
		stringBuilder = this.m_A;
		StringBuilder stringBuilder5 = stringBuilder;
		handler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder);
		handler.AppendLiteral("    desc: r");
		handler.AppendFormatted(P_2);
		handler.AppendLiteral(",");
		stringBuilder5.AppendLine(ref handler);
		this.m_A.AppendLine("    locale: _localeName");
		this.m_A.AppendLine("  );");
	}

	public string A()
	{
		string newValue = this.m_A.ToString();
		return "\r\nimport 'dart:async';\r\n\r\nimport 'package:intl/intl.dart';\r\nimport 'package:flutter/widgets.dart';\r\n\r\nimport '../i18n/messages_all.dart';\r\n\r\n// ignore_for_file: non_constant_identifier_names\r\nclass Strings {\r\n  Strings(Locale locale) : _localeName = locale.toString();\r\n\r\n  final String _localeName;\r\n\r\n  static Future<Strings> load(Locale locale) async {\r\n    await initializeMessages(locale.toString());\r\n    return Strings(locale);\r\n  }\r\n\r\n  static Strings of(BuildContext context) {\r\n    return Localizations.of<Strings>(context, Strings);\r\n  }\r\n<STRING_GETTERS>\r\n}\r\n".Replace("<STRING_GETTERS>", newValue);
	}

	[CompilerGenerated]
	internal static string A(string P_0)
	{
		string text = ((P_0.IndexOf("\"", StringComparison.InvariantCultureIgnoreCase) == -1) ? "\"" : ((P_0.IndexOf("'", StringComparison.InvariantCultureIgnoreCase) != -1) ? "\"\"\"" : "'"));
		return text + P_0 + text;
	}
}
