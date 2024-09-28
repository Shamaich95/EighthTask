using UnityEngine;

public class HealthItem : Item
{
    [SerializeField] private int _healthIncrease;
    [SerializeField] private float _destroyDelay;

    public override void DestroyItem()
    {
        Destroy(gameObject, _destroyDelay);
    }

    public override void ApplyEffect(Player player)
    {
        player.IncreaseHealth(_healthIncrease);
    }
}
