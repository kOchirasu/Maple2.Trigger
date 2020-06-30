using System;

namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7010}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {110})) {
                    context.State = new Stateburn_state(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateburn_state : TriggerState {
            internal Stateburn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7502}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016,
                        5017, 5018, 5019, 5020, 5021, 5022, 5023, 5024, 5025, 5026
                    }, arg2: false, arg3: 800, arg4: 100, arg5: 0f);
                context.SetEventUI(arg1: 1, arg2: "$02010052_BF__TORCHLIGHT_02__0$", arg3: new int[] {3000});
                context.SetEffect(arg1: new int[] {7010}, arg2: true);
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
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}