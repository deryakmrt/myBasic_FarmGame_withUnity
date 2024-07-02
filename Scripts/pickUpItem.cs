using UnityEngine;

//TESL�M ALMA KODU
public class pickUpItem : MonoBehaviour
{
    Transform player;
    [SerializeField] float speed = 5f; //nesne al�n�rken oyuncuya do�ru hareket etme h�z�
    [SerializeField] float pickUpDistance = 1.5f;
    [SerializeField] float ttl = 10f;

    public Item item;
    public int count = 1;

    private void Awake()
    {
        player = GameManager.instance.player.transform;
    }

    public void Set(Item item, int count)
    {
        this.item = item;
        this.count = count;

        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = item.icon;
    }
    private void Update()
    {
        ttl -= Time.deltaTime;
        if (ttl < 0)
        {
            Destroy(gameObject);
        }

        float distance = Vector3.Distance(transform.position, player.position); //oyuncu-nesne aras� mesafe
        if (distance > pickUpDistance)//oyuncu kar��lama mesafesinde mi?
        {
            return;
        }
        transform.position = Vector3.MoveTowards(
            transform.position,
            player.position,
            speed * Time.deltaTime);

        if (distance < 0.1f)
        // to do: burada kontrol edilmek yerine belirli bir denetleyiciye ta��nmal�d�r
        {
            if (GameManager.instance.inventoryContainer != null)
            {
                GameManager.instance.inventoryContainer.Add(item, count);
            }
            else
            {
                Debug.LogWarning("Oyun y�neticisine eklenmi� envanter yok");
            }
            Destroy(gameObject);
        }
    }
    
}
