using Maple2.Trigger.Enum;

namespace Maple2.Trigger._61000004_me {
    public static class _trigger_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetMesh(triggerIds: new []{301, 302, 303}, visible: true, arg3: 0, arg4: 0);
                context.SetMesh(triggerIds: new []{3101, 3102, 3201, 3202, 3301, 3302, 3401, 3402, 3403, 3404}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{71011, 71012, 71021, 71022, 72011, 72021, 73011, 73021, 73022, 73023}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateRandom블록01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom블록01 : TriggerState {
            internal StateRandom블록01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    context.SetMesh(triggerIds: new []{3101}, visible: true, arg3: 0, arg4: 0);
                    context.SetEffect(triggerIds: new []{71011, 71012}, visible: true);
                    return new StateRandom블록02(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    context.SetMesh(triggerIds: new []{3102}, visible: true, arg3: 0, arg4: 0);
                    context.SetEffect(triggerIds: new []{71021, 71022}, visible: true);
                    return new StateRandom블록02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom블록02 : TriggerState {
            internal StateRandom블록02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    context.SetMesh(triggerIds: new []{3201}, visible: true, arg3: 0, arg4: 0);
                    context.SetEffect(triggerIds: new []{72011}, visible: true);
                    return new StateRandom블록03(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    context.SetMesh(triggerIds: new []{3202}, visible: true, arg3: 0, arg4: 0);
                    context.SetEffect(triggerIds: new []{72021}, visible: true);
                    return new StateRandom블록03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom블록03 : TriggerState {
            internal StateRandom블록03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    context.SetMesh(triggerIds: new []{3301}, visible: true, arg3: 0, arg4: 0);
                    context.SetEffect(triggerIds: new []{73011}, visible: true);
                    return new StateRandom블록04(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    context.SetMesh(triggerIds: new []{3302}, visible: true, arg3: 0, arg4: 0);
                    context.SetEffect(triggerIds: new []{73021, 73022, 73023}, visible: true);
                    return new StateRandom블록04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom블록04 : TriggerState {
            internal StateRandom블록04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    context.SetMesh(triggerIds: new []{3401, 3402}, visible: true, arg3: 0, arg4: 0);
                    return new StateStartConditionCheck(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    context.SetMesh(triggerIds: new []{3403, 3404}, visible: true, arg3: 0, arg4: 0);
                    return new StateStartConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartConditionCheck : TriggerState {
            internal StateStartConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    return new State어나운스0(context);
                }

                if (context.GetUserCount(boxId: 101) == 20) {
                    return new State어나운스0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스0 : TriggerState {
            internal State어나운스0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "ME_Trigger_01_00");
                context.SetEventUI(arg1: 1, script: "$61000004_ME__TRIGGER_01__0$", duration: 7000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State어나운스1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$61000004_ME__TRIGGER_01__1$", stage: 0, count: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.SetMesh(triggerIds: new []{301, 302, 303}, visible: false, arg3: 12, arg4: 0);
                    context.SetAchievement(triggerId: 101, type: "trigger", code: "dailyquest_start");
                    context.GiveGuildExp(boxId: 0, type: 2);
                    context.StartMiniGame(boxId: 105, round: 1, type: MiniGame.LudibriumEscape);
                    context.StartMiniGameRound(boxId: 105, round: 1);
                    context.MoveUserToBox(boxId: 101, portalId: 1);
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999111, key: "gameStart", value: 1);
                context.SetTimer(timerId: "180", seconds: 180, autoRemove: false, display: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "180")) {
                    return new State경기종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경기종료 : TriggerState {
            internal State경기종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 102, type: "trigger", code: "escape_win");
                context.SetEventUI(arg1: 3, script: "$61000004_ME__TRIGGER_01__2$", duration: 5000, boxId: 102);
                context.SetEventUI(arg1: 6, script: "$61000004_ME__TRIGGER_01__3$", duration: 5000, notBoxId: 102);
                context.AddBuff(boxIds: new []{102}, skillId: 70000019, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.EndMiniGameRound(winnerBoxId: 102, expRate: 0.25f, isGainLoserBonus: true);
                    context.MiniGameGiveReward(winnerBoxId: 102, contentType: "miniGame");
                    context.EndMiniGame(winnerBoxId: 102, type: MiniGame.LudibriumEscape);
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.MoveUser(mapId: 0, portalId: 0);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
