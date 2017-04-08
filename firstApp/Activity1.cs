
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace firstApp
{
	[Activity(Label = "Activity1")]
	public class Activity1 : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			var geoUri = Android.Net.Uri.Parse("geo:37.819912, -122.477815");
			var mapIntent = new Intent(Intent.ActionView, geoUri);

				   StartActivity(mapIntent);
		}
	}
}
