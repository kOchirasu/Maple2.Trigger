namespace Maple2.Trigger._02000292_bf {
    public static class _battle05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {117, 118, 119, 120}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.DestroyMonster(arg1: new[] {1020, 1021, 1022, 1023, 1024, 2020, 2021, 2022, 2023, 2024});
                context.SetEffect(arg1: new[] {5004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateMobSpawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn01 : TriggerState {
            internal StateMobSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1020, 1021, 1022, 1023, 1024}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {1020, 1021, 1022, 1023, 1024})) {
                    return new StateMobBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobBattle01 : TriggerState {
            internal StateMobBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5004}, arg2: true);
                context.ChangeMonster(arg1: 1020, arg2: 2015);
                context.ChangeMonster(arg1: 1021, arg2: 2016);
                context.ChangeMonster(arg1: 1022, arg2: 2017);
                context.ChangeMonster(arg1: 1023, arg2: 2018);
                context.ChangeMonster(arg1: 1024, arg2: 2019);
                context.CreateMonster(arg1: new[] {1025}, arg2: false);
                context.SetMesh(arg1: new[] {117, 118, 119, 120}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBlockOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlockOn01 : TriggerState {
            internal StateBlockOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002923, textId: 20002923);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1025})) {
                    return new StateBlockOff01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlockOff01 : TriggerState {
            internal StateBlockOff01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002923);
                context.SetMesh(arg1: new[] {117, 118, 119, 120}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}