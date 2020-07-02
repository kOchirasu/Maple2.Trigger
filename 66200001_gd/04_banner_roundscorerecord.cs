namespace Maple2.Trigger._66200001_gd {
    public static class _04_banner_roundscorerecord {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {999, 1000, 1100}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {1001, 1002, 1003, 1100, 1101, 1102, 1103}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateEnter(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {1000, 1100}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class StateEnter : TriggerState {
            internal StateEnter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromGuildVsGameScore(teamId: 1, key: "BlueteamScore");
                context.UserValueToNumberMesh(key: "BlueteamScore", startMeshId: 1000, digitCount: 1);
                context.SetUserValueFromGuildVsGameScore(teamId: 2, key: "RedteamScore");
                context.UserValueToNumberMesh(key: "RedteamScore", startMeshId: 1100, digitCount: 1);
                context.SetUserValue(key: "RoundScoreRecord", value: 0);
                context.SetUserValue(key: "BlueteamScore", value: 0);
                context.SetUserValue(key: "RedteamScore", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "RoundScoreRecord") == 1) {
                    return new StateR01BannerUpdate(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01BannerUpdate : TriggerState {
            internal StateR01BannerUpdate(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromGuildVsGameScore(teamId: 1, key: "BlueteamScore");
                context.UserValueToNumberMesh(key: "BlueteamScore", startMeshId: 1000, digitCount: 1);
                context.SetUserValueFromGuildVsGameScore(teamId: 2, key: "RedteamScore");
                context.UserValueToNumberMesh(key: "RedteamScore", startMeshId: 1100, digitCount: 1);
                context.SetUserValue(key: "RoundScoreRecord", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "RoundScoreRecord") == 2) {
                    return new StateR02BannerUpdate(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02BannerUpdate : TriggerState {
            internal StateR02BannerUpdate(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromGuildVsGameScore(teamId: 1, key: "BlueteamScore");
                context.UserValueToNumberMesh(key: "BlueteamScore", startMeshId: 1000, digitCount: 1);
                context.SetUserValueFromGuildVsGameScore(teamId: 2, key: "RedteamScore");
                context.UserValueToNumberMesh(key: "RedteamScore", startMeshId: 1100, digitCount: 1);
                context.SetUserValue(key: "RoundScoreRecord", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "RoundScoreRecord") == 3) {
                    return new StateR03BannerUpdate(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03BannerUpdate : TriggerState {
            internal StateR03BannerUpdate(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromGuildVsGameScore(teamId: 1, key: "BlueteamScore");
                context.UserValueToNumberMesh(key: "BlueteamScore", startMeshId: 1000, digitCount: 1);
                context.SetUserValueFromGuildVsGameScore(teamId: 2, key: "RedteamScore");
                context.UserValueToNumberMesh(key: "RedteamScore", startMeshId: 1100, digitCount: 1);
                context.SetUserValue(key: "RoundScoreRecord", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BlueteamScore") == 3) {
                    return new StateBlueTeamWin(context);
                }

                if (context.GetUserValue(key: "RedteamScore") == 3) {
                    return new StateRedTeamWin(context);
                }

                if (context.GetUserValue(key: "RoundScoreRecord") == 4) {
                    return new StateR04BannerUpdate(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04BannerUpdate : TriggerState {
            internal StateR04BannerUpdate(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromGuildVsGameScore(teamId: 1, key: "BlueteamScore");
                context.UserValueToNumberMesh(key: "BlueteamScore", startMeshId: 1000, digitCount: 1);
                context.SetUserValueFromGuildVsGameScore(teamId: 2, key: "RedteamScore");
                context.UserValueToNumberMesh(key: "RedteamScore", startMeshId: 1100, digitCount: 1);
                context.SetUserValue(key: "RoundScoreRecord", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BlueteamScore") == 3) {
                    return new StateBlueTeamWin(context);
                }

                if (context.GetUserValue(key: "RedteamScore") == 3) {
                    return new StateRedTeamWin(context);
                }

                if (context.GetUserValue(key: "RoundScoreRecord") == 5) {
                    return new StateR05BannerUpdate(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05BannerUpdate : TriggerState {
            internal StateR05BannerUpdate(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromGuildVsGameScore(teamId: 1, key: "BlueteamScore");
                context.UserValueToNumberMesh(key: "BlueteamScore", startMeshId: 1000, digitCount: 1);
                context.SetUserValueFromGuildVsGameScore(teamId: 2, key: "RedteamScore");
                context.UserValueToNumberMesh(key: "RedteamScore", startMeshId: 1100, digitCount: 1);
                context.SetUserValue(key: "RoundScoreRecord", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BlueteamScore") == 3) {
                    return new StateBlueTeamWin(context);
                }

                if (context.GetUserValue(key: "RedteamScore") == 3) {
                    return new StateRedTeamWin(context);
                }

                if (context.GetUserValue(key: "RoundScoreRecord") == 5) {
                    return new StateEndGame(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlueTeamWin : TriggerState {
            internal StateBlueTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "WinnerTeam", value: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateRedTeamWin : TriggerState {
            internal StateRedTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "WinnerTeam", value: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndGame : TriggerState {
            internal StateEndGame(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}