namespace Quantum.HelloQ
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Add (a : Int, b : Int) : (Int)
    {
        body
        {
            return (a + b);
        }
    }
}
