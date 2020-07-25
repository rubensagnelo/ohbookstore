﻿namespace Application
{
	using System;


	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[System.Diagnostics.DebuggerNonUserCodeAttribute()]
	[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	internal class Messages
	{

		private static System.Resources.ResourceManager resourceMan;

		private static System.Globalization.CultureInfo resourceCulture;

		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		internal Messages()
		{
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (object.Equals(null, resourceMan))
				{
					System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Application.Messages", typeof(Messages).Assembly);
					resourceMan = temp;
				}
				return resourceMan;
			}
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static System.Globalization.CultureInfo Culture
		{
			get
			{
				return resourceCulture;
			}
			set
			{
				resourceCulture = value;
			}
		}

		internal static string AccountHasNotEnoughFunds
		{
			get
			{
				return ResourceManager.GetString("AccountHasNotEnoughFunds", resourceCulture);
			}
		}

		internal static string InputIsNull
		{
			get
			{
				return ResourceManager.GetString("InputIsNull", resourceCulture);
			}
		}

		internal static string CustomerAlreadyExists
		{
			get
			{
				return ResourceManager.GetString("CustomerAlreadyExists", resourceCulture);
			}
		}

		internal static string CustomerDoesNotExist
		{
			get
			{
				return ResourceManager.GetString("CustomerDoesNotExist", resourceCulture);
			}
		}

		internal static string AccountDoesNotExist
		{
			get
			{
				return ResourceManager.GetString("AccountDoesNotExist", resourceCulture);
			}
		}

		internal static string AccountHasFunds
		{
			get
			{
				return ResourceManager.GetString("AccountHasFunds", resourceCulture);
			}
		}
	}
}
