using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using Firebase.Iid;

namespace xamarinFCM
{
    [Activity(Label = "xamarinFCM", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            if (!GetString(Resource.String.google_app_id).Equals("1:1041344326014:android:87b1fba527305236"))
                throw new System.Exception("Invalid Json file");

            Task.Run(() => {
                var instanceId = FirebaseInstanceId.Instance;
                instanceId.DeleteInstanceId();
                Android.Util.Log.Debug("TAG", "{0} {1}", instanceId.Token, instanceId.GetToken(GetString(Resource.String.gcm_defaultSenderId), Firebase.Messaging.FirebaseMessaging.InstanceIdScope));


            });
        }
    }
}

