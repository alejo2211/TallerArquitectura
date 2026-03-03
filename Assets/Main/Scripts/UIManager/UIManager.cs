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
    private PowerUpType selectedPowerUp;// Esta variable guarda qué power-up está elegido actualmente.

    [SerializeField] private TMP_Text messageText;

    [SerializeField] private TMP_InputField inputField;

  

    public void SeleccionVida()
    {
        SeleccionPowerUp(PowerUpType.Heal);
    }
    public void SeleccionVelocidad()
    {
        SeleccionPowerUp(PowerUpType.SpeedBoost);
    }
    public void SeleccionEscudo()
    {
        SeleccionPowerUp(PowerUpType.Shield);
    }
    public void SeleccionDaño()
    {
       SeleccionPowerUp (PowerUpType.DamageBoost);
    }
    private void SeleccionPowerUp(PowerUpType type) // Aqui solo guarda el enum, solo se actualiza texto
    {
        selectedPowerUp = type;
        messageText.text = "Seleccionado" + type.ToString();
    }





}
