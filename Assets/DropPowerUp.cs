using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPowerUp : MonoBehaviour
{
    public Transform powerUp;
    // Start is called before the first frame update
    void OnDestroy()
    {
        Instantiate(powerUp, transform.position, Quaternion.identity);
    }
}
