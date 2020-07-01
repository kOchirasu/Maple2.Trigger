namespace Maple2.Trigger._02010054_bf {
    public static class _spawn_02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000885}, arg2: 2);
                context.SetEffect(arg1: new[] {611}, arg2: false);
                context.SetMesh(arg1: new[] {3128}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {106})) {
                    return new State몬스터생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터생성 : TriggerState {
            internal State몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {611}, arg2: true);
                context.SetMesh(arg1: new[] {3128}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.CreateMonster(arg1: new[] {2023}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2023})) {
                    context.SetInteractObject(arg1: new[] {10000885}, arg2: 1);
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