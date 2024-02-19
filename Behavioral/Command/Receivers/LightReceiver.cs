namespace Command.Receivers;

public class LightReceiver
{
    private string _state = "off";
    private int _brightness = 100;

    public void TurnOn() => _state= "on";
    
    public void TurnOff() => _state= "off";

    public void IncreaseBrightness()
    {
        _brightness += 10;

        _brightness = _brightness > 100 ? 100 : _brightness;
    }

    public void DecreaseBrightness()
    {
        _brightness -= 10;

        _brightness = _brightness < 0 ? 0 : _brightness;
    }

    public int GetBrightness() => _brightness;
    public string GetState() => _state;
}
