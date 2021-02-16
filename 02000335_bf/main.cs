using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000335_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906, 6907, 6908}, arg2: false, arg4: 0, arg5: 10f);
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 106, 107, 111, 120, 121, 124, 125, 131, 132, 133, 134, 135, 140, 143, 144, 145, 147, 148}, arg2: false);
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217}, arg2: false);
                context.SetEffect(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906}, arg2: false);
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 991, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 992, isEnable: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 700) == 1) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip(state: new StateStart_03(context));
                context.SetConversation(arg1: 1, arg2: 203, script: "$02000335_BF__MAIN__0$", arg4: 2, arg5: 0);
                context.CameraSelectPath(pathIds: new[] {80001, 80002, 80003, 80004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetEventUI(arg1: 1, script: "$02000335_BF__MAIN__1$", arg3: 3000, arg4: "0");
                context.SetTimer(id: "3", arg2: 3, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {6401, 6402, 6403, 6404}, arg2: false, arg4: 0, arg5: 10f);
            }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 105, textId: 20003361);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {107})) {
                    return new State관문_01_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 105);
            }
        }

        private class State관문_01_개방 : TriggerState {
            internal State관문_01_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362);
                context.SetMesh(arg1: new[] {6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108}, arg2: false, arg4: 0, arg5: 10f);
                context.SetTimer(id: "3", arg2: 3, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State관문_01_개방_02(context);
                }

                if (context.MonsterDead(arg1: new[] {106})) {
                    return new State관문_02_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 106);
            }
        }

        private class State관문_01_개방_02 : TriggerState {
            internal State관문_01_개방_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {106})) {
                    return new State관문_02_개방(context);
                }

                if (context.GetUserCount(boxId: 702) == 1) {
                    return new State관문_01_개방_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방_03 : TriggerState {
            internal State관문_01_개방_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 105, textId: 20003361);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {106})) {
                    return new State관문_02_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 105);
            }
        }

        private class State관문_02_개방 : TriggerState {
            internal State관문_02_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 991, isEnable: true);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362);
                context.SetMesh(arg1: new[] {6111, 6112, 6113, 6114, 6115, 6116, 6117, 6118}, arg2: false, arg4: 0, arg5: 10f);
                context.SetTimer(id: "3", arg2: 3, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State관문_02_개방_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 106);
            }
        }

        private class State관문_02_개방_02 : TriggerState {
            internal State관문_02_개방_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}