package md53b609913f6d97b57a9b1336385b137e0;


public class MyFirebaseIdService
	extends com.google.firebase.iid.FirebaseInstanceIdService
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTokenRefresh:()V:GetOnTokenRefreshHandler\n" +
			"";
		mono.android.Runtime.register ("xamarinFCM.MyFirebaseIdService, xamarinFCM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MyFirebaseIdService.class, __md_methods);
	}


	public MyFirebaseIdService () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MyFirebaseIdService.class)
			mono.android.TypeManager.Activate ("xamarinFCM.MyFirebaseIdService, xamarinFCM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onTokenRefresh ()
	{
		n_onTokenRefresh ();
	}

	private native void n_onTokenRefresh ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
