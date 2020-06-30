using System;

namespace Maple2.Trigger._61000029_me {
    public static class _61000029_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateNone(context);

        private class StateNone : TriggerState {
            internal StateNone(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateFieldGame(type: "HideAndSeek", reset: true);
                context.FieldGameConstant(key: "BeginTriggerID", value: "1");
                context.FieldGameConstant(key: "EndTriggerID", value: "36");
                context.FieldGameConstant(key: "RequireUserCount", value: "2");
                context.FieldGameConstant(key: "EnterableSeconds", value: "60");
                context.FieldGameConstant(key: "GameRuleNoticeTick", value: "10000");
                context.FieldGameConstant(key: "ShortOfUserTick", value: "10000");
                context.FieldGameConstant(key: "DivideTeamsSeconds", value: "5");
                context.FieldGameConstant(key: "MoveGameAreaTick", value: "2000");
                context.FieldGameConstant(key: "BeInHidingTeamsSeconds", value: "30");
                context.FieldGameConstant(key: "LookingForATeamsSeconds", value: "150");
                context.FieldGameConstant(key: "TeamMatchResultTick", value: "15000");
                context.FieldGameConstant(key: "GameExitNoticeTick", value: "10000");
                context.FieldGameConstant(key: "HideTeamExpDurationTick", value: "30000");
                context.FieldGameConstant(key: "SeekTeamInvincibleTick", value: "20000");
                context.FieldGameConstant(key: "InvincibleNoticeTick", value: "7000");
                context.FieldGameConstant(key: "InvincibleMessage", value: "$61000023_ME__61000023_MAIN__6$");
                context.FieldGameConstant(key: "PortalWaitAreaID", value: "1");
                context.FieldGameConstant(key: "PortalGameAreaID", value: "10");
                context.FieldGameConstant(key: "PortalFailAreaID", value: "20");
                context.FieldGameConstant(key: "SeekTeamSkillSetID", value: "99930041");
                context.FieldGameConstant(key: "HideTeamExp", value: "0");
                context.FieldGameConstant(key: "SeekTeamExp", value: "0");
                context.FieldGameConstant(key: "WinnerRewardItemID", value: "30001442", feature: "MassiveHideAndSeek",
                    locale: "KR");
                context.FieldGameConstant(key: "WinnerRewardItemRank", value: "1", feature: "MassiveHideAndSeek",
                    locale: "KR");
                context.FieldGameConstant(key: "WinnerRewardItemCount", value: "3", feature: "MassiveHideAndSeek",
                    locale: "KR");
                context.FieldGameConstant(key: "LoserRewardItemID", value: "30001442", feature: "MassiveHideAndSeek",
                    locale: "KR");
                context.FieldGameConstant(key: "LoserRewardItemRank", value: "1", feature: "MassiveHideAndSeek",
                    locale: "KR");
                context.FieldGameConstant(key: "LoserRewardItemCount", value: "1", feature: "MassiveHideAndSeek",
                    locale: "KR");
                context.FieldGameConstant(key: "WinnerRewardItemID", value: "30001446", feature: "MassiveHideAndSeek",
                    locale: "CN");
                context.FieldGameConstant(key: "WinnerRewardItemRank", value: "1", feature: "MassiveHideAndSeek",
                    locale: "CN");
                context.FieldGameConstant(key: "WinnerRewardItemCount", value: "3", feature: "MassiveHideAndSeek",
                    locale: "CN");
                context.FieldGameConstant(key: "LoserRewardItemID", value: "30001446", feature: "MassiveHideAndSeek",
                    locale: "CN");
                context.FieldGameConstant(key: "LoserRewardItemRank", value: "1", feature: "MassiveHideAndSeek",
                    locale: "CN");
                context.FieldGameConstant(key: "LoserRewardItemCount", value: "1", feature: "MassiveHideAndSeek",
                    locale: "CN");
                context.FieldGameConstant(key: "WatchCameraID", value: "101");
                context.FieldGameConstant(key: "EventDailyQuestStart", value: "dailyquest_start");
                context.FieldGameConstant(key: "EventHideAndSeekStart", value: "hideandseek_start");
                context.FieldGameConstant(key: "EventHideAndSeekWin", value: "hideandseek_win");
            }

            public override void Execute() {
                if (context.UserValue(key: "WaitForEnterUser", value: 1)) {
                    context.State = new StateWaitForEnterUser(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitForEnterUser : TriggerState {
            internal StateWaitForEnterUser(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 60, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "GameRuleNotice", value: 1)) {
                    context.State = new StateGameRuleNotice(context);
                    return;
                }

                if (context.UserValue(key: "ShortOfUser", value: 1)) {
                    context.State = new StateShortOfUser(context);
                    return;
                }

                if (context.WaitAndResetTick(waitTick: 5000)) {
                    context.ShowGuideSummary(entityID: 26500301, textID: 26500301, duration: 4500);
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
                context.HideGuideSummary(entityID: 26500301);
            }
        }

        private class StateGameRuleNotice : TriggerState {
            internal StateGameRuleNotice(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$61000023_ME__61000023_MAIN__1$", arg3: new int[] {10000});
            }

            public override void Execute() {
                if (context.UserValue(key: "DivideIntoTeams", value: 1)) {
                    context.State = new StateDivideIntoTeams(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDivideIntoTeams : TriggerState {
            internal StateDivideIntoTeams(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$61000023_ME__61000023_MAIN__0$", stage: 0, count: 5);
            }

            public override void Execute() {
                if (context.UserValue(key: "MoveGameArea", value: 1)) {
                    context.State = new StateMoveGameArea(context);
                    return;
                }

                if (context.UserValue(key: "ShortOfUser", value: 1)) {
                    context.State = new StateShortOfUser(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveGameArea : TriggerState {
            internal StateMoveGameArea(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "BeInHidingTeams", value: 1)) {
                    context.State = new StateBeInHidingTeams(context);
                    return;
                }

                if (context.UserValue(key: "ShortOfUser", value: 1)) {
                    context.State = new StateShortOfUser(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBeInHidingTeams : TriggerState {
            internal StateBeInHidingTeams(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: true, arg4: true);
                context.FieldGameMessage(custom: 1, type: "SetEventUI", arg1: true,
                    arg2: "$61000023_ME__61000023_MAIN__2$", arg3: 30000);
                context.FieldGameMessage(custom: 2, type: "SetEventUI", arg1: true,
                    arg2: "$61000023_ME__61000023_MAIN__3$", arg3: 30000);
            }

            public override void Execute() {
                if (context.UserValue(key: "LookingForATeams", value: 1)) {
                    context.State = new StateLookingForATeams(context);
                    return;
                }

                if (context.UserValue(key: "TeamMatchResult", value: 1)) {
                    context.State = new StateTeamMatchResult(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class StateLookingForATeams : TriggerState {
            internal StateLookingForATeams(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 150, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "TeamMatchResult", value: 1)) {
                    context.State = new StateTeamMatchResult(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class StateTeamMatchResult : TriggerState {
            internal StateTeamMatchResult(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "GameExitNotice", value: 1)) {
                    context.State = new StateGameExitNotice(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameExitNotice : TriggerState {
            internal StateGameExitNotice(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$61000023_ME__61000023_MAIN__4$", arg3: new int[] {10000});
            }

            public override void Execute() {
                if (context.UserValue(key: "End", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShortOfUser : TriggerState {
            internal StateShortOfUser(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$61000023_ME__61000023_MAIN__5$", arg3: new int[] {10000});
            }

            public override void Execute() {
                if (context.UserValue(key: "End", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}