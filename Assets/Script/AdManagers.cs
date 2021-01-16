using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManagers : MonoBehaviour, IUnityAdsListener
{
    private static readonly string storeID = "3964154";



    private static readonly string videoID = "video";
#if UNITY_EDITOR
    private static bool testMood = true;
#else
    private static bool testMood = false;
#endif
    public static AdManagers instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this; ;
            Advertisement.AddListener(this);
            Advertisement.Initialize(storeID, testMood);
        }

    }


    public static void ShowStandardAd()
    {
        if (Advertisement.IsReady(videoID))
            Advertisement.Show(videoID);
    }
    public void OnUnityAdsDidError(string message)
    {
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
    }

    public void OnUnityAdsDidStart(string placementId)
    {
    }

    public void OnUnityAdsReady(string placementId)
    {
    }


}
