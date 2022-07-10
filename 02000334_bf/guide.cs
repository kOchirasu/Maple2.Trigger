namespace Maple2.Trigger._02000334_bf {
    public static class _guide {
        public class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 90099, spawnIds: new []{150})) {
                    return new State1차타이머(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateGuide_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide_01 : TriggerState {
            internal StateGuide_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 101, textId: 20000010);
                context.SetEffect(triggerIds: new []{90021}, visible: true);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 90001, spawnIds: new []{301})) {
                    return new State2차타이머(context);
                }

                if (context.TimeExpired(timerId: "5")) {
                    return new StateGuide_01_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 101);
            }
        }

        private class StateGuide_01_02 : TriggerState {
            internal StateGuide_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 90001, spawnIds: new []{301})) {
                    return new State2차타이머(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차타이머 : TriggerState {
            internal State2차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateGuide_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide_02 : TriggerState {
            internal StateGuide_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{90100})) {
                    return new State오스칼_배웅(context);
                }

                if (context.MonsterDead(spawnIds: new []{190})) {
                    return new StateGuide_02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide_02_02 : TriggerState {
            internal StateGuide_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{90100})) {
                    return new State오스칼_배웅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼_배웅 : TriggerState {
            internal State오스칼_배웅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 199, patrolName: "MS2PatrolData_2016");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
