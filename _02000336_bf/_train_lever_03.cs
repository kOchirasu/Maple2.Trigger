namespace Maple2.Trigger._02000336_bf {
    public static class _train_lever_03 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8161, 8162, 8163, 8164}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000898}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000898}, arg2: 0)) {
                    return new State작동_01(context);
                }

                if (context.GetUserCount(boxId: 709) == 1) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 113, textId: 20003363, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000898}, arg2: 0)) {
                    return new State작동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동_01 : TriggerState {
            internal State작동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8161, 8162, 8163, 8164}, arg2: true, arg4: 300, arg5: 10f);
                context.SetMesh(arg1: new[] {8261, 8262, 8263, 8264}, arg2: false, arg4: 300, arg5: 10f);
                context.SetEffect(arg1: new[] {7012}, arg2: true);
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
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
                context.SetMesh(arg1: new[] {8064, 8065, 8066, 8067, 8068}, arg2: false, arg4: 0, arg5: 10f);
                context.SetSkill(arg1: new[] {5808}, arg2: true);
                context.SetMesh(arg1: new[] {8069}, arg2: false, arg4: 30, arg5: 0f);
                context.SetMesh(arg1: new[] {8161, 8162, 8163, 8164}, arg2: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}