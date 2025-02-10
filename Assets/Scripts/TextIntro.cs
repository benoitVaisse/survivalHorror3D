using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

namespace survival_horror.Assets.Scripts
{
    public class TextIntro : MonoBehaviour
    {
        [SerializeField]
        private string text;
        public TextMeshProUGUI textMeshPro;
        // Start is called before the first frame update
        void Start()
        {
            text = "Vous arrivez au manoir des Croft. Vous devez enquêter sur la disparition du majordhome. \nPartez à la recherche d'indice dans ce vieu manoir abandonné.";

            StartCoroutine(DislayText());

        }

        IEnumerator DislayText()
        {
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
