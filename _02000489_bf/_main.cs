namespace Maple2.Trigger._02000489_bf {
    public static class _main {
        public class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {702})) {
                    context.State = new Statechaos_raid(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statechaos_raid : TriggerState {
            internal Statechaos_raid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {402}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ExitPortal") == 1) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}