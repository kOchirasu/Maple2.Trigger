using Maple2.Trigger.Enum;

namespace Maple2.Trigger._61000008_me {
    public static class _01_massivemain {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 10000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 40000, enabled: false);
                context.SetEffect(triggerIds: new []{8000}, visible: false);
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{511, 512, 513, 514, 521, 522, 523, 524, 531, 532, 533, 534, 541, 542, 543, 544}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{110, 111, 112, 113, 114, 115, 120, 121, 122, 123, 124, 125, 130, 131, 132, 133, 134, 135, 140, 141, 142, 143, 144, 145, 210, 211, 212, 213, 214, 215, 220, 221, 222, 223, 224, 225, 230, 231, 232, 233, 234, 235, 240, 241, 242, 243, 244, 245, 310, 311, 312, 313, 314, 315, 320, 321, 322, 323, 324, 325, 330, 331, 332, 333, 334, 335, 340, 341, 342, 343, 344, 345, 410, 411, 412, 413, 414, 415, 420, 421, 422, 423, 424, 425, 430, 431, 432, 433, 434, 435, 440, 441, 442, 443, 444, 445}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
                context.SetInteractObject(interactIds: new []{10000934, 10000935, 10000936}, state: 2);
                context.SetUserValue(key: "Round", value: 0);
                context.SetUserValue(key: "GambleSuccess", value: 0);
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateEntryDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEntryDelay : TriggerState {
            internal StateEntryDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 60);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateMusicChange(context);
                }

                if (context.GetUserCount(boxId: 9001) == 50) {
                    return new StateMusicChange(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMusicChange : TriggerState {
            internal StateMusicChange(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGameGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuide01 : TriggerState {
            internal StateGameGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "BannerCheckIn", value: 1);
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 10000, enabled: true);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__0$", duration: 3000, boxId: 0);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Notice_01");
                context.SetAchievement(triggerId: 9001, type: "trigger", code: "dailyquest_start");
                context.SetAchievement(triggerId: 9001, type: "trigger", code: "ddstop_start");
                context.GiveGuildExp(boxId: 0, type: 2);
                context.SetMiniGameAreaForHack(boxId: 9001);
                context.StartMiniGame(boxId: 9001, round: 5, type: MiniGame.DanceDanceStop);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateGameGuide02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuide02 : TriggerState {
            internal StateGameGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__1$", duration: 4000, boxId: 0);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Notice_02");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateGameGuide03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuide03 : TriggerState {
            internal StateGameGuide03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__2$", duration: 4000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGameGuide04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuide04 : TriggerState {
            internal StateGameGuide04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__3$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateR01Start(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(key: "Round", value: 1);
            }
        }

        private class StateR01Start : TriggerState {
            internal StateR01Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__4$", duration: 3000, boxId: 0);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancetime_01");
                context.SetEventUI(arg1: 0, script: "1,5");
                context.SetSound(triggerId: 10000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.StartMiniGameRound(boxId: 9001, round: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR01DanceTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DanceTime : TriggerState {
            internal StateR01DanceTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 30)) {
                    return new StateR01DancePattern01(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new StateR01DancePattern02(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new StateR01DancePattern03(context);
                }

                if (context.RandomCondition(rate: 3)) {
                    return new StateR01DancePattern0401(context);
                }

                if (context.RandomCondition(rate: 3)) {
                    return new StateR01DancePattern0501(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateR01DancePattern0601(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateR01DancePattern0701(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10000933}, state: 2);
            }
        }

        private class StateR01DancePattern01 : TriggerState {
            internal StateR01DancePattern01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateR01_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern02 : TriggerState {
            internal StateR01DancePattern02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateR01_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern03 : TriggerState {
            internal StateR01DancePattern03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000936}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 19000)) {
                    return new StateR01_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0401 : TriggerState {
            internal StateR01DancePattern0401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 41);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateR01DancePattern0402(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0402 : TriggerState {
            internal StateR01DancePattern0402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__9$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_01");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR01DancePattern0403(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0403 : TriggerState {
            internal StateR01DancePattern0403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__10$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000933}, state: 2);
                context.SetInteractObject(interactIds: new []{10000934}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR01DancePattern0404(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0404 : TriggerState {
            internal StateR01DancePattern0404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 42);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateR01_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0501 : TriggerState {
            internal StateR01DancePattern0501(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 51);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateR01DancePattern0502(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0502 : TriggerState {
            internal StateR01DancePattern0502(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__11$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_02");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000934}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR01DancePattern0503(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0503 : TriggerState {
            internal StateR01DancePattern0503(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__12$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000934}, state: 2);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR01DancePattern0504(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0504 : TriggerState {
            internal StateR01DancePattern0504(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 52);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateR01_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0601 : TriggerState {
            internal StateR01DancePattern0601(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 61);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateR01DancePattern0602(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0602 : TriggerState {
            internal StateR01DancePattern0602(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__13$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_03");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000935}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR01DancePattern0603(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0603 : TriggerState {
            internal StateR01DancePattern0603(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__14$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000935}, state: 2);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR01DancePattern0604(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0604 : TriggerState {
            internal StateR01DancePattern0604(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 62);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateR01_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0701 : TriggerState {
            internal StateR01DancePattern0701(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 71);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateR01DancePattern0702(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0702 : TriggerState {
            internal StateR01DancePattern0702(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__15$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_04");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR01DancePattern0703(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0703 : TriggerState {
            internal StateR01DancePattern0703(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__16$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000933}, state: 2);
                context.SetInteractObject(interactIds: new []{10000935}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR01DancePattern0704(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01DancePattern0704 : TriggerState {
            internal StateR01DancePattern0704(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 72);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateR01_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01_GameStartDelay : TriggerState {
            internal StateR01_GameStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR01_GameStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01_GameStart : TriggerState {
            internal StateR01_GameStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 40000, enabled: true);
                context.SetInteractObject(interactIds: new []{10000933, 10000934, 10000935, 10000936}, state: 2);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__17$", duration: 4000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Round_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateR01_GameTimerStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01_GameTimerStart : TriggerState {
            internal StateR01_GameTimerStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11111", seconds: 30, autoRemove: true, display: true, vOffset: -40);
                context.SetUserValue(triggerId: 8, key: "CheerUpTimer", value: 1);
                context.SetUserValue(triggerId: 7, key: "GameGuide", value: 1);
            }

            public override TriggerState? Execute() {
                return new StateR01G00Check(context);
            }

            public override void OnExit() { }
        }

        private class StateR01G00Check : TriggerState {
            internal StateR01G00Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9001) > 40) {
                    return new StateG05orG04(context);
                }

                if (context.GetUserCount(boxId: 9001) > 30) {
                    return new StateG03orG04orG05(context);
                }

                if (context.GetUserCount(boxId: 9001) > 20) {
                    return new StateG02orG03orG04(context);
                }

                if (context.GetUserCount(boxId: 9001) > 10) {
                    return new StateG02orG03(context);
                }

                if (context.GetUserCount(boxId: 9001) <= 10) {
                    return new StateG01orG02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05orG04 : TriggerState {
            internal StateG05orG04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 80)) {
                    return new StateG05P00_Random(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateG04P00_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03orG04orG05 : TriggerState {
            internal StateG03orG04orG05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 10)) {
                    return new StateG03P00_Random(context);
                }

                if (context.RandomCondition(rate: 60)) {
                    return new StateG04P00_Random(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new StateG05P00_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02orG03orG04 : TriggerState {
            internal StateG02orG03orG04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 10)) {
                    return new StateG02P00_Random(context);
                }

                if (context.RandomCondition(rate: 60)) {
                    return new StateG03P00_Random(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new StateG04P00_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02orG03 : TriggerState {
            internal StateG02orG03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 60)) {
                    return new StateG02P00_Random(context);
                }

                if (context.RandomCondition(rate: 40)) {
                    return new StateG03P00_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01orG02 : TriggerState {
            internal StateG01orG02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 70)) {
                    return new StateG01P00_Random(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new StateG02P00_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P00_Random : TriggerState {
            internal StateG05P00_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P01_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P02_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P03_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P04_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P05_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P06_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P07_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P08_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P09_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P10_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P11_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P12_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P13_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P14_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P15_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P16_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P17_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P18_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P19_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P20_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P21_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P22_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P23_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P24_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P25_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P26_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P27_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P28_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P29_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P30_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P31_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P32_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P33_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P34_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P35_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P36_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P37_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P38_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P39_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P40_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P41_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P42_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P43_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P44_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P45_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P46_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P47_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P48_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P49_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateG05P50_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P00_Random : TriggerState {
            internal StateG04P00_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P01_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P02_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P03_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P04_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P05_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P06_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P07_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P08_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P09_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P10_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P11_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P12_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P13_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P14_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P15_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P16_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P17_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P18_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P19_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P20_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P21_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P22_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P23_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P24_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P25_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P26_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P27_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P28_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P29_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P30_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P31_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P32_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P33_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P34_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P35_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P36_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P37_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P38_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P39_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG04P40_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P00_Random : TriggerState {
            internal StateG03P00_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P01_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P02_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P03_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P04_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P05_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P06_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P07_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P08_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P09_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P10_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P11_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P12_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P13_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P14_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P15_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P16_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P17_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P18_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P19_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P20_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P21_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P22_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P23_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P24_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P25_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P26_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P27_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P28_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P29_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG03P30_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P00_Random : TriggerState {
            internal StateG02P00_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P01_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P02_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P03_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P04_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P05_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P06_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P07_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P08_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P09_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P10_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P11_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P12_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P13_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P14_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P15_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P16_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P17_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P18_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P19_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P20_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P21_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P22_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P23_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P24_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P25_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P26_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P27_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P28_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P29_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG02P30_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P00_Random : TriggerState {
            internal StateG01P00_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P01_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P02_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P03_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P04_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P05_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P06_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P07_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P08_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P09_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P10_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P11_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P12_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P13_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P14_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P15_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P16_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P17_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P18_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P19_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P20_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P21_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P22_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P23_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P24_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P25_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P26_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P27_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P28_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P29_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG01P30_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01EndDelay : TriggerState {
            internal StateR01EndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 5);
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 5);
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 5);
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 5);
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 5);
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 5);
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 5);
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 5);
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 5);
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 5);
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 5);
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 5);
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 5);
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 5);
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 5);
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 5);
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: true, arg3: 400, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR01End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01End : TriggerState {
            internal StateR01End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "dancedancestop", triggerId: 9001, @event: "round_clear", arg4: 1);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 901, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateR02Ready(context);
                }

                if (!context.UserDetected(boxIds: new []{9001})) {
                    return new StateFailAll(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02Ready : TriggerState {
            internal StateR02Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Round", value: 2);
                context.EndMiniGameRound(winnerBoxId: 9001, expRate: 0.2f);
                context.SetAchievement(triggerId: 9001, type: "trigger", code: "ddstop_pass");
                context.SetMesh(triggerIds: new []{8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914}, visible: false, arg3: 400, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR02Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02Start : TriggerState {
            internal StateR02Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 10);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 10);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 10);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 10);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 10);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 10);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 10);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 10);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 10);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 10);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 10);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 10);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 10);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 10);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 10);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 10);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__5$", duration: 3000, boxId: 0);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancetime_02");
                context.SetSound(triggerId: 40000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetEventUI(arg1: 0, script: "2,5");
                context.StartMiniGameRound(boxId: 9001, round: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR02DanceTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DanceTime : TriggerState {
            internal StateR02DanceTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 30)) {
                    return new StateR02DancePattern01(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new StateR02DancePattern02(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new StateR02DancePattern03(context);
                }

                if (context.RandomCondition(rate: 3)) {
                    return new StateR02DancePattern0401(context);
                }

                if (context.RandomCondition(rate: 3)) {
                    return new StateR02DancePattern0501(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateR02DancePattern0601(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateR02DancePattern0701(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern01 : TriggerState {
            internal StateR02DancePattern01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateR02_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern02 : TriggerState {
            internal StateR02DancePattern02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateR02_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern03 : TriggerState {
            internal StateR02DancePattern03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000936}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 19000)) {
                    return new StateR02_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0401 : TriggerState {
            internal StateR02DancePattern0401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 41);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateR02DancePattern0402(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0402 : TriggerState {
            internal StateR02DancePattern0402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__9$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_01");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR02DancePattern0403(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0403 : TriggerState {
            internal StateR02DancePattern0403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__10$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000933}, state: 2);
                context.SetInteractObject(interactIds: new []{10000934}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR02DancePattern0404(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0404 : TriggerState {
            internal StateR02DancePattern0404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 42);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateR02_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0501 : TriggerState {
            internal StateR02DancePattern0501(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 51);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateR02DancePattern0502(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0502 : TriggerState {
            internal StateR02DancePattern0502(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__11$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_02");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000934}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR02DancePattern0503(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0503 : TriggerState {
            internal StateR02DancePattern0503(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__12$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000934}, state: 2);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR02DancePattern0504(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0504 : TriggerState {
            internal StateR02DancePattern0504(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 52);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateR02_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0601 : TriggerState {
            internal StateR02DancePattern0601(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 61);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateR02DancePattern0602(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0602 : TriggerState {
            internal StateR02DancePattern0602(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__13$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_03");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000935}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR02DancePattern0603(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0603 : TriggerState {
            internal StateR02DancePattern0603(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__14$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000935}, state: 2);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR02DancePattern0604(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0604 : TriggerState {
            internal StateR02DancePattern0604(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 62);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateR02_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0701 : TriggerState {
            internal StateR02DancePattern0701(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 71);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateR02DancePattern0702(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0702 : TriggerState {
            internal StateR02DancePattern0702(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__15$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_04");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR02DancePattern0703(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0703 : TriggerState {
            internal StateR02DancePattern0703(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__16$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000933}, state: 2);
                context.SetInteractObject(interactIds: new []{10000935}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR02DancePattern0704(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02DancePattern0704 : TriggerState {
            internal StateR02DancePattern0704(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 72);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateR02_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02_GameStartDelay : TriggerState {
            internal StateR02_GameStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR02_GameStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02_GameStart : TriggerState {
            internal StateR02_GameStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 40000, enabled: true);
                context.SetInteractObject(interactIds: new []{10000933, 10000934, 10000935, 10000936}, state: 2);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__18$", duration: 4000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Round_02");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateR02_GameTimerStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02_GameTimerStart : TriggerState {
            internal StateR02_GameTimerStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11111", seconds: 20, autoRemove: true, display: true, vOffset: -40);
                context.SetUserValue(triggerId: 8, key: "CheerUpTimer", value: 2);
                context.SetUserValue(triggerId: 7, key: "GameGuide", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateR02G00Check(context);
            }

            public override void OnExit() { }
        }

        private class StateR02G00Check : TriggerState {
            internal StateR02G00Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9001) > 40) {
                    return new StateG05orG04(context);
                }

                if (context.GetUserCount(boxId: 9001) > 30) {
                    return new StateG03orG04orG05(context);
                }

                if (context.GetUserCount(boxId: 9001) > 20) {
                    return new StateG02orG03orG04(context);
                }

                if (context.GetUserCount(boxId: 9001) > 10) {
                    return new StateG02orG03(context);
                }

                if (context.GetUserCount(boxId: 9001) <= 10) {
                    return new StateG01orG02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02EndDelay : TriggerState {
            internal StateR02EndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 5);
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 5);
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 5);
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 5);
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 5);
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 5);
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 5);
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 5);
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 5);
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 5);
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 5);
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 5);
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 5);
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 5);
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 5);
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 5);
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: true, arg3: 400, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR02End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02End : TriggerState {
            internal StateR02End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "dancedancestop", triggerId: 9001, @event: "round_clear", arg4: 2);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 901, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateR03Ready(context);
                }

                if (!context.UserDetected(boxIds: new []{9001})) {
                    return new StateFailAll(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03Ready : TriggerState {
            internal StateR03Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Round", value: 3);
                context.EndMiniGameRound(winnerBoxId: 9001, expRate: 0.2f);
                context.SetAchievement(triggerId: 9001, type: "trigger", code: "ddstop_pass");
                context.SetMesh(triggerIds: new []{8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914}, visible: false, arg3: 400, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR03Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03Start : TriggerState {
            internal StateR03Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 10);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 10);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 10);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 10);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 10);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 10);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 10);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 10);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 10);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 10);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 10);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 10);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 10);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 10);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 10);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 10);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__6$", duration: 3000, boxId: 0);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancetime_03");
                context.SetSound(triggerId: 40000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetEventUI(arg1: 0, script: "3,5");
                context.StartMiniGameRound(boxId: 9001, round: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR03DanceTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DanceTime : TriggerState {
            internal StateR03DanceTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 30)) {
                    return new StateR03DancePattern01(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new StateR03DancePattern02(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new StateR03DancePattern03(context);
                }

                if (context.RandomCondition(rate: 3)) {
                    return new StateR03DancePattern0401(context);
                }

                if (context.RandomCondition(rate: 3)) {
                    return new StateR03DancePattern0501(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateR03DancePattern0601(context);
                }

                if (context.RandomCondition(rate: 2)) {
                    return new StateR03DancePattern0701(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern01 : TriggerState {
            internal StateR03DancePattern01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateR03_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern02 : TriggerState {
            internal StateR03DancePattern02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateR03_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern03 : TriggerState {
            internal StateR03DancePattern03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000936}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 19000)) {
                    return new StateR03_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0401 : TriggerState {
            internal StateR03DancePattern0401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 41);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateR03DancePattern0402(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0402 : TriggerState {
            internal StateR03DancePattern0402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__9$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_01");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR03DancePattern0403(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0403 : TriggerState {
            internal StateR03DancePattern0403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__10$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000933}, state: 2);
                context.SetInteractObject(interactIds: new []{10000934}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR03DancePattern0404(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0404 : TriggerState {
            internal StateR03DancePattern0404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 42);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateR03_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0501 : TriggerState {
            internal StateR03DancePattern0501(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 51);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateR03DancePattern0502(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0502 : TriggerState {
            internal StateR03DancePattern0502(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__11$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_02");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000934}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR03DancePattern0503(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0503 : TriggerState {
            internal StateR03DancePattern0503(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__12$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000934}, state: 2);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR03DancePattern0504(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0504 : TriggerState {
            internal StateR03DancePattern0504(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 52);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateR03_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0601 : TriggerState {
            internal StateR03DancePattern0601(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 61);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateR03DancePattern0602(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0602 : TriggerState {
            internal StateR03DancePattern0602(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__13$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_03");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000935}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR03DancePattern0603(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0603 : TriggerState {
            internal StateR03DancePattern0603(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__14$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000935}, state: 2);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR03DancePattern0604(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0604 : TriggerState {
            internal StateR03DancePattern0604(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 62);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateR03_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0701 : TriggerState {
            internal StateR03DancePattern0701(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 71);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateR03DancePattern0702(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0702 : TriggerState {
            internal StateR03DancePattern0702(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__15$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_04");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR03DancePattern0703(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0703 : TriggerState {
            internal StateR03DancePattern0703(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__16$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000933}, state: 2);
                context.SetInteractObject(interactIds: new []{10000935}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR03DancePattern0704(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03DancePattern0704 : TriggerState {
            internal StateR03DancePattern0704(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 72);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateR03_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03_GameStartDelay : TriggerState {
            internal StateR03_GameStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR03_GameStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03_GameStart : TriggerState {
            internal StateR03_GameStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 40000, enabled: true);
                context.SetInteractObject(interactIds: new []{10000933, 10000934, 10000935, 10000936}, state: 2);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__19$", duration: 4000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Round_03");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateR03_GameTimerStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03_GameTimerStart : TriggerState {
            internal StateR03_GameTimerStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11111", seconds: 15, autoRemove: true, display: true, vOffset: -40);
                context.SetUserValue(triggerId: 8, key: "CheerUpTimer", value: 3);
                context.SetUserValue(triggerId: 7, key: "GameGuide", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateR03G00Check(context);
            }

            public override void OnExit() { }
        }

        private class StateR03G00Check : TriggerState {
            internal StateR03G00Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9001) > 40) {
                    return new StateG05orG04(context);
                }

                if (context.GetUserCount(boxId: 9001) > 30) {
                    return new StateG03orG04orG05(context);
                }

                if (context.GetUserCount(boxId: 9001) > 20) {
                    return new StateG02orG03orG04(context);
                }

                if (context.GetUserCount(boxId: 9001) > 10) {
                    return new StateG02orG03(context);
                }

                if (context.GetUserCount(boxId: 9001) <= 10) {
                    return new StateG01orG02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03EndDelay : TriggerState {
            internal StateR03EndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 5);
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 5);
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 5);
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 5);
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 5);
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 5);
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 5);
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 5);
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 5);
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 5);
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 5);
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 5);
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 5);
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 5);
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 5);
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 5);
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: true, arg3: 400, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR03End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03End : TriggerState {
            internal StateR03End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "dancedancestop", triggerId: 9001, @event: "round_clear", arg4: 3);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 901, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateR04Ready(context);
                }

                if (!context.UserDetected(boxIds: new []{9001})) {
                    return new StateFailAll(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04Ready : TriggerState {
            internal StateR04Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Round", value: 4);
                context.EndMiniGameRound(winnerBoxId: 9001, expRate: 0.2f);
                context.SetAchievement(triggerId: 9001, type: "trigger", code: "ddstop_pass");
                context.SetMesh(triggerIds: new []{8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914}, visible: false, arg3: 400, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR04Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04Start : TriggerState {
            internal StateR04Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 10);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 10);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 10);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 10);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 10);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 10);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 10);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 10);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 10);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 10);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 10);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 10);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 10);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 10);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 10);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 10);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__7$", duration: 3000, boxId: 0);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancetime_04");
                context.SetSound(triggerId: 40000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetEventUI(arg1: 0, script: "4,5");
                context.StartMiniGameRound(boxId: 9001, round: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR04DanceTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DanceTime : TriggerState {
            internal StateR04DanceTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 2)) {
                    return new StateR04DancePattern01(context);
                }

                if (context.RandomCondition(rate: 3)) {
                    return new StateR04DancePattern02(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateR04DancePattern03(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateR04DancePattern0401(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateR04DancePattern0501(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateR04DancePattern0601(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateR04DancePattern0701(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern01 : TriggerState {
            internal StateR04DancePattern01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateR04_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern02 : TriggerState {
            internal StateR04DancePattern02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateR04_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern03 : TriggerState {
            internal StateR04DancePattern03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000936}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 19000)) {
                    return new StateR04_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0401 : TriggerState {
            internal StateR04DancePattern0401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 41);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateR04DancePattern0402(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0402 : TriggerState {
            internal StateR04DancePattern0402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__9$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_01");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR04DancePattern0403(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0403 : TriggerState {
            internal StateR04DancePattern0403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__10$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000933}, state: 2);
                context.SetInteractObject(interactIds: new []{10000934}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR04DancePattern0404(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0404 : TriggerState {
            internal StateR04DancePattern0404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 42);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateR04_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0501 : TriggerState {
            internal StateR04DancePattern0501(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 51);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateR04DancePattern0502(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0502 : TriggerState {
            internal StateR04DancePattern0502(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__11$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_02");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000934}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR04DancePattern0503(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0503 : TriggerState {
            internal StateR04DancePattern0503(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__12$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000934}, state: 2);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR04DancePattern0504(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0504 : TriggerState {
            internal StateR04DancePattern0504(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 52);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateR04_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0601 : TriggerState {
            internal StateR04DancePattern0601(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 61);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateR04DancePattern0602(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0602 : TriggerState {
            internal StateR04DancePattern0602(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__13$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_03");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000935}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR04DancePattern0603(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0603 : TriggerState {
            internal StateR04DancePattern0603(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__14$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000935}, state: 2);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR04DancePattern0604(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0604 : TriggerState {
            internal StateR04DancePattern0604(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 62);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateR04_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0701 : TriggerState {
            internal StateR04DancePattern0701(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 71);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateR04DancePattern0702(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0702 : TriggerState {
            internal StateR04DancePattern0702(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__15$", duration: 1000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_04");
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR04DancePattern0703(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0703 : TriggerState {
            internal StateR04DancePattern0703(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__16$", duration: 1500, boxId: 0);
                context.SetInteractObject(interactIds: new []{10000933}, state: 2);
                context.SetInteractObject(interactIds: new []{10000935}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR04DancePattern0704(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04DancePattern0704 : TriggerState {
            internal StateR04DancePattern0704(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 72);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateR04_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04_GameStartDelay : TriggerState {
            internal StateR04_GameStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR04_GambleOrNormal00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04_GambleOrNormal00 : TriggerState {
            internal StateR04_GambleOrNormal00(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9001) >= 20) {
                    return new StateR04_GambleOrJackpot(context);
                }

                if (context.GetUserCount(boxId: 9001) >= 10) {
                    return new StateR04_GambleOrNormal(context);
                }

                if (context.GetUserCount(boxId: 9001) < 10) {
                    return new StateR04_GameStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04_GambleOrJackpot : TriggerState {
            internal StateR04_GambleOrJackpot(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 75)) {
                    return new StateR04_GambleGuide01(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateR04_JackpotGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04_GambleOrNormal : TriggerState {
            internal StateR04_GambleOrNormal(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    return new StateR04_GambleGuide01(context);
                }

                if (context.RandomCondition(rate: 50)) {
                    return new StateR04_GameStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04_GambleGuide01 : TriggerState {
            internal StateR04_GambleGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Round", value: 6);
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 40000, enabled: true);
                context.SetInteractObject(interactIds: new []{10000933, 10000934, 10000935, 10000936}, state: 2);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__22$", duration: 3000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Round_06");
                context.WriteLog(logName: "dancedancestop", triggerId: 9001, @event: "system_event", arg4: 4, arg5: "gamble");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateR04_GambleGuide02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04_GambleGuide02 : TriggerState {
            internal StateR04_GambleGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__23$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateR04_GambleTimerStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04_GambleTimerStart : TriggerState {
            internal StateR04_GambleTimerStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11111", seconds: 15, autoRemove: true, display: true, vOffset: -40);
                context.SetUserValue(triggerId: 8, key: "CheerUpTimer", value: 3);
                context.SetUserValue(triggerId: 7, key: "GameGuide", value: 6);
            }

            public override TriggerState? Execute() {
                return new StateR04GambleCheck(context);
            }

            public override void OnExit() { }
        }

        private class StateR04GambleCheck : TriggerState {
            internal StateR04GambleCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9001) > 40) {
                    return new StateG06P400_Random(context);
                }

                if (context.GetUserCount(boxId: 9001) > 30) {
                    return new StateG06P300_Random(context);
                }

                if (context.GetUserCount(boxId: 9001) > 20) {
                    return new StateG06P200_Random(context);
                }

                if (context.GetUserCount(boxId: 9001) > 10) {
                    return new StateG06P100_Random(context);
                }

                if (context.GetUserCount(boxId: 9001) <= 10) {
                    return new StateG06P100_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P400_Random : TriggerState {
            internal StateG06P400_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P401_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P402_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P403_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P404_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P405_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P406_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P407_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P408_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P409_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P410_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P300_Random : TriggerState {
            internal StateG06P300_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P301_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P302_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P303_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P304_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P305_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P306_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P307_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P308_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P309_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P310_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P311_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P312_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P313_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P314_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P315_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P316_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P317_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P318_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P319_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P320_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P200_Random : TriggerState {
            internal StateG06P200_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P201_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P202_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P203_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P204_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P205_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P206_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P207_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P208_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P209_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P210_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P211_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P212_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P213_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P214_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P215_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P216_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P217_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P218_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P219_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateG06P220_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P100_Random : TriggerState {
            internal StateG06P100_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P101_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P102_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P103_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P104_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P105_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P106_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P107_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P108_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P109_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG06P110_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04_JackpotGuide01 : TriggerState {
            internal StateR04_JackpotGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Round", value: 6);
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 40000, enabled: true);
                context.SetInteractObject(interactIds: new []{10000933, 10000934, 10000935, 10000936}, state: 2);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__24$", duration: 3000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Round_06");
                context.WriteLog(logName: "dancedancestop", triggerId: 9001, @event: "system_event", arg4: 4, arg5: "jackpot");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateR04_JackpotGuide02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04_JackpotGuide02 : TriggerState {
            internal StateR04_JackpotGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__25$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateR04_JackpotTimerStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04_JackpotTimerStart : TriggerState {
            internal StateR04_JackpotTimerStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11111", seconds: 20, autoRemove: true, display: true, vOffset: -40);
                context.SetUserValue(triggerId: 8, key: "CheerUpTimer", value: 2);
                context.SetUserValue(triggerId: 7, key: "GameGuide", value: 7);
            }

            public override TriggerState? Execute() {
                return new StateR04JackpotCheck(context);
            }

            public override void OnExit() { }
        }

        private class StateR04JackpotCheck : TriggerState {
            internal StateR04JackpotCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9001) > 40) {
                    return new StateG07P400_Random(context);
                }

                if (context.GetUserCount(boxId: 9001) > 30) {
                    return new StateG07P300_Random(context);
                }

                if (context.GetUserCount(boxId: 9001) > 20) {
                    return new StateG07P200_Random(context);
                }

                if (context.GetUserCount(boxId: 9001) <= 20) {
                    return new StateG07P200_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P400_Random : TriggerState {
            internal StateG07P400_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P401_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P402_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P403_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P404_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P405_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P406_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P407_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P300_Random : TriggerState {
            internal StateG07P300_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P301_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P302_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P303_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P304_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P305_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P306_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P307_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P308_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P309_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P310_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P200_Random : TriggerState {
            internal StateG07P200_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P201_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P202_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P203_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P204_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P205_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P206_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P207_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P208_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P209_RoundCheckIn(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateG07P210_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04GambleEndDelay : TriggerState {
            internal StateR04GambleEndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 5);
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 5);
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 5);
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 5);
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 5);
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 5);
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 5);
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 5);
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 5);
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 5);
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 5);
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 5);
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 5);
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 5);
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 5);
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 5);
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: true, arg3: 400, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR04GambleEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04GambleEnd : TriggerState {
            internal StateR04GambleEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "dancedancestop", triggerId: 9001, @event: "round_clear", arg4: 4);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 901, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateR05ReadyAfterGamble(context);
                }

                if (!context.UserDetected(boxIds: new []{9001})) {
                    return new StateFailAll(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05ReadyAfterGamble : TriggerState {
            internal StateR05ReadyAfterGamble(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Round", value: 5);
                context.EndMiniGameRound(winnerBoxId: 9001, expRate: 0.2f);
                context.SetAchievement(triggerId: 9001, type: "trigger", code: "ddstop_pass");
                context.SetMesh(triggerIds: new []{8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914}, visible: false, arg3: 400, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR05StartAfterGamble(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05StartAfterGamble : TriggerState {
            internal StateR05StartAfterGamble(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "GambleSuccess") == 1) {
                    return new StateR05StartGamblePass(context);
                }

                if (context.GetUserValue(key: "GambleSuccess") == 0) {
                    return new StateR05StartGambleFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05StartGamblePass : TriggerState {
            internal StateR05StartGamblePass(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 10);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 10);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 10);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 10);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 10);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 10);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 10);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 10);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 10);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 10);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 10);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 10);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 10);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 10);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 10);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 10);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__26$", duration: 5000, boxId: 0);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_02");
                context.SetEventUI(arg1: 0, script: "5,5");
                context.StartMiniGameRound(boxId: 9001, round: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateR05DanceTimeDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05StartGambleFail : TriggerState {
            internal StateR05StartGambleFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 10);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 10);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 10);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 10);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 10);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 10);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 10);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 10);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 10);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 10);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 10);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 10);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 10);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 10);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 10);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 10);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__27$", duration: 4000, boxId: 0);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_03");
                context.SetEventUI(arg1: 0, script: "5,5");
                context.StartMiniGameRound(boxId: 9001, round: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateR05DanceTimeDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04_GameStart : TriggerState {
            internal StateR04_GameStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 40000, enabled: true);
                context.SetInteractObject(interactIds: new []{10000933, 10000934, 10000935, 10000936}, state: 2);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__20$", duration: 4000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Round_04");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateR04_GameTimerStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04_GameTimerStart : TriggerState {
            internal StateR04_GameTimerStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11111", seconds: 10, autoRemove: true, display: true, vOffset: -40);
                context.SetUserValue(triggerId: 8, key: "CheerUpTimer", value: 4);
                context.SetUserValue(triggerId: 7, key: "GameGuide", value: 4);
            }

            public override TriggerState? Execute() {
                return new StateR04G00Check(context);
            }

            public override void OnExit() { }
        }

        private class StateR04G00Check : TriggerState {
            internal StateR04G00Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9001) > 40) {
                    return new StateG05orG04(context);
                }

                if (context.GetUserCount(boxId: 9001) > 30) {
                    return new StateG03orG04orG05(context);
                }

                if (context.GetUserCount(boxId: 9001) > 20) {
                    return new StateG02orG03orG04(context);
                }

                if (context.GetUserCount(boxId: 9001) > 10) {
                    return new StateG02orG03(context);
                }

                if (context.GetUserCount(boxId: 9001) <= 10) {
                    return new StateG01orG02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DanceTimeDelay : TriggerState {
            internal StateR05DanceTimeDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 40000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__33$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR05DanceTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04EndDelay : TriggerState {
            internal StateR04EndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 5);
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 5);
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 5);
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 5);
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 5);
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 5);
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 5);
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 5);
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 5);
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 5);
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 5);
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 5);
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 5);
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 5);
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 5);
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 5);
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: true, arg3: 400, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR04End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04End : TriggerState {
            internal StateR04End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "dancedancestop", triggerId: 9001, @event: "round_clear", arg4: 4);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 901, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateR05Ready(context);
                }

                if (!context.UserDetected(boxIds: new []{9001})) {
                    return new StateFailAll(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05Ready : TriggerState {
            internal StateR05Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Round", value: 5);
                context.EndMiniGameRound(winnerBoxId: 9001, expRate: 0.2f);
                context.SetAchievement(triggerId: 9001, type: "trigger", code: "ddstop_pass");
                context.SetMesh(triggerIds: new []{8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914}, visible: false, arg3: 400, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR05Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05Start : TriggerState {
            internal StateR05Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 10);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 10);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 10);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 10);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 10);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 10);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 10);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 10);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 10);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 10);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 10);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 10);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 10);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 10);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 10);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 10);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__8$", duration: 3000, boxId: 0);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancetime_05");
                context.SetSound(triggerId: 40000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetEventUI(arg1: 0, script: "5,5");
                context.StartMiniGameRound(boxId: 9001, round: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR05DanceTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DanceTime : TriggerState {
            internal StateR05DanceTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 2)) {
                    return new StateR05DancePattern01(context);
                }

                if (context.RandomCondition(rate: 3)) {
                    return new StateR05DancePattern02(context);
                }

                if (context.RandomCondition(rate: 5)) {
                    return new StateR05DancePattern03(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateR05DancePattern0401(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateR05DancePattern0501(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateR05DancePattern0601(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateR05DancePattern0701(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern01 : TriggerState {
            internal StateR05DancePattern01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateR05_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern02 : TriggerState {
            internal StateR05DancePattern02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateR05_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern03 : TriggerState {
            internal StateR05DancePattern03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000936}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 19000)) {
                    return new StateR05_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0401 : TriggerState {
            internal StateR05DancePattern0401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 41);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateR05DancePattern0402(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0402 : TriggerState {
            internal StateR05DancePattern0402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__34$", duration: 1000);
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR05DancePattern0403(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0403 : TriggerState {
            internal StateR05DancePattern0403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__35$", duration: 1500, boxId: 0);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_05");
                context.SetInteractObject(interactIds: new []{10000933}, state: 2);
                context.SetInteractObject(interactIds: new []{10000934}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR05DancePattern0404(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0404 : TriggerState {
            internal StateR05DancePattern0404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 42);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateR05_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0501 : TriggerState {
            internal StateR05DancePattern0501(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000934}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 51);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateR05DancePattern0502(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0502 : TriggerState {
            internal StateR05DancePattern0502(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__36$", duration: 1000);
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000934}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR05DancePattern0503(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0503 : TriggerState {
            internal StateR05DancePattern0503(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__37$", duration: 1500, boxId: 0);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_05");
                context.SetInteractObject(interactIds: new []{10000934}, state: 2);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR05DancePattern0504(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0504 : TriggerState {
            internal StateR05DancePattern0504(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 52);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateR05_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0601 : TriggerState {
            internal StateR05DancePattern0601(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 61);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateR05DancePattern0602(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0602 : TriggerState {
            internal StateR05DancePattern0602(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__38$", duration: 1000);
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000935}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR05DancePattern0603(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0603 : TriggerState {
            internal StateR05DancePattern0603(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__39$", duration: 1500, boxId: 0);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_05");
                context.SetInteractObject(interactIds: new []{10000935}, state: 2);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR05DancePattern0604(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0604 : TriggerState {
            internal StateR05DancePattern0604(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 62);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateR05_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0701 : TriggerState {
            internal StateR05DancePattern0701(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000933}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 71);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateR05DancePattern0702(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0702 : TriggerState {
            internal StateR05DancePattern0702(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__40$", duration: 1000);
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetInteractObject(interactIds: new []{10000933}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR05DancePattern0703(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0703 : TriggerState {
            internal StateR05DancePattern0703(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__41$", duration: 1500, boxId: 0);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancerandom_05");
                context.SetInteractObject(interactIds: new []{10000933}, state: 2);
                context.SetInteractObject(interactIds: new []{10000935}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR05DancePattern0704(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05DancePattern0704 : TriggerState {
            internal StateR05DancePattern0704(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 20000, enabled: true);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DDStop_Stage_Ready_01");
                context.SetInteractObject(interactIds: new []{10000935}, state: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 72);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateR05_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05_GameStartDelay : TriggerState {
            internal StateR05_GameStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 30000, enabled: true);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR05_GameStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05_GameStart : TriggerState {
            internal StateR05_GameStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 30000, enabled: false);
                context.SetSound(triggerId: 40000, enabled: true);
                context.SetInteractObject(interactIds: new []{10000933, 10000934, 10000935, 10000936}, state: 2);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__21$", duration: 4000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Round_05");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateR05_GameTimerStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05_GameTimerStart : TriggerState {
            internal StateR05_GameTimerStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11111", seconds: 10, autoRemove: true, display: true, vOffset: -40);
                context.SetUserValue(triggerId: 8, key: "CheerUpTimer", value: 4);
                context.SetUserValue(triggerId: 7, key: "GameGuide", value: 5);
            }

            public override TriggerState? Execute() {
                return new StateR05G05Check(context);
            }

            public override void OnExit() { }
        }

        private class StateR05G05Check : TriggerState {
            internal StateR05G05Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9001) > 40) {
                    return new StateG05orG04(context);
                }

                if (context.GetUserCount(boxId: 9001) > 30) {
                    return new StateG03orG04orG05(context);
                }

                if (context.GetUserCount(boxId: 9001) > 20) {
                    return new StateG02orG03orG04(context);
                }

                if (context.GetUserCount(boxId: 9001) > 10) {
                    return new StateG02orG03(context);
                }

                if (context.GetUserCount(boxId: 9001) <= 10) {
                    return new StateG01orG02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05EndDelay : TriggerState {
            internal StateR05EndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 5);
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 5);
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 5);
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 5);
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 5);
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 5);
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 5);
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 5);
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 5);
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 5);
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 5);
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 5);
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 5);
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 5);
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 5);
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 5);
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: true, arg3: 400, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateR05End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05End : TriggerState {
            internal StateR05End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "dancedancestop", triggerId: 9001, @event: "round_clear", arg4: 5);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 901, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateGameWrapUp(context);
                }

                if (!context.UserDetected(boxIds: new []{9001})) {
                    return new StateFailAll(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameWrapUp : TriggerState {
            internal StateGameWrapUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 9001, expRate: 0.2f);
                context.SetAchievement(triggerId: 9001, type: "trigger", code: "ddstop_pass");
                context.SetMesh(triggerIds: new []{8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914}, visible: false, arg3: 400, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 10);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 10);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 10);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 10);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 10);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 10);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 10);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 10);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 10);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 10);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 10);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 10);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 10);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 10);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 10);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMiniGameCameraDirection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMiniGameCameraDirection : TriggerState {
            internal StateMiniGameCameraDirection(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MiniGameCameraDirection(boxId: 9001, cameraId: 910);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGameOver(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameOver : TriggerState {
            internal StateGameOver(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 61000008, portalId: 3, boxId: 9002);
                context.SetEventUI(arg1: 3, script: "$61000008_ME__01_MASSIVEMAIN__29$", duration: 3000, boxId: 9001);
                context.SetEventUI(arg1: 4, script: "$61000008_ME__01_MASSIVEMAIN__30$", duration: 3000, notBoxId: 9001);
                context.PlaySystemSoundInBox(boxIds: new []{9001}, sound: "DJDD_Ending_01");
                context.PlaySystemSoundInBox(boxIds: new []{9010, 9011, 9012, 9013}, sound: "DJDD_Ending_02");
                context.SetAchievement(triggerId: 9001, type: "trigger", code: "ddstop_win");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateGiveReward(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGiveReward : TriggerState {
            internal StateGiveReward(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MiniGameGiveReward(winnerBoxId: 9001, contentType: "miniGame");
                context.EndMiniGame(winnerBoxId: 9001, type: MiniGame.DanceDanceStop);
                context.AddBuff(boxIds: new []{9001}, skillId: 70000019, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateLeaveAll(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFailAll : TriggerState {
            internal StateFailAll(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGame(winnerBoxId: 9001, type: MiniGame.DanceDanceStop);
                context.SetEventUI(arg1: 0, script: "0,0");
                context.SetEventUI(arg1: 5, script: "$61000008_ME__01_MASSIVEMAIN__28$", duration: 5000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Ending_02");
                context.SetMesh(triggerIds: new []{8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914}, visible: false, arg3: 400, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 4, key: "BannerCheckIn", value: 1);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 10);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 10);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 10);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 10);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 10);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 10);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 10);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 10);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 10);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 10);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 10);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 10);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 10);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 10);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 10);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 10);
                context.SetUserValue(triggerId: 7110, key: "Color11", value: 5);
                context.SetUserValue(triggerId: 7120, key: "Color12", value: 5);
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 5);
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 5);
                context.SetUserValue(triggerId: 7210, key: "Color21", value: 5);
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 5);
                context.SetUserValue(triggerId: 7230, key: "Color23", value: 5);
                context.SetUserValue(triggerId: 7240, key: "Color24", value: 5);
                context.SetUserValue(triggerId: 7310, key: "Color31", value: 5);
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 5);
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 5);
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 5);
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 5);
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 5);
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 5);
                context.SetUserValue(triggerId: 7440, key: "Color44", value: 5);
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: true, arg3: 400, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateLeaveAll(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "10004");
            }
        }

        private class StateLeaveAll : TriggerState {
            internal StateLeaveAll(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 910, enabled: false);
                context.UnSetMiniGameAreaForHack();
                context.SetSound(triggerId: 40000, enabled: false);
                context.SetUserValue(triggerId: 5, key: "BannerNumber", value: 0);
                context.SetEventUI(arg1: 1, script: "$61000008_ME__01_MASSIVEMAIN__31$", duration: 10000);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Ending_03");
                context.SetSound(triggerId: 10000, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 0, portalId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P01_RoundCheckIn : TriggerState {
            internal StateG01P01_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P01Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P01_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P01_CleanUp : TriggerState {
            internal StateG01P01_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P01_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P01_Check : TriggerState {
            internal StateG01P01_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P01TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P01_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P01_End : TriggerState {
            internal StateG01P01_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P01End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P02_RoundCheckIn : TriggerState {
            internal StateG01P02_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P02Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P02_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P02_CleanUp : TriggerState {
            internal StateG01P02_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P02_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P02_Check : TriggerState {
            internal StateG01P02_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P02TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P02_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P02_End : TriggerState {
            internal StateG01P02_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P02End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P03_RoundCheckIn : TriggerState {
            internal StateG01P03_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P03Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P03_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P03_CleanUp : TriggerState {
            internal StateG01P03_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P03_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P03_Check : TriggerState {
            internal StateG01P03_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P03TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P03_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P03_End : TriggerState {
            internal StateG01P03_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P03End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P04_RoundCheckIn : TriggerState {
            internal StateG01P04_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P04Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P04_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P04_CleanUp : TriggerState {
            internal StateG01P04_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P04_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P04_Check : TriggerState {
            internal StateG01P04_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P04TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P04_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P04_End : TriggerState {
            internal StateG01P04_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P04End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P05_RoundCheckIn : TriggerState {
            internal StateG01P05_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P05Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P05_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P05_CleanUp : TriggerState {
            internal StateG01P05_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P05_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P05_Check : TriggerState {
            internal StateG01P05_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P05TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P05_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P05_End : TriggerState {
            internal StateG01P05_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P05End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P06_RoundCheckIn : TriggerState {
            internal StateG01P06_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P06Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P06_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P06_CleanUp : TriggerState {
            internal StateG01P06_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P06_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P06_Check : TriggerState {
            internal StateG01P06_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P06TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P06_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P06_End : TriggerState {
            internal StateG01P06_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P06End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P07_RoundCheckIn : TriggerState {
            internal StateG01P07_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P07Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P07_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P07_CleanUp : TriggerState {
            internal StateG01P07_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P07_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P07_Check : TriggerState {
            internal StateG01P07_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P07TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P07_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P07_End : TriggerState {
            internal StateG01P07_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P07End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P08_RoundCheckIn : TriggerState {
            internal StateG01P08_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P08Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P08_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P08_CleanUp : TriggerState {
            internal StateG01P08_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P08_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P08_Check : TriggerState {
            internal StateG01P08_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P08TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P08_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P08_End : TriggerState {
            internal StateG01P08_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P08End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P09_RoundCheckIn : TriggerState {
            internal StateG01P09_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P09Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P09_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P09_CleanUp : TriggerState {
            internal StateG01P09_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P09_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P09_Check : TriggerState {
            internal StateG01P09_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P09TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P09_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P09_End : TriggerState {
            internal StateG01P09_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P09End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P10_RoundCheckIn : TriggerState {
            internal StateG01P10_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P10Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P10_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P10_CleanUp : TriggerState {
            internal StateG01P10_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P10_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P10_Check : TriggerState {
            internal StateG01P10_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P10TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P10_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P10_End : TriggerState {
            internal StateG01P10_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P10End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P11_RoundCheckIn : TriggerState {
            internal StateG01P11_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P11Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P11_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P11_CleanUp : TriggerState {
            internal StateG01P11_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P11_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P11_Check : TriggerState {
            internal StateG01P11_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P11TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P11_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P11_End : TriggerState {
            internal StateG01P11_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P11End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P12_RoundCheckIn : TriggerState {
            internal StateG01P12_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P12Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P12_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P12_CleanUp : TriggerState {
            internal StateG01P12_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P12_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P12_Check : TriggerState {
            internal StateG01P12_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P12TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P12_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P12_End : TriggerState {
            internal StateG01P12_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P12End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P13_RoundCheckIn : TriggerState {
            internal StateG01P13_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P13Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P13_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P13_CleanUp : TriggerState {
            internal StateG01P13_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P13_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P13_Check : TriggerState {
            internal StateG01P13_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P13TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P13_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P13_End : TriggerState {
            internal StateG01P13_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P13End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P14_RoundCheckIn : TriggerState {
            internal StateG01P14_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P14Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P14_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P14_CleanUp : TriggerState {
            internal StateG01P14_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P14_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P14_Check : TriggerState {
            internal StateG01P14_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P14TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P14_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P14_End : TriggerState {
            internal StateG01P14_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P14End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P15_RoundCheckIn : TriggerState {
            internal StateG01P15_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P15Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P15_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P15_CleanUp : TriggerState {
            internal StateG01P15_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P15_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P15_Check : TriggerState {
            internal StateG01P15_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P15TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P15_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P15_End : TriggerState {
            internal StateG01P15_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P15End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P16_RoundCheckIn : TriggerState {
            internal StateG01P16_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P16Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P16_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P16_CleanUp : TriggerState {
            internal StateG01P16_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P16_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P16_Check : TriggerState {
            internal StateG01P16_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P16TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P16_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P16_End : TriggerState {
            internal StateG01P16_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P16End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P17_RoundCheckIn : TriggerState {
            internal StateG01P17_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P17Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P17_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P17_CleanUp : TriggerState {
            internal StateG01P17_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P17_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P17_Check : TriggerState {
            internal StateG01P17_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P17TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P17_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P17_End : TriggerState {
            internal StateG01P17_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P17End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P18_RoundCheckIn : TriggerState {
            internal StateG01P18_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P18Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P18_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P18_CleanUp : TriggerState {
            internal StateG01P18_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P18_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P18_Check : TriggerState {
            internal StateG01P18_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P18TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P18_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P18_End : TriggerState {
            internal StateG01P18_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P18End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P19_RoundCheckIn : TriggerState {
            internal StateG01P19_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P19Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P19_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P19_CleanUp : TriggerState {
            internal StateG01P19_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P19_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P19_Check : TriggerState {
            internal StateG01P19_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P19TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P19_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P19_End : TriggerState {
            internal StateG01P19_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P19End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P20_RoundCheckIn : TriggerState {
            internal StateG01P20_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P20Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P20_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P20_CleanUp : TriggerState {
            internal StateG01P20_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P20_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P20_Check : TriggerState {
            internal StateG01P20_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P20TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P20_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P20_End : TriggerState {
            internal StateG01P20_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P20End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P21_RoundCheckIn : TriggerState {
            internal StateG01P21_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P21Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P21_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P21_CleanUp : TriggerState {
            internal StateG01P21_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P21_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P21_Check : TriggerState {
            internal StateG01P21_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P21TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P21_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P21_End : TriggerState {
            internal StateG01P21_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P21End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P22_RoundCheckIn : TriggerState {
            internal StateG01P22_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P22Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P22_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P22_CleanUp : TriggerState {
            internal StateG01P22_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P22_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P22_Check : TriggerState {
            internal StateG01P22_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P22TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P22_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P22_End : TriggerState {
            internal StateG01P22_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P22End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P23_RoundCheckIn : TriggerState {
            internal StateG01P23_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P23Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P23_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P23_CleanUp : TriggerState {
            internal StateG01P23_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P23_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P23_Check : TriggerState {
            internal StateG01P23_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P23TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P23_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P23_End : TriggerState {
            internal StateG01P23_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P23End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P24_RoundCheckIn : TriggerState {
            internal StateG01P24_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P24Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P24_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P24_CleanUp : TriggerState {
            internal StateG01P24_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P24_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P24_Check : TriggerState {
            internal StateG01P24_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P24TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P24_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P24_End : TriggerState {
            internal StateG01P24_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P24End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P25_RoundCheckIn : TriggerState {
            internal StateG01P25_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P25Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P25_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P25_CleanUp : TriggerState {
            internal StateG01P25_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P25_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P25_Check : TriggerState {
            internal StateG01P25_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P25TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P25_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P25_End : TriggerState {
            internal StateG01P25_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P25End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P26_RoundCheckIn : TriggerState {
            internal StateG01P26_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P26Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P26_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P26_CleanUp : TriggerState {
            internal StateG01P26_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P26_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P26_Check : TriggerState {
            internal StateG01P26_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P26TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P26_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P26_End : TriggerState {
            internal StateG01P26_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P26End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P27_RoundCheckIn : TriggerState {
            internal StateG01P27_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P27Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P27_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P27_CleanUp : TriggerState {
            internal StateG01P27_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P27_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P27_Check : TriggerState {
            internal StateG01P27_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P27TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P27_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P27_End : TriggerState {
            internal StateG01P27_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P27End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P28_RoundCheckIn : TriggerState {
            internal StateG01P28_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P28Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P28_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P28_CleanUp : TriggerState {
            internal StateG01P28_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P28_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P28_Check : TriggerState {
            internal StateG01P28_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P28TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P28_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P28_End : TriggerState {
            internal StateG01P28_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P28End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P29_RoundCheckIn : TriggerState {
            internal StateG01P29_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P29Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P29_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P29_CleanUp : TriggerState {
            internal StateG01P29_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P29_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P29_Check : TriggerState {
            internal StateG01P29_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P29TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P29_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P29_End : TriggerState {
            internal StateG01P29_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P29End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P30_RoundCheckIn : TriggerState {
            internal StateG01P30_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P30Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG01P30_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG01P30_CleanUp : TriggerState {
            internal StateG01P30_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG01P30_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P30_Check : TriggerState {
            internal StateG01P30_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P30TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG01P30_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P30_End : TriggerState {
            internal StateG01P30_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G01P30End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P01_RoundCheckIn : TriggerState {
            internal StateG02P01_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P01Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P01_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P01_CleanUp : TriggerState {
            internal StateG02P01_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P01_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P01_Check : TriggerState {
            internal StateG02P01_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P01TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P01_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P01_End : TriggerState {
            internal StateG02P01_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P01End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P02_RoundCheckIn : TriggerState {
            internal StateG02P02_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P02Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P02_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P02_CleanUp : TriggerState {
            internal StateG02P02_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P02_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P02_Check : TriggerState {
            internal StateG02P02_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P02TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P02_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P02_End : TriggerState {
            internal StateG02P02_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P02End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P03_RoundCheckIn : TriggerState {
            internal StateG02P03_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P03Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P03_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P03_CleanUp : TriggerState {
            internal StateG02P03_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P03_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P03_Check : TriggerState {
            internal StateG02P03_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P03TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P03_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P03_End : TriggerState {
            internal StateG02P03_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P03End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P04_RoundCheckIn : TriggerState {
            internal StateG02P04_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P04Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P04_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P04_CleanUp : TriggerState {
            internal StateG02P04_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P04_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P04_Check : TriggerState {
            internal StateG02P04_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P04TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P04_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P04_End : TriggerState {
            internal StateG02P04_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P04End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P05_RoundCheckIn : TriggerState {
            internal StateG02P05_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P05Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P05_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P05_CleanUp : TriggerState {
            internal StateG02P05_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P05_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P05_Check : TriggerState {
            internal StateG02P05_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P05TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P05_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P05_End : TriggerState {
            internal StateG02P05_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P05End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P06_RoundCheckIn : TriggerState {
            internal StateG02P06_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P06Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P06_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P06_CleanUp : TriggerState {
            internal StateG02P06_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P06_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P06_Check : TriggerState {
            internal StateG02P06_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P06TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P06_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P06_End : TriggerState {
            internal StateG02P06_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P06End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P07_RoundCheckIn : TriggerState {
            internal StateG02P07_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P07Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P07_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P07_CleanUp : TriggerState {
            internal StateG02P07_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P07_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P07_Check : TriggerState {
            internal StateG02P07_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P07TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P07_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P07_End : TriggerState {
            internal StateG02P07_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P07End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P08_RoundCheckIn : TriggerState {
            internal StateG02P08_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P08Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P08_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P08_CleanUp : TriggerState {
            internal StateG02P08_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P08_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P08_Check : TriggerState {
            internal StateG02P08_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P08TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P08_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P08_End : TriggerState {
            internal StateG02P08_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P08End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P09_RoundCheckIn : TriggerState {
            internal StateG02P09_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P09Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P09_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P09_CleanUp : TriggerState {
            internal StateG02P09_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P09_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P09_Check : TriggerState {
            internal StateG02P09_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P09TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P09_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P09_End : TriggerState {
            internal StateG02P09_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P09End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P10_RoundCheckIn : TriggerState {
            internal StateG02P10_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P10Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P10_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P10_CleanUp : TriggerState {
            internal StateG02P10_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P10_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P10_Check : TriggerState {
            internal StateG02P10_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P10TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P10_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P10_End : TriggerState {
            internal StateG02P10_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P10End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P11_RoundCheckIn : TriggerState {
            internal StateG02P11_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P11Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P11_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P11_CleanUp : TriggerState {
            internal StateG02P11_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P11_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P11_Check : TriggerState {
            internal StateG02P11_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P11TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P11_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P11_End : TriggerState {
            internal StateG02P11_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P11End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P12_RoundCheckIn : TriggerState {
            internal StateG02P12_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P12Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P12_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P12_CleanUp : TriggerState {
            internal StateG02P12_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P12_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P12_Check : TriggerState {
            internal StateG02P12_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P12TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P12_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P12_End : TriggerState {
            internal StateG02P12_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P12End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P13_RoundCheckIn : TriggerState {
            internal StateG02P13_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P13Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P13_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P13_CleanUp : TriggerState {
            internal StateG02P13_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P13_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P13_Check : TriggerState {
            internal StateG02P13_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P13TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P13_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P13_End : TriggerState {
            internal StateG02P13_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P13End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P14_RoundCheckIn : TriggerState {
            internal StateG02P14_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P14Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P14_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P14_CleanUp : TriggerState {
            internal StateG02P14_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P14_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P14_Check : TriggerState {
            internal StateG02P14_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P14TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P14_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P14_End : TriggerState {
            internal StateG02P14_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P14End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P15_RoundCheckIn : TriggerState {
            internal StateG02P15_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P15Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P15_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P15_CleanUp : TriggerState {
            internal StateG02P15_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P15_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P15_Check : TriggerState {
            internal StateG02P15_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P15TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P15_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P15_End : TriggerState {
            internal StateG02P15_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P15End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P16_RoundCheckIn : TriggerState {
            internal StateG02P16_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P16Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P16_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P16_CleanUp : TriggerState {
            internal StateG02P16_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P16_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P16_Check : TriggerState {
            internal StateG02P16_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P16TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P16_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P16_End : TriggerState {
            internal StateG02P16_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P16End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P17_RoundCheckIn : TriggerState {
            internal StateG02P17_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P17Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P17_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P17_CleanUp : TriggerState {
            internal StateG02P17_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P17_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P17_Check : TriggerState {
            internal StateG02P17_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P17TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P17_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P17_End : TriggerState {
            internal StateG02P17_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P17End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P18_RoundCheckIn : TriggerState {
            internal StateG02P18_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P18Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P18_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P18_CleanUp : TriggerState {
            internal StateG02P18_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P18_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P18_Check : TriggerState {
            internal StateG02P18_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P18TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P18_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P18_End : TriggerState {
            internal StateG02P18_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P18End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P19_RoundCheckIn : TriggerState {
            internal StateG02P19_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P19Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P19_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P19_CleanUp : TriggerState {
            internal StateG02P19_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P19_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P19_Check : TriggerState {
            internal StateG02P19_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P19TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P19_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P19_End : TriggerState {
            internal StateG02P19_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P19End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P20_RoundCheckIn : TriggerState {
            internal StateG02P20_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P20Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P20_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P20_CleanUp : TriggerState {
            internal StateG02P20_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P20_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P20_Check : TriggerState {
            internal StateG02P20_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P20TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P20_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P20_End : TriggerState {
            internal StateG02P20_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P20End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P21_RoundCheckIn : TriggerState {
            internal StateG02P21_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P21Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P21_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P21_CleanUp : TriggerState {
            internal StateG02P21_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P21_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P21_Check : TriggerState {
            internal StateG02P21_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P21TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P21_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P21_End : TriggerState {
            internal StateG02P21_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P21End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P22_RoundCheckIn : TriggerState {
            internal StateG02P22_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P22Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P22_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P22_CleanUp : TriggerState {
            internal StateG02P22_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P22_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P22_Check : TriggerState {
            internal StateG02P22_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P22TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P22_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P22_End : TriggerState {
            internal StateG02P22_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P22End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P23_RoundCheckIn : TriggerState {
            internal StateG02P23_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P23Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P23_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P23_CleanUp : TriggerState {
            internal StateG02P23_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P23_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P23_Check : TriggerState {
            internal StateG02P23_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P23TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P23_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P23_End : TriggerState {
            internal StateG02P23_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P23End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P24_RoundCheckIn : TriggerState {
            internal StateG02P24_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P24Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P24_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P24_CleanUp : TriggerState {
            internal StateG02P24_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P24_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P24_Check : TriggerState {
            internal StateG02P24_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P24TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P24_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P24_End : TriggerState {
            internal StateG02P24_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P24End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P25_RoundCheckIn : TriggerState {
            internal StateG02P25_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P25Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P25_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P25_CleanUp : TriggerState {
            internal StateG02P25_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P25_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P25_Check : TriggerState {
            internal StateG02P25_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P25TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P25_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P25_End : TriggerState {
            internal StateG02P25_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P25End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P26_RoundCheckIn : TriggerState {
            internal StateG02P26_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P26Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P26_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P26_CleanUp : TriggerState {
            internal StateG02P26_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P26_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P26_Check : TriggerState {
            internal StateG02P26_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P26TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P26_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P26_End : TriggerState {
            internal StateG02P26_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P26End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P27_RoundCheckIn : TriggerState {
            internal StateG02P27_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P27Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P27_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P27_CleanUp : TriggerState {
            internal StateG02P27_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P27_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P27_Check : TriggerState {
            internal StateG02P27_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P27TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P27_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P27_End : TriggerState {
            internal StateG02P27_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P27End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P28_RoundCheckIn : TriggerState {
            internal StateG02P28_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P28Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P28_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P28_CleanUp : TriggerState {
            internal StateG02P28_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P28_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P28_Check : TriggerState {
            internal StateG02P28_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P28TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P28_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P28_End : TriggerState {
            internal StateG02P28_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P28End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P29_RoundCheckIn : TriggerState {
            internal StateG02P29_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P29Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P29_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P29_CleanUp : TriggerState {
            internal StateG02P29_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P29_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P29_Check : TriggerState {
            internal StateG02P29_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P29TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P29_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P29_End : TriggerState {
            internal StateG02P29_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P29End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P30_RoundCheckIn : TriggerState {
            internal StateG02P30_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P30Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG02P30_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG02P30_CleanUp : TriggerState {
            internal StateG02P30_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG02P30_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P30_Check : TriggerState {
            internal StateG02P30_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 200, key: "G02P30TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG02P30_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P30_End : TriggerState {
            internal StateG02P30_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G02P30End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P01_RoundCheckIn : TriggerState {
            internal StateG03P01_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P01Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P01_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P01_CleanUp : TriggerState {
            internal StateG03P01_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P01_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P01_Check : TriggerState {
            internal StateG03P01_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P01TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P01_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P01_End : TriggerState {
            internal StateG03P01_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P01End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P02_RoundCheckIn : TriggerState {
            internal StateG03P02_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P02Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P02_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P02_CleanUp : TriggerState {
            internal StateG03P02_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P02_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P02_Check : TriggerState {
            internal StateG03P02_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P02TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P02_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P02_End : TriggerState {
            internal StateG03P02_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P02End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P03_RoundCheckIn : TriggerState {
            internal StateG03P03_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P03Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P03_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P03_CleanUp : TriggerState {
            internal StateG03P03_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P03_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P03_Check : TriggerState {
            internal StateG03P03_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P03TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P03_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P03_End : TriggerState {
            internal StateG03P03_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P03End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P04_RoundCheckIn : TriggerState {
            internal StateG03P04_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P04Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P04_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P04_CleanUp : TriggerState {
            internal StateG03P04_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P04_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P04_Check : TriggerState {
            internal StateG03P04_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P04TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P04_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P04_End : TriggerState {
            internal StateG03P04_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P04End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P05_RoundCheckIn : TriggerState {
            internal StateG03P05_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P05Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P05_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P05_CleanUp : TriggerState {
            internal StateG03P05_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P05_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P05_Check : TriggerState {
            internal StateG03P05_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P05TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P05_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P05_End : TriggerState {
            internal StateG03P05_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P05End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P06_RoundCheckIn : TriggerState {
            internal StateG03P06_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P06Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P06_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P06_CleanUp : TriggerState {
            internal StateG03P06_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P06_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P06_Check : TriggerState {
            internal StateG03P06_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P06TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P06_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P06_End : TriggerState {
            internal StateG03P06_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P06End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P07_RoundCheckIn : TriggerState {
            internal StateG03P07_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P07Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P07_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P07_CleanUp : TriggerState {
            internal StateG03P07_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P07_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P07_Check : TriggerState {
            internal StateG03P07_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P07TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P07_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P07_End : TriggerState {
            internal StateG03P07_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P07End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P08_RoundCheckIn : TriggerState {
            internal StateG03P08_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P08Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P08_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P08_CleanUp : TriggerState {
            internal StateG03P08_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P08_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P08_Check : TriggerState {
            internal StateG03P08_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P08TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P08_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P08_End : TriggerState {
            internal StateG03P08_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P08End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P09_RoundCheckIn : TriggerState {
            internal StateG03P09_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P09Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P09_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P09_CleanUp : TriggerState {
            internal StateG03P09_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P09_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P09_Check : TriggerState {
            internal StateG03P09_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P09TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P09_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P09_End : TriggerState {
            internal StateG03P09_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P09End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P10_RoundCheckIn : TriggerState {
            internal StateG03P10_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P10Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P10_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P10_CleanUp : TriggerState {
            internal StateG03P10_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P10_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P10_Check : TriggerState {
            internal StateG03P10_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P10TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P10_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P10_End : TriggerState {
            internal StateG03P10_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P10End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P11_RoundCheckIn : TriggerState {
            internal StateG03P11_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P11Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P11_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P11_CleanUp : TriggerState {
            internal StateG03P11_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P11_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P11_Check : TriggerState {
            internal StateG03P11_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P11TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P11_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P11_End : TriggerState {
            internal StateG03P11_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P11End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P12_RoundCheckIn : TriggerState {
            internal StateG03P12_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P12Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P12_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P12_CleanUp : TriggerState {
            internal StateG03P12_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P12_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P12_Check : TriggerState {
            internal StateG03P12_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P12TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P12_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P12_End : TriggerState {
            internal StateG03P12_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P12End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P13_RoundCheckIn : TriggerState {
            internal StateG03P13_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P13Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P13_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P13_CleanUp : TriggerState {
            internal StateG03P13_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P13_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P13_Check : TriggerState {
            internal StateG03P13_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P13TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P13_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P13_End : TriggerState {
            internal StateG03P13_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P13End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P14_RoundCheckIn : TriggerState {
            internal StateG03P14_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P14Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P14_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P14_CleanUp : TriggerState {
            internal StateG03P14_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P14_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P14_Check : TriggerState {
            internal StateG03P14_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P14TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P14_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P14_End : TriggerState {
            internal StateG03P14_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P14End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P15_RoundCheckIn : TriggerState {
            internal StateG03P15_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P15Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P15_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P15_CleanUp : TriggerState {
            internal StateG03P15_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P15_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P15_Check : TriggerState {
            internal StateG03P15_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P15TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P15_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P15_End : TriggerState {
            internal StateG03P15_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P15End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P16_RoundCheckIn : TriggerState {
            internal StateG03P16_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P16Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P16_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P16_CleanUp : TriggerState {
            internal StateG03P16_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P16_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P16_Check : TriggerState {
            internal StateG03P16_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P16TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P16_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P16_End : TriggerState {
            internal StateG03P16_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P16End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P17_RoundCheckIn : TriggerState {
            internal StateG03P17_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P17Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P17_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P17_CleanUp : TriggerState {
            internal StateG03P17_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P17_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P17_Check : TriggerState {
            internal StateG03P17_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P17TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P17_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P17_End : TriggerState {
            internal StateG03P17_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P17End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P18_RoundCheckIn : TriggerState {
            internal StateG03P18_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P18Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P18_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P18_CleanUp : TriggerState {
            internal StateG03P18_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P18_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P18_Check : TriggerState {
            internal StateG03P18_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P18TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P18_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P18_End : TriggerState {
            internal StateG03P18_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P18End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P19_RoundCheckIn : TriggerState {
            internal StateG03P19_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P19Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P19_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P19_CleanUp : TriggerState {
            internal StateG03P19_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P19_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P19_Check : TriggerState {
            internal StateG03P19_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P19TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P19_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P19_End : TriggerState {
            internal StateG03P19_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P19End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P20_RoundCheckIn : TriggerState {
            internal StateG03P20_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P20Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P20_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P20_CleanUp : TriggerState {
            internal StateG03P20_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P20_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P20_Check : TriggerState {
            internal StateG03P20_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P20TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P20_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P20_End : TriggerState {
            internal StateG03P20_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P20End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P21_RoundCheckIn : TriggerState {
            internal StateG03P21_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P21Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P21_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P21_CleanUp : TriggerState {
            internal StateG03P21_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P21_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P21_Check : TriggerState {
            internal StateG03P21_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P21TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P21_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P21_End : TriggerState {
            internal StateG03P21_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P21End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P22_RoundCheckIn : TriggerState {
            internal StateG03P22_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P22Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P22_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P22_CleanUp : TriggerState {
            internal StateG03P22_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P22_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P22_Check : TriggerState {
            internal StateG03P22_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P22TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P22_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P22_End : TriggerState {
            internal StateG03P22_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P22End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P23_RoundCheckIn : TriggerState {
            internal StateG03P23_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P23Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P23_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P23_CleanUp : TriggerState {
            internal StateG03P23_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P23_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P23_Check : TriggerState {
            internal StateG03P23_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P23TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P23_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P23_End : TriggerState {
            internal StateG03P23_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P23End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P24_RoundCheckIn : TriggerState {
            internal StateG03P24_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P24Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P24_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P24_CleanUp : TriggerState {
            internal StateG03P24_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P24_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P24_Check : TriggerState {
            internal StateG03P24_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P24TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P24_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P24_End : TriggerState {
            internal StateG03P24_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P24End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P25_RoundCheckIn : TriggerState {
            internal StateG03P25_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P25Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P25_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P25_CleanUp : TriggerState {
            internal StateG03P25_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P25_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P25_Check : TriggerState {
            internal StateG03P25_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P25TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P25_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P25_End : TriggerState {
            internal StateG03P25_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P25End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P26_RoundCheckIn : TriggerState {
            internal StateG03P26_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P26Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P26_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P26_CleanUp : TriggerState {
            internal StateG03P26_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P26_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P26_Check : TriggerState {
            internal StateG03P26_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P26TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P26_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P26_End : TriggerState {
            internal StateG03P26_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P26End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P27_RoundCheckIn : TriggerState {
            internal StateG03P27_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P27Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P27_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P27_CleanUp : TriggerState {
            internal StateG03P27_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P27_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P27_Check : TriggerState {
            internal StateG03P27_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P27TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P27_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P27_End : TriggerState {
            internal StateG03P27_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P27End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P28_RoundCheckIn : TriggerState {
            internal StateG03P28_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P28Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P28_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P28_CleanUp : TriggerState {
            internal StateG03P28_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P28_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P28_Check : TriggerState {
            internal StateG03P28_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P28TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P28_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P28_End : TriggerState {
            internal StateG03P28_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P28End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P29_RoundCheckIn : TriggerState {
            internal StateG03P29_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P29Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P29_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P29_CleanUp : TriggerState {
            internal StateG03P29_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P29_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P29_Check : TriggerState {
            internal StateG03P29_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P29TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P29_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P29_End : TriggerState {
            internal StateG03P29_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P29End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P30_RoundCheckIn : TriggerState {
            internal StateG03P30_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P30Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG03P30_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG03P30_CleanUp : TriggerState {
            internal StateG03P30_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG03P30_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P30_Check : TriggerState {
            internal StateG03P30_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 300, key: "G03P30TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG03P30_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P30_End : TriggerState {
            internal StateG03P30_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G03P30End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P01_RoundCheckIn : TriggerState {
            internal StateG04P01_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P01Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P01_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P01_CleanUp : TriggerState {
            internal StateG04P01_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P01_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P01_Check : TriggerState {
            internal StateG04P01_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P01TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P01_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P01_End : TriggerState {
            internal StateG04P01_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P01End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P02_RoundCheckIn : TriggerState {
            internal StateG04P02_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P02Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P02_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P02_CleanUp : TriggerState {
            internal StateG04P02_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P02_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P02_Check : TriggerState {
            internal StateG04P02_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P02TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P02_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P02_End : TriggerState {
            internal StateG04P02_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P02End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P03_RoundCheckIn : TriggerState {
            internal StateG04P03_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P03Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P03_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P03_CleanUp : TriggerState {
            internal StateG04P03_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P03_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P03_Check : TriggerState {
            internal StateG04P03_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P03TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P03_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P03_End : TriggerState {
            internal StateG04P03_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P03End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P04_RoundCheckIn : TriggerState {
            internal StateG04P04_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P04Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P04_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P04_CleanUp : TriggerState {
            internal StateG04P04_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P04_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P04_Check : TriggerState {
            internal StateG04P04_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P04TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P04_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P04_End : TriggerState {
            internal StateG04P04_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P04End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P05_RoundCheckIn : TriggerState {
            internal StateG04P05_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P05Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P05_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P05_CleanUp : TriggerState {
            internal StateG04P05_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P05_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P05_Check : TriggerState {
            internal StateG04P05_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P05TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P05_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P05_End : TriggerState {
            internal StateG04P05_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P05End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P06_RoundCheckIn : TriggerState {
            internal StateG04P06_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P06Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P06_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P06_CleanUp : TriggerState {
            internal StateG04P06_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P06_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P06_Check : TriggerState {
            internal StateG04P06_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P06TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P06_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P06_End : TriggerState {
            internal StateG04P06_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P06End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P07_RoundCheckIn : TriggerState {
            internal StateG04P07_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P07Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P07_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P07_CleanUp : TriggerState {
            internal StateG04P07_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P07_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P07_Check : TriggerState {
            internal StateG04P07_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P07TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P07_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P07_End : TriggerState {
            internal StateG04P07_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P07End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P08_RoundCheckIn : TriggerState {
            internal StateG04P08_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P08Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P08_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P08_CleanUp : TriggerState {
            internal StateG04P08_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P08_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P08_Check : TriggerState {
            internal StateG04P08_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P08TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P08_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P08_End : TriggerState {
            internal StateG04P08_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P08End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P09_RoundCheckIn : TriggerState {
            internal StateG04P09_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P09Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P09_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P09_CleanUp : TriggerState {
            internal StateG04P09_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P09_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P09_Check : TriggerState {
            internal StateG04P09_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P09TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P09_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P09_End : TriggerState {
            internal StateG04P09_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P09End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P10_RoundCheckIn : TriggerState {
            internal StateG04P10_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P10Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P10_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P10_CleanUp : TriggerState {
            internal StateG04P10_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P10_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P10_Check : TriggerState {
            internal StateG04P10_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P10TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P10_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P10_End : TriggerState {
            internal StateG04P10_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P10End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P11_RoundCheckIn : TriggerState {
            internal StateG04P11_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P11Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P11_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P11_CleanUp : TriggerState {
            internal StateG04P11_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P11_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P11_Check : TriggerState {
            internal StateG04P11_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P11TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P11_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P11_End : TriggerState {
            internal StateG04P11_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P11End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P12_RoundCheckIn : TriggerState {
            internal StateG04P12_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P12Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P12_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P12_CleanUp : TriggerState {
            internal StateG04P12_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P12_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P12_Check : TriggerState {
            internal StateG04P12_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P12TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P12_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P12_End : TriggerState {
            internal StateG04P12_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P12End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P13_RoundCheckIn : TriggerState {
            internal StateG04P13_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P13Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P13_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P13_CleanUp : TriggerState {
            internal StateG04P13_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P13_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P13_Check : TriggerState {
            internal StateG04P13_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P13TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P13_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P13_End : TriggerState {
            internal StateG04P13_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P13End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P14_RoundCheckIn : TriggerState {
            internal StateG04P14_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P14Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P14_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P14_CleanUp : TriggerState {
            internal StateG04P14_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P14_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P14_Check : TriggerState {
            internal StateG04P14_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P14TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P14_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P14_End : TriggerState {
            internal StateG04P14_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P14End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P15_RoundCheckIn : TriggerState {
            internal StateG04P15_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P15Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P15_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P15_CleanUp : TriggerState {
            internal StateG04P15_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P15_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P15_Check : TriggerState {
            internal StateG04P15_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P15TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P15_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P15_End : TriggerState {
            internal StateG04P15_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P15End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P16_RoundCheckIn : TriggerState {
            internal StateG04P16_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P16Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P16_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P16_CleanUp : TriggerState {
            internal StateG04P16_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P16_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P16_Check : TriggerState {
            internal StateG04P16_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P16TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P16_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P16_End : TriggerState {
            internal StateG04P16_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P16End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P17_RoundCheckIn : TriggerState {
            internal StateG04P17_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P17Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P17_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P17_CleanUp : TriggerState {
            internal StateG04P17_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P17_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P17_Check : TriggerState {
            internal StateG04P17_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P17TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P17_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P17_End : TriggerState {
            internal StateG04P17_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P17End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P18_RoundCheckIn : TriggerState {
            internal StateG04P18_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P18Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P18_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P18_CleanUp : TriggerState {
            internal StateG04P18_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P18_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P18_Check : TriggerState {
            internal StateG04P18_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P18TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P18_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P18_End : TriggerState {
            internal StateG04P18_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P18End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P19_RoundCheckIn : TriggerState {
            internal StateG04P19_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P19Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P19_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P19_CleanUp : TriggerState {
            internal StateG04P19_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P19_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P19_Check : TriggerState {
            internal StateG04P19_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P19TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P19_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P19_End : TriggerState {
            internal StateG04P19_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P19End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P20_RoundCheckIn : TriggerState {
            internal StateG04P20_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P20Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P20_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P20_CleanUp : TriggerState {
            internal StateG04P20_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P20_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P20_Check : TriggerState {
            internal StateG04P20_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P20TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P20_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P20_End : TriggerState {
            internal StateG04P20_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P20End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P21_RoundCheckIn : TriggerState {
            internal StateG04P21_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P21Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P21_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P21_CleanUp : TriggerState {
            internal StateG04P21_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P21_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P21_Check : TriggerState {
            internal StateG04P21_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P21TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P21_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P21_End : TriggerState {
            internal StateG04P21_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P21End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P22_RoundCheckIn : TriggerState {
            internal StateG04P22_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P22Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P22_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P22_CleanUp : TriggerState {
            internal StateG04P22_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P22_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P22_Check : TriggerState {
            internal StateG04P22_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P22TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P22_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P22_End : TriggerState {
            internal StateG04P22_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P22End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P23_RoundCheckIn : TriggerState {
            internal StateG04P23_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P23Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P23_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P23_CleanUp : TriggerState {
            internal StateG04P23_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P23_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P23_Check : TriggerState {
            internal StateG04P23_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P23TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P23_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P23_End : TriggerState {
            internal StateG04P23_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P23End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P24_RoundCheckIn : TriggerState {
            internal StateG04P24_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P24Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P24_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P24_CleanUp : TriggerState {
            internal StateG04P24_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P24_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P24_Check : TriggerState {
            internal StateG04P24_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P24TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P24_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P24_End : TriggerState {
            internal StateG04P24_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P24End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P25_RoundCheckIn : TriggerState {
            internal StateG04P25_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P25Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P25_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P25_CleanUp : TriggerState {
            internal StateG04P25_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P25_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P25_Check : TriggerState {
            internal StateG04P25_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P25TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P25_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P25_End : TriggerState {
            internal StateG04P25_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P25End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P26_RoundCheckIn : TriggerState {
            internal StateG04P26_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P26Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P26_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P26_CleanUp : TriggerState {
            internal StateG04P26_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P26_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P26_Check : TriggerState {
            internal StateG04P26_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P26TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P26_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P26_End : TriggerState {
            internal StateG04P26_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P26End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P27_RoundCheckIn : TriggerState {
            internal StateG04P27_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P27Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P27_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P27_CleanUp : TriggerState {
            internal StateG04P27_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P27_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P27_Check : TriggerState {
            internal StateG04P27_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P27TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P27_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P27_End : TriggerState {
            internal StateG04P27_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P27End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P28_RoundCheckIn : TriggerState {
            internal StateG04P28_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P28Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P28_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P28_CleanUp : TriggerState {
            internal StateG04P28_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P28_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P28_Check : TriggerState {
            internal StateG04P28_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P28TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P28_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P28_End : TriggerState {
            internal StateG04P28_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P28End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P29_RoundCheckIn : TriggerState {
            internal StateG04P29_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P29Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P29_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P29_CleanUp : TriggerState {
            internal StateG04P29_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P29_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P29_Check : TriggerState {
            internal StateG04P29_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P29TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P29_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P29_End : TriggerState {
            internal StateG04P29_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P29End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P30_RoundCheckIn : TriggerState {
            internal StateG04P30_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P30Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P30_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P30_CleanUp : TriggerState {
            internal StateG04P30_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P30_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P30_Check : TriggerState {
            internal StateG04P30_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P30TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P30_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P30_End : TriggerState {
            internal StateG04P30_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P30End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P31_RoundCheckIn : TriggerState {
            internal StateG04P31_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P31Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P31_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P31_CleanUp : TriggerState {
            internal StateG04P31_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P31_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P31_Check : TriggerState {
            internal StateG04P31_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P31TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P31_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P31_End : TriggerState {
            internal StateG04P31_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P31End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P32_RoundCheckIn : TriggerState {
            internal StateG04P32_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P32Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P32_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P32_CleanUp : TriggerState {
            internal StateG04P32_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P32_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P32_Check : TriggerState {
            internal StateG04P32_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P32TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P32_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P32_End : TriggerState {
            internal StateG04P32_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P32End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P33_RoundCheckIn : TriggerState {
            internal StateG04P33_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P33Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P33_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P33_CleanUp : TriggerState {
            internal StateG04P33_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P33_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P33_Check : TriggerState {
            internal StateG04P33_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P33TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P33_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P33_End : TriggerState {
            internal StateG04P33_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P33End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P34_RoundCheckIn : TriggerState {
            internal StateG04P34_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P34Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P34_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P34_CleanUp : TriggerState {
            internal StateG04P34_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P34_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P34_Check : TriggerState {
            internal StateG04P34_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P34TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P34_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P34_End : TriggerState {
            internal StateG04P34_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P34End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P35_RoundCheckIn : TriggerState {
            internal StateG04P35_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P35Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P35_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P35_CleanUp : TriggerState {
            internal StateG04P35_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P35_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P35_Check : TriggerState {
            internal StateG04P35_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P35TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P35_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P35_End : TriggerState {
            internal StateG04P35_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P35End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P36_RoundCheckIn : TriggerState {
            internal StateG04P36_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P36Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P36_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P36_CleanUp : TriggerState {
            internal StateG04P36_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P36_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P36_Check : TriggerState {
            internal StateG04P36_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P36TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P36_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P36_End : TriggerState {
            internal StateG04P36_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P36End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P37_RoundCheckIn : TriggerState {
            internal StateG04P37_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P37Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P37_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P37_CleanUp : TriggerState {
            internal StateG04P37_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P37_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P37_Check : TriggerState {
            internal StateG04P37_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P37TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P37_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P37_End : TriggerState {
            internal StateG04P37_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P37End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P38_RoundCheckIn : TriggerState {
            internal StateG04P38_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P38Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P38_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P38_CleanUp : TriggerState {
            internal StateG04P38_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P38_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P38_Check : TriggerState {
            internal StateG04P38_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P38TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P38_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P38_End : TriggerState {
            internal StateG04P38_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P38End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P39_RoundCheckIn : TriggerState {
            internal StateG04P39_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P39Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P39_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P39_CleanUp : TriggerState {
            internal StateG04P39_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P39_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P39_Check : TriggerState {
            internal StateG04P39_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P39TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P39_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P39_End : TriggerState {
            internal StateG04P39_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P39End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P40_RoundCheckIn : TriggerState {
            internal StateG04P40_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P40Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG04P40_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG04P40_CleanUp : TriggerState {
            internal StateG04P40_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG04P40_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P40_Check : TriggerState {
            internal StateG04P40_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 400, key: "G04P40TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG04P40_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P40_End : TriggerState {
            internal StateG04P40_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G04P40End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P01_RoundCheckIn : TriggerState {
            internal StateG05P01_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P01Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P01_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P01_CleanUp : TriggerState {
            internal StateG05P01_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P01_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P01_Check : TriggerState {
            internal StateG05P01_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P01TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P01_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P01_End : TriggerState {
            internal StateG05P01_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P01End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P02_RoundCheckIn : TriggerState {
            internal StateG05P02_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P02Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P02_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P02_CleanUp : TriggerState {
            internal StateG05P02_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P02_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P02_Check : TriggerState {
            internal StateG05P02_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P02TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P02_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P02_End : TriggerState {
            internal StateG05P02_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P02End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P03_RoundCheckIn : TriggerState {
            internal StateG05P03_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P03Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P03_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P03_CleanUp : TriggerState {
            internal StateG05P03_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P03_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P03_Check : TriggerState {
            internal StateG05P03_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P03TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P03_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P03_End : TriggerState {
            internal StateG05P03_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P03End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P04_RoundCheckIn : TriggerState {
            internal StateG05P04_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P04Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P04_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P04_CleanUp : TriggerState {
            internal StateG05P04_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P04_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P04_Check : TriggerState {
            internal StateG05P04_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P04TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P04_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P04_End : TriggerState {
            internal StateG05P04_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P04End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P05_RoundCheckIn : TriggerState {
            internal StateG05P05_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P05Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P05_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P05_CleanUp : TriggerState {
            internal StateG05P05_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P05_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P05_Check : TriggerState {
            internal StateG05P05_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P05TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P05_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P05_End : TriggerState {
            internal StateG05P05_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P05End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P06_RoundCheckIn : TriggerState {
            internal StateG05P06_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P06Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P06_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P06_CleanUp : TriggerState {
            internal StateG05P06_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P06_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P06_Check : TriggerState {
            internal StateG05P06_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P06TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P06_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P06_End : TriggerState {
            internal StateG05P06_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P06End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P07_RoundCheckIn : TriggerState {
            internal StateG05P07_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P07Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P07_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P07_CleanUp : TriggerState {
            internal StateG05P07_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P07_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P07_Check : TriggerState {
            internal StateG05P07_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P07TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P07_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P07_End : TriggerState {
            internal StateG05P07_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P07End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P08_RoundCheckIn : TriggerState {
            internal StateG05P08_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P08Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P08_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P08_CleanUp : TriggerState {
            internal StateG05P08_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P08_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P08_Check : TriggerState {
            internal StateG05P08_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P08TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P08_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P08_End : TriggerState {
            internal StateG05P08_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P08End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P09_RoundCheckIn : TriggerState {
            internal StateG05P09_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P09Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P09_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P09_CleanUp : TriggerState {
            internal StateG05P09_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P09_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P09_Check : TriggerState {
            internal StateG05P09_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P09TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P09_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P09_End : TriggerState {
            internal StateG05P09_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P09End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P10_RoundCheckIn : TriggerState {
            internal StateG05P10_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P10Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P10_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P10_CleanUp : TriggerState {
            internal StateG05P10_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P10_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P10_Check : TriggerState {
            internal StateG05P10_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P10TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P10_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P10_End : TriggerState {
            internal StateG05P10_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P10End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P11_RoundCheckIn : TriggerState {
            internal StateG05P11_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P11Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P11_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P11_CleanUp : TriggerState {
            internal StateG05P11_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P11_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P11_Check : TriggerState {
            internal StateG05P11_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P11TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P11_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P11_End : TriggerState {
            internal StateG05P11_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P11End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P12_RoundCheckIn : TriggerState {
            internal StateG05P12_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P12Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P12_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P12_CleanUp : TriggerState {
            internal StateG05P12_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P12_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P12_Check : TriggerState {
            internal StateG05P12_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P12TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P12_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P12_End : TriggerState {
            internal StateG05P12_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P12End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P13_RoundCheckIn : TriggerState {
            internal StateG05P13_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P13Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P13_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P13_CleanUp : TriggerState {
            internal StateG05P13_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P13_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P13_Check : TriggerState {
            internal StateG05P13_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P13TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P13_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P13_End : TriggerState {
            internal StateG05P13_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P13End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P14_RoundCheckIn : TriggerState {
            internal StateG05P14_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P14Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P14_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P14_CleanUp : TriggerState {
            internal StateG05P14_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P14_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P14_Check : TriggerState {
            internal StateG05P14_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P14TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P14_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P14_End : TriggerState {
            internal StateG05P14_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P14End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P15_RoundCheckIn : TriggerState {
            internal StateG05P15_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P15Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P15_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P15_CleanUp : TriggerState {
            internal StateG05P15_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P15_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P15_Check : TriggerState {
            internal StateG05P15_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P15TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P15_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P15_End : TriggerState {
            internal StateG05P15_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P15End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P16_RoundCheckIn : TriggerState {
            internal StateG05P16_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P16Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P16_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P16_CleanUp : TriggerState {
            internal StateG05P16_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P16_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P16_Check : TriggerState {
            internal StateG05P16_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P16TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P16_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P16_End : TriggerState {
            internal StateG05P16_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P16End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P17_RoundCheckIn : TriggerState {
            internal StateG05P17_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P17Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P17_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P17_CleanUp : TriggerState {
            internal StateG05P17_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P17_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P17_Check : TriggerState {
            internal StateG05P17_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P17TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P17_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P17_End : TriggerState {
            internal StateG05P17_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P17End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P18_RoundCheckIn : TriggerState {
            internal StateG05P18_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P18Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P18_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P18_CleanUp : TriggerState {
            internal StateG05P18_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P18_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P18_Check : TriggerState {
            internal StateG05P18_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P18TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P18_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P18_End : TriggerState {
            internal StateG05P18_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P18End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P19_RoundCheckIn : TriggerState {
            internal StateG05P19_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P19Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P19_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P19_CleanUp : TriggerState {
            internal StateG05P19_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P19_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P19_Check : TriggerState {
            internal StateG05P19_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P19TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P19_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P19_End : TriggerState {
            internal StateG05P19_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P19End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P20_RoundCheckIn : TriggerState {
            internal StateG05P20_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P20Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P20_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P20_CleanUp : TriggerState {
            internal StateG05P20_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P20_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P20_Check : TriggerState {
            internal StateG05P20_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P20TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P20_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P20_End : TriggerState {
            internal StateG05P20_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P20End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P21_RoundCheckIn : TriggerState {
            internal StateG05P21_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P21Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P21_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P21_CleanUp : TriggerState {
            internal StateG05P21_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P21_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P21_Check : TriggerState {
            internal StateG05P21_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P21TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P21_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P21_End : TriggerState {
            internal StateG05P21_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P21End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P22_RoundCheckIn : TriggerState {
            internal StateG05P22_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P22Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P22_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P22_CleanUp : TriggerState {
            internal StateG05P22_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P22_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P22_Check : TriggerState {
            internal StateG05P22_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P22TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P22_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P22_End : TriggerState {
            internal StateG05P22_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P22End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P23_RoundCheckIn : TriggerState {
            internal StateG05P23_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P23Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P23_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P23_CleanUp : TriggerState {
            internal StateG05P23_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P23_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P23_Check : TriggerState {
            internal StateG05P23_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P23TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P23_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P23_End : TriggerState {
            internal StateG05P23_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P23End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P24_RoundCheckIn : TriggerState {
            internal StateG05P24_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P24Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P24_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P24_CleanUp : TriggerState {
            internal StateG05P24_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P24_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P24_Check : TriggerState {
            internal StateG05P24_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P24TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P24_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P24_End : TriggerState {
            internal StateG05P24_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P24End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P25_RoundCheckIn : TriggerState {
            internal StateG05P25_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P25Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P25_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P25_CleanUp : TriggerState {
            internal StateG05P25_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P25_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P25_Check : TriggerState {
            internal StateG05P25_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P25TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P25_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P25_End : TriggerState {
            internal StateG05P25_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P25End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P26_RoundCheckIn : TriggerState {
            internal StateG05P26_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P26Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P26_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P26_CleanUp : TriggerState {
            internal StateG05P26_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P26_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P26_Check : TriggerState {
            internal StateG05P26_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P26TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P26_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P26_End : TriggerState {
            internal StateG05P26_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P26End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P27_RoundCheckIn : TriggerState {
            internal StateG05P27_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P27Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P27_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P27_CleanUp : TriggerState {
            internal StateG05P27_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P27_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P27_Check : TriggerState {
            internal StateG05P27_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P27TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P27_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P27_End : TriggerState {
            internal StateG05P27_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P27End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P28_RoundCheckIn : TriggerState {
            internal StateG05P28_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P28Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P28_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P28_CleanUp : TriggerState {
            internal StateG05P28_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P28_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P28_Check : TriggerState {
            internal StateG05P28_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P28TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P28_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P28_End : TriggerState {
            internal StateG05P28_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P28End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P29_RoundCheckIn : TriggerState {
            internal StateG05P29_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P29Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P29_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P29_CleanUp : TriggerState {
            internal StateG05P29_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P29_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P29_Check : TriggerState {
            internal StateG05P29_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P29TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P29_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P29_End : TriggerState {
            internal StateG05P29_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P29End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P30_RoundCheckIn : TriggerState {
            internal StateG05P30_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P30Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P30_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P30_CleanUp : TriggerState {
            internal StateG05P30_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P30_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P30_Check : TriggerState {
            internal StateG05P30_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P30TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P30_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P30_End : TriggerState {
            internal StateG05P30_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P30End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P31_RoundCheckIn : TriggerState {
            internal StateG05P31_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P31Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P31_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P31_CleanUp : TriggerState {
            internal StateG05P31_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P31_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P31_Check : TriggerState {
            internal StateG05P31_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P31TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P31_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P31_End : TriggerState {
            internal StateG05P31_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P31End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P32_RoundCheckIn : TriggerState {
            internal StateG05P32_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P32Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P32_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P32_CleanUp : TriggerState {
            internal StateG05P32_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P32_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P32_Check : TriggerState {
            internal StateG05P32_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P32TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P32_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P32_End : TriggerState {
            internal StateG05P32_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P32End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P33_RoundCheckIn : TriggerState {
            internal StateG05P33_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P33Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P33_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P33_CleanUp : TriggerState {
            internal StateG05P33_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P33_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P33_Check : TriggerState {
            internal StateG05P33_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P33TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P33_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P33_End : TriggerState {
            internal StateG05P33_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P33End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P34_RoundCheckIn : TriggerState {
            internal StateG05P34_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P34Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P34_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P34_CleanUp : TriggerState {
            internal StateG05P34_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P34_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P34_Check : TriggerState {
            internal StateG05P34_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P34TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P34_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P34_End : TriggerState {
            internal StateG05P34_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P34End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P35_RoundCheckIn : TriggerState {
            internal StateG05P35_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P35Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P35_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P35_CleanUp : TriggerState {
            internal StateG05P35_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P35_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P35_Check : TriggerState {
            internal StateG05P35_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P35TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P35_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P35_End : TriggerState {
            internal StateG05P35_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P35End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P36_RoundCheckIn : TriggerState {
            internal StateG05P36_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P36Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P36_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P36_CleanUp : TriggerState {
            internal StateG05P36_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P36_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P36_Check : TriggerState {
            internal StateG05P36_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P36TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P36_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P36_End : TriggerState {
            internal StateG05P36_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P36End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P37_RoundCheckIn : TriggerState {
            internal StateG05P37_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P37Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P37_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P37_CleanUp : TriggerState {
            internal StateG05P37_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P37_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P37_Check : TriggerState {
            internal StateG05P37_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P37TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P37_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P37_End : TriggerState {
            internal StateG05P37_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P37End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P38_RoundCheckIn : TriggerState {
            internal StateG05P38_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P38Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P38_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P38_CleanUp : TriggerState {
            internal StateG05P38_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P38_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P38_Check : TriggerState {
            internal StateG05P38_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P38TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P38_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P38_End : TriggerState {
            internal StateG05P38_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P38End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P39_RoundCheckIn : TriggerState {
            internal StateG05P39_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P39Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P39_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P39_CleanUp : TriggerState {
            internal StateG05P39_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P39_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P39_Check : TriggerState {
            internal StateG05P39_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P39TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P39_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P39_End : TriggerState {
            internal StateG05P39_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P39End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P40_RoundCheckIn : TriggerState {
            internal StateG05P40_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P40Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P40_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P40_CleanUp : TriggerState {
            internal StateG05P40_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P40_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P40_Check : TriggerState {
            internal StateG05P40_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P40TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P40_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P40_End : TriggerState {
            internal StateG05P40_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P40End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P41_RoundCheckIn : TriggerState {
            internal StateG05P41_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P41Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P41_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P41_CleanUp : TriggerState {
            internal StateG05P41_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P41_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P41_Check : TriggerState {
            internal StateG05P41_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P41TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P41_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P41_End : TriggerState {
            internal StateG05P41_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P41End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P42_RoundCheckIn : TriggerState {
            internal StateG05P42_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P42Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P42_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P42_CleanUp : TriggerState {
            internal StateG05P42_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P42_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P42_Check : TriggerState {
            internal StateG05P42_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P42TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P42_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P42_End : TriggerState {
            internal StateG05P42_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P42End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P43_RoundCheckIn : TriggerState {
            internal StateG05P43_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P43Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P43_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P43_CleanUp : TriggerState {
            internal StateG05P43_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P43_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P43_Check : TriggerState {
            internal StateG05P43_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P43TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P43_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P43_End : TriggerState {
            internal StateG05P43_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P43End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P44_RoundCheckIn : TriggerState {
            internal StateG05P44_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P44Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P44_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P44_CleanUp : TriggerState {
            internal StateG05P44_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P44_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P44_Check : TriggerState {
            internal StateG05P44_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P44TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P44_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P44_End : TriggerState {
            internal StateG05P44_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P44End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P45_RoundCheckIn : TriggerState {
            internal StateG05P45_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P45Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P45_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P45_CleanUp : TriggerState {
            internal StateG05P45_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P45_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P45_Check : TriggerState {
            internal StateG05P45_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P45TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P45_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P45_End : TriggerState {
            internal StateG05P45_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P45End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P46_RoundCheckIn : TriggerState {
            internal StateG05P46_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P46Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P46_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P46_CleanUp : TriggerState {
            internal StateG05P46_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P46_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P46_Check : TriggerState {
            internal StateG05P46_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P46TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P46_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P46_End : TriggerState {
            internal StateG05P46_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P46End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P47_RoundCheckIn : TriggerState {
            internal StateG05P47_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P47Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P47_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P47_CleanUp : TriggerState {
            internal StateG05P47_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P47_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P47_Check : TriggerState {
            internal StateG05P47_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P47TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P47_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P47_End : TriggerState {
            internal StateG05P47_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P47End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P48_RoundCheckIn : TriggerState {
            internal StateG05P48_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P48Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P48_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P48_CleanUp : TriggerState {
            internal StateG05P48_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P48_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P48_Check : TriggerState {
            internal StateG05P48_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P48TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P48_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P48_End : TriggerState {
            internal StateG05P48_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P48End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P49_RoundCheckIn : TriggerState {
            internal StateG05P49_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P49Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P49_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P49_CleanUp : TriggerState {
            internal StateG05P49_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P49_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P49_Check : TriggerState {
            internal StateG05P49_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P49TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P49_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P49_End : TriggerState {
            internal StateG05P49_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P49End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P50_RoundCheckIn : TriggerState {
            internal StateG05P50_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P50Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG05P50_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG05P50_CleanUp : TriggerState {
            internal StateG05P50_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG05P50_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P50_Check : TriggerState {
            internal StateG05P50_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 500, key: "G05P50TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG05P50_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P50_End : TriggerState {
            internal StateG05P50_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G05P50End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P101_RoundCheckIn : TriggerState {
            internal StateG06P101_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P101Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P101_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P101_CleanUp : TriggerState {
            internal StateG06P101_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P101_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P101_Check : TriggerState {
            internal StateG06P101_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P101TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P101_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P101_End : TriggerState {
            internal StateG06P101_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P101End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P102_RoundCheckIn : TriggerState {
            internal StateG06P102_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P102Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P102_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P102_CleanUp : TriggerState {
            internal StateG06P102_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P102_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P102_Check : TriggerState {
            internal StateG06P102_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P102TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P102_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P102_End : TriggerState {
            internal StateG06P102_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P102End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P103_RoundCheckIn : TriggerState {
            internal StateG06P103_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P103Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P103_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P103_CleanUp : TriggerState {
            internal StateG06P103_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P103_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P103_Check : TriggerState {
            internal StateG06P103_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P103TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P103_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P103_End : TriggerState {
            internal StateG06P103_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P103End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P104_RoundCheckIn : TriggerState {
            internal StateG06P104_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P104Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P104_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P104_CleanUp : TriggerState {
            internal StateG06P104_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P104_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P104_Check : TriggerState {
            internal StateG06P104_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P104TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P104_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P104_End : TriggerState {
            internal StateG06P104_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P104End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P105_RoundCheckIn : TriggerState {
            internal StateG06P105_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P105Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P105_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P105_CleanUp : TriggerState {
            internal StateG06P105_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P105_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P105_Check : TriggerState {
            internal StateG06P105_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P105TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P105_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P105_End : TriggerState {
            internal StateG06P105_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P105End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P106_RoundCheckIn : TriggerState {
            internal StateG06P106_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P106Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P106_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P106_CleanUp : TriggerState {
            internal StateG06P106_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P106_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P106_Check : TriggerState {
            internal StateG06P106_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P106TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P106_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P106_End : TriggerState {
            internal StateG06P106_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P106End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P107_RoundCheckIn : TriggerState {
            internal StateG06P107_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P107Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P107_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P107_CleanUp : TriggerState {
            internal StateG06P107_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P107_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P107_Check : TriggerState {
            internal StateG06P107_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P107TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P107_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P107_End : TriggerState {
            internal StateG06P107_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P107End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P108_RoundCheckIn : TriggerState {
            internal StateG06P108_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P108Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P108_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P108_CleanUp : TriggerState {
            internal StateG06P108_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P108_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P108_Check : TriggerState {
            internal StateG06P108_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P108TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P108_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P108_End : TriggerState {
            internal StateG06P108_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P108End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P109_RoundCheckIn : TriggerState {
            internal StateG06P109_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P109Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P109_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P109_CleanUp : TriggerState {
            internal StateG06P109_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P109_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P109_Check : TriggerState {
            internal StateG06P109_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P109TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P109_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P109_End : TriggerState {
            internal StateG06P109_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P109End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P110_RoundCheckIn : TriggerState {
            internal StateG06P110_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P110Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P110_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P110_CleanUp : TriggerState {
            internal StateG06P110_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P110_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P110_Check : TriggerState {
            internal StateG06P110_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P110TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P110_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P110_End : TriggerState {
            internal StateG06P110_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P110End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P201_RoundCheckIn : TriggerState {
            internal StateG06P201_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P201Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P201_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P201_CleanUp : TriggerState {
            internal StateG06P201_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P201_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P201_Check : TriggerState {
            internal StateG06P201_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P201TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P201_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P201_End : TriggerState {
            internal StateG06P201_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P201End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P202_RoundCheckIn : TriggerState {
            internal StateG06P202_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P202Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P202_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P202_CleanUp : TriggerState {
            internal StateG06P202_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P202_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P202_Check : TriggerState {
            internal StateG06P202_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P202TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P202_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P202_End : TriggerState {
            internal StateG06P202_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P202End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P203_RoundCheckIn : TriggerState {
            internal StateG06P203_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P203Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P203_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P203_CleanUp : TriggerState {
            internal StateG06P203_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P203_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P203_Check : TriggerState {
            internal StateG06P203_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P203TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P203_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P203_End : TriggerState {
            internal StateG06P203_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P203End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P204_RoundCheckIn : TriggerState {
            internal StateG06P204_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P204Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P204_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P204_CleanUp : TriggerState {
            internal StateG06P204_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P204_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P204_Check : TriggerState {
            internal StateG06P204_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P204TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P204_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P204_End : TriggerState {
            internal StateG06P204_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P204End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P205_RoundCheckIn : TriggerState {
            internal StateG06P205_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P205Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P205_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P205_CleanUp : TriggerState {
            internal StateG06P205_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P205_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P205_Check : TriggerState {
            internal StateG06P205_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P205TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P205_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P205_End : TriggerState {
            internal StateG06P205_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P205End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P206_RoundCheckIn : TriggerState {
            internal StateG06P206_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P206Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P206_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P206_CleanUp : TriggerState {
            internal StateG06P206_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P206_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P206_Check : TriggerState {
            internal StateG06P206_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P206TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P206_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P206_End : TriggerState {
            internal StateG06P206_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P206End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P207_RoundCheckIn : TriggerState {
            internal StateG06P207_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P207Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P207_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P207_CleanUp : TriggerState {
            internal StateG06P207_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P207_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P207_Check : TriggerState {
            internal StateG06P207_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P207TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P207_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P207_End : TriggerState {
            internal StateG06P207_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P207End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P208_RoundCheckIn : TriggerState {
            internal StateG06P208_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P208Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P208_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P208_CleanUp : TriggerState {
            internal StateG06P208_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P208_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P208_Check : TriggerState {
            internal StateG06P208_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P208TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P208_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P208_End : TriggerState {
            internal StateG06P208_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P208End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P209_RoundCheckIn : TriggerState {
            internal StateG06P209_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P209Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P209_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P209_CleanUp : TriggerState {
            internal StateG06P209_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P209_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P209_Check : TriggerState {
            internal StateG06P209_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P209TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P209_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P209_End : TriggerState {
            internal StateG06P209_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P209End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P210_RoundCheckIn : TriggerState {
            internal StateG06P210_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P210Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P210_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P210_CleanUp : TriggerState {
            internal StateG06P210_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P210_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P210_Check : TriggerState {
            internal StateG06P210_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P210TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P210_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P210_End : TriggerState {
            internal StateG06P210_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P210End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P211_RoundCheckIn : TriggerState {
            internal StateG06P211_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P211Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P211_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P211_CleanUp : TriggerState {
            internal StateG06P211_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P211_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P211_Check : TriggerState {
            internal StateG06P211_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P211TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P211_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P211_End : TriggerState {
            internal StateG06P211_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P211End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P212_RoundCheckIn : TriggerState {
            internal StateG06P212_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P212Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P212_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P212_CleanUp : TriggerState {
            internal StateG06P212_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P212_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P212_Check : TriggerState {
            internal StateG06P212_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P212TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P212_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P212_End : TriggerState {
            internal StateG06P212_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P212End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P213_RoundCheckIn : TriggerState {
            internal StateG06P213_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P213Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P213_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P213_CleanUp : TriggerState {
            internal StateG06P213_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P213_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P213_Check : TriggerState {
            internal StateG06P213_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P213TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P213_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P213_End : TriggerState {
            internal StateG06P213_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P213End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P214_RoundCheckIn : TriggerState {
            internal StateG06P214_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P214Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P214_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P214_CleanUp : TriggerState {
            internal StateG06P214_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P214_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P214_Check : TriggerState {
            internal StateG06P214_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P214TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P214_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P214_End : TriggerState {
            internal StateG06P214_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P214End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P215_RoundCheckIn : TriggerState {
            internal StateG06P215_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P215Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P215_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P215_CleanUp : TriggerState {
            internal StateG06P215_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P215_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P215_Check : TriggerState {
            internal StateG06P215_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P215TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P215_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P215_End : TriggerState {
            internal StateG06P215_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P215End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P216_RoundCheckIn : TriggerState {
            internal StateG06P216_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P216Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P216_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P216_CleanUp : TriggerState {
            internal StateG06P216_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P216_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P216_Check : TriggerState {
            internal StateG06P216_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P216TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P216_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P216_End : TriggerState {
            internal StateG06P216_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P216End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P217_RoundCheckIn : TriggerState {
            internal StateG06P217_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P217Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P217_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P217_CleanUp : TriggerState {
            internal StateG06P217_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P217_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P217_Check : TriggerState {
            internal StateG06P217_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P217TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P217_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P217_End : TriggerState {
            internal StateG06P217_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P217End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P218_RoundCheckIn : TriggerState {
            internal StateG06P218_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P218Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P218_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P218_CleanUp : TriggerState {
            internal StateG06P218_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P218_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P218_Check : TriggerState {
            internal StateG06P218_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P218TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P218_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P218_End : TriggerState {
            internal StateG06P218_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P218End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P219_RoundCheckIn : TriggerState {
            internal StateG06P219_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P219Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P219_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P219_CleanUp : TriggerState {
            internal StateG06P219_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P219_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P219_Check : TriggerState {
            internal StateG06P219_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P219TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P219_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P219_End : TriggerState {
            internal StateG06P219_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P219End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P220_RoundCheckIn : TriggerState {
            internal StateG06P220_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P220Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P220_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P220_CleanUp : TriggerState {
            internal StateG06P220_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P220_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P220_Check : TriggerState {
            internal StateG06P220_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P220TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P220_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P220_End : TriggerState {
            internal StateG06P220_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P220End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P301_RoundCheckIn : TriggerState {
            internal StateG06P301_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P301Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P301_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P301_CleanUp : TriggerState {
            internal StateG06P301_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P301_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P301_Check : TriggerState {
            internal StateG06P301_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P301TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P301_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P301_End : TriggerState {
            internal StateG06P301_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P301End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P302_RoundCheckIn : TriggerState {
            internal StateG06P302_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P302Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P302_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P302_CleanUp : TriggerState {
            internal StateG06P302_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P302_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P302_Check : TriggerState {
            internal StateG06P302_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P302TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P302_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P302_End : TriggerState {
            internal StateG06P302_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P302End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P303_RoundCheckIn : TriggerState {
            internal StateG06P303_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P303Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P303_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P303_CleanUp : TriggerState {
            internal StateG06P303_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P303_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P303_Check : TriggerState {
            internal StateG06P303_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P303TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P303_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P303_End : TriggerState {
            internal StateG06P303_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P303End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P304_RoundCheckIn : TriggerState {
            internal StateG06P304_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P304Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P304_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P304_CleanUp : TriggerState {
            internal StateG06P304_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P304_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P304_Check : TriggerState {
            internal StateG06P304_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P304TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P304_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P304_End : TriggerState {
            internal StateG06P304_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P304End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P305_RoundCheckIn : TriggerState {
            internal StateG06P305_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P305Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P305_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P305_CleanUp : TriggerState {
            internal StateG06P305_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P305_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P305_Check : TriggerState {
            internal StateG06P305_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P305TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P305_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P305_End : TriggerState {
            internal StateG06P305_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P305End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P306_RoundCheckIn : TriggerState {
            internal StateG06P306_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P306Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P306_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P306_CleanUp : TriggerState {
            internal StateG06P306_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P306_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P306_Check : TriggerState {
            internal StateG06P306_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P306TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P306_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P306_End : TriggerState {
            internal StateG06P306_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P306End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P307_RoundCheckIn : TriggerState {
            internal StateG06P307_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P307Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P307_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P307_CleanUp : TriggerState {
            internal StateG06P307_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P307_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P307_Check : TriggerState {
            internal StateG06P307_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P307TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P307_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P307_End : TriggerState {
            internal StateG06P307_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P307End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P308_RoundCheckIn : TriggerState {
            internal StateG06P308_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P308Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P308_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P308_CleanUp : TriggerState {
            internal StateG06P308_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P308_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P308_Check : TriggerState {
            internal StateG06P308_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P308TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P308_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P308_End : TriggerState {
            internal StateG06P308_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P308End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P309_RoundCheckIn : TriggerState {
            internal StateG06P309_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P309Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P309_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P309_CleanUp : TriggerState {
            internal StateG06P309_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P309_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P309_Check : TriggerState {
            internal StateG06P309_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P309TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P309_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P309_End : TriggerState {
            internal StateG06P309_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P309End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P310_RoundCheckIn : TriggerState {
            internal StateG06P310_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P310Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P310_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P310_CleanUp : TriggerState {
            internal StateG06P310_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P310_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P310_Check : TriggerState {
            internal StateG06P310_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P310TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P310_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P310_End : TriggerState {
            internal StateG06P310_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P310End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P311_RoundCheckIn : TriggerState {
            internal StateG06P311_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P311Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P311_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P311_CleanUp : TriggerState {
            internal StateG06P311_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P311_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P311_Check : TriggerState {
            internal StateG06P311_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P311TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P311_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P311_End : TriggerState {
            internal StateG06P311_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P311End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P312_RoundCheckIn : TriggerState {
            internal StateG06P312_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P312Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P312_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P312_CleanUp : TriggerState {
            internal StateG06P312_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P312_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P312_Check : TriggerState {
            internal StateG06P312_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P312TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P312_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P312_End : TriggerState {
            internal StateG06P312_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P312End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P313_RoundCheckIn : TriggerState {
            internal StateG06P313_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P313Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P313_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P313_CleanUp : TriggerState {
            internal StateG06P313_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P313_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P313_Check : TriggerState {
            internal StateG06P313_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P313TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P313_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P313_End : TriggerState {
            internal StateG06P313_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P313End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P314_RoundCheckIn : TriggerState {
            internal StateG06P314_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P314Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P314_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P314_CleanUp : TriggerState {
            internal StateG06P314_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P314_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P314_Check : TriggerState {
            internal StateG06P314_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P314TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P314_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P314_End : TriggerState {
            internal StateG06P314_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P314End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P315_RoundCheckIn : TriggerState {
            internal StateG06P315_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P315Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P315_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P315_CleanUp : TriggerState {
            internal StateG06P315_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P315_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P315_Check : TriggerState {
            internal StateG06P315_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P315TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P315_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P315_End : TriggerState {
            internal StateG06P315_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P315End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P316_RoundCheckIn : TriggerState {
            internal StateG06P316_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P316Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P316_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P316_CleanUp : TriggerState {
            internal StateG06P316_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P316_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P316_Check : TriggerState {
            internal StateG06P316_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P316TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P316_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P316_End : TriggerState {
            internal StateG06P316_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P316End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P317_RoundCheckIn : TriggerState {
            internal StateG06P317_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P317Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P317_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P317_CleanUp : TriggerState {
            internal StateG06P317_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P317_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P317_Check : TriggerState {
            internal StateG06P317_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P317TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P317_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P317_End : TriggerState {
            internal StateG06P317_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P317End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P318_RoundCheckIn : TriggerState {
            internal StateG06P318_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P318Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P318_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P318_CleanUp : TriggerState {
            internal StateG06P318_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P318_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P318_Check : TriggerState {
            internal StateG06P318_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P318TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P318_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P318_End : TriggerState {
            internal StateG06P318_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P318End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P319_RoundCheckIn : TriggerState {
            internal StateG06P319_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P319Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P319_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P319_CleanUp : TriggerState {
            internal StateG06P319_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P319_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P319_Check : TriggerState {
            internal StateG06P319_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P319TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P319_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P319_End : TriggerState {
            internal StateG06P319_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P319End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P320_RoundCheckIn : TriggerState {
            internal StateG06P320_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P320Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P320_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P320_CleanUp : TriggerState {
            internal StateG06P320_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P320_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P320_Check : TriggerState {
            internal StateG06P320_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P320TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P320_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P320_End : TriggerState {
            internal StateG06P320_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P320End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P401_RoundCheckIn : TriggerState {
            internal StateG06P401_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P401Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P401_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P401_CleanUp : TriggerState {
            internal StateG06P401_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P401_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P401_Check : TriggerState {
            internal StateG06P401_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P401TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P401_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P401_End : TriggerState {
            internal StateG06P401_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P401End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P402_RoundCheckIn : TriggerState {
            internal StateG06P402_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P402Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P402_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P402_CleanUp : TriggerState {
            internal StateG06P402_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P402_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P402_Check : TriggerState {
            internal StateG06P402_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P402TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P402_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P402_End : TriggerState {
            internal StateG06P402_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P402End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P403_RoundCheckIn : TriggerState {
            internal StateG06P403_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P403Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P403_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P403_CleanUp : TriggerState {
            internal StateG06P403_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P403_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P403_Check : TriggerState {
            internal StateG06P403_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P403TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P403_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P403_End : TriggerState {
            internal StateG06P403_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P403End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P404_RoundCheckIn : TriggerState {
            internal StateG06P404_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P404Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P404_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P404_CleanUp : TriggerState {
            internal StateG06P404_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P404_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P404_Check : TriggerState {
            internal StateG06P404_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P404TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P404_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P404_End : TriggerState {
            internal StateG06P404_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P404End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P405_RoundCheckIn : TriggerState {
            internal StateG06P405_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P405Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P405_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P405_CleanUp : TriggerState {
            internal StateG06P405_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P405_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P405_Check : TriggerState {
            internal StateG06P405_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P405TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P405_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P405_End : TriggerState {
            internal StateG06P405_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P405End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P406_RoundCheckIn : TriggerState {
            internal StateG06P406_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P406Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P406_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P406_CleanUp : TriggerState {
            internal StateG06P406_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P406_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P406_Check : TriggerState {
            internal StateG06P406_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P406TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P406_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P406_End : TriggerState {
            internal StateG06P406_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P406End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P407_RoundCheckIn : TriggerState {
            internal StateG06P407_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P407Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P407_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P407_CleanUp : TriggerState {
            internal StateG06P407_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P407_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P407_Check : TriggerState {
            internal StateG06P407_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P407TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P407_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P407_End : TriggerState {
            internal StateG06P407_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P407End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P408_RoundCheckIn : TriggerState {
            internal StateG06P408_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P408Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P408_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P408_CleanUp : TriggerState {
            internal StateG06P408_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P408_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P408_Check : TriggerState {
            internal StateG06P408_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P408TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P408_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P408_End : TriggerState {
            internal StateG06P408_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P408End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P409_RoundCheckIn : TriggerState {
            internal StateG06P409_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P409Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P409_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P409_CleanUp : TriggerState {
            internal StateG06P409_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P409_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P409_Check : TriggerState {
            internal StateG06P409_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P409TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P409_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P409_End : TriggerState {
            internal StateG06P409_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P409End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P410_RoundCheckIn : TriggerState {
            internal StateG06P410_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P410Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG06P410_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG06P410_CleanUp : TriggerState {
            internal StateG06P410_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG06P410_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P410_Check : TriggerState {
            internal StateG06P410_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 600, key: "G06P410TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG06P410_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG06P410_End : TriggerState {
            internal StateG06P410_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G06P410End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P201_RoundCheckIn : TriggerState {
            internal StateG07P201_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P201Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P201_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P201_CleanUp : TriggerState {
            internal StateG07P201_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P201_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P201_Check : TriggerState {
            internal StateG07P201_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P201TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P201_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P201_End : TriggerState {
            internal StateG07P201_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P201End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P202_RoundCheckIn : TriggerState {
            internal StateG07P202_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P202Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P202_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P202_CleanUp : TriggerState {
            internal StateG07P202_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P202_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P202_Check : TriggerState {
            internal StateG07P202_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P202TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P202_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P202_End : TriggerState {
            internal StateG07P202_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P202End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P203_RoundCheckIn : TriggerState {
            internal StateG07P203_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P203Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P203_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P203_CleanUp : TriggerState {
            internal StateG07P203_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P203_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P203_Check : TriggerState {
            internal StateG07P203_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P203TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P203_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P203_End : TriggerState {
            internal StateG07P203_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P203End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P204_RoundCheckIn : TriggerState {
            internal StateG07P204_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P204Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P204_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P204_CleanUp : TriggerState {
            internal StateG07P204_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P204_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P204_Check : TriggerState {
            internal StateG07P204_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P204TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P204_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P204_End : TriggerState {
            internal StateG07P204_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P204End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P205_RoundCheckIn : TriggerState {
            internal StateG07P205_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P205Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P205_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P205_CleanUp : TriggerState {
            internal StateG07P205_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P205_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P205_Check : TriggerState {
            internal StateG07P205_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P205TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P205_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P205_End : TriggerState {
            internal StateG07P205_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P205End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P206_RoundCheckIn : TriggerState {
            internal StateG07P206_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P206Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P206_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P206_CleanUp : TriggerState {
            internal StateG07P206_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P206_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P206_Check : TriggerState {
            internal StateG07P206_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P206TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P206_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P206_End : TriggerState {
            internal StateG07P206_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P206End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P207_RoundCheckIn : TriggerState {
            internal StateG07P207_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P207Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P207_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P207_CleanUp : TriggerState {
            internal StateG07P207_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P207_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P207_Check : TriggerState {
            internal StateG07P207_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P207TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P207_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P207_End : TriggerState {
            internal StateG07P207_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P207End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P208_RoundCheckIn : TriggerState {
            internal StateG07P208_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P208Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P208_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P208_CleanUp : TriggerState {
            internal StateG07P208_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P208_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P208_Check : TriggerState {
            internal StateG07P208_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P208TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P208_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P208_End : TriggerState {
            internal StateG07P208_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P208End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P209_RoundCheckIn : TriggerState {
            internal StateG07P209_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P209Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P209_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P209_CleanUp : TriggerState {
            internal StateG07P209_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P209_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P209_Check : TriggerState {
            internal StateG07P209_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P209TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P209_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P209_End : TriggerState {
            internal StateG07P209_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P209End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P210_RoundCheckIn : TriggerState {
            internal StateG07P210_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P210Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P210_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P210_CleanUp : TriggerState {
            internal StateG07P210_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P210_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P210_Check : TriggerState {
            internal StateG07P210_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P210TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P210_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P210_End : TriggerState {
            internal StateG07P210_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P210End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P301_RoundCheckIn : TriggerState {
            internal StateG07P301_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P301Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P301_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P301_CleanUp : TriggerState {
            internal StateG07P301_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P301_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P301_Check : TriggerState {
            internal StateG07P301_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P301TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P301_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P301_End : TriggerState {
            internal StateG07P301_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P301End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P302_RoundCheckIn : TriggerState {
            internal StateG07P302_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P302Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P302_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P302_CleanUp : TriggerState {
            internal StateG07P302_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P302_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P302_Check : TriggerState {
            internal StateG07P302_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P302TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P302_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P302_End : TriggerState {
            internal StateG07P302_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P302End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P303_RoundCheckIn : TriggerState {
            internal StateG07P303_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P303Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P303_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P303_CleanUp : TriggerState {
            internal StateG07P303_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P303_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P303_Check : TriggerState {
            internal StateG07P303_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P303TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P303_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P303_End : TriggerState {
            internal StateG07P303_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P303End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P304_RoundCheckIn : TriggerState {
            internal StateG07P304_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P304Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P304_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P304_CleanUp : TriggerState {
            internal StateG07P304_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P304_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P304_Check : TriggerState {
            internal StateG07P304_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P304TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P304_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P304_End : TriggerState {
            internal StateG07P304_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P304End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P305_RoundCheckIn : TriggerState {
            internal StateG07P305_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P305Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P305_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P305_CleanUp : TriggerState {
            internal StateG07P305_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P305_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P305_Check : TriggerState {
            internal StateG07P305_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P305TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P305_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P305_End : TriggerState {
            internal StateG07P305_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P305End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P306_RoundCheckIn : TriggerState {
            internal StateG07P306_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P306Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P306_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P306_CleanUp : TriggerState {
            internal StateG07P306_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P306_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P306_Check : TriggerState {
            internal StateG07P306_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P306TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P306_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P306_End : TriggerState {
            internal StateG07P306_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P306End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P307_RoundCheckIn : TriggerState {
            internal StateG07P307_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P307Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P307_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P307_CleanUp : TriggerState {
            internal StateG07P307_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P307_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P307_Check : TriggerState {
            internal StateG07P307_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P307TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P307_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P307_End : TriggerState {
            internal StateG07P307_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P307End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P308_RoundCheckIn : TriggerState {
            internal StateG07P308_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P308Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P308_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P308_CleanUp : TriggerState {
            internal StateG07P308_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P308_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P308_Check : TriggerState {
            internal StateG07P308_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P308TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P308_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P308_End : TriggerState {
            internal StateG07P308_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P308End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P309_RoundCheckIn : TriggerState {
            internal StateG07P309_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P309Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P309_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P309_CleanUp : TriggerState {
            internal StateG07P309_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P309_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P309_Check : TriggerState {
            internal StateG07P309_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P309TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P309_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P309_End : TriggerState {
            internal StateG07P309_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P309End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P310_RoundCheckIn : TriggerState {
            internal StateG07P310_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P310Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P310_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P310_CleanUp : TriggerState {
            internal StateG07P310_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P310_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P310_Check : TriggerState {
            internal StateG07P310_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P310TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P310_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P310_End : TriggerState {
            internal StateG07P310_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P310End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P401_RoundCheckIn : TriggerState {
            internal StateG07P401_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P401Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P401_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P401_CleanUp : TriggerState {
            internal StateG07P401_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P401_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P401_Check : TriggerState {
            internal StateG07P401_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P401TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P401_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P401_End : TriggerState {
            internal StateG07P401_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P401End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P402_RoundCheckIn : TriggerState {
            internal StateG07P402_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P402Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P402_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P402_CleanUp : TriggerState {
            internal StateG07P402_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P402_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P402_Check : TriggerState {
            internal StateG07P402_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P402TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P402_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P402_End : TriggerState {
            internal StateG07P402_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P402End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P403_RoundCheckIn : TriggerState {
            internal StateG07P403_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P403Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P403_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P403_CleanUp : TriggerState {
            internal StateG07P403_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P403_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P403_Check : TriggerState {
            internal StateG07P403_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P403TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P403_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P403_End : TriggerState {
            internal StateG07P403_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P403End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P404_RoundCheckIn : TriggerState {
            internal StateG07P404_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P404Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P404_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P404_CleanUp : TriggerState {
            internal StateG07P404_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P404_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P404_Check : TriggerState {
            internal StateG07P404_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P404TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P404_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P404_End : TriggerState {
            internal StateG07P404_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P404End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P405_RoundCheckIn : TriggerState {
            internal StateG07P405_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P405Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P405_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P405_CleanUp : TriggerState {
            internal StateG07P405_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P405_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P405_Check : TriggerState {
            internal StateG07P405_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P405TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P405_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P405_End : TriggerState {
            internal StateG07P405_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P405End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P406_RoundCheckIn : TriggerState {
            internal StateG07P406_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P406Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P406_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P406_CleanUp : TriggerState {
            internal StateG07P406_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P406_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P406_Check : TriggerState {
            internal StateG07P406_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P406TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P406_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P406_End : TriggerState {
            internal StateG07P406_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P406End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P407_RoundCheckIn : TriggerState {
            internal StateG07P407_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P407Set", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11111")) {
                    return new StateG07P407_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "11111");
            }
        }

        private class StateG07P407_CleanUp : TriggerState {
            internal StateG07P407_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(triggerId: 901, enabled: true);
                context.SetCinematicUI(type: 3, script: "$61000008_ME__01_MASSIVEMAIN__32$");
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "DJDD_Dancing_01");
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, visible: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateG07P407_Check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P407_Check : TriggerState {
            internal StateG07P407_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 700, key: "G07P407TimeLimit", value: 1);
                context.PlaySystemSoundInBox(boxIds: new []{6901, 6902, 6903, 6904, 6905, 6906}, sound: "DDStop_Stage_Fail_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateG07P407_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG07P407_End : TriggerState {
            internal StateG07P407_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P407End") == 1) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoundCheckOut : TriggerState {
            internal StateRoundCheckOut(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "BannerCheckIn", value: 1);
                context.SetMesh(triggerIds: new []{8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCheckNextRound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckNextRound : TriggerState {
            internal StateCheckNextRound(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Round") == 1) {
                    return new StateR01EndDelay(context);
                }

                if (context.GetUserValue(key: "Round") == 2) {
                    return new StateR02EndDelay(context);
                }

                if (context.GetUserValue(key: "Round") == 3) {
                    return new StateR03EndDelay(context);
                }

                if (context.GetUserValue(key: "Round") == 4) {
                    return new StateR04EndDelay(context);
                }

                if (context.GetUserValue(key: "Round") == 6) {
                    return new StateR04GambleEndDelay(context);
                }

                if (context.GetUserValue(key: "Round") == 5) {
                    return new StateR05EndDelay(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(key: "Round", value: 0);
            }
        }
    }
}
