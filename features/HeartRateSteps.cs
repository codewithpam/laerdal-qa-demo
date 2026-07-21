using NUnit.Framework;
using Reqnroll;
[Binding]
public class HeartRateSteps
{
    private int _heartRate;
    private string _errorMessage;
    private bool _simulatorRunning;

    [Given("the simulator is running")]
    public void GivenSimulatorIsRunning()
    {
        _simulatorRunning = true;
        Assert.That(_simulatorRunning, Is.True);
    }

    [When("I set the heart rate to (.*)")]
    public void WhenISetHeartRate(int rate)
    {
        _heartRate = rate;
    }

    [Then("the monitor should display (.*) BPM")]
    public void ThenMonitorDisplays(int expected)
    {
        Assert.That(_heartRate, Is.EqualTo(expected));
    }

    [Then("the system should show an error message")]
    public void ThenShowError()
    {
        Assert.That(_heartRate, Is.GreaterThan(300),
            "Heart rate above maximum — error expected");
    }

    [Then("the patient status should show cardiac arrest")]
    public void ThenCardiacArrest()
    {
        Assert.That(_heartRate, Is.EqualTo(0),
            "Zero heart rate indicates cardiac arrest");
    }
}
