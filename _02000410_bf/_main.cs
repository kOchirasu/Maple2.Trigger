using System;

namespace Maple2.Trigger._02000410_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {6010, 6011}, arg2: true, arg3: 1, arg4: 1);
                context.SetMesh(arg1: new int[] {6000, 6001, 6002, 6003}, arg2: false);
                context.SetMesh(arg1: new int[] {6004, 6005}, arg2: false);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 750, arg2: 1)) {
                    context.State = new State전투시작_인페르녹전함(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작_인페르녹전함 : TriggerState {
            internal State전투시작_인페르녹전함(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.DungeonSetLapTime(id: 1, lapTime: 420000);
                context.DungeonSetLapTime(id: 2, lapTime: 720000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State첫번째페이즈_인페르녹전함(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째페이즈_인페르녹전함 : TriggerState {
            internal State첫번째페이즈_인페르녹전함(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "SecondPhase", value: 1)) {
                    context.State = new State두번째페이즈_인페르녹전함(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째페이즈_인페르녹전함 : TriggerState {
            internal State두번째페이즈_인페르녹전함(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {6010, 6011, 6012, 6013, 6014, 6015, 6016}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0.5f);
                context.DungeonMissionComplete(feature: "DungeonRankBalance_01", missionID: 24090007);
                context.DungeonMissionComplete(feature: "DungeonRankBalance_02", missionID: 24090017);
            }

            public override void Execute() {
                if (context.UserValue(key: "ThirdPhase", value: 1)) {
                    context.State = new State세번째페이즈_인페르녹등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째페이즈_인페르녹등장 : TriggerState {
            internal State세번째페이즈_인페르녹등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMoveLapTimeToNow(id: true);
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.SetSound(arg1: 8410, arg2: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "BalrogMagicBursterBattlePhase", value: 1)) {
                    context.State = new State인페르녹전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹전투시작 : TriggerState {
            internal State인페르녹전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "Phase", value: 1);
            }

            public override void Execute() {
                if (context.DungeonCheckPlayTime(playSeconds: 720)) {
                    context.State = new State네번째페이즈_인페르녹광폭화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네번째페이즈_인페르녹광폭화 : TriggerState {
            internal State네번째페이즈_인페르녹광폭화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "Phase", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}