using System;

namespace Maple2.Trigger._02000177_bf {
    public static class _horus {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateHorus(context);

        private class StateHorus : TriggerState {
            internal StateHorus(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 710, arg2: 1)) {
                    context.State = new StateHorus_move_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHorus_move_01 : TriggerState {
            internal StateHorus_move_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20001772, textID: 20001772, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateHorus_01_broken(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHorus_01_broken : TriggerState {
            internal StateHorus_01_broken(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 999, arg2: "MS2PatrolData_2004");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateHorus_01_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHorus_01_End : TriggerState {
            internal StateHorus_01_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {3001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    context.State = new StateHorus_01_End_02(context);
                    return;
                }

                if (context.CountUsers(arg1: 711, arg2: 1)) {
                    context.State = new StateHorus_move_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHorus_01_End_02 : TriggerState {
            internal StateHorus_01_End_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {999});
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 711, arg2: 1)) {
                    context.State = new StateHorus_move_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHorus_move_02 : TriggerState {
            internal StateHorus_move_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20001772, textID: 20001772, durationTime: 5000);
                context.CreateMonster(arg1: new int[] {998}, arg2: false);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 751, arg2: new int[] {998})) {
                    context.State = new StateHorus_02_End(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001060}, arg2: 2)) {
                    context.State = new StateHorus_move_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHorus_02_End : TriggerState {
            internal StateHorus_02_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {998});
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 752, arg2: 1)) {
                    context.State = new StateHorus_move_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHorus_move_03 : TriggerState {
            internal StateHorus_move_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20001772, textID: 20001772, durationTime: 5000);
                context.CreateMonster(arg1: new int[] {997}, arg2: false);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 753, arg2: new int[] {997})) {
                    context.State = new StateHorus_03_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHorus_03_End : TriggerState {
            internal StateHorus_03_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {997});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}