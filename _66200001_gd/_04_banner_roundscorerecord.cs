using System;

namespace Maple2.Trigger._66200001_gd {
    public static class _04_banner_roundscorerecord {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {999}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1100}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1001, 1002, 1003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1100, 1101, 1102, 1103}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateEnter(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetMesh(arg1: new int[] {1000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1100}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class StateEnter : TriggerState {
            internal StateEnter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromGuildVsGameScore(teamID: 1, key: "BlueteamScore");
                context.UserValueToNumberMesh(key: "BlueteamScore", startMeshID: 1000, digitCount: 1);
                context.SetUserValueFromGuildVsGameScore(teamID: 2, key: "RedteamScore");
                context.UserValueToNumberMesh(key: "RedteamScore", startMeshID: 1100, digitCount: 1);
                context.SetUserValue(key: "RoundScoreRecord", value: 0);
                context.SetUserValue(key: "BlueteamScore", value: 0);
                context.SetUserValue(key: "RedteamScore", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "RoundScoreRecord", value: 1)) {
                    context.State = new StateR01BannerUpdate(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR01BannerUpdate : TriggerState {
            internal StateR01BannerUpdate(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromGuildVsGameScore(teamID: 1, key: "BlueteamScore");
                context.UserValueToNumberMesh(key: "BlueteamScore", startMeshID: 1000, digitCount: 1);
                context.SetUserValueFromGuildVsGameScore(teamID: 2, key: "RedteamScore");
                context.UserValueToNumberMesh(key: "RedteamScore", startMeshID: 1100, digitCount: 1);
                context.SetUserValue(key: "RoundScoreRecord", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "RoundScoreRecord", value: 2)) {
                    context.State = new StateR02BannerUpdate(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR02BannerUpdate : TriggerState {
            internal StateR02BannerUpdate(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromGuildVsGameScore(teamID: 1, key: "BlueteamScore");
                context.UserValueToNumberMesh(key: "BlueteamScore", startMeshID: 1000, digitCount: 1);
                context.SetUserValueFromGuildVsGameScore(teamID: 2, key: "RedteamScore");
                context.UserValueToNumberMesh(key: "RedteamScore", startMeshID: 1100, digitCount: 1);
                context.SetUserValue(key: "RoundScoreRecord", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "RoundScoreRecord", value: 3)) {
                    context.State = new StateR03BannerUpdate(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR03BannerUpdate : TriggerState {
            internal StateR03BannerUpdate(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromGuildVsGameScore(teamID: 1, key: "BlueteamScore");
                context.UserValueToNumberMesh(key: "BlueteamScore", startMeshID: 1000, digitCount: 1);
                context.SetUserValueFromGuildVsGameScore(teamID: 2, key: "RedteamScore");
                context.UserValueToNumberMesh(key: "RedteamScore", startMeshID: 1100, digitCount: 1);
                context.SetUserValue(key: "RoundScoreRecord", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "BlueteamScore", value: 3)) {
                    context.State = new StateBlueTeamWin(context);
                    return;
                }

                if (context.UserValue(key: "RedteamScore", value: 3)) {
                    context.State = new StateRedTeamWin(context);
                    return;
                }

                if (context.UserValue(key: "RoundScoreRecord", value: 4)) {
                    context.State = new StateR04BannerUpdate(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR04BannerUpdate : TriggerState {
            internal StateR04BannerUpdate(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromGuildVsGameScore(teamID: 1, key: "BlueteamScore");
                context.UserValueToNumberMesh(key: "BlueteamScore", startMeshID: 1000, digitCount: 1);
                context.SetUserValueFromGuildVsGameScore(teamID: 2, key: "RedteamScore");
                context.UserValueToNumberMesh(key: "RedteamScore", startMeshID: 1100, digitCount: 1);
                context.SetUserValue(key: "RoundScoreRecord", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "BlueteamScore", value: 3)) {
                    context.State = new StateBlueTeamWin(context);
                    return;
                }

                if (context.UserValue(key: "RedteamScore", value: 3)) {
                    context.State = new StateRedTeamWin(context);
                    return;
                }

                if (context.UserValue(key: "RoundScoreRecord", value: 5)) {
                    context.State = new StateR05BannerUpdate(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateR05BannerUpdate : TriggerState {
            internal StateR05BannerUpdate(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromGuildVsGameScore(teamID: 1, key: "BlueteamScore");
                context.UserValueToNumberMesh(key: "BlueteamScore", startMeshID: 1000, digitCount: 1);
                context.SetUserValueFromGuildVsGameScore(teamID: 2, key: "RedteamScore");
                context.UserValueToNumberMesh(key: "RedteamScore", startMeshID: 1100, digitCount: 1);
                context.SetUserValue(key: "RoundScoreRecord", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "BlueteamScore", value: 3)) {
                    context.State = new StateBlueTeamWin(context);
                    return;
                }

                if (context.UserValue(key: "RedteamScore", value: 3)) {
                    context.State = new StateRedTeamWin(context);
                    return;
                }

                if (context.UserValue(key: "RoundScoreRecord", value: 5)) {
                    context.State = new StateEndGame(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlueTeamWin : TriggerState {
            internal StateBlueTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "WinnerTeam", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateRedTeamWin : TriggerState {
            internal StateRedTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "WinnerTeam", value: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateEndGame : TriggerState {
            internal StateEndGame(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}