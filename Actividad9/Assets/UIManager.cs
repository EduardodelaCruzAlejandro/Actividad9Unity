using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text weaponNameText;
    [SerializeField] private Text descriptionText;
    [SerializeField] private Text costText;
    [SerializeField] private Text damageText;

    private static UIManager instance;

    public static UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<UIManager>();
            }
            return instance;
        }
    }

    public void UpdateUI(WeaponData weaponData)
    {
        weaponNameText.text = weaponData.WeaponName;
        descriptionText.text = weaponData.Description;
        costText.text = weaponData.Cost.ToString();
        damageText.text = weaponData.Damage.ToString();
    }

    public void HighLightWeapon(Weapon weaponToHighlight)
    {
        Weapon[] weapons = FindObjectsOfType<Weapon>();
        foreach (Weapon weapon in weapons)
        {
            weapon.GetComponent<SpriteRenderer>().color = Color.white;
        }

        weaponToHighlight.GetComponent<SpriteRenderer>().color = Color.green;
    }
}
