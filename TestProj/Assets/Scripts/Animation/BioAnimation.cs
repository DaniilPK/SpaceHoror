using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BioAnimation : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private IEnumerator OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            Debug.Log("+");
            animator.SetTrigger("Run");
            yield return new WaitForSeconds(2);
            animator.SetTrigger("Walk");
            animator.ResetTrigger("Run");
        }
    }

   /* IEnumerator Trg() {
        Debug.Log("-");
        // yield return new WaitForSeconds(2);
        yield return null;
        animator.SetTrigger("Walk");
    }*/

}
