using UnityEngine;

namespace RiyalCoin
{
    public class Hover : MonoBehaviour
    {
        [Header("Settings Switch")]
        [SerializeField]
        private bool useGlobal = true;
        
        [Header("Global Settings")]
        [SerializeField]
        private Settings.Hover settings;
        
        [Header("Local Settings")]
        [SerializeField]
        [Range(0.1f, 5f)]
        private float _speed = 1.3f;
        [SerializeField]
        [Range(0.1f, 2f)]
        private float _height = 1.0f;
        
        private Vector3 _startPos;
        
        private float speed => this.useGlobal ? this.settings.speed : this._speed;
        private float height => this.useGlobal ? this.settings.height : this._height;

        private void Start()
        {
            this._startPos = this.transform.position;
        }

        private void Update()
        {
            Vector3 v = this._startPos;
            v.y += this.height * Mathf.Sin(Time.time * this.speed);
            this.transform.position = v;
        }
    }
}