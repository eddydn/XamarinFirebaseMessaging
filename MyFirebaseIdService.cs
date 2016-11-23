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
using Firebase.Iid;

namespace xamarinFCM
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT"})]
    class MyFirebaseIdService:FirebaseInstanceIdService
    {

        public override void OnTokenRefresh()
        {
            base.OnTokenRefresh();
            Android.Util.Log.Debug("Refreshed Token:", FirebaseInstanceId.Instance.Token);
        }
    }
}