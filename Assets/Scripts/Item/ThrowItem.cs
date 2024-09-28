using UnityEngine;

public class ThrowItem : Item
{
    [SerializeField] private float _destroyDelay;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public override void DestroyItem()
    {
        Unbind();

        Destroy(gameObject, _destroyDelay);
    }

    public override void ApplyEffect(Player player)
    {
        _rigidbody.AddForce(transform.forward * player.ThrowingForce, ForceMode.Impulse);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Ray r = new Ray(transform.position, transform.forward);

        Gizmos.DrawRay(r);
    }
}
