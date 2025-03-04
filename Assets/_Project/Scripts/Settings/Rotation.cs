using UnityEngine;

namespace RiyalCoin.Settings
{
    [CreateAssetMenu(fileName = "RotationSettings", menuName = "Scriptable Objects/Settings/Rotation")]
    public class Rotation : ScriptableObject
    {
        [Range(10, 100)]
        public float speed = 65.0f;
        
        [Tooltip("0 = X-Axis, 1 = Y-Axis, 2 = Z-Axis")]
        [Range(0, 2)]
        public int axis = 1;
    }
}
