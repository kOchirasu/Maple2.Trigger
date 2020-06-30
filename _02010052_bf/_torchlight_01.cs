using System;

namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {81001}, arg2: false);
                context.SetEffect(arg1: new int[] {81002}, arg2: false);
                context.SetEffect(arg1: new int[] {81003}, arg2: false);
                context.SetEffect(arg1: new int[] {81004}, arg2: false);
                context.SetEffect(arg1: new int[] {81005}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new Stateburn_state(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateburn_state : TriggerState {
            internal Stateburn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012},
                    arg2: false, arg3: 800, arg4: 100, arg5: 0f);
                context.SetEventUI(arg1: 1, arg2: "$02010052_BF__TORCHLIGHT_01__0$", arg3: new int[] {3000});
                context.SetEffect(arg1: new int[] {7001}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new Statespawn_state(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statespawn_state : TriggerState {
            internal Statespawn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 200);
                context.SetEffect(arg1: new int[] {7501}, arg2: true);
                context.SetEffect(arg1: new int[] {81001}, arg2: true);
                context.SetEffect(arg1: new int[] {81002}, arg2: true);
                context.SetEffect(arg1: new int[] {81003}, arg2: true);
                context.SetEffect(arg1: new int[] {81004}, arg2: true);
                context.SetEffect(arg1: new int[] {81005}, arg2: true);
                context.SetActor(arg1: 8101, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8102, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8103, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8104, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8105, arg2: false, arg3: "Dmg_A");
                context.CreateMonster(arg1: new int[] {311, 312, 313, 314, 315}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}