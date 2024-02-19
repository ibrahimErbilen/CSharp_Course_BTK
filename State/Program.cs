#region main

Context context = new Context();
ModifiedState modifiedState = new ModifiedState();

modifiedState.DoAction(context);

Console.WriteLine($"GetState : {context.GetState()}");

DeletedState deletedState = new DeletedState();
deletedState.DoAction(context);

Console.WriteLine($"GetState : {context.GetState()}");

#endregion

interface IState
{
    void DoAction(Context context);
}

class Context
{
    private IState _state;

    public void SetState(IState state)
    {
        _state = state;
    }

    public IState GetState()
    {
        return _state;
    }
}


class ModifiedState : IState
{
    private string _stateName => "Modified";
    public void DoAction(Context context)
    {
        Console.WriteLine($"State : {_stateName}");
        context.SetState(this);
    }

    public override string ToString()
    {
        return _stateName;
    }
}

class DeletedState : IState
{
    private string _stateName => "Deleted";
    public void DoAction(Context context)
    {
        Console.WriteLine($"State : {_stateName}");
        context.SetState(this);
    }

    public override string ToString()
    {
        return _stateName;
    }
}

class AddedState : IState
{
    private string _stateName => "Added";
    public void DoAction(Context context)
    {
        Console.WriteLine($"State : {_stateName}");
        context.SetState(this);
    }

    public override string ToString()
    {
        return _stateName;
    }
}
