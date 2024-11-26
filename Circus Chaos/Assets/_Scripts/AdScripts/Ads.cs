using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField]
    bool _testMode = true;
    IUnityAdsShowListener adsListener;
    public static bool isShowing;
    // Start is called before the first frame update
    void Start()
    {

        Advertisement.Initialize("SuaIDAqui", _testMode, this);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnInitializationComplete()
    {
        print("Inicializou");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        print("Deu ruim");
    }
}