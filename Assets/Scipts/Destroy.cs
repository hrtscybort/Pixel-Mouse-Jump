using UnityEngine;

public class Destroy : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D other) {

        if (other.gameObject.name == "Platform")
        {
            Destroy(other.transform.root.gameObject);
        }
    }
}
