namespace Maple2.Trigger._02100000_bf {
    public static class _debuff {
        public class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {106})) {
                    context.State = new State버프(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프 : TriggerState {
            internal State버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 70000130, arg3: 1, arg4: false, arg5: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State버프_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프_2 : TriggerState {
            internal State버프_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 70000130, arg3: 1, arg4: false, arg5: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State버프_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프_3 : TriggerState {
            internal State버프_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 70000130, arg3: 1, arg4: false, arg5: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State버프_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프_4 : TriggerState {
            internal State버프_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 70000130, arg3: 1, arg4: false, arg5: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State버프_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프_5 : TriggerState {
            internal State버프_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 70000131, arg3: 1, arg4: false, arg5: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State버프(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}