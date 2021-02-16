namespace Maple2.Trigger._02000336_bf {
    public static class _train_open {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {16014, 16015, 16016}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000805}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 706) == 1) {
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
                context.ShowGuideSummary(entityId: 113, textId: 20003363);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000805}, arg2: 0)) {
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
                context.SetMesh(arg1: new[] {16011, 16012, 16013}, arg2: false, arg4: 300, arg5: 10f);
                context.SetMesh(arg1: new[] {16014, 16015, 16016}, arg2: true, arg4: 300, arg5: 10f);
                context.SetEffect(arg1: new[] {7013}, arg2: true);
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
                context.SetSkill(arg1: new[] {5802}, arg2: true);
                context.SetMesh(arg1: new[] {16001}, arg2: false, arg4: 30, arg5: 0f);
                context.SetMesh(arg1: new[] {16014, 16015, 16016}, arg2: false, arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new[] {16000}, arg2: false, arg4: 50, arg5: 1f);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new State작동_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동_03 : TriggerState {
            internal State작동_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {305, 306, 307, 308}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}