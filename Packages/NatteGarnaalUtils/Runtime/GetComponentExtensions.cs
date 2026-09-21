using UnityEngine;

namespace NatteGarnaal
{
    public static class GetComponentExtensions
    {
        public static bool TryGetComponentInChildren<T>(
            this GameObject gameObject,
            out T component
        ) where T : Component
        {
            component = gameObject.GetComponentInChildren<T>();
            return component != null;
        }

        public static bool TryGetComponentInChildren<T>(
            this Component component,
            out T result
        ) where T : Component
        {
            result = component.GetComponentInChildren<T>();
            return result != null;
        }

        public static bool TryGetComponentInParent<T>(
            this GameObject gameObject,
            out T component
        ) where T : Component
        {
            component = gameObject.GetComponentInParent<T>();
            return component != null;
        }

        public static bool TryGetComponentInParent<T>(
            this Component component,
            out T result
        ) where T : Component
        {
            result = component.GetComponentInParent<T>();
            return result != null;
        }
    }
}