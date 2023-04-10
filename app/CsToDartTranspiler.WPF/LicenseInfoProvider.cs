using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using CsToDartTranspiler.WPF.Properties;
using KineApps.Common.Diagnostics;
using Windows.Services.Store;
using WinRT.Interop;

namespace CsToDartTranspiler.WPF;

internal class LicenseInfoProvider
{
	public const string ProductId = "9P5BNFRSMQ00";

	private const string ProStoreID = "9MZ1CN3QQZVX";

	private static StoreContext storeContext;

	public static bool IsPro => Settings.Default.License == "9MZ1CN3QQZVX";

	public static async Task GetLicenseInfoAsync(IntPtr hwnd)
	{
		if (storeContext == null)
		{
			storeContext = StoreContext.GetDefault();
			InitializeWithWindow.Initialize(storeContext, hwnd);
		}
		List<string> productKinds = new List<string>(new string[1] { "Durable" });
		StoreProductQueryResult storeProductQueryResult = await storeContext.GetStoreProductsAsync(productKinds, new string[1] { "9MZ1CN3QQZVX" });
		if (storeProductQueryResult.ExtendedError != null)
		{
			Log.Error("ExtendedError: " + storeProductQueryResult.ExtendedError.Message, "GetLicenseInfoAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler.WPF\\LicenseInfoProvider.cs", 52);
			return;
		}
		foreach (KeyValuePair<string, StoreProduct> product in storeProductQueryResult.Products)
		{
			StoreProduct value = product.Value;
			if (value.StoreId == "9MZ1CN3QQZVX" && value.IsInUserCollection)
			{
				Settings.Default.License = "9MZ1CN3QQZVX";
				Settings.Default.Save();
			}
		}
	}

	public static async Task PurchaseAsync(Window parentWindow)
	{
		IntPtr hWnd = new WindowInteropHelper(parentWindow).EnsureHandle();
		try
		{
			_ = 1;
			try
			{
				await GetLicenseInfoAsync(hWnd);
				if (!IsPro)
				{
					StorePurchaseResult storePurchaseResult = await storeContext.RequestPurchaseAsync("9MZ1CN3QQZVX");
					string text = string.Empty;
					if (storePurchaseResult.ExtendedError != null)
					{
						text = storePurchaseResult.ExtendedError.Message;
					}
					string text2;
					switch (storePurchaseResult.Status)
					{
					case StorePurchaseStatus.Succeeded:
						text2 = "The purchase was successful.";
						Settings.Default.License = "9MZ1CN3QQZVX";
						Settings.Default.Save();
						break;
					case StorePurchaseStatus.AlreadyPurchased:
						text2 = "You have already purchased the product.";
						Settings.Default.License = "9MZ1CN3QQZVX";
						Settings.Default.Save();
						break;
					case StorePurchaseStatus.NotPurchased:
						text2 = "The purchase did not complete (" + text + ").";
						break;
					case StorePurchaseStatus.NetworkError:
						text2 = "The purchase was unsuccessful due to a network error (" + text + ").";
						break;
					case StorePurchaseStatus.ServerError:
						text2 = "The purchase was unsuccessful due to a server error (" + text + ").";
						break;
					default:
						text2 = "The purchase was unsuccessful due to an unknown error (" + text + ").";
						break;
					}
					if (text2 != null)
					{
						text2 = text2.Replace(" ()", string.Empty);
						MessageBox.Show(parentWindow, text2, "Purchase", MessageBoxButton.OK, (storePurchaseResult.Status == StorePurchaseStatus.Succeeded || storePurchaseResult.Status == StorePurchaseStatus.AlreadyPurchased) ? MessageBoxImage.Asterisk : MessageBoxImage.Hand);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(parentWindow, ex.Message, "Purchase", MessageBoxButton.OK, MessageBoxImage.Hand);
			}
		}
		finally
		{
			await GetLicenseInfoAsync(hWnd);
		}
	}
}
