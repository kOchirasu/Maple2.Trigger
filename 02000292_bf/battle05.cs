namespace Maple2.Trigger._02000292_bf {
    public static class _battle05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{117, 118, 119, 120}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.DestroyMonster(spawnIds: new []{1020, 1021, 1022, 1023, 1024, 2020, 2021, 2022, 2023, 2024});
                context.SetEffect(triggerIds: new []{5004}, visible: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{1020, 1021, 1022, 1023, 1024}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{1020, 1021, 1022, 1023, 1024})) {
                    return new StateMobBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobBattle01 : TriggerState {
            internal StateMobBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5004}, visible: true);
                context.ChangeMonster(removeSpawnId: 1020, addSpawnId: 2015);
                context.ChangeMonster(removeSpawnId: 1021, addSpawnId: 2016);
                context.ChangeMonster(removeSpawnId: 1022, addSpawnId: 2017);
                context.ChangeMonster(removeSpawnId: 1023, addSpawnId: 2018);
                context.ChangeMonster(removeSpawnId: 1024, addSpawnId: 2019);
                context.CreateMonster(spawnIds: new []{1025}, arg2: false);
                context.SetMesh(triggerIds: new []{117, 118, 119, 120}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002923, textId: 20002923);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1025})) {
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
                context.SetMesh(triggerIds: new []{117, 118, 119, 120}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
