namespace Maple2.Trigger._52000090_qd {
    public static class _52000090_trigger {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029});
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9100}, questIds: new []{50100470}, questStates: new byte[]{1})) {
                    return new State20002272진행중일때(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9100}, questIds: new []{20002272}, questStates: new byte[]{1})) {
                    return new State20002272진행중일때(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002272진행중일때 : TriggerState {
            internal State20002272진행중일때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(spawnIds: new []{1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010}, isAutoTargeting: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State20002272진행중일때02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002272진행중일때02 : TriggerState {
            internal State20002272진행중일때02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(spawnIds: new []{1011, 1012, 1013, 1014, 1015}, isAutoTargeting: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State20002272진행중일때03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002272진행중일때03 : TriggerState {
            internal State20002272진행중일때03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(spawnIds: new []{1016, 1017, 1018, 1019, 1020}, isAutoTargeting: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State20002272진행중일때04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002272진행중일때04 : TriggerState {
            internal State20002272진행중일때04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(spawnIds: new []{1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029}, isAutoTargeting: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
