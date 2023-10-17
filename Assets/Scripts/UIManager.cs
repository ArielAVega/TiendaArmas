using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{   
    // Implementación del patron de Diseño Singleton
    private static UIManager instance;

    private TextMeshProUGUI weaponNameText;
    private TextMeshProUGUI descriptionText;
    private TextMeshProUGUI costText;
    private TextMeshProUGUI damageText;

    public static UIManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<UIManager>();
            }
            return instance;
        } 
    }
    
    private void Start()
    {
        //weaponNameText= GameObject.FindGameObjectWithTag("WeaponNameText").GetComponent<TextMeshProUGUI>();
       weaponNameText = GameObject.Find("WeaponNameText").GetComponent<TextMeshProUGUI>();
       descriptionText =GameObject.Find("DescriptionText").GetComponent<TextMeshProUGUI>();
       costText = GameObject.Find("CostText").GetComponent<TextMeshProUGUI>();
       damageText = GameObject.Find("DamageText").GetComponent<TextMeshProUGUI>();
    }
    
    public void UpdateUI(WeaponData weaponData)
    {
        weaponNameText.text = weaponData.WeaponName;
        descriptionText.text = weaponData.Description;
        costText.text = weaponData.Cost.ToString();
        damageText.text = weaponData.Damage.ToString();
    }
}
