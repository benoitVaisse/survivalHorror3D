using UnityEngine;

namespace survival_horror.Assets.Scripts
{
    public class LetterRayCast : MonoBehaviour, IRaysCastTrigger
    {
        public void OnRayCastEnter()
        {
            gameObject.GetComponent<Outline>().enabled = true;
        }

        public void OnRayCastExit()
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }
    }
}
