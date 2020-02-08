using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class DestroyOutsideArea: MonoBehaviour
{
    [Tag]
    public string areaTag;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == areaTag)
        {
            Destroy(gameObject);
        }
    }
}
