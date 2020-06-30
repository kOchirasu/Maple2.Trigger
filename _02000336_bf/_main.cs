using System;

namespace Maple2.Trigger._02000336_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {16003, 16004}, arg2: false, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {122, 123, 301, 302}, arg2: false);
                context.CreateMonster(
                    arg1: new int[] {
                        110, 111, 112, 113, 114, 116, 117, 120, 121, 124, 125, 126, 127, 128, 129, 131, 132, 133, 134,
                        135, 137, 139, 141, 142, 144
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 703, arg2: 1)) {
                    context.State = new State관문_01_개방_준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방_준비 : TriggerState {
            internal State관문_01_개방_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 105, textID: 20003361);
                context.CreateMonster(arg1: new int[] {309, 311, 313, 172, 173}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {127})) {
                    context.State = new State관문_01_개방(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 105);
            }
        }

        private class State관문_01_개방 : TriggerState {
            internal State관문_01_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 106, textID: 20003362, duration: 3000);
                context.SetMesh(arg1: new int[] {8010, 8011, 8012, 8013, 8014}, arg2: false, arg4: 0, arg5: 10f);
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {125})) {
                    context.State = new State관문_02_개방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State관문_02_개방_준비 : TriggerState {
            internal State관문_02_개방_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {127})) {
                    context.State = new State관문_01_개방(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 113);
            }
        }

        private class State관문_02_개방 : TriggerState {
            internal State관문_02_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {16017, 16018}, arg2: false, arg4: 0, arg5: 10f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}