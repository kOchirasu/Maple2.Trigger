using System;

namespace Maple2.Trigger._02000336_bf {
    public static class _train_patrol {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7002}, arg2: false);
                context.SetEffect(arg1: new int[] {7003}, arg2: false);
                context.SetEffect(arg1: new int[] {7004}, arg2: false);
                context.SetMesh(arg1: new int[] {16004}, arg2: false, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 704, arg2: 1)) {
                    context.State = new State패트롤_01(context);
                    return;
                }

                if (context.CountUsers(arg1: 707, arg2: 1)) {
                    context.State = new State패트롤_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패트롤_01 : TriggerState {
            internal State패트롤_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {147, 148, 149}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 707, arg2: 1)) {
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
                context.ShowGuideSummary(entityID: 105, textID: 20003361);
                context.CreateMonster(arg1: new int[] {191, 192, 193, 194, 195, 196, 197, 198}, arg2: false);
                context.SetEffect(arg1: new int[] {7002}, arg2: true);
                context.SetSkill(arg1: new int[] {5803}, arg2: true);
                context.SetSkill(arg1: new int[] {5804}, arg2: true);
                context.SetSkill(arg1: new int[] {5805}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {196})) {
                    context.State = new State관문_03_개방(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 105);
            }
        }

        private class State관문_03_개방 : TriggerState {
            internal State관문_03_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 106, textID: 20003362, durationTime: 3000);
                context.SetMesh(arg1: new int[] {8030, 8031, 8032, 8033, 8034}, arg2: false, arg4: 0, arg5: 10f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}