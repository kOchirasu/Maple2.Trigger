using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000354_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7701, 7702, 7703, 7704, 7705}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7701}, visible: true);
                context.SetMesh(triggerIds: new []{6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012}, visible: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{11, 12, 13, 14, 15, 16, 17}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{11, 12, 13, 14, 15, 16, 17})) {
                    return new State관문_01_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class State관문_01_개방 : TriggerState {
            internal State관문_01_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7702}, visible: true);
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 113, textId: 40011);
                context.SetMesh(triggerIds: new []{6021, 6022, 6023, 6024, 6025, 6026, 6027, 6028, 6029, 6030, 6031, 6032, 6033}, visible: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 703) == 1) {
                    return new State관문_02_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_시작 : TriggerState {
            internal State관문_02_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{21, 22, 23, 24, 25, 26, 27}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{21, 22, 23, 24, 25, 26, 27})) {
                    return new State관문_02_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class State관문_02_개방 : TriggerState {
            internal State관문_02_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7703}, visible: true);
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 113, textId: 40011);
                context.SetMesh(triggerIds: new []{6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062, 6063, 6064, 6065, 6066, 6067, 6068, 6069, 6070, 6071, 6072, 6073, 6074, 6075, 6076, 6077, 6078, 6079, 6080, 6081, 6082, 6083}, visible: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 704) == 1) {
                    return new State관문_03_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_03_시작 : TriggerState {
            internal State관문_03_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{31, 32, 33, 34, 35, 36, 37, 38, 39}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{31, 32, 33, 34, 35, 36, 37, 38, 39})) {
                    return new State관문_03_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class State관문_03_개방 : TriggerState {
            internal State관문_03_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7704}, visible: true);
                context.SetMesh(triggerIds: new []{6111, 6112, 6113, 6114, 6115, 6116, 6117, 6118, 6119, 6120, 6121, 6122, 6123}, visible: false, arg4: 0, arg5: 10f);
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 113, textId: 40011);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 705) == 1) {
                    return new State관문_04_시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class State관문_04_시작 : TriggerState {
            internal State관문_04_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{41, 42, 43, 44, 45, 46, 47, 48}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{341, 42, 43, 44, 45, 46, 47, 48})) {
                    return new State관문_04_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class State관문_04_개방 : TriggerState {
            internal State관문_04_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7705}, visible: true);
                context.SetMesh(triggerIds: new []{6151, 6152, 6153, 6154, 6155, 6156, 6157, 6158, 6159, 6160, 6161, 6162, 6163, 6164, 6165, 6166}, visible: false, arg4: 0, arg5: 10f);
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 113, textId: 40011);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 706) == 1) {
                    return new State관문_05_시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 113);
            }
        }

        private class State관문_05_시작 : TriggerState {
            internal State관문_05_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{51}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{51})) {
                    return new State관문_05_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class State관문_05_개방 : TriggerState {
            internal State관문_05_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 112, textId: 40009);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 112);
            }
        }
    }
}
