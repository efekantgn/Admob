
using GoogleMobileAds.Api;
using UnityEngine;
namespace Efekan.Ads.Admob
{
    public abstract class AdmobMobileAds : MonoBehaviour
    {
        public virtual void Start()
        {
            // Initialize the Google Mobile Ads SDK.
            MobileAds.Initialize(initStatus => { });
        }
    }
}

