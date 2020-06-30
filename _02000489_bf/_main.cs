using System;

namespace Maple2.Trigger._02000489_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateready(context);

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {6001}, arg2: false);
                context.SetMesh(arg1: new int[] {6002}, arg2: false);
                context.SetMesh(arg1: new int[] {6003}, arg2: false);
                context.SetMesh(arg1: new int[] {6004}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "702")) {
                    context.State = new Statechaos_raid(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statechaos_raid : TriggerState {
            internal Statechaos_raid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {402}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "ExitPortal", value: 1)) {
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