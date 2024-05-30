
public abstract class AbstractBaseClassObject
{
    internal virtual int MyProperty { get; private set; }
    public virtual int MyProperty2 { get; private set; }
    //extern int MyProperty3 { get; }
    public int MyProperty4 { get; private set; }
    public virtual void Func1()
    {
        throw new NotImplementedException();
    }

    public virtual void Func1(string text, int a, int b)
    {
        throw new NotImplementedException();
    }
}