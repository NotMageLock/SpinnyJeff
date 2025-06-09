using BepInEx;
using UnityEngine;
using SamLib;
using UnityEngine.SceneManagement;

namespace SpinnyJeff
{
    [DefaultExecutionOrder(-50)]
    [BepInPlugin("com.magelock.spinnyjeff", "SpinnyJeff", "0.0.1")]
    [BepInDependency("com.magelock.samlib")]
    public class Plugin : BaseUnityPlugin
    {
        internal GameObject jeff;
        internal bool canThing = false;
        internal bool nuhuh = true;
        private void Awake()
        {
            Debug.Log("SpinnyJeff Init");
            SceneManager.sceneLoaded += ShopCheck;
            if (nuhuh)
            {
                SamLib.Plugin.Instance.AddMod("SpinnyJeff", "MageLock", "0.0.1", "com.magelock.spinnyjeff");
                nuhuh = false;
            }
        }

        private void ShopCheck(Scene scene, LoadSceneMode mode)
        {
            Debug.Log("Shop Check");
            if (scene.name == "Shop")
            {
                jeff = GameObject.Find("BEAD TRADER");
                Debug.Log(jeff);
                jeff.GetComponent<Animator>().enabled = false;
                canThing = true;
                jeff.AddComponent<Spinner>();
            }
        }
    }
}