using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000293_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2028, 2029, 2030, 2031, 2032, 2033, 2034, 2035, 2036});
                context.DestroyMonster(spawnIds: new []{25000, 25001, 25002, 25003, 25004, 25005, 25006, 25007, 25008});
                context.SetInteractObject(interactIds: new []{10000509}, state: 1);
                context.SetInteractObject(interactIds: new []{10000504, 10000505, 10000520, 10000521, 10000522, 10000523, 10000524, 10000529, 10000530, 10000531}, state: 0);
                context.SetPortal(portalId: 2, visible: true, enabled: false, minimapVisible: true);
                context.SetMesh(triggerIds: new []{510000, 3001, 3002, 3003, 3004, 3005, 3006}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 600, enabled: true);
                context.SetSkip(state: new StateCameraWalk01(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCameraWalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 600, enabled: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006}, visible: false, arg3: 0, arg4: 100, arg5: 2f);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002931, textId: 20002931);
                context.CreateMonster(spawnIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20)) {
                    return new State1TimedCreation(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State2TimedCreation(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State3TimedCreation(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State4TimedCreation(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State5TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1TimedCreation : TriggerState {
            internal State1TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000523, 10000505, 10000509, 10000520, 10000521, 10000522}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000523}, arg2: 0)) {
                    return new State1번아이템(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1번아이템 : TriggerState {
            internal State1번아이템(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002931);
                context.CreateMonster(spawnIds: new []{25000}, arg2: false);
                context.SetConversation(type: 1, spawnId: 25000, script: "$02000293_BF__MAIN__1$", arg4: 2);
                context.CreateItem(spawnIds: new []{500001});
                context.ShowGuideSummary(entityId: 20002932, textId: 20002932);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetTimer(timerId: "181", seconds: 181);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000509}, arg2: 0)) {
                    return new StateWaitDestroy(context);
                }

                if (context.TimeExpired(timerId: "181")) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2TimedCreation : TriggerState {
            internal State2TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000504, 10000524, 10000509, 10000520, 10000521, 10000522}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000524}, arg2: 0)) {
                    return new State2번아이템(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2번아이템 : TriggerState {
            internal State2번아이템(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002931);
                context.CreateMonster(spawnIds: new []{25001}, arg2: false);
                context.SetConversation(type: 1, spawnId: 25001, script: "$02000293_BF__MAIN__3$", arg4: 2);
                context.CreateItem(spawnIds: new []{500002});
                context.ShowGuideSummary(entityId: 20002932, textId: 20002932);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetTimer(timerId: "181", seconds: 181);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000509}, arg2: 0)) {
                    return new StateWaitDestroy(context);
                }

                if (context.TimeExpired(timerId: "181")) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3TimedCreation : TriggerState {
            internal State3TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000504, 10000505, 10000509, 10000529, 10000521, 10000522}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000529}, arg2: 0)) {
                    return new State3번아이템(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3번아이템 : TriggerState {
            internal State3번아이템(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002931);
                context.CreateMonster(spawnIds: new []{25006}, arg2: false);
                context.SetConversation(type: 1, spawnId: 25006, script: "$02000293_BF__MAIN__13$", arg4: 2);
                context.CreateItem(spawnIds: new []{500007});
                context.ShowGuideSummary(entityId: 20002932, textId: 20002932);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetTimer(timerId: "181", seconds: 181);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000509}, arg2: 0)) {
                    return new StateWaitDestroy(context);
                }

                if (context.TimeExpired(timerId: "181")) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4TimedCreation : TriggerState {
            internal State4TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000504, 10000505, 10000509, 10000520, 10000530, 10000522}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000530}, arg2: 0)) {
                    return new State4번아이템(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4번아이템 : TriggerState {
            internal State4번아이템(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002931);
                context.CreateMonster(spawnIds: new []{25007}, arg2: false);
                context.SetConversation(type: 1, spawnId: 25007, script: "$02000293_BF__MAIN__15$", arg4: 2);
                context.CreateItem(spawnIds: new []{500008});
                context.ShowGuideSummary(entityId: 20002932, textId: 20002932);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetTimer(timerId: "181", seconds: 181);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000509}, arg2: 0)) {
                    return new StateWaitDestroy(context);
                }

                if (context.TimeExpired(timerId: "181")) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5TimedCreation : TriggerState {
            internal State5TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000504, 10000505, 10000509, 10000520, 10000521, 10000531}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000531}, arg2: 0)) {
                    return new State5번아이템(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5번아이템 : TriggerState {
            internal State5번아이템(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002931);
                context.CreateMonster(spawnIds: new []{25008}, arg2: false);
                context.SetConversation(type: 1, spawnId: 25008, script: "$02000293_BF__MAIN__17$", arg4: 2);
                context.CreateItem(spawnIds: new []{500009});
                context.ShowGuideSummary(entityId: 20002932, textId: 20002932);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetTimer(timerId: "181", seconds: 181);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000509}, arg2: 0)) {
                    return new StateWaitDestroy(context);
                }

                if (context.TimeExpired(timerId: "181")) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDestroy : TriggerState {
            internal StateWaitDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{510000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State소멸2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002932);
                context.DestroyMonster(spawnIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2028, 2029, 2030, 2031, 2032, 2033, 2034, 2035, 2036});
                context.DestroyMonster(spawnIds: new []{25000, 25001, 25002, 25003, 25004, 25005, 25006, 25007, 25008});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸2 : TriggerState {
            internal State소멸2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002932);
                context.DestroyMonster(spawnIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2028, 2029, 2030, 2031, 2032, 2033, 2034, 2035, 2036});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
