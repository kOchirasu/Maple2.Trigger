namespace Maple2.Trigger._02000292_bf {
    public static class _battle01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 2001, 2002, 2003, 2004, 2005});
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
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{1001, 1002, 1003, 1004, 1005})) {
                    return new StateMobBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobBattle01 : TriggerState {
            internal StateMobBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.ChangeMonster(removeSpawnId: 1001, addSpawnId: 2001);
                context.ChangeMonster(removeSpawnId: 1002, addSpawnId: 2002);
                context.ChangeMonster(removeSpawnId: 1003, addSpawnId: 2003);
                context.ChangeMonster(removeSpawnId: 1004, addSpawnId: 2004);
                context.ChangeMonster(removeSpawnId: 1005, addSpawnId: 2005);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLadderOff01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOff01 : TriggerState {
            internal StateLadderOff01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002925, textId: 20002925, duration: 3000);
                context.SetInteractObject(interactIds: new []{10001061}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001061}, arg2: 0)) {
                    return new StateLadderOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOn01 : TriggerState {
            internal StateLadderOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 501, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 502, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 503, visible: true, animationEffect: true);
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
