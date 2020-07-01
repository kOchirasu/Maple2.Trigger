namespace Maple2.Trigger._52010038_qd {
    public static class _npc_3 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6203}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "GaugeStart") == 1) {
                    return new Statenpc체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statenpc체크 : TriggerState {
            internal Statenpc체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {1803})) {
                    return new State이펙트(context);
                }

                if (!context.MonsterInCombat(arg1: new[] {1803})) {
                    return new State생성(context);
                }

                if (context.GetUserValue(key: "GaugeClosed") == 1) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트 : TriggerState {
            internal State이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6203}, arg2: true);
            }

            public override TriggerState Execute() {
                if (!context.MonsterInCombat(arg1: new[] {1803})) {
                    return new State생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6203}, arg2: false);
                context.InitNpcRotation(arg1: new[] {1803});
                context.CreateMonster(arg1: new[] {4000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statenpc체크(context);
                }

                if (context.GetUserValue(key: "GaugeClosed") == 1) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}