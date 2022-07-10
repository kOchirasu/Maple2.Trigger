namespace Maple2.Trigger._02000297_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{6100, 6200});
                context.SetAgent(triggerIds: new []{101, 102, 103, 104, 105, 106, 121, 122, 123, 124, 125, 126, 127, 128}, visible: false);
                context.SetUserValue(key: "BattleStart", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay01 : TriggerState {
            internal StateLoadingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BattleStart") == 1) {
                    return new StateLoadingDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay02 : TriggerState {
            internal StateLoadingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattle01 : TriggerState {
            internal StateBossBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$02000297_BF__MAIN__0$", duration: 5000, boxId: 0);
                context.SetAgent(triggerIds: new []{101, 102, 103, 104, 105, 106, 121, 122, 123, 124, 125, 126, 127, 128}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBossBattle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattle02 : TriggerState {
            internal StateBossBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{6100});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{6200})) {
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
