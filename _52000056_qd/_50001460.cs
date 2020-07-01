namespace Maple2.Trigger._52000056_qd {
    public static class _50001460 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: false);
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.SetEffect(arg1: new[] {604}, arg2: false);
                context.SetEffect(arg1: new[] {605}, arg2: false);
                context.SetEffect(arg1: new[] {606}, arg2: false);
                context.SetEffect(arg1: new[] {607}, arg2: false);
                context.SetEffect(arg1: new[] {608}, arg2: false);
                context.SetEffect(arg1: new[] {609}, arg2: false);
                context.SetEffect(arg1: new[] {610}, arg2: false);
                context.SetEffect(arg1: new[] {611}, arg2: false);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetGravity(gravity: -9.8f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {103, 104, 105, 106})) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000056, arg2: 3);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePC말풍선01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선01 : TriggerState {
            internal StatePC말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000056_QD__50001460__0$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State낙하준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낙하준비 : TriggerState {
            internal State낙하준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008}, arg2: false, arg3: 0,
                    arg4: 200, arg5: 2f);
                context.SetGravity(gravity: -37f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State낙하시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낙하시작 : TriggerState {
            internal State낙하시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State낙하종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낙하종료 : TriggerState {
            internal State낙하종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePC말풍선02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선02 : TriggerState {
            internal StatePC말풍선02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000056_QD__50001460__1$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StatePC말풍선03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선03 : TriggerState {
            internal StatePC말풍선03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000056_QD__50001460__2$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEffect(arg1: new[] {601}, arg2: true);
                    context.SetEffect(arg1: new[] {602}, arg2: true);
                    context.SetEffect(arg1: new[] {603}, arg2: true);
                    context.SetEffect(arg1: new[] {604}, arg2: true);
                    context.SetEffect(arg1: new[] {605}, arg2: true);
                    context.SetEffect(arg1: new[] {606}, arg2: true);
                    context.SetEffect(arg1: new[] {607}, arg2: true);
                    context.SetEffect(arg1: new[] {608}, arg2: true);
                    context.SetEffect(arg1: new[] {609}, arg2: true);
                    context.SetEffect(arg1: new[] {610}, arg2: true);
                    context.SetEffect(arg1: new[] {611}, arg2: true);
                    context.SetProductionUI(arg1: 0);
                    context.SetProductionUI(arg1: 2);
                    context.SetGravity(gravity: -9.8f);
                    context.State = new State이펙트종료대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트종료대기 : TriggerState {
            internal State이펙트종료대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    context.SetEffect(arg1: new[] {601}, arg2: false);
                    context.SetEffect(arg1: new[] {602}, arg2: false);
                    context.SetEffect(arg1: new[] {603}, arg2: false);
                    context.SetEffect(arg1: new[] {604}, arg2: false);
                    context.SetEffect(arg1: new[] {605}, arg2: false);
                    context.SetEffect(arg1: new[] {606}, arg2: false);
                    context.SetEffect(arg1: new[] {607}, arg2: false);
                    context.SetEffect(arg1: new[] {608}, arg2: false);
                    context.SetEffect(arg1: new[] {609}, arg2: false);
                    context.SetEffect(arg1: new[] {610}, arg2: false);
                    context.SetEffect(arg1: new[] {611}, arg2: false);
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