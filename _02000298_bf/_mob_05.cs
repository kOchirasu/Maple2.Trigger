namespace Maple2.Trigger._02000298_bf {
    public static class _mob_05 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602, 605}, arg2: false);
                context.SetMesh(arg1: new[] {3006, 3007, 3008, 3009, 3010, 3206, 3207, 3208, 3209, 3210}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    context.CreateMonster(arg1: new[] {1005}, arg2: false);
                    return new State방호벽대기(context);
                }

                if (context.UserDetected(arg1: new[] {103})) {
                    context.CreateMonster(arg1: new[] {1005}, arg2: false);
                    return new State방호벽대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방호벽대기 : TriggerState {
            internal State방호벽대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new State방호벽해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방호벽해제 : TriggerState {
            internal State방호벽해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetMesh(arg1: new[] {3006, 3007, 3008, 3009, 3010}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State10번생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10번생성 : TriggerState {
            internal State10번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1010}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1010})) {
                    return new State방호벽해제2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방호벽해제2 : TriggerState {
            internal State방호벽해제2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetMesh(arg1: new[] {3206, 3207, 3208, 3209, 3210}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1800000", arg2: 1800000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1800000")) {
                    // return new State종료2(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}