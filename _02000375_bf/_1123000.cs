using System;

namespace Maple2.Trigger._02000375_bf {
    public static class _1123000 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3400}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_off");
            }

            public override void Execute() {
                if (context.UserValue(key: "SecondPhaseEnd", value: 1)) {
                    context.State = new State문열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3400}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_on");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
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