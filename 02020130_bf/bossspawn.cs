namespace Maple2.Trigger._02020130_bf {
    public static class _bossspawn {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022}, visible: false);
                context.SetPortal(portalId: 20, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 21, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 22, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 23, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{600})) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{701, 702, 703}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{701, 702, 703})) {
                    return new StateEndDelay(context);
                }

                if (context.DungeonTimeOut()) {
                    return new StateDungeonFailure(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new StateDungeonFailure(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndDelay : TriggerState {
            internal StateEndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonStopTimer();
                context.DungeonMissionComplete(missionId: 23040000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.DungeonClear();
                    context.SetAchievement(type: "trigger", code: "IshuraFinalDungeonClear");
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonFailure : TriggerState {
            internal StateDungeonFailure(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.DungeonFail();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 20, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 21, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 22, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 23, visible: true, enabled: true, minimapVisible: true);
                context.DungeonEnableGiveUp(enable: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
