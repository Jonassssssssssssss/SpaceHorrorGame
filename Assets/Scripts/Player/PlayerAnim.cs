using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    [SerializeField] Animator _anim;

    public void SwitchAnim(string animName)
    {
        _anim.SetTrigger(animName);
    }
}
