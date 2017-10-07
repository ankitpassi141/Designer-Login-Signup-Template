package md5e45d223d5b50a1773f425a8ae55fc5a6;


public class Mockup2_LoginScreen
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onBackPressed:()V:GetOnBackPressedHandler\n" +
			"";
		mono.android.Runtime.register ("Mockup01.Mockup2_LoginScreen, Mockup01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Mockup2_LoginScreen.class, __md_methods);
	}


	public Mockup2_LoginScreen () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Mockup2_LoginScreen.class)
			mono.android.TypeManager.Activate ("Mockup01.Mockup2_LoginScreen, Mockup01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onBackPressed ()
	{
		n_onBackPressed ();
	}

	private native void n_onBackPressed ();

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
