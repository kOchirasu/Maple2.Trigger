namespace Maple2.Trigger._02020200_bf {
    public static class _08_bomb7 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BombOn") == 1) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {311}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BombOn") == 2) {
                    return new State종료(context);
                }

                if (context.MonsterDead(arg1: new[] {311})) {
                    return new State폭탄_터짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭탄_터짐 : TriggerState {
            internal State폭탄_터짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2007}, arg2: false, arg3: 1500, arg5: 3f);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BombOn") == 2) {
                    return new State종료(context);
                }

                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BombOn") == 2) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 40000)) {
                    context.SetMesh(arg1: new[] {2007}, arg2: true, arg5: 3f);
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {311});
                context.SetMesh(arg1: new[] {2007}, arg2: false, arg3: 1500, arg5: 3f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}