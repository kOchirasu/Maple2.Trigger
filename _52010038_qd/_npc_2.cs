namespace Maple2.Trigger._52010038_qd {
    public static class _npc_2 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6202}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "GaugeStart") == 1) {
                    context.State = new Statenpc체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc체크 : TriggerState {
            internal Statenpc체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {1802})) {
                    context.State = new State이펙트(context);
                    return;
                }

                if (!context.MonsterInCombat(arg1: new[] {1802})) {
                    context.State = new State생성(context);
                    return;
                }

                if (context.GetUserValue(key: "GaugeClosed") == 1) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트 : TriggerState {
            internal State이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6202}, arg2: true);
            }

            public override void Execute() {
                if (!context.MonsterInCombat(arg1: new[] {1802})) {
                    context.State = new State생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6202}, arg2: false);
                context.InitNpcRotation(arg1: new[] {1802});
                context.CreateMonster(arg1: new[] {4000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statenpc체크(context);
                    return;
                }

                if (context.GetUserValue(key: "GaugeClosed") == 1) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}