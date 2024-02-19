using System;

public class RecordNotFoundException : Exception
{
    public RecordNotFoundException(string Message) : base(Message)
    {

    }
    // public string Message { get; set; } // when contructor does not exists
}
