using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{

    public Animator frontAni;
    public Animator backAni;
    public GameObject juno;
    public GameObject JunoFront;
    private SpriteRenderer sr;

}

        /* float signedAngle = Vector2.SignedAngle(mainTransform.forward, Vector3.up);

        Vector2 animationDirection = new Vector2(0f, -1f);

        float angle = signedAngle;

        if (angle < backAngle)
        {
            animationDirection = new Vector2(0f, -1f);
        }
        else if (angle < sideAngle)
        {
            // right angle
            animationDirection = new Vector2(1f, 0f);
        }
        else
        {
            // front
            animationDirection = new Vector2(0f, 1f);
        }

        animator.SetFloat("moveX", animationDirection.x);
        animator.SetFloat("moveY", animationDirection.y);
} */

    // Update is called once per frame
    //    public void FixedUpdate()
    //    {
    //        if (juno.direction.move = -y) sr.show backAni etc
    //         transform.position += transform.forward
    //        if (Input.GetKey(KeyCode.W))
    //        {
    //            back sprite show
    //            JunoFront.SetActive(false);
    //            JunoSide.SetActive(false);
    //            JunoBack.SetActive(true);
    //        }
    //        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
    //        {
    //            show side sprite
    //            JunoFront.SetActive(false);
    //            JunoSide.SetActive(true);
    //            JunoBack.SetActive(false);
    //        }
    //        if (Input.GetKey(KeyCode.S))
    //        {
    //            show front sprite
    //            JunoBack.SetActive(false);
    //            JunoSide.SetActive(false);
    //            JunoFront.SetActive(true);

    //        }
    //    }
