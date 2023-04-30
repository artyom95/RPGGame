using UnityEngine;
using UnityEngine.AI;

public class AnimatorController : MonoBehaviour
{
    private static readonly int Speed = Animator.StringToHash("speed");
    private Animator _animator;
    private NavMeshAgent _navMeshAgent;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        _animator.SetFloat(Speed, _navMeshAgent.velocity.magnitude);
    }
}