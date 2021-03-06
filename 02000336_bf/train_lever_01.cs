namespace Maple2.Trigger._02000336_bf {
    public static class _train_lever_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000896}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000896}, arg2: 0)) {
                    return new State작동_01(context);
                }

                if (context.GetUserCount(boxId: 708) == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 113, textId: 20003363, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000896}, arg2: 0)) {
                    return new State작동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동_01 : TriggerState {
            internal State작동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: true, arg4: 300, arg5: 10f);
                context.SetMesh(arg1: new[] {8101, 8102, 8103, 8104}, arg2: false, arg4: 300, arg5: 10f);
                context.SetEffect(arg1: new[] {7010}, arg2: true);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State작동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동_02 : TriggerState {
            internal State작동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
                context.SetMesh(arg1: new[] {8050, 8051, 8052, 8053, 8054}, arg2: false, arg4: 0, arg5: 10f);
                context.SetSkill(arg1: new[] {5806}, arg2: true);
                context.SetMesh(arg1: new[] {8055}, arg2: false, arg4: 30, arg5: 0f);
                context.SetMesh(arg1: new[] {8111, 8112, 8113, 8114}, arg2: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}