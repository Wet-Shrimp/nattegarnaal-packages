using UnityEngine;

namespace NatteGarnaal
{
    public abstract class PersistingSingleton<T> : Singleton<T> where T : MonoBehaviour
    {
        protected override void Awake()
        {
            base.Awake();

            if (Instance != this) { return; }

            transform.SetParent(null); // de-root in runtime
            DontDestroyOnLoad(gameObject);
        }
    }
}