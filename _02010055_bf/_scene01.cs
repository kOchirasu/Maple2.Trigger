using System;

namespace Maple2.Trigger._02010055_bf {
    public static class _scene01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {699}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "105")) {
                    context.State = new State바르칸트대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바르칸트대사 : TriggerState {
            internal State바르칸트대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetEffect(arg1: new int[] {699}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 23000068, arg3: "$02010055_BF__SCENE01__0$", arg4: 4);
                context.SetSkip(arg1: "바르칸트대사2스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State바르칸트대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바르칸트대사2스킵 : TriggerState {
            internal State바르칸트대사2스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State바르칸트대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바르칸트대사2 : TriggerState {
            internal State바르칸트대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetEffect(arg1: new int[] {699}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 23000068, arg3: "$02010055_BF__SCENE01__1$", arg4: 4);
                context.SetSkip(arg1: "종료준비");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료준비 : TriggerState {
            internal State종료준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}