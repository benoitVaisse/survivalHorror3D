using System.Collections;
using UnityEngine;

namespace survival_horror.Assets.Scripts
{
    public class EnableObjectAfterSecond : MonoBehaviour
    {
        public int second;
        public GameObject objectToEnabled;

        public void Start()
        {
            StartCoroutine(EnabledObject());
        }

        IEnumerator EnabledObject()
        {
            yield return new WaitForSeconds(second);
            objectToEnabled.SetActive(true);
        }
    }
}
