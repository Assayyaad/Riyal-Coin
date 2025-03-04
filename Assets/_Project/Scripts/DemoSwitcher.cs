using UnityEngine;

namespace RiyalCoin
{
    public class DemoSwitcher : MonoBehaviour
    {
        [SerializeField]
        private Transform _demoHolder;
        
        [SerializeField]
        [Min(1)]
        private float _demoOffset = 50f;
        
        private int _demoCount = 0;
      
        private void Start()
        {
          this._demoCount = this._demoHolder.childCount - 1;
          this.Switch(0);
        }

        private void Update()
        {
          if (Input.GetKeyDown(KeyCode.RightArrow))
          {
            this.SwitchNext();
          }
          else if (Input.GetKeyDown(KeyCode.LeftArrow))
          {
            this.SwitchPrevious();
          }
        }
        
        [ContextMenu("Switch Next")]
        private void SwitchNext()
        {
          int index = (int)(this.transform.position.x / this._demoOffset) + 1;
          index = (int)Mathf.Min(this._demoCount, index);
          this.Switch(index);
        }
        
        [ContextMenu("Switch Previous")]
        private void SwitchPrevious()
        {
          int index = (int)(this.transform.position.x / this._demoOffset) - 1;
          index = (int)Mathf.Max(0, index);
          this.Switch(index);
        }
        
        private void Switch(int index)
        {
          Vector3 temp = this.transform.position;
          temp.x = index * this._demoOffset;
          this.transform.position = temp;
        }
        
        #if UNITY_EDITOR
        private void OnValidate()
        {
          this._demoCount = this._demoHolder.childCount - 1;
        }
        #endif
    }
}
