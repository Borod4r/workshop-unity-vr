using UnityEngine;

namespace Borodar.WorkshopVR
{
    public class Collectible : MonoBehaviour
    {
        public void OnTriggerEnter(Collider other)
        {
            Destroy(this.gameObject);
        }
    }
}
