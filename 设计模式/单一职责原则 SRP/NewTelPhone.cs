using 单一职责原则_SRP.Interfaces;

namespace 单一职责原则_SRP;

public class NewTelPhone
{
    public NewTelPhone(IDial dial, IHangUp hangUp)
    {
        _dial = dial;
        _hangUp = hangUp;
    }

    private readonly IDial _dial;

    private readonly IHangUp _hangUp;


    public void DialPhoneNumber(string PhoneNumber)
    {
        _dial.Dial(PhoneNumber);
    }
}
