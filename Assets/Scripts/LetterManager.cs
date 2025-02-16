using TMPro;
using UnityEngine;

namespace survival_horror.Assets.Scripts
{
    public sealed class LetterManager : MonoBehaviour
    {
        private LetterManager()
        {
        }
        [SerializeField]
        private GameObject panel;

        private void Awake()
        {
            panel = GameObject.Find("PanelAnalyse");
            panel.SetActive(false);
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Debug.Log("aother instance log");
                Destroy(this);
            }
        }

        public static LetterManager Instance;

        public void SeeLetter(string letter)
        {
            TextMeshProUGUI textMeshPro = GetLetterTextUI();
            textMeshPro.text = letter;
        }


        public TextMeshProUGUI GetLetterTextUI() => panel.transform.Find("TextLetter")?.GetComponent<TextMeshProUGUI>();
        public GameObject GetLetterTextPanel() => panel;

    }
}
