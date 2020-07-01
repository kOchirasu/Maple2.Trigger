namespace Maple2.Trigger._52010015_qd {
    public static class _act01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10002824}, arg3: new byte[] {2})) {
                    return new State딜레이01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State딜레이01 : TriggerState {
            internal State딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "100", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "100")) {
                    return new State미카교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카교체01 : TriggerState {
            internal State미카교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {202}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State미카이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카이동01 : TriggerState {
            internal State미카이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_2020");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 8000, arg2: new[] {202})) {
                    return new State미카소멸01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카소멸01 : TriggerState {
            internal State미카소멸01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {202});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}