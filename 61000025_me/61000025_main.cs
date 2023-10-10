using Maple2.Trigger.Enum;

namespace Maple2.Trigger._61000025_me {
    public static class _61000025_main {
        public class StateNone : TriggerState {
            internal StateNone(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateFieldGame(type: FieldGame.HideAndSeek, reset: true);
                context.FieldGameConstant(key: "BeginTriggerId", value: "1");
                context.FieldGameConstant(key: "EndTriggerId", value: "36");
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
                context.FieldGameConstant(key: "InvincibleMessage", value: "$61000025_ME__61000025_MAIN__6$");
                context.FieldGameConstant(key: "PortalWaitAreaId", value: "1");
                context.FieldGameConstant(key: "PortalGameAreaId", value: "10");
                context.FieldGameConstant(key: "PortalFailAreaId", value: "20");
                context.FieldGameConstant(key: "SeekTeamSkillSetId", value: "99930041");
                context.FieldGameConstant(key: "HideTeamExp", value: "0");
                context.FieldGameConstant(key: "SeekTeamExp", value: "0");
                context.FieldGameConstant(key: "WinnerRewardItemId", value: "30001442", feature: "MassiveHideAndSeek", Locale.KR);
                context.FieldGameConstant(key: "WinnerRewardItemRank", value: "1", feature: "MassiveHideAndSeek", Locale.KR);
                context.FieldGameConstant(key: "WinnerRewardItemCount", value: "3", feature: "MassiveHideAndSeek", Locale.KR);
                context.FieldGameConstant(key: "LoserRewardItemId", value: "30001442", feature: "MassiveHideAndSeek", Locale.KR);
                context.FieldGameConstant(key: "LoserRewardItemRank", value: "1", feature: "MassiveHideAndSeek", Locale.KR);
                context.FieldGameConstant(key: "LoserRewardItemCount", value: "1", feature: "MassiveHideAndSeek", Locale.KR);
                context.FieldGameConstant(key: "WinnerRewardItemId", value: "30001446", feature: "MassiveHideAndSeek", Locale.CN);
                context.FieldGameConstant(key: "WinnerRewardItemRank", value: "1", feature: "MassiveHideAndSeek", Locale.CN);
                context.FieldGameConstant(key: "WinnerRewardItemCount", value: "3", feature: "MassiveHideAndSeek", Locale.CN);
                context.FieldGameConstant(key: "LoserRewardItemId", value: "30001446", feature: "MassiveHideAndSeek", Locale.CN);
                context.FieldGameConstant(key: "LoserRewardItemRank", value: "1", feature: "MassiveHideAndSeek", Locale.CN);
                context.FieldGameConstant(key: "LoserRewardItemCount", value: "1", feature: "MassiveHideAndSeek", Locale.CN);
                context.FieldGameConstant(key: "WinnerRewardItemId", value: "30000610", feature: "MassiveHideAndSeek", Locale.NA);
                context.FieldGameConstant(key: "WinnerRewardItemRank", value: "1", feature: "MassiveHideAndSeek", Locale.NA);
                context.FieldGameConstant(key: "WinnerRewardItemCount", value: "2", feature: "MassiveHideAndSeek", Locale.NA);
                context.FieldGameConstant(key: "LoserRewardItemId", value: "30000610", feature: "MassiveHideAndSeek", Locale.NA);
                context.FieldGameConstant(key: "LoserRewardItemRank", value: "1", feature: "MassiveHideAndSeek", Locale.NA);
                context.FieldGameConstant(key: "LoserRewardItemCount", value: "1", feature: "MassiveHideAndSeek", Locale.NA);
                context.FieldGameConstant(key: "WatchCameraId", value: "101");
                context.FieldGameConstant(key: "EventDailyQuestStart", value: "dailyquest_start");
                context.FieldGameConstant(key: "EventHideAndSeekStart", value: "hideandseek_start");
                context.FieldGameConstant(key: "EventHideAndSeekWin", value: "hideandseek_win");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "WaitForEnterUser") == 1) {
                    return new StateWaitForEnterUser(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitForEnterUser : TriggerState {
            internal StateWaitForEnterUser(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 60, autoRemove: true, display: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "GameRuleNotice") == 1) {
                    return new StateGameRuleNotice(context);
                }

                if (context.GetUserValue(key: "ShortOfUser") == 1) {
                    return new StateShortOfUser(context);
                }

                if (context.WaitAndResetTick(waitTick: 5000)) {
                    context.ShowGuideSummary(entityId: 26500301, textId: 26500301, duration: 4500);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
                context.HideGuideSummary(entityId: 26500301);
            }
        }

        private class StateGameRuleNotice : TriggerState {
            internal StateGameRuleNotice(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000023_ME__61000023_MAIN__1$", duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "DivideIntoTeams") == 1) {
                    return new StateDivideIntoTeams(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDivideIntoTeams : TriggerState {
            internal StateDivideIntoTeams(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$61000023_ME__61000023_MAIN__0$", stage: 0, count: 5);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MoveGameArea") == 1) {
                    return new StateMoveGameArea(context);
                }

                if (context.GetUserValue(key: "ShortOfUser") == 1) {
                    return new StateShortOfUser(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveGameArea : TriggerState {
            internal StateMoveGameArea(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BeInHidingTeams") == 1) {
                    return new StateBeInHidingTeams(context);
                }

                if (context.GetUserValue(key: "ShortOfUser") == 1) {
                    return new StateShortOfUser(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeInHidingTeams : TriggerState {
            internal StateBeInHidingTeams(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: true, display: true);
                context.FieldGameMessage(custom: 1, type: "SetEventUI", arg1: 1, script: "$61000023_ME__61000023_MAIN__2$", duration: 30000);
                context.FieldGameMessage(custom: 2, type: "SetEventUI", arg1: 1, script: "$61000023_ME__61000023_MAIN__3$", duration: 30000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "LookingForATeams") == 1) {
                    return new StateLookingForATeams(context);
                }

                if (context.GetUserValue(key: "TeamMatchResult") == 1) {
                    return new StateTeamMatchResult(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class StateLookingForATeams : TriggerState {
            internal StateLookingForATeams(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 150, autoRemove: true, display: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TeamMatchResult") == 1) {
                    return new StateTeamMatchResult(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class StateTeamMatchResult : TriggerState {
            internal StateTeamMatchResult(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "GameExitNotice") == 1) {
                    return new StateGameExitNotice(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameExitNotice : TriggerState {
            internal StateGameExitNotice(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000023_ME__61000023_MAIN__4$", duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "End") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShortOfUser : TriggerState {
            internal StateShortOfUser(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000023_ME__61000023_MAIN__5$", duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "End") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 0, portalId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
