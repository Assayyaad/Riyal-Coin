using UnityEngine;

namespace RiyalCoin
{
    public class Rotation : MonoBehaviour
    {
        [Header("Settings Switch")]
        [SerializeField]
        private bool useGlobal = true;
        
        [Header("Global Settings")]
        [SerializeField]
        private Settings.Rotation settings;
        
        [Header("Local Settings")]
        [SerializeField]
        [Range(10, 100)]
        private float _speed = 65.0f;
        
        [SerializeField]
        [Tooltip("0 = X-Axis, 1 = Y-Axis, 2 = Z-Axis")]
        [Range(0, 2)]
        private int _axis = 1;
        
        private float speed => this.useGlobal ? this.settings.speed : this._speed;
        private int axis => this.useGlobal ? this.settings.axis : this._axis;
        
        private void Update()
        {
            Vector3 v = Vector3.zero;
            v[this.axis] += 1;
            this.transform.Rotate(v, this.speed * Time.deltaTime, Space.World);
        }
    }
}