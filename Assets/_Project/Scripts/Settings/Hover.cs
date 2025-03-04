using UnityEngine;

namespace RiyalCoin.Settings
{
    [CreateAssetMenu(fileName = "HoverSettings", menuName = "Scriptable Objects/Settings/Hover")]
    public class Hover : ScriptableObject
    {
        [Range(0.1f, 5f)]
        public float speed = 1.3f;
        [Range(0.1f, 2f)]
        public float height = 1.0f;
    }
}
