namespace Maple2.Trigger._02000304_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 201, visible: false, initialSequence: "Closed_A");
                context.SetActor(triggerId: 202, visible: false, initialSequence: "Closed_A");
                context.SetActor(triggerId: 203, visible: true, initialSequence: "sf_functobj_monitor_C01_On");
                context.SetEffect(triggerIds: new []{602, 603}, visible: false);
                context.SetPortal(portalId: 98, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 99, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10000646}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100})) {
                    context.CreateMonster(spawnIds: new []{2001}, arg2: false);
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCamera이동Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동Wait : TriggerState {
            internal StateCamera이동Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateBattleStartWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStartWait : TriggerState {
            internal StateBattleStartWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003041, textId: 20003041, duration: 4000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 301, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{2001})) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 2001, script: "$02000304_BF__MAIN__1$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    context.SetActor(triggerId: 203, visible: false, initialSequence: "sf_functobj_monitor_C01_On");
                    context.SetInteractObject(interactIds: new []{10000646}, state: 1);
                    return new State반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait : TriggerState {
            internal State반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{603}, visible: true);
                context.ShowGuideSummary(entityId: 20003003, textId: 20003003);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000646}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003003);
                    context.SetEffect(triggerIds: new []{603}, visible: false);
                    context.SetEffect(triggerIds: new []{602}, visible: true);
                    context.SetAchievement(triggerId: 999, type: "trigger", code: "ClearTimehole");
                    return new State미션Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미션Success : TriggerState {
            internal State미션Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 201, visible: true, initialSequence: "Closed_A");
                context.SetActor(triggerId: 202, visible: true, initialSequence: "Closed_A");
                context.SetPortal(portalId: 99, visible: false, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 98, visible: false, enabled: true, minimapVisible: true);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd2 : TriggerState {
            internal StateEnd2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
