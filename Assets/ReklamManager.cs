using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class ReklamManager : MonoBehaviour
{
    public static ReklamManager instance;
    private string appID = "ca-app-pub-7566968370872281~3260110398"; 

    private BannerView bannerView;
    private string bannerID = "ca-app-pub-7566968370872281/7735376177";




    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void RequestBanner()
    {
        bannerView = new BannerView(bannerID, AdSize.Banner, AdPosition.Top);
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
        bannerView.Show();
    }

    public void HideBanner()
    {
        bannerView.Hide();
    }


}