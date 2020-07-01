namespace Maple2.Trigger._02000245_bf {
    public static class _trigger_01_02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {802}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {7021}, arg2: true);
                context.SetSkill(arg1: new[] {7022}, arg2: true);
                context.SetSkill(arg1: new[] {7023}, arg2: true);
                context.SetSkill(arg1: new[] {7024}, arg2: true);
                context.SetSkill(arg1: new[] {7025}, arg2: true);
                context.SetSkill(arg1: new[] {7026}, arg2: true);
                context.SetSkill(arg1: new[] {7027}, arg2: true);
                context.SetSkill(arg1: new[] {7028}, arg2: true);
                context.SetSkill(arg1: new[] {7029}, arg2: true);
                context.SetSkill(arg1: new[] {7030}, arg2: true);
                context.SetSkill(arg1: new[] {7031}, arg2: true);
                context.SetSkill(arg1: new[] {7032}, arg2: true);
                context.SetSkill(arg1: new[] {7033}, arg2: true);
                context.SetSkill(arg1: new[] {7034}, arg2: true);
                context.SetSkill(arg1: new[] {7035}, arg2: true);
                context.SetSkill(arg1: new[] {7036}, arg2: true);
                context.SetSkill(arg1: new[] {7037}, arg2: true);
                context.SetSkill(arg1: new[] {7038}, arg2: true);
                context.SetSkill(arg1: new[] {7039}, arg2: true);
                context.SetSkill(arg1: new[] {7040}, arg2: true);
                context.SetEffect(arg1: new[] {921}, arg2: true);
                context.SetEffect(arg1: new[] {922}, arg2: true);
                context.SetEffect(arg1: new[] {923}, arg2: true);
                context.SetEffect(arg1: new[] {924}, arg2: true);
                context.SetEffect(arg1: new[] {925}, arg2: true);
                context.SetEffect(arg1: new[] {926}, arg2: true);
                context.SetEffect(arg1: new[] {927}, arg2: true);
                context.SetEffect(arg1: new[] {928}, arg2: true);
                context.SetEffect(arg1: new[] {929}, arg2: true);
                context.SetEffect(arg1: new[] {930}, arg2: true);
                context.SetEffect(arg1: new[] {931}, arg2: true);
                context.SetEffect(arg1: new[] {932}, arg2: true);
                context.SetEffect(arg1: new[] {933}, arg2: true);
                context.SetEffect(arg1: new[] {934}, arg2: true);
                context.SetEffect(arg1: new[] {935}, arg2: true);
                context.SetEffect(arg1: new[] {936}, arg2: true);
                context.SetEffect(arg1: new[] {937}, arg2: true);
                context.SetEffect(arg1: new[] {938}, arg2: true);
                context.SetEffect(arg1: new[] {939}, arg2: true);
                context.SetEffect(arg1: new[] {940}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {208})) {
                    context.State = new State1단계(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1단계 : TriggerState {
            internal State1단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {802}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {7021}, arg2: false);
                context.SetSkill(arg1: new[] {7022}, arg2: false);
                context.SetSkill(arg1: new[] {7023}, arg2: false);
                context.SetSkill(arg1: new[] {7024}, arg2: false);
                context.SetSkill(arg1: new[] {7025}, arg2: false);
                context.SetSkill(arg1: new[] {7026}, arg2: false);
                context.SetSkill(arg1: new[] {7027}, arg2: false);
                context.SetSkill(arg1: new[] {7028}, arg2: false);
                context.SetSkill(arg1: new[] {7029}, arg2: false);
                context.SetSkill(arg1: new[] {7030}, arg2: false);
                context.SetSkill(arg1: new[] {7031}, arg2: false);
                context.SetSkill(arg1: new[] {7032}, arg2: false);
                context.SetSkill(arg1: new[] {7033}, arg2: false);
                context.SetSkill(arg1: new[] {7034}, arg2: false);
                context.SetSkill(arg1: new[] {7035}, arg2: false);
                context.SetSkill(arg1: new[] {7036}, arg2: false);
                context.SetSkill(arg1: new[] {7037}, arg2: false);
                context.SetSkill(arg1: new[] {7038}, arg2: false);
                context.SetSkill(arg1: new[] {7039}, arg2: false);
                context.SetSkill(arg1: new[] {7040}, arg2: false);
                context.SetEffect(arg1: new[] {921}, arg2: false);
                context.SetEffect(arg1: new[] {922}, arg2: false);
                context.SetEffect(arg1: new[] {923}, arg2: false);
                context.SetEffect(arg1: new[] {924}, arg2: false);
                context.SetEffect(arg1: new[] {925}, arg2: false);
                context.SetEffect(arg1: new[] {926}, arg2: false);
                context.SetEffect(arg1: new[] {927}, arg2: false);
                context.SetEffect(arg1: new[] {928}, arg2: false);
                context.SetEffect(arg1: new[] {929}, arg2: false);
                context.SetEffect(arg1: new[] {930}, arg2: false);
                context.SetEffect(arg1: new[] {931}, arg2: false);
                context.SetEffect(arg1: new[] {932}, arg2: false);
                context.SetEffect(arg1: new[] {933}, arg2: false);
                context.SetEffect(arg1: new[] {934}, arg2: false);
                context.SetEffect(arg1: new[] {935}, arg2: false);
                context.SetEffect(arg1: new[] {936}, arg2: false);
                context.SetEffect(arg1: new[] {937}, arg2: false);
                context.SetEffect(arg1: new[] {938}, arg2: false);
                context.SetEffect(arg1: new[] {939}, arg2: false);
                context.SetEffect(arg1: new[] {940}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}