using UnityEngine;

namespace Borodar.WorkshopVR
{
    public class Crystal : MonoBehaviour
    {
        public void OnTriggerEnter(Collider other)
        {
            GameManager.Instance.CollectCrystal();
            Destroy(this.gameObject);
        }
    }
}
