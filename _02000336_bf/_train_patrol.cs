namespace Maple2.Trigger._02000336_bf {
    public static class _train_patrol {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7002, 7003, 7004}, arg2: false);
                context.SetMesh(arg1: new[] {16004}, arg2: false, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 704) == 1) {
                    context.State = new State패트롤_01(context);
                    return;
                }

                if (context.GetUserCount(boxId: 707) == 1) {
                    context.State = new State패트롤_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패트롤_01 : TriggerState {
            internal State패트롤_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {147, 148, 149}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 707) == 1) {
                    context.State = new State패트롤_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패트롤_02 : TriggerState {
            internal State패트롤_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State패트롤_03 : TriggerState {
            internal State패트롤_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 105, textId: 20003361);
                context.CreateMonster(arg1: new[] {191, 192, 193, 194, 195, 196, 197, 198}, arg2: false);
                context.SetEffect(arg1: new[] {7002}, arg2: true);
                context.SetSkill(arg1: new[] {5803, 5804, 5805}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {196})) {
                    context.State = new State관문_03_개방(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 105);
            }
        }

        private class State관문_03_개방 : TriggerState {
            internal State관문_03_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
                context.SetMesh(arg1: new[] {8030, 8031, 8032, 8033, 8034}, arg2: false, arg4: 0, arg5: 10f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}