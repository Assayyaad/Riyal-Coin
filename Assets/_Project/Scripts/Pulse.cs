using UnityEngine;

namespace RiyalCoin
{
    public class Pulse : MonoBehaviour
    {
        [Header("Settings Switch")]
        [SerializeField]
        private bool useGlobal = true;

        [Header("Global Settings")]
        [SerializeField]
        private Settings.Pulse settings;

        [Header("Local Settings")]
        [SerializeField]
        [Range(1f, 10f)]
        public float _speed = 1.5f;
        [SerializeField]
        [Range(0.01f, 0.7f)]
        public float _scale = 0.3f;

        private Vector3 _startScale;

        private float speed => this.useGlobal ? this.settings.speed : this._speed;
        private float scale => this.useGlobal ? this.settings.scale : this._scale;

        private void Start()
        {
            this._startScale = this.transform.localScale;
        }

        private void Update()
        {
            float s = this._startScale.x;
            s += this.scale * Mathf.Sin(Time.time * this.speed);
            //s = Mathf.Max(this._startScale.x, s);
            // s += 1;
            this.transform.localScale = Vector3.one * s;
        }
    }
}