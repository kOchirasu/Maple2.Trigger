using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02010070_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 800, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{699, 700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724, 725, 726, 727, 728, 729, 730, 731, 732, 733, 734, 735, 736, 737}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(triggerIds: new []{7004}, arg2: false);
                context.SetEffect(triggerIds: new []{7000, 7001, 7002, 7003, 7010, 7011, 7012}, visible: false);
                context.DestroyMonster(spawnIds: new []{22201, 22202, 22203, 22204, 1000, 1001, 1002, 1003, 1004, 1005, 1006});
                context.SetEffect(triggerIds: new []{95222}, visible: false);
                context.CreateMonster(spawnIds: new []{1007, 1008}, arg2: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5, visible: false, enabled: false, minimapVisible: false);
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
                context.SetActor(triggerId: 800, visible: true, initialSequence: "Opend");
                context.SetMesh(triggerIds: new []{699}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGateOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGateOpen : TriggerState {
            internal StateGateOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 800, visible: false, initialSequence: "Opend");
                context.SetRandomMesh(triggerIds: new []{700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724, 725, 726, 727, 728, 729, 730, 731, 732, 733, 734, 735, 736, 737}, visible: false, meshCount: 38, arg4: 50, delay: 2);
                context.SetEffect(triggerIds: new []{7010, 7011, 7012}, visible: true);
                context.CreateMonster(spawnIds: new []{22201, 22202, 22203, 22204}, arg2: false);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20100701, textId: 20100701, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{999992})) {
                    return new StateStart1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart1 : TriggerState {
            internal StateStart1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{95222}, visible: true);
                context.SetEventUI(arg1: 1, script: "$02010070_BF__MAIN__3$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStart2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart2 : TriggerState {
            internal StateStart2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1007, 1008});
                context.CreateMonster(spawnIds: new []{1000, 1001, 1002}, arg2: true);
                context.SetEffect(triggerIds: new []{7010, 7011, 7012}, visible: false);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20100702, textId: 20100702, duration: 7000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1000, 1001, 1002})) {
                    return new StateStart3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart3 : TriggerState {
            internal StateStart3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1003, 1004, 1005}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateStart4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart4 : TriggerState {
            internal StateStart4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1006}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1003, 1004, 1005, 1006})) {
                    return new State시간1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시간1 : TriggerState {
            internal State시간1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "150", seconds: 5);
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
                context.SetEffect(triggerIds: new []{7002, 7003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEffect(triggerIds: new []{7001}, visible: true);
                    context.SetSkill(triggerIds: new []{7004}, arg2: true);
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
                    context.MoveUser(mapId: 02010070, portalId: 3);
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
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
