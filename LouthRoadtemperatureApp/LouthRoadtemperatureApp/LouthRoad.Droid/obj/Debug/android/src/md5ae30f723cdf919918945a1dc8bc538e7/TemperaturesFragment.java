package md5ae30f723cdf919918945a1dc8bc538e7;


public class TemperaturesFragment
	extends android.app.ListFragment
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("LouthRoad.Droid.TemperaturesFragment, LouthRoad.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", TemperaturesFragment.class, __md_methods);
	}


	public TemperaturesFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TemperaturesFragment.class)
			mono.android.TypeManager.Activate ("LouthRoad.Droid.TemperaturesFragment, LouthRoad.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
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
