using UnityEngine;

namespace survival_horror.Assets.Scripts
{
    public class CamRayCast : MonoBehaviour
    {
        private GameObject _hitObject;
        private void FixedUpdate()
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, 1f))
            {
                IRaysCastTrigger raysCastTrigger = hitInfo.transform.gameObject.GetComponent<IRaysCastTrigger>();
                if (raysCastTrigger != null)
                {
                    _hitObject = hitInfo.transform.gameObject;
                    raysCastTrigger.OnRayCastEnter();
                }
            }
            else
            {
                if (_hitObject != null)
                {
                    _hitObject.GetComponent<IRaysCastTrigger>()?.OnRayCastExit();
                    _hitObject = null;
                }
            }
        }
    }

}
