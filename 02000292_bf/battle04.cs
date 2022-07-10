namespace Maple2.Trigger._02000292_bf {
    public static class _battle04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 521, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 522, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 523, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 524, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 525, visible: true, animationEffect: true);
                context.DestroyMonster(spawnIds: new []{1015, 1016, 1017, 1018, 1019, 2015, 2016, 2017, 2018, 2019});
                context.SetEffect(triggerIds: new []{5003}, visible: false);
                context.SetInteractObject(interactIds: new []{10001063}, state: 0);
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
                context.CreateMonster(spawnIds: new []{1015, 1016, 1017, 1018, 1019}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{1015, 1016, 1017, 1018, 1019})) {
                    return new StateMobBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobBattle01 : TriggerState {
            internal StateMobBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.ChangeMonster(removeSpawnId: 1015, addSpawnId: 2015);
                context.ChangeMonster(removeSpawnId: 1016, addSpawnId: 2016);
                context.ChangeMonster(removeSpawnId: 1017, addSpawnId: 2017);
                context.ChangeMonster(removeSpawnId: 1018, addSpawnId: 2018);
                context.ChangeMonster(removeSpawnId: 1019, addSpawnId: 2019);
                context.SetLadder(triggerId: 521, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 522, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 523, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 524, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 525, visible: false, animationEffect: false);
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
                context.ShowGuideSummary(entityId: 20002921, textId: 20002921, duration: 5000);
                context.SetInteractObject(interactIds: new []{10001063}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001063}, arg2: 0)) {
                    return new StateLadderOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOn01 : TriggerState {
            internal StateLadderOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 521, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 522, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 523, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 524, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 525, visible: true, animationEffect: true);
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
