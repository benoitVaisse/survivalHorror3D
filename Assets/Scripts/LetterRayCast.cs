using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

namespace survival_horror.Assets.Scripts
{
    public class LetterRayCast : MonoBehaviour, IRaysCastTrigger
    {
        private bool _isEnabledOutline;
        private bool _reading;
        public void OnRayCastEnter()
        {
            gameObject.GetComponent<Outline>().enabled = true;
            _isEnabledOutline = true;
        }

        public void OnRayCastExit()
        {
            gameObject.GetComponent<Outline>().enabled = false;
            _isEnabledOutline = false;
        }


        private void Update()
        {
            if (_isEnabledOutline && !_reading && Input.GetKeyUp(KeyCode.E))
            {
                _reading = !_reading;
                LetterProperties properties = gameObject.GetComponent<LetterProperties>();
                LetterManager.Instance.GetLetterTextPanel().SetActive(true);
                StartCoroutine(DislayText(properties.text));
            }
            else if (_reading && Input.GetKeyUp(KeyCode.E))
            {
                LetterManager.Instance.GetLetterTextUI().text = string.Empty;
                LetterManager.Instance.GetLetterTextPanel().SetActive(false);
                _reading = !_reading;
            }
        }

        IEnumerator DislayText(string text)
        {
            TextMeshProUGUI textMeshPro = LetterManager.Instance.GetLetterTextUI();
            List<char> textSliced = text.ToList();
            string final = string.Empty;
            foreach (char c in textSliced)
            {
                final += c;
                yield return new WaitForSeconds(0.1f);
                textMeshPro.SetText(final);
            }
        }
    }
}
