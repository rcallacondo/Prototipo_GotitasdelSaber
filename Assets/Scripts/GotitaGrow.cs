using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotitaGrow : MonoBehaviour
{
    // Start is called before the first frame update
    public GotitaTail gotitaTail;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            Destroy(other.gameObject, 0.02f);
            gotitaTail.AddTail();
        }
    }
}
