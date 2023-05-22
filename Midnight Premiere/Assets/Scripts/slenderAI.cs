using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slenderAI : MonoBehaviour
{
    public Transform dest1, dest2, dest3, dest4, dest5, dest6, dest7, dest8, player;
    private bool teleporting = true;
    public float teleportRate;
    int randNum;

    void Start()
    {
        StartCoroutine(teleport());
    }

    void Update()
    {
        this.transform.LookAt(new Vector3(player.position.x, this.transform.position.y, player.position.z));
    }

    IEnumerator teleport()
    {
        while (teleporting == true)
        {
            yield return new WaitForSeconds(teleportRate);
            randNum = Random.Range(0, 8);
            if (randNum == 0)
            {
                this.transform.position = dest1.position;
            }
            if (randNum == 1)
            {
                this.transform.position = dest2.position;
            }
            if (randNum == 2)
            {
                this.transform.position = dest3.position;
            }
            if (randNum == 3)
            {
                this.transform.position = dest4.position;
            }
            if (randNum == 4)
            {
                this.transform.position = dest5.position;
            }
            if (randNum == 5)
            {
                this.transform.position = dest6.position;
            }
            if (randNum == 6)
            {
                this.transform.position = dest7.position;
            }
            if (randNum == 7)
            {
                this.transform.position = dest8.position;
            }
        }
    }
}
