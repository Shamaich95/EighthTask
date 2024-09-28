using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public void Bind(Transform parentTransform, Transform position)
    {
        transform.SetParent(parentTransform);

        transform.localPosition = position.localPosition;

        transform.rotation = position.rotation;
    }

    protected void Unbind()
    {
        transform.SetParent(null);

        Collider collider = transform.GetComponent<Collider>();

        if (collider != null )
            Destroy(collider);
    }

    public abstract void ApplyEffect(Player player);

    public abstract void DestroyItem();
}
