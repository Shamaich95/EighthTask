using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> _spawnPoints;

    [SerializeField] private List<Item> _items;

    private void Start()
    {
        foreach (Transform point in _spawnPoints)
        {
            Item item = _items[Random.Range(0, _items.Count)];

            Instantiate(item, point.position, Quaternion.identity);
        }
    }
}
