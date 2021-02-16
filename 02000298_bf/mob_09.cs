namespace Maple2.Trigger._02000298_bf {
    public static class _mob_09 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604, 607}, arg2: false);
                context.SetMesh(arg1: new[] {3016, 3017, 3018, 3019, 3020, 3216, 3217, 3218, 3219, 3220}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {110})) {
                    context.CreateMonster(arg1: new[] {1009}, arg2: false);
                    return new State방호벽Wait(context);
                }

                if (context.UserDetected(arg1: new[] {111})) {
                    context.CreateMonster(arg1: new[] {1009}, arg2: false);
                    return new State방호벽Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방호벽Wait : TriggerState {
            internal State방호벽Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1009})) {
                    return new State방호벽해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방호벽해제 : TriggerState {
            internal State방호벽해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetMesh(arg1: new[] {3016, 3017, 3018, 3019, 3020}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State12TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12TimedCreation : TriggerState {
            internal State12TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1012}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1012})) {
                    return new State방호벽해제2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방호벽해제2 : TriggerState {
            internal State방호벽해제2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {607}, arg2: true);
                context.SetMesh(arg1: new[] {3216, 3217, 3218, 3219, 3220}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetTimer(id: "1", arg2: 1);
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
                context.SetTimer(id: "1800000", arg2: 1800000);
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