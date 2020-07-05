# Maple2.Trigger ([nuget](https://www.nuget.org/packages/Maple2.Trigger/))
Xml.m2d trigger scripts converted to C#

To use these scripts, you will have to implement `ITriggerContext` for functionality.

### Basic Script Runner
```C#
public class TriggerScript {
    private readonly TriggerContext context;

    private TriggerState state;
    private TriggerState nextState;

    public TriggerScript(TriggerContext context, TriggerState start) {
        this.context = context;
        this.nextState = start;
    }

    public void Next() {
        if (Environment.TickCount < context.NextTick) return;
        context.NextTick = Environment.TickCount + context.TickDelay;

        if (nextState != null) {
            state?.OnExit();
            state = nextState;
            state.OnEnter();
            nextState = null;
        }

        nextState = state.Execute();
    }
}
```
