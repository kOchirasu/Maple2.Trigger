namespace Maple2.Trigger._02000316_bf {
    public static class _qeagle_04 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000572}, arg2: 1);
                context.SetActor(arg1: 907, arg2: false, arg3: "Attack_Idle_A");
                context.SetEffect(arg1: new[] {908}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000572}, arg2: 0)) {
                    return new State오브젝트반응(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 907, arg2: true, arg3: "Attack_Idle_A");
                context.SetEffect(arg1: new[] {908}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State그리폰제거(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 907, arg2: false, arg3: "Attack_Idle_A");
                context.SetEffect(arg1: new[] {908}, arg2: false);
            }
        }

        private class State그리폰제거 : TriggerState {
            internal State그리폰제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 600);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}