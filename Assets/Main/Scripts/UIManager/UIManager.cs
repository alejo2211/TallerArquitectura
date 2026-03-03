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

    private PlayerStats playerStats;

  

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
    private bool ValidarReferencias()
    {
        if (playerStats == null)
        {
            messageText.text = "Error: PlayerStatsno asignado";
            return false;
        }
        if (inputField == null)
        {
            messageText.text = "Error: Input no asginado";
            return false;

        }
        if (messageText == null)
        {
            Debug.Log("Mensaje de texto no asignado en el inspector");
            return false;

        }
        return true;

    }
    public void AplicarPowerUpSeleccionado()
    {
        if (!ValidarReferencias()) return;
        if (!TryReadValue(out float value)) return;
      
    }
    private bool TryReadValue(out float value)
    {
        value = 0f;

        if (string.IsNullOrWhiteSpace(inputField.text))
        {
            messageText.text = "Ingrese un valor.";
            return false;
        }

        if (!float.TryParse(inputField.text, out value))
        {
            messageText.text = "Ingrese un número válido.";
            return false;
        }

        return true;
    }





}
