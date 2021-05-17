using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Android.Exoplayer2.Source.Ads
{
    public sealed partial class AdPlaybackState
    {
        public sealed partial class AdGroup
        {
			[Register("uris")]
			public IList<global::Android.Net.Uri> Uris
			{
				get
				{
					const string __id = "uris.[Landroid/net/Uri;";

					var __v = _members.InstanceFields.GetObjectValue(__id, this);
					return global::Android.Runtime.JavaArray<global::Android.Net.Uri>.FromJniHandle(__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					const string __id = "uris.[Landroid/net/Uri;";

					IntPtr native_value = global::Android.Runtime.JavaArray<global::Android.Net.Uri>.ToLocalJniHandle(value);
					try
					{
						_members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
					}
					finally
					{
						global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
					}
				}
			}

		}
	}
}
