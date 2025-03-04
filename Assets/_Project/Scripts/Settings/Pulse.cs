using UnityEngine;

namespace RiyalCoin.Settings
{
    [CreateAssetMenu(fileName = "PulseSettings", menuName = "Scriptable Objects/Settings/Pulse")]
    public class Pulse : ScriptableObject
    {
        [Range(1f, 10f)]
        public float speed = 1.5f;
        [Range(0.01f, 1f)]
        public float scale = 0.3f;
    }
}
