using System.Collections;
using UnityEngine;

namespace survival_horror.Assets.Scripts
{
    public class DisabledObjectAfterSecond : MonoBehaviour
    {

        public int second;
        public GameObject objectToDisabled;

        public void Start()
        {
            StartCoroutine(DisabledObject());
        }

        IEnumerator DisabledObject()
        {
            yield return new WaitForSeconds(second);
            objectToDisabled.SetActive(false);
        }
    }
}
