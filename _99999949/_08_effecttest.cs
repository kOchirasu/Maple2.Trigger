using System;

namespace Maple2.Trigger._99999949 {
    public static class _08_effecttest {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9100})) {
                    context.State = new StateGuide(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuide : TriggerState {
            internal StateGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(@string: "8번 영역에 들어가면 EffectTest 트리거가 발동됩니다.");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9100})) {
                    context.State = new StateCameraReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraReady : TriggerState {
            internal StateCameraReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(@string: "EffectTest 2초 후에 시작됩니다.");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State이펙트출력01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트출력01 : TriggerState {
            internal State이펙트출력01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(@string: "EffectTest 발동");
                context.SetEffect(arg1: new int[] {9101, 9102, 9103, 9104, 9105, 9106, 9107, 9108, 9109, 9110},
                    arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(@string: "5초 후에 트리거가 리셋됩니다. 8번 영역 밖으로 나가세요.");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}