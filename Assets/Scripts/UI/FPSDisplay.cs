using TMPro;
using UnityEngine;

namespace survival_horror.Assets.Scripts.UI
{
    public class FPSDisplay : MonoBehaviour
    {
        public TextMeshProUGUI FpsText;

        private float _pollongTime = 1f;
        private float _time;
        private int _framecount;

        private void Start()
        {
            Application.targetFrameRate = 300;
        }
        private void Update()
        {
            _time += Time.deltaTime;
            _framecount++;
            if (_time > _pollongTime)
            {
                int frameRate = Mathf.RoundToInt(_framecount / _time);
                FpsText.text = $"{frameRate.ToString()} FPS";
                _time -= _pollongTime;
                _framecount = 0;
            }
        }
    }
}
