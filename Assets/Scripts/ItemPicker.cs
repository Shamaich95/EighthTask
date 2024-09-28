using UnityEngine;

public class ItemPicker : MonoBehaviour
{
    private Player _player;
    private Item _currentItem = null;

    [SerializeField] private Transform _itemPoint;
    [SerializeField] private string _emptyItemmessage;
    [SerializeField] private KeyCode _useItem;

    private void Start()
    {
        _player = GetComponent<Player>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(_useItem))
            UseItem();
    }

    private void OnTriggerEnter(Collider other)
    {
        Item newItem = other.GetComponent<Item>();

        if (_currentItem == null && newItem != null)
        {
            _currentItem = newItem;

            _currentItem.Bind(transform, _itemPoint);
        }
    }

    private void UseItem()
    {
        if (_currentItem != null)
        {
            _currentItem.ApplyEffect(_player);

            _currentItem.DestroyItem();

            _currentItem = null;
        }
        else
        {
            Debug.Log(_emptyItemmessage);
        }
    }
}
