namespace Maple2.Trigger._02000282_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000424, 10000425, 10000426}, state: 0);
                context.SetInteractObject(interactIds: new []{10000433, 10000434, 10000435}, state: 2);
                context.SetLadder(triggerId: 341, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 342, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 343, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 351, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 352, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 353, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 361, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 362, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 363, visible: false, animationEffect: false);
                context.SetPortal(portalId: 4, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 33f)) {
                    return new State4TimedCreation(context);
                }

                if (context.RandomCondition(rate: 33f)) {
                    return new State5TimedCreation(context);
                }

                if (context.RandomCondition(rate: 34f)) {
                    return new State6TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4TimedCreation : TriggerState {
            internal State4TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000424}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000424}, arg2: 0)) {
                    return new State4번Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4번Monster : TriggerState {
            internal State4번Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2004}, arg2: false);
                context.ShowGuideSummary(entityId: 20002817, textId: 20002817, duration: 5000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2004})) {
                    context.ShowGuideSummary(entityId: 20002812, textId: 20002812, duration: 5000);
                    context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                    context.SetLadder(triggerId: 341, visible: true, animationEffect: true);
                    context.SetLadder(triggerId: 342, visible: true, animationEffect: true);
                    context.SetLadder(triggerId: 343, visible: true, animationEffect: true);
                    context.SetPortal(portalId: 4, visible: false, enabled: true, minimapVisible: true);
                    return new StateWaitDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5TimedCreation : TriggerState {
            internal State5TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000425}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000425}, arg2: 0)) {
                    return new State5번Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5번Monster : TriggerState {
            internal State5번Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2005}, arg2: false);
                context.ShowGuideSummary(entityId: 20002817, textId: 20002817, duration: 5000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2005})) {
                    context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                    context.ShowGuideSummary(entityId: 20002812, textId: 20002812, duration: 5000);
                    context.SetLadder(triggerId: 351, visible: true, animationEffect: true);
                    context.SetLadder(triggerId: 352, visible: true, animationEffect: true);
                    context.SetLadder(triggerId: 353, visible: true, animationEffect: true);
                    context.SetPortal(portalId: 5, visible: false, enabled: true, minimapVisible: true);
                    return new StateWaitDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6TimedCreation : TriggerState {
            internal State6TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000426}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000426}, arg2: 0)) {
                    return new State6번Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6번Monster : TriggerState {
            internal State6번Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2006}, arg2: false);
                context.ShowGuideSummary(entityId: 20002817, textId: 20002817, duration: 5000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2006})) {
                    context.ShowGuideSummary(entityId: 20002812, textId: 20002812, duration: 5000);
                    context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                    context.SetLadder(triggerId: 361, visible: true, animationEffect: true);
                    context.SetLadder(triggerId: 362, visible: true, animationEffect: true);
                    context.SetLadder(triggerId: 363, visible: true, animationEffect: true);
                    context.SetPortal(portalId: 6, visible: false, enabled: true, minimapVisible: true);
                    return new StateWaitDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDestroy : TriggerState {
            internal StateWaitDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
