namespace Maple2.Trigger._02010086_bf {
    public static class _train_open_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000897}, arg2: 0);
                context.SetEffect(arg1: new[] {7003, 7004}, arg2: false);
                context.SetMesh(arg1: new[] {1161, 1162, 1163}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000897}, arg2: 1)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 113, textId: 20003363);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000897}, arg2: 0)) {
                    return new State작동_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 113);
            }
        }

        private class State작동_01 : TriggerState {
            internal State작동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7003, 7004}, arg2: true);
                context.SetMesh(arg1: new[] {1171, 1172, 1173}, arg2: false, arg4: 300, arg5: 10f);
                context.SetMesh(arg1: new[] {1161, 1162, 1163}, arg2: true, arg4: 300, arg5: 10f);
                context.SetTimer(arg1: "3", arg2: 3);
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
                context.SetMesh(arg1: new[] {2111}, arg2: false, arg4: 30, arg5: 0f);
                context.SetMesh(arg1: new[] {1161, 1162, 1163}, arg2: false, arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new[] {2101}, arg2: false, arg4: 50, arg5: 1f);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State벽Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽Remove : TriggerState {
            internal State벽Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}