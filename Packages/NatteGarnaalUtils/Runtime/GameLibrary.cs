using UnityEngine;

namespace NatteGarnaal
{
    public abstract class GameLibrary<T> : ScriptableObject where T : ScriptableObject
    {
        static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    string path = $"Libraries/{typeof(T).Name}";
                    instance = Resources.Load<T>(path);

                    if (instance == null)
                    {
                        Debug.LogError($"GameLibrary: Could not find {typeof(T).Name} in Assets/Resources/Libraries.");
                    }
                }

                return instance;
            }
        }

        public static bool Exists => Instance != null;
    }
}