namespace Maple2.Trigger._02000348_bf {
    public static class _cage_01 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2101}, arg2: false, arg3: 0, arg4: 10);
                context.SetEffect(arg1: new[] {8001}, arg2: false);
                context.SetActor(arg1: 2201, arg2: false, arg3: "Sit_Ground_Idle_A");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "cage_01") == 1) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2101}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {8001}, arg2: true);
                context.SetActor(arg1: 2201, arg2: true, arg3: "Sit_Ground_Idle_A");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {211})) {
                    context.State = new Statenpc(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc : TriggerState {
            internal Statenpc(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8001}, arg2: false);
                context.SetMesh(arg1: new[] {2101}, arg2: false, arg3: 0, arg4: 10);
                context.SetActor(arg1: 2201, arg2: false, arg3: "Dead_A");
                context.CreateMonster(arg1: new[] {221}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {221});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}