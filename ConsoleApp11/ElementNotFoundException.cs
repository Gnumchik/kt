class ElementNotFoundException : Exception
{
    public override string Message { get; }

    public ElementNotFoundException()
    {
        Message = "Ошибочка";
    }
}