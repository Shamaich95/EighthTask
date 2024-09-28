using UnityEngine;

public class SpeedItem : Item
{
    [SerializeField] private float _speedIncrease;
    [SerializeField] private float _destroyDelay;

    public override void DestroyItem()
    {
        Destroy(gameObject, _destroyDelay);
    }

    public override void ApplyEffect(Player player)
    {
        player.Mover.IncreaseMovementSpeed(_speedIncrease);
    }
}
