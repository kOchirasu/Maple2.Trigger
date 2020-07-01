using System;

namespace Maple2.Trigger._02000331_bf {
    public static class _switch15 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000801}, arg2: 2);
                context.SetEffect(arg1: new int[] {4200}, arg2: false);
                context.SetUserValue(key: "SecondBridgeOff", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {99993})) {
                    context.State = new State전투체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투체크 : TriggerState {
            internal State전투체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "SecondBridgeOff", value: 1)) {
                    context.State = new State스위치준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스위치준비 : TriggerState {
            internal State스위치준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {777703}, arg2: false);
                context.SetEffect(arg1: new int[] {777804}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {99995})) {
                    context.State = new State스위치켜기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스위치켜기 : TriggerState {
            internal State스위치켜기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000801}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000801}, arg2: 1);
                context.SetEffect(arg1: new int[] {4200}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000801})) {
                    context.State = new State외다리재생성(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {7775}, arg2: true);
            }
        }

        private class State외다리재생성 : TriggerState {
            internal State외다리재생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {90008}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(arg1: new int[] {10040, 10041, 10042, 10043, 10044}, arg2: true, arg3: 5,
                    arg4: 100, arg5: 100);
                context.SetEffect(arg1: new int[] {777703}, arg2: true);
                context.SetEffect(arg1: new int[] {4200}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {99992})) {
                    context.State = new State이동안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동안내 : TriggerState {
            internal State이동안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
                context.SetMesh(arg1: new int[] {90008}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(arg1: new int[] {10040, 10041, 10042, 10043, 10044}, arg2: true, arg3: 5,
                    arg4: 150, arg5: 150);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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