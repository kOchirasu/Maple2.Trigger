using System;

namespace Maple2.Trigger._99999912 {
    public static class _01_movetest {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateInit(context);

        private class StateInit : TriggerState {
            internal StateInit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateFieldGame(type: "GuildVsGame");
                context.UserTagSymbol(symbol1: "guild_game_red", symbol2: "guild_game_blue");
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9000, arg2: 1, arg3: ">=", userTagID: 1)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001129}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10001130}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10001131}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001129}, arg2: 0)) {
                    context.State = new StateMove01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMove01 : TriggerState {
            internal StateMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(@string: "강제이동 트리거가 발동됩니다.");
                context.MoveToPortal(userTagId: 1, portalId: 1);
                context.MoveToPortal(userTagId: 2, portalId: 2);
                context.ShowEventResult(type: "notice", text: @"1팀 안녕?\n줄바꿈확인", duration: 3000, userTagID: 1);
                context.ShowEventResult(type: "notice", text: @"2팀 안녕?\n줄바꿈확인", duration: 3000, userTagID: 2);
                context.PlaySystemSoundByUserTag(userTagID: 1, soundKey: "System_ShowGuideSummary_01");
                context.PlaySystemSoundByUserTag(userTagID: 2, soundKey: "System_PartTimeJob_Right_01");
                context.GuildVsGameScoreByUser(triggerBoxID: 9000, score: true,
                    desc: "9000 트리거 박스 안의 유저수가 많은 팀에 1점을 추가한다.");
                context.GuildVsGameGiveReward(type: "exp", teamID: 1, isWin: "true", desc: "길드 경험치를 지급한다.");
                context.GuildVsGameGiveReward(type: "fund", teamID: 1, isWin: "true", desc: "길드 기금을 지급한다.");
                context.GuildVsGameGiveContribution(teamID: 1, isWin: "true", desc: "길드 기여도를 지급한다.");
                context.GuildVsGameGiveReward(type: "exp", teamID: 2, isWin: "false", desc: "길드 경험치를 지급한다.");
                context.GuildVsGameGiveReward(type: "fund", teamID: 2, isWin: "false", desc: "길드 기금을 지급한다.");
                context.GuildVsGameGiveContribution(teamID: 2, isWin: "false", desc: "길드 기여도를 지급한다.");
                context.GuildVsGameResult(desc: "결과창을 출력");
                context.GuildVsGameLogResult(desc: "로그를 남긴다");
                context.GuildVsGameLogWonByDefault(teamID: 1, desc: "1팀의 부전승 보상 로그를 남긴다.");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePrintWinnerTeam(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePrintWinnerTeam : TriggerState {
            internal StatePrintWinnerTeam(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GuildVsGameScoredTeam(teamID: 1)) {
                    context.DebugString(@string: "1팀이 득점 했습니다");
                    context.State = new StateReset(context);
                    return;
                }

                if (context.GuildVsGameScoredTeam(teamID: 2)) {
                    context.DebugString(@string: "2팀이 득점 했습니다");
                    context.State = new StateReset(context);
                    return;
                }

                if (context.GuildVsGameScoredTeam(teamID: 0)) {
                    context.DebugString(@string: "아직 득점한 팀이 없습니다.");
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(@string: "트리거 초기화");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}