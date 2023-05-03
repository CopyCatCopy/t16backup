using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interactor : MonoBehaviour
{
    [SerializeField] private Transform _interactionPoint;
    [SerializeField] private float _interactionPointRadius = 0.3f;
    [SerializeField] private LayerMask _interactableMask;

    private readonly Collider[] _colliders = new Collider[3];
    [SerializeField] private int _numFound;
    public GameObject obj;
    public float delayTime = 3f;

    void Start()
    {
        obj.SetActive(false);
    }

    private void Update()
    {
        _numFound = Physics.OverlapSphereNonAlloc(_interactionPoint.position, _interactionPointRadius, _colliders,
            _interactableMask);

        if (_numFound > 0)
        {
            var interactable = _colliders[0].GetComponent<IInteractable>();

            if(interactable != null && Input.GetKeyDown(KeyCode.F))
            {
                interactable.Interact(this);
                Debug.Log("Interacted!");
                Invoke("ConvoStart", delayTime);
            }

        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_interactionPoint.position, _interactionPointRadius);
    }

    public void ConvoStart()
    {
        obj.SetActive(true);
    }

}
