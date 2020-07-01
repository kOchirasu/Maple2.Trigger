namespace Maple2.Trigger._02010086_bf {
    public static class _train_open {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7001}, arg2: false);
                context.SetEffect(arg1: new[] {7002}, arg2: false);
                context.SetMesh(arg1: new[] {1061, 1062, 1063}, arg2: false);
                context.SetMesh(arg1: new[] {2011, 2012, 2013}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000896}, arg2: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000896}, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 113, textId: 20003363);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000896}, arg2: 0)) {
                    context.State = new State작동_01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 113);
            }
        }

        private class State작동_01 : TriggerState {
            internal State작동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7001}, arg2: true);
                context.SetEffect(arg1: new[] {7002}, arg2: true);
                context.SetMesh(arg1: new[] {1071, 1072, 1073}, arg2: false, arg4: 300, arg5: 10f);
                context.SetMesh(arg1: new[] {1061, 1062, 1063}, arg2: true, arg4: 300, arg5: 10f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State작동_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State작동_02 : TriggerState {
            internal State작동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1055}, arg2: false, arg4: 30, arg5: 0f);
                context.SetMesh(arg1: new[] {1061, 1062, 1063}, arg2: false, arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new[] {1005}, arg2: false, arg4: 50, arg5: 1f);
                context.SetActor(arg1: 1022, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {1021}, arg2: false, arg4: 0, arg5: 10f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}