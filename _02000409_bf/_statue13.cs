using System;

namespace Maple2.Trigger._02000409_bf {
    public static class _statue13 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State세팅(context);

        private class State세팅 : TriggerState {
            internal State세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {13}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "199")) {
                    context.State = new State수신대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State수신대기 : TriggerState {
            internal State수신대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "StatueAnimal02Death", value: 1)) {
                    context.SetMesh(arg1: new int[] {13}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {13}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}