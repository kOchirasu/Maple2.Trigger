using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000335_bf {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906, 6907, 6908}, arg2: false, arg4: 0, arg5: 10f);
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 106, 107, 111, 120, 121, 124, 125, 131, 132, 133, 134, 135, 140, 143, 144, 145, 147, 148}, arg2: false);
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217}, arg2: false);
                context.SetEffect(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906}, arg2: false);
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 991, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 992, isEnable: false);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 700) == 1) {
                    context.State = new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State시작_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_02 : TriggerState {
            internal State시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSkip(arg1: "시작_03");
                context.SetConversation(arg1: 1, arg2: 203, arg3: "$02000335_BF__MAIN__0$", arg4: 2, arg5: 0);
                context.CameraSelectPath(arg1: new[] {80001, 80002, 80003, 80004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State시작_03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State시작_03 : TriggerState {
            internal State시작_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetEventUI(arg1: 1, arg2: "$02000335_BF__MAIN__1$", arg3: 3000, arg4: "0");
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State시작_04(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {6401, 6402, 6403, 6404}, arg2: false, arg4: 0, arg5: 10f);
            }
        }

        private class State시작_04 : TriggerState {
            internal State시작_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 105, textId: 20003361);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {107})) {
                    context.State = new State관문_01_개방(context);
                    return;
                }
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
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State관문_01_개방_02(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {106})) {
                    context.State = new State관문_02_개방(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 106);
            }
        }

        private class State관문_01_개방_02 : TriggerState {
            internal State관문_01_개방_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {106})) {
                    context.State = new State관문_02_개방(context);
                    return;
                }

                if (context.GetUserCount(boxId: 702) == 1) {
                    context.State = new State관문_01_개방_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방_03 : TriggerState {
            internal State관문_01_개방_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 105, textId: 20003361);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {106})) {
                    context.State = new State관문_02_개방(context);
                    return;
                }
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
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State관문_02_개방_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 106);
            }
        }

        private class State관문_02_개방_02 : TriggerState {
            internal State관문_02_개방_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}