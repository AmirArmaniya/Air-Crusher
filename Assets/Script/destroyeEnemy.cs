using UnityEngine;

public class destroyeEnemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("rocket"))
        {
            Destroy(this.gameObject);
        }
    }
}
