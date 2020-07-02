namespace Maple2.Trigger._02000298_bf {
    public static class _mob_07 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603, 606}, arg2: false);
                context.SetMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3211, 3212, 3213, 3214, 3215}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {106})) {
                    context.CreateMonster(arg1: new[] {1007}, arg2: false);
                    return new State방호벽대기(context);
                }

                if (context.UserDetected(arg1: new[] {107})) {
                    context.CreateMonster(arg1: new[] {1007}, arg2: false);
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
                if (context.MonsterDead(arg1: new[] {1007})) {
                    return new State방호벽해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방호벽해제 : TriggerState {
            internal State방호벽해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State11TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State11TimedCreation : TriggerState {
            internal State11TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1011})) {
                    return new State방호벽해제2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방호벽해제2 : TriggerState {
            internal State방호벽해제2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {606}, arg2: true);
                context.SetMesh(arg1: new[] {3211, 3212, 3213, 3214, 3215}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1800000", arg2: 1800000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1800000")) {
                    // return new StateEnd2(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}