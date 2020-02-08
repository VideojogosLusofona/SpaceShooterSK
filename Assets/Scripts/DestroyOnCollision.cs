using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class DestroyOnCollision : MonoBehaviour
{
    [Tag]
    new public string       tag;
    public GameObject       effect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((tag == collision.tag) || (tag == ""))
        {
            Destroy(gameObject);

            if (effect)
            {
                Instantiate(effect, transform.position, transform.rotation);
            }
        }
    }
}
