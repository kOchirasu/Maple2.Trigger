using Maple2.Trigger.Enum;

namespace Maple2.Trigger._99999912 {
    public static class _01_movetest {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateFieldGame(type: FieldGame.GuildVsGame);
                context.UserTagSymbol(symbol1: "guild_game_red", symbol2: "guild_game_blue");
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9000, userTagId: 1) >= 1) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001129, 10001130, 10001131}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001129}, arg2: 0)) {
                    return new StateMove01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMove01 : TriggerState {
            internal StateMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "강제이동 트리거가 발동됩니다.");
                context.MoveToPortal(userTagId: 1, portalId: 1);
                context.MoveToPortal(userTagId: 2, portalId: 2);
                context.ShowEventResult(type: EventResultType.Notice, text: @"1팀 안녕?\n줄바꿈확인", duration: 3000, userTagId: 1);
                context.ShowEventResult(type: EventResultType.Notice, text: @"2팀 안녕?\n줄바꿈확인", duration: 3000, userTagId: 2);
                context.PlaySystemSoundByUserTag(userTagId: 1, sound: "System_ShowGuideSummary_01");
                context.PlaySystemSoundByUserTag(userTagId: 2, sound: "System_PartTimeJob_Right_01");
                context.GuildVsGameScoreByUser(boxId: 9000, score: true, description: "9000 트리거 박스 안의 유저수가 많은 팀에 1점을 추가한다.");
                context.GuildVsGameGiveReward(type: GuildReward.Experience, teamId: 1, isWin: true, description: "길드 경험치를 지급한다.");
                context.GuildVsGameGiveReward(type: GuildReward.Funds, teamId: 1, isWin: true, description: "길드 기금을 지급한다.");
                context.GuildVsGameGiveContribution(teamId: 1, isWin: true, description: "길드 기여도를 지급한다.");
                context.GuildVsGameGiveReward(type: GuildReward.Experience, teamId: 2, isWin: false, description: "길드 경험치를 지급한다.");
                context.GuildVsGameGiveReward(type: GuildReward.Funds, teamId: 2, isWin: false, description: "길드 기금을 지급한다.");
                context.GuildVsGameGiveContribution(teamId: 2, isWin: false, description: "길드 기여도를 지급한다.");
                context.GuildVsGameResult(description: "결과창을 출력");
                context.GuildVsGameLogResult(description: "로그를 남긴다");
                context.GuildVsGameLogWonByDefault(teamId: 1, description: "1팀의 부전승 보상 로그를 남긴다.");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePrintWinnerTeam(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePrintWinnerTeam : TriggerState {
            internal StatePrintWinnerTeam(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GuildVsGameWinnerTeam(teamId: 1)) {
                    context.DebugString(message: "1팀이 득점 했습니다");
                    return new StateReset(context);
                }

                if (context.GuildVsGameWinnerTeam(teamId: 2)) {
                    context.DebugString(message: "2팀이 득점 했습니다");
                    return new StateReset(context);
                }

                if (context.GuildVsGameWinnerTeam(teamId: 0)) {
                    context.DebugString(message: "아직 득점한 팀이 없습니다.");
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "트리거 초기화");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
