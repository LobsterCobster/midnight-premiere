using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyaiJumpScare : MonoBehaviour
{
    public Animator enemyaiAnim;
    public GameObject player;
    public float jumpscareTime;
    public string sceneName;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            enemyaiAnim.ResetTrigger("idle");
            enemyaiAnim.ResetTrigger("walk");
            enemyaiAnim.ResetTrigger("run");
            enemyaiAnim.SetTrigger("jumpscare");
            StartCoroutine(jumpscare());
        }
    }

    IEnumerator jumpscare()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManager.LoadScene(sceneName);
    }
}