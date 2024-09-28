using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private int _health;
    [SerializeField] private KeyCode _showStats;

    private ItemPicker _itemPicker;

    public Mover Mover { get; private set; }
    [field: SerializeField] public int ThrowingForce { get; private set; }

    private void Start()
    {
        Mover = new Mover(transform, _movementSpeed, _rotationSpeed);

        _itemPicker = GetComponent<ItemPicker>();
    }

    private void Update()
    {
        Mover.ProcessMove();

        if (Input.GetKeyDown(_showStats))
            ShowStats();
    }

    public void IncreaseHealth(int healthIncrease)
    {
        _health += healthIncrease;
    }

    private void ShowStats()
    {
        Debug.Log($"Текущее здоровье - {_health}");
        Debug.Log($"Текущая скорость - {Mover.MovementSpeed}");
    }
}
