namespace Maple2.Trigger._02000292_bf {
    public static class _battle03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 511, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 512, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 513, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 514, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 515, visible: true, animationEffect: true);
                context.DestroyMonster(spawnIds: new []{1011, 1012, 1013, 1014, 2011, 2012, 2013, 2014});
                context.SetEffect(triggerIds: new []{5002}, visible: false);
                context.SetInteractObject(interactIds: new []{10001062}, state: 0);
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
                context.CreateMonster(spawnIds: new []{1011, 1012, 1013, 1014}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{1011, 1012, 1013, 1014})) {
                    return new StateMobBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobBattle01 : TriggerState {
            internal StateMobBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.ChangeMonster(removeSpawnId: 1011, addSpawnId: 2011);
                context.ChangeMonster(removeSpawnId: 1012, addSpawnId: 2012);
                context.ChangeMonster(removeSpawnId: 1013, addSpawnId: 2013);
                context.ChangeMonster(removeSpawnId: 1014, addSpawnId: 2014);
                context.SetLadder(triggerId: 511, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 512, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 513, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 514, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 515, visible: false, animationEffect: false);
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
                context.SetInteractObject(interactIds: new []{10001062}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001062}, arg2: 0)) {
                    return new StateLadderOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOn01 : TriggerState {
            internal StateLadderOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 511, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 512, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 513, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 514, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 515, visible: true, animationEffect: true);
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
