using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000329_bf {
    public static class _01_main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{701}, arg2: false);
                context.SetEffect(triggerIds: new []{6701}, visible: true);
                context.CreateMonster(spawnIds: new []{5001, 5002, 1301, 1302, 1303, 1304}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 101) == 1) {
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
                context.SetSkip(state: new StateScene_02(context));
                context.CameraSelectPath(pathIds: new []{80001, 80002, 80003, 80004}, returnView: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateScene_02(context));
                context.SetConversation(type: 1, spawnId: 1301, script: "$02000329_BF__01_MAIN__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
                context.CameraSelectPath(pathIds: new []{80005}, returnView: true);
                context.SetEventUI(arg1: 1, script: "$02000329_BF__01_MAIN__1$", duration: 3000, boxId: 0);
                context.CreateMonster(spawnIds: new []{2001, 2002, 2003, 2004, 2005}, arg2: false);
                context.SetMesh(triggerIds: new []{10000, 11001, 11002, 11003, 19999}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 105) == 1) {
                    return new StateNpc_talk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_talk : TriggerState {
            internal StateNpc_talk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 1301, sequenceName: "Talk_A");
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 101, textId: 20000051, duration: 5000);
                context.SetConversation(type: 1, spawnId: 1301, script: "$02000329_BF__01_MAIN__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNpc_talk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_talk_02 : TriggerState {
            internal StateNpc_talk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 1301, sequenceName: "Talk_A");
                context.SetConversation(type: 1, spawnId: 1301, script: "$02000329_BF__01_MAIN__3$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
