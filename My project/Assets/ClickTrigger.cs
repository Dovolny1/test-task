using UnityEngine;

public class ClickTrigger : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        if (anim)
        {
            anim.SetTrigger("Action");
        }
    }
}
