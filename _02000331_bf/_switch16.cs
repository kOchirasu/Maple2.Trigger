using System;

namespace Maple2.Trigger._02000331_bf {
    public static class _switch16 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000802}, arg2: 2);
                context.SetEffect(arg1: new int[] {4100}, arg2: false);
                context.SetUserValue(key: "FirstBridgeOff", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9001})) {
                    context.State = new State첫번째전투종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째전투종료 : TriggerState {
            internal State첫번째전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "FirstBridgeOff", value: 1)) {
                    context.State = new State딜레이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이01 : TriggerState {
            internal State딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State유저재시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저재시작 : TriggerState {
            internal State유저재시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new State딜레이02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이02 : TriggerState {
            internal State딜레이02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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
                context.SetInteractObject(arg1: new int[] {10000802}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000802}, arg2: 1);
                context.SetEffect(arg1: new int[] {4100}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State스위치켜기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스위치켜기 : TriggerState {
            internal State스위치켜기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000802})) {
                    context.State = new State다리재생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리재생성 : TriggerState {
            internal State다리재생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new int[] {
                        10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013,
                        10014, 10015, 10016
                    }, arg2: true, arg3: 16, arg4: 100, arg5: 100);
                context.SetEffect(arg1: new int[] {777701}, arg2: true);
                context.SetMesh(arg1: new int[] {90000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {90001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {4100}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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