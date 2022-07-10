namespace Maple2.Trigger._02100004_bf {
    public static class _achieve_tentomanfight {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "LastRoundStart", value: 0);
                context.SetUserValue(key: "LastRoundEnd", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "LastRoundStart") == 1) {
                    return new StateMobCheck01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCheck01 : TriggerState {
            internal StateMobCheck01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{2000})) {
                    return new StateMobCheck02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCheck02 : TriggerState {
            internal StateMobCheck02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (!context.NpcDetected(boxId: 102, spawnIds: new []{2001}) && !context.NpcDetected(boxId: 102, spawnIds: new []{2002}) && !context.NpcDetected(boxId: 102, spawnIds: new []{2003}) && !context.NpcDetected(boxId: 102, spawnIds: new []{2004}) && !context.NpcDetected(boxId: 102, spawnIds: new []{2005}) && !context.NpcDetected(boxId: 102, spawnIds: new []{2006}) && !context.NpcDetected(boxId: 102, spawnIds: new []{2008}) && !context.NpcDetected(boxId: 102, spawnIds: new []{2009}) && !context.NpcDetected(boxId: 102, spawnIds: new []{2010}) && !context.NpcDetected(boxId: 102, spawnIds: new []{2011}) && !context.NpcDetected(boxId: 102, spawnIds: new []{2012}) && !context.NpcDetected(boxId: 102, spawnIds: new []{2013})) {
                    return new StateCheckSuccess(context);
                }

                if (context.GetUserValue(key: "LastRoundEnd") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSuccess : TriggerState {
            internal StateCheckSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2000})) {
                    return new StateMemberCheck(context);
                }

                if (context.GetUserValue(key: "LastRoundEnd") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMemberCheck : TriggerState {
            internal StateMemberCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 102) == 10) {
                    return new StateAchieve(context);
                }

                if (context.GetUserValue(key: "LastRoundEnd") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAchieve : TriggerState {
            internal StateAchieve(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 102, type: "trigger", code: "TenToOneFight");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
