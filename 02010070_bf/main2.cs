namespace Maple2.Trigger._02010070_bf {
    public static class _main2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108});
                context.SetInteractObject(interactIds: new []{10000834}, state: 1);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 4, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{95001}, visible: false);
                context.DestroyMonster(spawnIds: new []{22210, 22211, 22212, 22213});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{999993})) {
                    return new StateWaitTime안내01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime안내01 : TriggerState {
            internal StateWaitTime안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 22210, 22211, 22212, 22213}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWaitTime02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime02 : TriggerState {
            internal StateWaitTime02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02010070_BF__MAIN__4$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{999983})) {
                    return new StateStart1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart1 : TriggerState {
            internal StateStart1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20100706, textId: 20100706, duration: 7000);
                context.MoveNpc(spawnId: 2108, patrolName: "MS2PatrolData0");
                context.SetConversation(type: 1, spawnId: 2108, script: "$02010070_BF__MAIN__1$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{88123})) {
                    return new StateStart112(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart112 : TriggerState {
            internal StateStart112(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 2108, script: "$02010070_BF__MAIN__2$", arg4: 4);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20100707, textId: 20100707);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000834}, arg2: 0)) {
                    return new StateStart2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart2 : TriggerState {
            internal StateStart2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{95001}, visible: true);
                context.HideGuideSummary(entityId: 20100707);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20100708, textId: 20100708);
                context.DestroyMonster(spawnIds: new []{2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108});
                context.CreateMonster(spawnIds: new []{2000, 2001, 2002, 2003}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateStart32(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart32 : TriggerState {
            internal StateStart32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2004, 2005}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2000, 2001, 2002, 2003, 2004, 2005})) {
                    return new StateStart3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart3 : TriggerState {
            internal StateStart3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20100708);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20100709, textId: 20100709);
                context.CreateMonster(spawnIds: new []{2006, 2007, 2008}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2006, 2007, 2008})) {
                    return new State시간1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시간1 : TriggerState {
            internal State시간1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20100709);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart5 : TriggerState {
            internal StateStart5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{70002, 70003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEffect(triggerIds: new []{70001}, visible: true);
                    context.SetSkill(triggerIds: new []{70004}, enabled: true);
                    return new StateStart6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart6 : TriggerState {
            internal StateStart6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 6);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.MoveUser(mapId: 02010070, portalId: 9);
                    return new StateStart7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart7 : TriggerState {
            internal StateStart7(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart8 : TriggerState {
            internal StateStart8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
