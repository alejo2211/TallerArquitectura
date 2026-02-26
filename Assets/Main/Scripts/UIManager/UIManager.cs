using UnityEngine;
using TMPro;
using UnityEditorInternal;

public class UIManager : MonoBehaviour
{
    public enum PowerUpType
    {
        Heal,
        SpeedBoost,
        Shield,
        DamageBoost
    }
    private PowerUpType powerUpType;

    [SerializeField] private TMP_Text selectedPowerUpText;

    public PowerUpType currentSelectedPowerUp;

    public void SelectPowerUp(PowerUpType _powerup)
    {
       powerUpType = _powerup;
    }
    public void Heal()
    {
        powerUpType = PowerUpType.Heal;
    }
    public void SpeedBoost()
    {
        powerUpType = PowerUpType.SpeedBoost;
    }
    public void Shield()
    {
        powerUpType = PowerUpType.Shield;  
    }
    public void DamageBoost()
    {
        powerUpType = PowerUpType.DamageBoost;
    }



    public void UpdateUI()
    {

        switch (powerUpType)
        {
            case PowerUpType.Heal:
            default:
                break;
        }

    }

}
