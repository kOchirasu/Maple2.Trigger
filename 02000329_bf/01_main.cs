using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000329_bf {
    public static class _01_main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {701}, arg2: false);
                context.SetEffect(arg1: new[] {6701}, arg2: true);
                context.CreateMonster(arg1: new[] {5001, 5002, 1301, 1302, 1303, 1304}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetSkip(arg1: "scene_02");
                context.CameraSelectPath(arg1: new[] {80001, 80002, 80003, 80004}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetSkip(arg1: "scene_02");
                context.SetConversation(arg1: 1, arg2: 1301, arg3: "$02000329_BF__01_MAIN__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 7);
            }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 7);
                context.CameraSelectPath(arg1: new[] {80005}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000329_BF__01_MAIN__1$", arg3: 3000, arg4: "0");
                context.CreateMonster(arg1: new[] {2001, 2002, 2003, 2004, 2005}, arg2: false);
                context.SetMesh(arg1: new[] {10000, 11001, 11002, 11003, 19999}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 1301, arg2: "Talk_A");
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 101, textId: 20000051, duration: 5000);
                context.SetConversation(arg1: 1, arg2: 1301, arg3: "$02000329_BF__01_MAIN__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionSequence(arg1: 1301, arg2: "Talk_A");
                context.SetConversation(arg1: 1, arg2: 1301, arg3: "$02000329_BF__01_MAIN__3$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}