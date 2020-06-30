using System;

namespace Maple2.Trigger._02000245_bf {
    public static class _trigger_01_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {802}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new int[] {7021}, arg2: true);
                context.SetSkill(arg1: new int[] {7022}, arg2: true);
                context.SetSkill(arg1: new int[] {7023}, arg2: true);
                context.SetSkill(arg1: new int[] {7024}, arg2: true);
                context.SetSkill(arg1: new int[] {7025}, arg2: true);
                context.SetSkill(arg1: new int[] {7026}, arg2: true);
                context.SetSkill(arg1: new int[] {7027}, arg2: true);
                context.SetSkill(arg1: new int[] {7028}, arg2: true);
                context.SetSkill(arg1: new int[] {7029}, arg2: true);
                context.SetSkill(arg1: new int[] {7030}, arg2: true);
                context.SetSkill(arg1: new int[] {7031}, arg2: true);
                context.SetSkill(arg1: new int[] {7032}, arg2: true);
                context.SetSkill(arg1: new int[] {7033}, arg2: true);
                context.SetSkill(arg1: new int[] {7034}, arg2: true);
                context.SetSkill(arg1: new int[] {7035}, arg2: true);
                context.SetSkill(arg1: new int[] {7036}, arg2: true);
                context.SetSkill(arg1: new int[] {7037}, arg2: true);
                context.SetSkill(arg1: new int[] {7038}, arg2: true);
                context.SetSkill(arg1: new int[] {7039}, arg2: true);
                context.SetSkill(arg1: new int[] {7040}, arg2: true);
                context.SetEffect(arg1: new int[] {921}, arg2: true);
                context.SetEffect(arg1: new int[] {922}, arg2: true);
                context.SetEffect(arg1: new int[] {923}, arg2: true);
                context.SetEffect(arg1: new int[] {924}, arg2: true);
                context.SetEffect(arg1: new int[] {925}, arg2: true);
                context.SetEffect(arg1: new int[] {926}, arg2: true);
                context.SetEffect(arg1: new int[] {927}, arg2: true);
                context.SetEffect(arg1: new int[] {928}, arg2: true);
                context.SetEffect(arg1: new int[] {929}, arg2: true);
                context.SetEffect(arg1: new int[] {930}, arg2: true);
                context.SetEffect(arg1: new int[] {931}, arg2: true);
                context.SetEffect(arg1: new int[] {932}, arg2: true);
                context.SetEffect(arg1: new int[] {933}, arg2: true);
                context.SetEffect(arg1: new int[] {934}, arg2: true);
                context.SetEffect(arg1: new int[] {935}, arg2: true);
                context.SetEffect(arg1: new int[] {936}, arg2: true);
                context.SetEffect(arg1: new int[] {937}, arg2: true);
                context.SetEffect(arg1: new int[] {938}, arg2: true);
                context.SetEffect(arg1: new int[] {939}, arg2: true);
                context.SetEffect(arg1: new int[] {940}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "208")) {
                    context.State = new State1단계(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1단계 : TriggerState {
            internal State1단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {802}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new int[] {7021}, arg2: false);
                context.SetSkill(arg1: new int[] {7022}, arg2: false);
                context.SetSkill(arg1: new int[] {7023}, arg2: false);
                context.SetSkill(arg1: new int[] {7024}, arg2: false);
                context.SetSkill(arg1: new int[] {7025}, arg2: false);
                context.SetSkill(arg1: new int[] {7026}, arg2: false);
                context.SetSkill(arg1: new int[] {7027}, arg2: false);
                context.SetSkill(arg1: new int[] {7028}, arg2: false);
                context.SetSkill(arg1: new int[] {7029}, arg2: false);
                context.SetSkill(arg1: new int[] {7030}, arg2: false);
                context.SetSkill(arg1: new int[] {7031}, arg2: false);
                context.SetSkill(arg1: new int[] {7032}, arg2: false);
                context.SetSkill(arg1: new int[] {7033}, arg2: false);
                context.SetSkill(arg1: new int[] {7034}, arg2: false);
                context.SetSkill(arg1: new int[] {7035}, arg2: false);
                context.SetSkill(arg1: new int[] {7036}, arg2: false);
                context.SetSkill(arg1: new int[] {7037}, arg2: false);
                context.SetSkill(arg1: new int[] {7038}, arg2: false);
                context.SetSkill(arg1: new int[] {7039}, arg2: false);
                context.SetSkill(arg1: new int[] {7040}, arg2: false);
                context.SetEffect(arg1: new int[] {921}, arg2: false);
                context.SetEffect(arg1: new int[] {922}, arg2: false);
                context.SetEffect(arg1: new int[] {923}, arg2: false);
                context.SetEffect(arg1: new int[] {924}, arg2: false);
                context.SetEffect(arg1: new int[] {925}, arg2: false);
                context.SetEffect(arg1: new int[] {926}, arg2: false);
                context.SetEffect(arg1: new int[] {927}, arg2: false);
                context.SetEffect(arg1: new int[] {928}, arg2: false);
                context.SetEffect(arg1: new int[] {929}, arg2: false);
                context.SetEffect(arg1: new int[] {930}, arg2: false);
                context.SetEffect(arg1: new int[] {931}, arg2: false);
                context.SetEffect(arg1: new int[] {932}, arg2: false);
                context.SetEffect(arg1: new int[] {933}, arg2: false);
                context.SetEffect(arg1: new int[] {934}, arg2: false);
                context.SetEffect(arg1: new int[] {935}, arg2: false);
                context.SetEffect(arg1: new int[] {936}, arg2: false);
                context.SetEffect(arg1: new int[] {937}, arg2: false);
                context.SetEffect(arg1: new int[] {938}, arg2: false);
                context.SetEffect(arg1: new int[] {939}, arg2: false);
                context.SetEffect(arg1: new int[] {940}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}