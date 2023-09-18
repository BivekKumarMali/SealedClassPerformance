namespace SealedClassPerformance
{
    public class BaseClass
    {
        public virtual void ExampleVoidMethod() { }
        public virtual int ExampleIntMethod() => 69;
    }

    public class OpenClass : BaseClass
    {

        public override void ExampleVoidMethod() { }
        public override int ExampleIntMethod() => 70;
    }
    public sealed class SealedClass : BaseClass
    {

        public override void ExampleVoidMethod() { }
        public override int ExampleIntMethod() => 00;
    }
}