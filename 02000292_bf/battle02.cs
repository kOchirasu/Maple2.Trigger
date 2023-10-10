namespace Maple2.Trigger._02000292_bf {
    public static class _battle02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 501, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 502, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 503, visible: true, animationEffect: true);
                context.DestroyMonster(spawnIds: new []{1006, 1007, 1008, 1009, 1010, 2006, 2007, 2008, 2009, 2010});
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.SetInteractObject(interactIds: new []{10001061}, state: 0);
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
                context.CreateMonster(spawnIds: new []{1006, 1007, 1008, 1009, 1010}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{1006, 1007, 1008, 1009, 1010})) {
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
                context.ChangeMonster(removeSpawnId: 1006, addSpawnId: 2006);
                context.ChangeMonster(removeSpawnId: 1007, addSpawnId: 2007);
                context.ChangeMonster(removeSpawnId: 1008, addSpawnId: 2008);
                context.ChangeMonster(removeSpawnId: 1009, addSpawnId: 2009);
                context.ChangeMonster(removeSpawnId: 1010, addSpawnId: 2010);
                context.SetLadder(triggerId: 501, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 502, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 503, visible: false, animationEffect: false);
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
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01", boxIds: 9001);
                context.ShowGuideSummary(entityId: 20002921, textId: 20002921, duration: 5000);
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
