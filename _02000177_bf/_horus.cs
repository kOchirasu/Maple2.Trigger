namespace Maple2.Trigger._02000177_bf {
    public static class _horus {
        public class StateHorus : TriggerState {
            internal StateHorus(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 710) == 1) {
                    return new StateHorus_move_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHorus_move_01 : TriggerState {
            internal StateHorus_move_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20001772, textId: 20001772, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateHorus_01_broken(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHorus_01_broken : TriggerState {
            internal StateHorus_01_broken(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 999, arg2: "MS2PatrolData_2004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateHorus_01_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHorus_01_End : TriggerState {
            internal StateHorus_01_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {3001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new StateHorus_01_End_02(context);
                }

                if (context.GetUserCount(boxId: 711) == 1) {
                    return new StateHorus_move_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHorus_01_End_02 : TriggerState {
            internal StateHorus_01_End_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {999});
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 711) == 1) {
                    return new StateHorus_move_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHorus_move_02 : TriggerState {
            internal StateHorus_move_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20001772, textId: 20001772, duration: 5000);
                context.CreateMonster(arg1: new[] {998}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 751, arg2: new[] {998})) {
                    return new StateHorus_02_End(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001060}, arg2: 2)) {
                    return new StateHorus_move_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHorus_02_End : TriggerState {
            internal StateHorus_02_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {998});
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 752) == 1) {
                    return new StateHorus_move_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHorus_move_03 : TriggerState {
            internal StateHorus_move_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20001772, textId: 20001772, duration: 5000);
                context.CreateMonster(arg1: new[] {997}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 753, arg2: new[] {997})) {
                    return new StateHorus_03_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHorus_03_End : TriggerState {
            internal StateHorus_03_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {997});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}