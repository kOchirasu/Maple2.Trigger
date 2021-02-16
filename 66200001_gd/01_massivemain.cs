using Maple2.Trigger.Enum;

namespace Maple2.Trigger._66200001_gd {
    public static class _01_massivemain {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateFieldGame(type: FieldGame.GuildVsGame);
                context.UserTagSymbol(symbol1: "guild_game_blue", symbol2: "guild_game_red");
                context.SetSound(arg1: 10000, arg2: false);
                context.SetSound(arg1: 20000, arg2: false);
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 40000, arg2: false);
                context.SetEffect(arg1: new[] {8000, 8002, 8003, 8004, 8005}, arg2: false);
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {511, 512, 513, 514, 521, 522, 523, 524, 531, 532, 533, 534, 541, 542, 543, 544}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {110, 111, 112, 113, 114, 115, 120, 121, 122, 123, 124, 125, 130, 131, 132, 133, 134, 135, 140, 141, 142, 143, 144, 145, 210, 211, 212, 213, 214, 215, 220, 221, 222, 223, 224, 225, 230, 231, 232, 233, 234, 235, 240, 241, 242, 243, 244, 245, 310, 311, 312, 313, 314, 315, 320, 321, 322, 323, 324, 325, 330, 331, 332, 333, 334, 335, 340, 341, 342, 343, 344, 345, 410, 411, 412, 413, 414, 415, 420, 421, 422, 423, 424, 425, 430, 431, 432, 433, 434, 435, 440, 441, 442, 443, 444, 445}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[]
                        {8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001180}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10001181, 10001182, 10001183}, arg2: 2);
                context.SetUserValue(key: "Round", value: 0);
                context.SetUserValue(key: "DanceTime", value: 0);
                context.SetUserValue(key: "WinnerTeam", value: 0);
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 7, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 8, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 9, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateEntryDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEntryDelay : TriggerState {
            internal StateEntryDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMiniGameAreaForHack(boxId: 9001);
                context.SetUserValue(triggerId: 9, key: "MoveToTeamPortal", value: 1);
                context.SetUserValue(triggerId: 10, key: "BannerCheckIn", value: 1);
                context.SetUserValue(triggerId: 11, key: "BannerCheckIn", value: 1);
                context.SetTimer(id: "1", arg2: 90);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateIsGameStartOrNot(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIsGameStartOrNot : TriggerState {
            internal StateIsGameStartOrNot(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9000, userTagId: 1) >= 10) {
                    return new StateIsGameStart_True01(context);
                }

                if (context.GetUserCount(boxId: 9000, userTagId: 2) >= 10) {
                    return new StateIsGameStart_Ture02(context);
                }

                if (context.GetUserCount(boxId: 9000, userTagId: 1) < 10) {
                    return new StateIsGameStart_False(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIsGameStart_True01 : TriggerState {
            internal StateIsGameStart_True01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9000, userTagId: 2) >= 10) {
                    return new StateMoveToTeamCamp(context);
                }

                if (context.GetUserCount(boxId: 9000, userTagId: 2) < 10) {
                    return new StateDefaultbyWin_BlueTeam(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIsGameStart_Ture02 : TriggerState {
            internal StateIsGameStart_Ture02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9000, userTagId: 1) >= 10) {
                    return new StateMoveToTeamCamp(context);
                }

                if (context.GetUserCount(boxId: 9000, userTagId: 1) < 10) {
                    return new StateDefaultbyWin_RedTeam(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIsGameStart_False : TriggerState {
            internal StateIsGameStart_False(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9000, userTagId: 2) < 10) {
                    return new StateGameCancel(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToTeamCamp : TriggerState {
            internal StateMoveToTeamCamp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9, key: "MoveToTeamPortal", value: 2);
                context.MoveToPortal(userTagId: 1, portalId: 21);
                context.MoveToPortal(userTagId: 2, portalId: 22);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateGameGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuide01 : TriggerState {
            internal StateGameGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "0,0");
                context.SetUserValue(triggerId: 10, key: "BannerCheckIn", value: 0);
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 10000, arg2: true);
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__0$", arg3: 5000,
                    arg4: "0");
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "guildminigame_start");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGameGuide02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuide02 : TriggerState {
            internal StateGameGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__1$", arg3: 5000,
                    arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGameGuide03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuide03 : TriggerState {
            internal StateGameGuide03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__2$", arg3: 5000,
                    arg4: "0");
            }

            public override TriggerState Execute() {
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
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__3$", arg3: 5000,
                    arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateR01Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01Ready : TriggerState {
            internal StateR01Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Round", value: 1);
                context.SetEventUI(arg1: 0, script: "1,5");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateR01PlayerRandomPick01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01PlayerRandomPick01 : TriggerState {
            internal StateR01PlayerRandomPick01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__67$", arg3: 3000,
                    arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePlayerRandomPick02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayerRandomPick02 : TriggerState {
            internal StatePlayerRandomPick02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "BattleField_Event");
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__5$", arg3: 5000,
                    arg4: "0");
                context.SetEffect(arg1: new[] {8002, 8003, 8004, 8005}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePlayerRandomPickStartCount(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayerRandomPickStartCount : TriggerState {
            internal StatePlayerRandomPickStartCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$66200001_GD__01_MASSIVEMAIN__6$", stage: 0, count: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePlayerRandomPickMove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayerRandomPickMove : TriggerState {
            internal StatePlayerRandomPickMove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8002, 8003, 8004, 8005}, arg2: false);
                context.MoveRandomUser(arg1: 66200001, arg2: 1, arg3: 9031, arg4: 30);
                context.MoveRandomUser(arg1: 66200001, arg2: 2, arg3: 9032, arg4: 30);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "GuildBattle_MemberPick");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCheckTheNumberOfPlayer(context);
                }

                if (!context.UserDetected(arg1: new[] {9000})) {
                    return new StateLeaveAll(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckTheNumberOfPlayer : TriggerState {
            internal StateCheckTheNumberOfPlayer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 11, key: "BannerCheckIn", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "BattleField_Event");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Round") == 1) {
                    return new StateR01Start(context);
                }

                if (context.GetUserValue(key: "Round") == 2) {
                    return new StateR02Start(context);
                }

                if (context.GetUserValue(key: "Round") == 3) {
                    return new StateR03Start(context);
                }

                if (context.GetUserValue(key: "Round") == 4) {
                    return new StateR04Start(context);
                }

                if (context.GetUserValue(key: "Round") == 5) {
                    return new StateR05Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01Start : TriggerState {
            internal StateR01Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__7$", arg3: 3000,
                    arg4: "0");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancetime_01");
                context.SetSound(arg1: 10000, arg2: false);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 20000, arg2: true);
                context.SetUserValue(key: "DanceTime", value: 1);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    return new StateDancePattern01(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new StateDancePattern02(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new StateDancePattern03(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new StateDancePattern0401(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new StateDancePattern0501(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateDancePattern0601(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateDancePattern0701(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10001180}, arg2: 2);
            }
        }

        private class StateDancePattern01 : TriggerState {
            internal StateDancePattern01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "DDStop_Stage_Ready_01");
                context.SetInteractObject(arg1: new[] {10001181}, arg2: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateCheckDanceRound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern02 : TriggerState {
            internal StateDancePattern02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "DDStop_Stage_Ready_01");
                context.SetInteractObject(arg1: new[] {10001182}, arg2: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateCheckDanceRound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern03 : TriggerState {
            internal StateDancePattern03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "DDStop_Stage_Ready_01");
                context.SetInteractObject(arg1: new[] {10001183}, arg2: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 19000)) {
                    return new StateCheckDanceRound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0401 : TriggerState {
            internal StateDancePattern0401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "DDStop_Stage_Ready_01");
                context.SetInteractObject(arg1: new[] {10001180}, arg2: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 41);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateDancePattern0402(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0402 : TriggerState {
            internal StateDancePattern0402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__8$", arg3: 1000);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancerandom_01");
                context.SetSound(arg1: 20000, arg2: false);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
                context.SetInteractObject(arg1: new[] {10001180}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDancePattern0403(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0403 : TriggerState {
            internal StateDancePattern0403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__9$", arg3: 1500,
                    arg4: "0");
                context.SetInteractObject(arg1: new[] {10001180}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10001181}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateDancePattern0404(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0404 : TriggerState {
            internal StateDancePattern0404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 20000, arg2: true);
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "DDStop_Stage_Ready_01");
                context.SetInteractObject(arg1: new[] {10001181}, arg2: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 42);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateCheckDanceRound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0501 : TriggerState {
            internal StateDancePattern0501(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "DDStop_Stage_Ready_01");
                context.SetInteractObject(arg1: new[] {10001181}, arg2: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 51);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateDancePattern0502(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0502 : TriggerState {
            internal StateDancePattern0502(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__10$", arg3: 1000);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancerandom_02");
                context.SetSound(arg1: 20000, arg2: false);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
                context.SetInteractObject(arg1: new[] {10001181}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDancePattern0503(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0503 : TriggerState {
            internal StateDancePattern0503(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__11$", arg3: 1500,
                    arg4: "0");
                context.SetInteractObject(arg1: new[] {10001181}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10001180}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateDancePattern0504(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0504 : TriggerState {
            internal StateDancePattern0504(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 20000, arg2: true);
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "DDStop_Stage_Ready_01");
                context.SetInteractObject(arg1: new[] {10001180}, arg2: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 52);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateCheckDanceRound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0601 : TriggerState {
            internal StateDancePattern0601(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "DDStop_Stage_Ready_01");
                context.SetInteractObject(arg1: new[] {10001182}, arg2: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 61);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateDancePattern0602(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0602 : TriggerState {
            internal StateDancePattern0602(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__12$", arg3: 1000);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancerandom_03");
                context.SetSound(arg1: 20000, arg2: false);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
                context.SetInteractObject(arg1: new[] {10001182}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDancePattern0603(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0603 : TriggerState {
            internal StateDancePattern0603(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__13$", arg3: 1500,
                    arg4: "0");
                context.SetInteractObject(arg1: new[] {10001182}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10001180}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateDancePattern0604(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0604 : TriggerState {
            internal StateDancePattern0604(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 20000, arg2: true);
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "DDStop_Stage_Ready_01");
                context.SetInteractObject(arg1: new[] {10001180}, arg2: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 62);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateCheckDanceRound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0701 : TriggerState {
            internal StateDancePattern0701(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "DDStop_Stage_Ready_01");
                context.SetInteractObject(arg1: new[] {10001180}, arg2: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 71);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateDancePattern0702(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0702 : TriggerState {
            internal StateDancePattern0702(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__14$", arg3: 1000);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancerandom_04");
                context.SetSound(arg1: 20000, arg2: false);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
                context.SetInteractObject(arg1: new[] {10001180}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDancePattern0703(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0703 : TriggerState {
            internal StateDancePattern0703(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__15$", arg3: 1500,
                    arg4: "0");
                context.SetInteractObject(arg1: new[] {10001180}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10001182}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateDancePattern0704(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDancePattern0704 : TriggerState {
            internal StateDancePattern0704(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 20000, arg2: true);
                context.PlaySystemSoundInBox(arg1: new[] {9001}, arg2: "DDStop_Stage_Ready_01");
                context.SetInteractObject(arg1: new[] {10001182}, arg2: 1);
                context.SetUserValue(triggerId: 6, key: "DanceGuide", value: 72);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateCheckDanceRound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckDanceRound : TriggerState {
            internal StateCheckDanceRound(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "DanceTime") == 1) {
                    return new StateR01_GameStartDelay(context);
                }

                if (context.GetUserValue(key: "DanceTime") == 2) {
                    return new StateR02_GameStartDelay(context);
                }

                if (context.GetUserValue(key: "DanceTime") == 3) {
                    return new StateR03_GameStartDelay(context);
                }

                if (context.GetUserValue(key: "DanceTime") == 4) {
                    return new StateR04_GameStartDelay(context);
                }

                if (context.GetUserValue(key: "DanceTime") == 5) {
                    return new StateR05_GameStartDelay(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(key: "DanceTime", value: 0);
            }
        }

        private class StateR01_GameStartDelay : TriggerState {
            internal StateR01_GameStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 20000, arg2: false);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 40000, arg2: true);
                context.SetInteractObject(arg1: new[] {10001180, 10001181, 10001182, 10001183}, arg2: 2);
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__16$", arg3: 4000);
            }

            public override TriggerState Execute() {
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
                context.SetTimer(id: "11111", arg2: 20, arg3: true, arg4: true, arg5: -40);
                context.SetUserValue(triggerId: 8, key: "CheerUpTimer", value: 1);
                context.SetUserValue(triggerId: 7, key: "GameGuide", value: 1);
            }

            public override TriggerState Execute() {
                return new StateR01G00Check(context);
            }

            public override void OnExit() { }
        }

        private class StateR01G00Check : TriggerState {
            internal StateR01G00Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9001) > 50) {
                    return new StateG05P00_Random(context);
                }

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

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 80f)) {
                    return new StateG05P00_Random(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateG04P00_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03orG04orG05 : TriggerState {
            internal StateG03orG04orG05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    return new StateG03P00_Random(context);
                }

                if (context.RandomCondition(arg1: 60f)) {
                    return new StateG04P00_Random(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new StateG05P00_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02orG03orG04 : TriggerState {
            internal StateG02orG03orG04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    return new StateG02P00_Random(context);
                }

                if (context.RandomCondition(arg1: 60f)) {
                    return new StateG03P00_Random(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new StateG04P00_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02orG03 : TriggerState {
            internal StateG02orG03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 60f)) {
                    return new StateG02P00_Random(context);
                }

                if (context.RandomCondition(arg1: 40f)) {
                    return new StateG03P00_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01orG02 : TriggerState {
            internal StateG01orG02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 70f)) {
                    return new StateG01P00_Random(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new StateG02P00_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG05P00_Random : TriggerState {
            internal StateG05P00_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P01_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P02_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P03_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P04_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P05_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P06_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P07_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P08_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P09_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P10_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P11_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P12_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P13_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P14_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P15_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P16_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P17_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P18_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P19_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P20_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P21_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P22_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P23_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P24_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P25_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P26_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P27_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P28_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P29_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P30_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P31_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P32_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P33_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P34_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P35_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P36_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P37_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P38_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P39_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P40_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P41_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P42_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P43_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P44_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P45_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P46_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P47_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P48_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P49_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateG05P50_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG04P00_Random : TriggerState {
            internal StateG04P00_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P01_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P02_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P03_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P04_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P05_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P06_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P07_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P08_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P09_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P10_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P11_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P12_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P13_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P14_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P15_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P16_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P17_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P18_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P19_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P20_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P21_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P22_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P23_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P24_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P25_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P26_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P27_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P28_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P29_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P30_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P31_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P32_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P33_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P34_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P35_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P36_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P37_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P38_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P39_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG04P40_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG03P00_Random : TriggerState {
            internal StateG03P00_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P01_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P02_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P03_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P04_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P05_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P06_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P07_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P08_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P09_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P10_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P11_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P12_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P13_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P14_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P15_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P16_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P17_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P18_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P19_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P20_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P21_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P22_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P23_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P24_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P25_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P26_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P27_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P28_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P29_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG03P30_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG02P00_Random : TriggerState {
            internal StateG02P00_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P01_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P02_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P03_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P04_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P05_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P06_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P07_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P08_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P09_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P10_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P11_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P12_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P13_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P14_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P15_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P16_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P17_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P18_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P19_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P20_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P21_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P22_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P23_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P24_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P25_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P26_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P27_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P28_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P29_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG02P30_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P00_Random : TriggerState {
            internal StateG01P00_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P01_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P02_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P03_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P04_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P05_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P06_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P07_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P08_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P09_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P10_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P11_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P12_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P13_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P14_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P15_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P16_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P17_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P18_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P19_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P20_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P21_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P22_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P23_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P24_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P25_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P26_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P27_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P28_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P29_RoundCheckIn(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateG01P30_RoundCheckIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01EndDelay : TriggerState {
            internal StateR01EndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 4, key: "RoundScoreRecord", value: 1);
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: true, arg3: 400, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 901, arg2: false);
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
                context.SetMesh(
                    arg1: new[]
                        {8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914},
                    arg2: false, arg3: 400, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State01RoundResultNotice(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State01RoundResultNotice : TriggerState {
            internal State01RoundResultNotice(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GuildVsGameScoredTeam(teamId: 1)) {
                    return new State01RoundResult_BlueTeamWin(context);
                }

                if (context.GuildVsGameScoredTeam(teamId: 2)) {
                    return new State01RoundResult_RedTeamWin(context);
                }

                if (context.GuildVsGameScoredTeam(teamId: 0)) {
                    return new State01RoundResult_Draw(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State01RoundResult_BlueTeamWin : TriggerState {
            internal State01RoundResult_BlueTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__17$", duration: 4000,
                    userTagId: 1);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__18$", duration: 4000,
                    userTagId: 2);
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_YouWin_01");
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_YouLose_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateR01RoundScoreRecord(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State01RoundResult_RedTeamWin : TriggerState {
            internal State01RoundResult_RedTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__19$", duration: 4000,
                    userTagId: 2);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__20$", duration: 4000,
                    userTagId: 1);
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_YouWin_01");
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_YouLose_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateR01RoundScoreRecord(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State01RoundResult_Draw : TriggerState {
            internal State01RoundResult_Draw(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__21$", duration: 4000,
                    userTagId: 1);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__22$", duration: 4000,
                    userTagId: 2);
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_Draw_01");
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_Draw_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateR01RoundScoreRecord(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR01RoundScoreRecord : TriggerState {
            internal StateR01RoundScoreRecord(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "WinnerTeam") == 0) {
                    return new StateEveryPlayerVacuumGuide(context);
                }

                if (context.GetUserValue(key: "WinnerTeam") == 1) {
                    return new StateBlueTeamWinAlreadyNotice(context);
                }

                if (context.GetUserValue(key: "WinnerTeam") == 2) {
                    return new StateRedTeamWinAlreadyNotice(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveryPlayerVacuumGuide : TriggerState {
            internal StateEveryPlayerVacuumGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__23$", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEveryPlayerVacuumExecute(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveryPlayerVacuumExecute : TriggerState {
            internal StateEveryPlayerVacuumExecute(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveToPortal(boxId: 9001, userTagId: 1, portalId: 21);
                context.MoveToPortal(boxId: 9001, userTagId: 2, portalId: 22);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Round") == 1) {
                    return new StateR02Ready(context);
                }

                if (context.GetUserValue(key: "Round") == 2) {
                    return new StateR03Ready(context);
                }

                if (context.GetUserValue(key: "Round") == 3) {
                    return new StateR04Ready(context);
                }

                if (context.GetUserValue(key: "Round") == 4) {
                    return new StateR05Ready(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 11, key: "BannerCheckIn", value: 1);
            }
        }

        private class StateR02Ready : TriggerState {
            internal StateR02Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Round", value: 2);
                context.SetEventUI(arg1: 0, script: "2,5");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateR02PlayerRandomPick01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02PlayerRandomPick01 : TriggerState {
            internal StateR02PlayerRandomPick01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__4$", arg3: 3000,
                    arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePlayerRandomPick02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02Start : TriggerState {
            internal StateR02Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__24$", arg3: 3000,
                    arg4: "0");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancetime_02");
                context.SetSound(arg1: 40000, arg2: false);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 20000, arg2: true);
                context.SetUserValue(key: "DanceTime", value: 2);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    return new StateDancePattern01(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new StateDancePattern02(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new StateDancePattern03(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new StateDancePattern0401(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new StateDancePattern0501(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateDancePattern0601(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateDancePattern0701(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02_GameStartDelay : TriggerState {
            internal StateR02_GameStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 20000, arg2: false);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 40000, arg2: true);
                context.SetInteractObject(arg1: new[] {10001180, 10001181, 10001182, 10001183}, arg2: 2);
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__25$", arg3: 4000);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Round_02");
            }

            public override TriggerState Execute() {
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
                context.SetTimer(id: "11111", arg2: 20, arg3: true, arg4: true, arg5: -40);
                context.SetUserValue(triggerId: 8, key: "CheerUpTimer", value: 1);
                context.SetUserValue(triggerId: 7, key: "GameGuide", value: 1);
            }

            public override TriggerState Execute() {
                return new StateR02G00Check(context);
            }

            public override void OnExit() { }
        }

        private class StateR02G00Check : TriggerState {
            internal StateR02G00Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9001) > 50) {
                    return new StateG05P00_Random(context);
                }

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
                context.SetUserValue(triggerId: 7110, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 4, key: "RoundScoreRecord", value: 2);
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: true, arg3: 400, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 901, arg2: false);
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
                context.SetMesh(
                    arg1: new[]
                        {8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914},
                    arg2: false, arg3: 400, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State02RoundResultNotice(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State02RoundResultNotice : TriggerState {
            internal State02RoundResultNotice(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GuildVsGameScoredTeam(teamId: 1)) {
                    return new State02RoundResult_BlueTeamWin(context);
                }

                if (context.GuildVsGameScoredTeam(teamId: 2)) {
                    return new State02RoundResult_RedTeamWin(context);
                }

                if (context.GuildVsGameScoredTeam(teamId: 0)) {
                    return new State02RoundResult_Draw(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State02RoundResult_BlueTeamWin : TriggerState {
            internal State02RoundResult_BlueTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__26$", duration: 4000,
                    userTagId: 1);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__27$", duration: 4000,
                    userTagId: 2);
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_YouWin_01");
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_YouLose_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateR02RoundScoreRecord(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State02RoundResult_RedTeamWin : TriggerState {
            internal State02RoundResult_RedTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__28$", duration: 4000,
                    userTagId: 2);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__29$", duration: 4000,
                    userTagId: 1);
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_YouWin_01");
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_YouLose_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateR02RoundScoreRecord(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State02RoundResult_Draw : TriggerState {
            internal State02RoundResult_Draw(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__30$", duration: 4000,
                    userTagId: 1);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__31$", duration: 4000,
                    userTagId: 2);
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_Draw_01");
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_Draw_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateR02RoundScoreRecord(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR02RoundScoreRecord : TriggerState {
            internal StateR02RoundScoreRecord(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "WinnerTeam") == 0) {
                    return new StateEveryPlayerVacuumGuide(context);
                }

                if (context.GetUserValue(key: "WinnerTeam") == 1) {
                    return new StateBlueTeamWinAlreadyNotice(context);
                }

                if (context.GetUserValue(key: "WinnerTeam") == 2) {
                    return new StateRedTeamWinAlreadyNotice(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03Ready : TriggerState {
            internal StateR03Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Round", value: 3);
                context.SetEventUI(arg1: 0, script: "3,5");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateR02PlayerRandomPick01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03Start : TriggerState {
            internal StateR03Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__32$", arg3: 3000,
                    arg4: "0");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancetime_03");
                context.SetSound(arg1: 40000, arg2: false);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 20000, arg2: true);
                context.SetUserValue(key: "DanceTime", value: 3);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    return new StateDancePattern01(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new StateDancePattern02(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new StateDancePattern03(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new StateDancePattern0401(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new StateDancePattern0501(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateDancePattern0601(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new StateDancePattern0701(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03_GameStartDelay : TriggerState {
            internal StateR03_GameStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 20000, arg2: false);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 40000, arg2: true);
                context.SetInteractObject(arg1: new[] {10001180, 10001181, 10001182, 10001183}, arg2: 2);
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__33$", arg3: 4000);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Round_03");
            }

            public override TriggerState Execute() {
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
                context.SetTimer(id: "11111", arg2: 20, arg3: true, arg4: true, arg5: -40);
                context.SetUserValue(triggerId: 8, key: "CheerUpTimer", value: 1);
                context.SetUserValue(triggerId: 7, key: "GameGuide", value: 1);
            }

            public override TriggerState Execute() {
                return new StateR03G00Check(context);
            }

            public override void OnExit() { }
        }

        private class StateR03G00Check : TriggerState {
            internal StateR03G00Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9001) > 50) {
                    return new StateG05P00_Random(context);
                }

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
                context.SetUserValue(triggerId: 7110, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 4, key: "RoundScoreRecord", value: 3);
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: true, arg3: 400, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 901, arg2: false);
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
                context.SetMesh(
                    arg1: new[]
                        {8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914},
                    arg2: false, arg3: 400, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State03RoundResultNotice(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State03RoundResultNotice : TriggerState {
            internal State03RoundResultNotice(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GuildVsGameScoredTeam(teamId: 1)) {
                    return new State03RoundResult_BlueTeamWin(context);
                }

                if (context.GuildVsGameScoredTeam(teamId: 2)) {
                    return new State03RoundResult_RedTeamWin(context);
                }

                if (context.GuildVsGameScoredTeam(teamId: 0)) {
                    return new State03RoundResult_Draw(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State03RoundResult_BlueTeamWin : TriggerState {
            internal State03RoundResult_BlueTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__34$", duration: 4000,
                    userTagId: 1);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__35$", duration: 4000,
                    userTagId: 2);
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_YouWin_01");
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_YouLose_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateR03RoundScoreRecord(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State03RoundResult_RedTeamWin : TriggerState {
            internal State03RoundResult_RedTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__36$", duration: 4000,
                    userTagId: 2);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__37$", duration: 4000,
                    userTagId: 1);
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_YouWin_01");
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_YouLose_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateR03RoundScoreRecord(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State03RoundResult_Draw : TriggerState {
            internal State03RoundResult_Draw(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__38$", duration: 4000,
                    userTagId: 1);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__39$", duration: 4000,
                    userTagId: 2);
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_Draw_01");
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_Draw_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateR03RoundScoreRecord(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR03RoundScoreRecord : TriggerState {
            internal StateR03RoundScoreRecord(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "WinnerTeam") == 0) {
                    return new StateEveryPlayerVacuumGuide(context);
                }

                if (context.GetUserValue(key: "WinnerTeam") == 1) {
                    return new StateBlueTeamWinAlreadyNotice(context);
                }

                if (context.GetUserValue(key: "WinnerTeam") == 2) {
                    return new StateRedTeamWinAlreadyNotice(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04Ready : TriggerState {
            internal StateR04Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Round", value: 4);
                context.SetEventUI(arg1: 0, script: "4,5");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateR02PlayerRandomPick01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04Start : TriggerState {
            internal StateR04Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__40$", arg3: 3000,
                    arg4: "0");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancetime_04");
                context.SetSound(arg1: 40000, arg2: false);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 20000, arg2: true);
                context.SetUserValue(key: "DanceTime", value: 4);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 2f)) {
                    return new StateDancePattern01(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new StateDancePattern02(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateDancePattern03(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateDancePattern0401(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateDancePattern0501(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateDancePattern0601(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateDancePattern0701(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04_GameStartDelay : TriggerState {
            internal StateR04_GameStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 20000, arg2: false);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateR04_GameStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04_GameStart : TriggerState {
            internal StateR04_GameStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 40000, arg2: true);
                context.SetInteractObject(arg1: new[] {10001180, 10001181, 10001182, 10001183}, arg2: 2);
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__41$", arg3: 4000);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Round_04");
            }

            public override TriggerState Execute() {
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
                context.SetTimer(id: "11111", arg2: 20, arg3: true, arg4: true, arg5: -40);
                context.SetUserValue(triggerId: 8, key: "CheerUpTimer", value: 1);
                context.SetUserValue(triggerId: 7, key: "GameGuide", value: 1);
            }

            public override TriggerState Execute() {
                return new StateR04G00Check(context);
            }

            public override void OnExit() { }
        }

        private class StateR04G00Check : TriggerState {
            internal StateR04G00Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9001) > 50) {
                    return new StateG05P00_Random(context);
                }

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

        private class StateR04EndDelay : TriggerState {
            internal StateR04EndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 4, key: "RoundScoreRecord", value: 4);
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: true, arg3: 400, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 901, arg2: false);
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
                context.SetMesh(
                    arg1: new[]
                        {8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914},
                    arg2: false, arg3: 400, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State04RoundResultNotice(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State04RoundResultNotice : TriggerState {
            internal State04RoundResultNotice(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GuildVsGameScoredTeam(teamId: 1)) {
                    return new State04RoundResult_BlueTeamWin(context);
                }

                if (context.GuildVsGameScoredTeam(teamId: 2)) {
                    return new State04RoundResult_RedTeamWin(context);
                }

                if (context.GuildVsGameScoredTeam(teamId: 0)) {
                    return new State04RoundResult_Draw(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State04RoundResult_BlueTeamWin : TriggerState {
            internal State04RoundResult_BlueTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__42$", duration: 4000,
                    userTagId: 1);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__43$", duration: 4000,
                    userTagId: 2);
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_YouWin_01");
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_YouLose_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateR04RoundScoreRecord(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State04RoundResult_RedTeamWin : TriggerState {
            internal State04RoundResult_RedTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__44$", duration: 4000,
                    userTagId: 2);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__45$", duration: 4000,
                    userTagId: 1);
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_YouWin_01");
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_YouLose_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateR04RoundScoreRecord(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State04RoundResult_Draw : TriggerState {
            internal State04RoundResult_Draw(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__46$", duration: 4000,
                    userTagId: 1);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__47$", duration: 4000,
                    userTagId: 2);
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_Draw_01");
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_Draw_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateR04RoundScoreRecord(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR04RoundScoreRecord : TriggerState {
            internal StateR04RoundScoreRecord(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "WinnerTeam") == 0) {
                    return new StateEveryPlayerVacuumGuide(context);
                }

                if (context.GetUserValue(key: "WinnerTeam") == 1) {
                    return new StateBlueTeamWinAlreadyNotice(context);
                }

                if (context.GetUserValue(key: "WinnerTeam") == 2) {
                    return new StateRedTeamWinAlreadyNotice(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05Ready : TriggerState {
            internal StateR05Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Round", value: 5);
                context.SetEventUI(arg1: 0, script: "5,5");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateR05PlayerRandomPick01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05PlayerRandomPick01 : TriggerState {
            internal StateR05PlayerRandomPick01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__68$", arg3: 3000,
                    arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePlayerRandomPick02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05Start : TriggerState {
            internal StateR05Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__48$", arg3: 3000,
                    arg4: "0");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancetime_05");
                context.SetSound(arg1: 40000, arg2: false);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 20000, arg2: true);
                context.SetUserValue(key: "DanceTime", value: 5);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 2f)) {
                    return new StateDancePattern01(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new StateDancePattern02(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateDancePattern03(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateDancePattern0401(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateDancePattern0501(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateDancePattern0601(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateDancePattern0701(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateR05_GameStartDelay : TriggerState {
            internal StateR05_GameStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 20000, arg2: false);
                context.SetSound(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetSound(arg1: 30000, arg2: false);
                context.SetSound(arg1: 40000, arg2: true);
                context.SetInteractObject(arg1: new[] {10001180, 10001181, 10001182, 10001183}, arg2: 2);
                context.SetEventUI(arg1: 1, script: "$66200001_GD__01_MASSIVEMAIN__49$", arg3: 4000);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Round_05");
            }

            public override TriggerState Execute() {
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
                context.SetTimer(id: "11111", arg2: 20, arg3: true, arg4: true, arg5: -40);
                context.SetUserValue(triggerId: 8, key: "CheerUpTimer", value: 1);
                context.SetUserValue(triggerId: 7, key: "GameGuide", value: 1);
            }

            public override TriggerState Execute() {
                return new StateR05G05Check(context);
            }

            public override void OnExit() { }
        }

        private class StateR05G05Check : TriggerState {
            internal StateR05G05Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9001) > 50) {
                    return new StateG05P00_Random(context);
                }

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
                context.SetUserValue(triggerId: 7110, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorEnd", value: 1);
                context.SetUserValue(triggerId: 4, key: "RoundScoreRecord", value: 5);
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: true, arg3: 400, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 901, arg2: false);
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
                context.SetMesh(
                    arg1: new[]
                        {8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914},
                    arg2: false, arg3: 400, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State05RoundResultNotice(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State05RoundResultNotice : TriggerState {
            internal State05RoundResultNotice(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GuildVsGameScoredTeam(teamId: 1)) {
                    return new State05RoundResult_BlueTeamWin(context);
                }

                if (context.GuildVsGameScoredTeam(teamId: 2)) {
                    return new State05RoundResult_RedTeamWin(context);
                }

                if (context.GuildVsGameScoredTeam(teamId: 0)) {
                    return new State05RoundResult_Draw(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State05RoundResult_BlueTeamWin : TriggerState {
            internal State05RoundResult_BlueTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__50$", duration: 4000,
                    userTagId: 1);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__51$", duration: 4000,
                    userTagId: 2);
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_YouWin_01");
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_YouLose_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGameWrapUp_EveryPlayerVacuumExecute(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State05RoundResult_RedTeamWin : TriggerState {
            internal State05RoundResult_RedTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__52$", duration: 4000,
                    userTagId: 2);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__53$", duration: 4000,
                    userTagId: 1);
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_YouWin_01");
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_YouLose_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGameWrapUp_EveryPlayerVacuumExecute(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State05RoundResult_Draw : TriggerState {
            internal State05RoundResult_Draw(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__54$", duration: 4000,
                    userTagId: 1);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__55$", duration: 4000,
                    userTagId: 2);
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_Draw_01");
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_Draw_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGameWrapUp_EveryPlayerVacuumExecute(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameWrapUp_EveryPlayerVacuumExecute : TriggerState {
            internal StateGameWrapUp_EveryPlayerVacuumExecute(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveToPortal(boxId: 9001, userTagId: 1, portalId: 21);
                context.MoveToPortal(boxId: 9001, userTagId: 2, portalId: 22);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateR05RoundScoreRecord(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 11, key: "BannerCheckIn", value: 1);
            }
        }

        private class StateR05RoundScoreRecord : TriggerState {
            internal StateR05RoundScoreRecord(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GuildVsGameWinnerTeam(teamId: 1)) {
                    return new StateBlueTeamWin_GiveReward(context);
                }

                if (context.GuildVsGameWinnerTeam(teamId: 2)) {
                    return new StateRedTeamWin_GiveReward(context);
                }

                if (context.GuildVsGameWinnerTeam(teamId: 0)) {
                    return new StateDrawGame_GiveReward(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlueTeamWinAlreadyNotice : TriggerState {
            internal StateBlueTeamWinAlreadyNotice(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__56$", duration: 3000,
                    userTagId: 1);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__57$", duration: 3000,
                    userTagId: 2);
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_YouWin_01");
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_YouLose_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateBlueTeamWinWinAlready_VacuumExecute(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlueTeamWinWinAlready_VacuumExecute : TriggerState {
            internal StateBlueTeamWinWinAlready_VacuumExecute(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveToPortal(boxId: 9001, userTagId: 1, portalId: 21);
                context.MoveToPortal(boxId: 9001, userTagId: 2, portalId: 22);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBlueTeamWin_GiveReward(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRedTeamWinAlreadyNotice : TriggerState {
            internal StateRedTeamWinAlreadyNotice(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__58$", duration: 3000,
                    userTagId: 2);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__59$", duration: 3000,
                    userTagId: 1);
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "System_YouWin_01");
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "System_YouLose_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateRedTeamWinAlready_VacuumExecute(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRedTeamWinAlready_VacuumExecute : TriggerState {
            internal StateRedTeamWinAlready_VacuumExecute(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveToPortal(boxId: 9001, userTagId: 1, portalId: 21);
                context.MoveToPortal(boxId: 9001, userTagId: 2, portalId: 22);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateRedTeamWin_GiveReward(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlueTeamWin_GiveReward : TriggerState {
            internal StateBlueTeamWin_GiveReward(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuildVsGameGiveReward(type: GuildReward.Funds, teamId: 1, isWin: true);
                context.GuildVsGameGiveReward(type: GuildReward.Experience, teamId: 1, isWin: true);
                context.GuildVsGameGiveReward(type: GuildReward.GuildCoins, teamId: 1, isWin: true);
                context.GuildVsGameGiveContribution(teamId: 1, isWin: true);
                context.GuildVsGameGiveReward(type: GuildReward.Funds, teamId: 2, isWin: false);
                context.GuildVsGameGiveReward(type: GuildReward.Experience, teamId: 2, isWin: false);
                context.GuildVsGameGiveReward(type: GuildReward.GuildCoins, teamId: 2, isWin: false);
                context.GuildVsGameGiveContribution(teamId: 2, isWin: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateResultPopUp_BlueTeamWin(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRedTeamWin_GiveReward : TriggerState {
            internal StateRedTeamWin_GiveReward(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuildVsGameGiveReward(type: GuildReward.Funds, teamId: 2, isWin: true);
                context.GuildVsGameGiveReward(type: GuildReward.Experience, teamId: 2, isWin: true);
                context.GuildVsGameGiveReward(type: GuildReward.GuildCoins, teamId: 2, isWin: true);
                context.GuildVsGameGiveContribution(teamId: 2, isWin: true);
                context.GuildVsGameGiveReward(type: GuildReward.Funds, teamId: 1, isWin: false);
                context.GuildVsGameGiveReward(type: GuildReward.Experience, teamId: 1, isWin: false);
                context.GuildVsGameGiveReward(type: GuildReward.GuildCoins, teamId: 1, isWin: false);
                context.GuildVsGameGiveContribution(teamId: 1, isWin: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateResultPopUp_RedTeamWin(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDrawGame_GiveReward : TriggerState {
            internal StateDrawGame_GiveReward(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuildVsGameGiveReward(type: GuildReward.Funds, teamId: 1, isWin: false);
                context.GuildVsGameGiveReward(type: GuildReward.Experience, teamId: 1, isWin: false);
                context.GuildVsGameGiveReward(type: GuildReward.GuildCoins, teamId: 1, isWin: false);
                context.GuildVsGameGiveContribution(teamId: 1, isWin: false);
                context.GuildVsGameGiveReward(type: GuildReward.Funds, teamId: 2, isWin: false);
                context.GuildVsGameGiveReward(type: GuildReward.Experience, teamId: 2, isWin: false);
                context.GuildVsGameGiveReward(type: GuildReward.GuildCoins, teamId: 2, isWin: false);
                context.GuildVsGameGiveContribution(teamId: 2, isWin: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateResultPopUp_Draw(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResultPopUp_BlueTeamWin : TriggerState {
            internal StateResultPopUp_BlueTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "0,0");
                context.GuildVsGameResult();
                context.GuildVsGameLogResult();
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "massive_success");
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "massive_fail");
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateLeaveAll(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResultPopUp_RedTeamWin : TriggerState {
            internal StateResultPopUp_RedTeamWin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "0,0");
                context.GuildVsGameResult();
                context.GuildVsGameLogResult();
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "massive_success");
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "massive_fail");
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateLeaveAll(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResultPopUp_Draw : TriggerState {
            internal StateResultPopUp_Draw(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "0,0");
                context.GuildVsGameResult();
                context.GuildVsGameLogResult();
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "massive_fail");
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "massive_fail");
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateLeaveAll(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefaultbyWin_BlueTeam : TriggerState {
            internal StateDefaultbyWin_BlueTeam(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "0,0");
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__60$", duration: 4000,
                    userTagId: 1);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__61$", duration: 4000,
                    userTagId: 2);
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "massive_success");
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "massive_fail");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefaultbyWin_BlueTeam_GiveReward(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefaultbyWin_BlueTeam_GiveReward : TriggerState {
            internal StateDefaultbyWin_BlueTeam_GiveReward(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuildVsGameGiveReward(type: GuildReward.Funds, teamId: 1, isWin: false);
                context.GuildVsGameGiveReward(type: GuildReward.Experience, teamId: 1, isWin: false);
                context.GuildVsGameGiveReward(type: GuildReward.GuildCoins, teamId: 1, isWin: false);
                context.GuildVsGameGiveContribution(teamId: 1, isWin: false);
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: true);
                context.GuildVsGameLogWonByDefault(teamId: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateLeaveAll(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefaultbyWin_RedTeam : TriggerState {
            internal StateDefaultbyWin_RedTeam(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "0,0");
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__62$", duration: 4000,
                    userTagId: 2);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__63$", duration: 4000,
                    userTagId: 1);
                context.PlaySystemSoundByUserTag(userTagId: 2, soundKey: "massive_success");
                context.PlaySystemSoundByUserTag(userTagId: 1, soundKey: "massive_fail");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefaultbyWin_RedTeam_GiveReward(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefaultbyWin_RedTeam_GiveReward : TriggerState {
            internal StateDefaultbyWin_RedTeam_GiveReward(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuildVsGameGiveReward(type: GuildReward.Funds, teamId: 2, isWin: false);
                context.GuildVsGameGiveReward(type: GuildReward.Experience, teamId: 2, isWin: false);
                context.GuildVsGameGiveReward(type: GuildReward.GuildCoins, teamId: 2, isWin: false);
                context.GuildVsGameGiveContribution(teamId: 2, isWin: false);
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: true);
                context.GuildVsGameLogWonByDefault(teamId: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateLeaveAll(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameCancel : TriggerState {
            internal StateGameCancel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 9, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: true);
                context.SetEventUI(arg1: 0, script: "0,0");
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__64$", duration: 4000,
                    triggerBoxId: 9000, isOutSide: false);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "massive_fail");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateLeaveAll(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeaveAll : TriggerState {
            internal StateLeaveAll(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuildVsGameEndGame();
                context.UnSetMiniGameAreaForHack();
                context.SetSound(arg1: 40000, arg2: false);
                context.ShowEventResult(type: EventResultType.Notice, text: "$66200001_GD__01_MASSIVEMAIN__65$", duration: 10000,
                    triggerBoxId: 9000, isOutSide: false);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Ending_03");
                context.SetSound(arg1: 10000, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateG01P01_RoundCheckIn : TriggerState {
            internal StateG01P01_RoundCheckIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "G01P01Set", value: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P01_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P01_CleanUp : TriggerState {
            internal StateG01P01_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P01End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P02_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P02_CleanUp : TriggerState {
            internal StateG01P02_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P02End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P03_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P03_CleanUp : TriggerState {
            internal StateG01P03_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P03End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P04_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P04_CleanUp : TriggerState {
            internal StateG01P04_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P04End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P05_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P05_CleanUp : TriggerState {
            internal StateG01P05_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P05End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P06_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P06_CleanUp : TriggerState {
            internal StateG01P06_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P06End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P07_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P07_CleanUp : TriggerState {
            internal StateG01P07_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P07End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P08_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P08_CleanUp : TriggerState {
            internal StateG01P08_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P08End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P09_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P09_CleanUp : TriggerState {
            internal StateG01P09_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P09End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P10_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P10_CleanUp : TriggerState {
            internal StateG01P10_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P10End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P11_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P11_CleanUp : TriggerState {
            internal StateG01P11_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P11End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P12_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P12_CleanUp : TriggerState {
            internal StateG01P12_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P12End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P13_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P13_CleanUp : TriggerState {
            internal StateG01P13_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P13End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P14_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P14_CleanUp : TriggerState {
            internal StateG01P14_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P14End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P15_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P15_CleanUp : TriggerState {
            internal StateG01P15_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P15End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P16_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P16_CleanUp : TriggerState {
            internal StateG01P16_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P16End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P17_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P17_CleanUp : TriggerState {
            internal StateG01P17_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P17End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P18_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P18_CleanUp : TriggerState {
            internal StateG01P18_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P18End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P19_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P19_CleanUp : TriggerState {
            internal StateG01P19_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P19End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P20_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P20_CleanUp : TriggerState {
            internal StateG01P20_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P20End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P21_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P21_CleanUp : TriggerState {
            internal StateG01P21_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P21End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P22_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P22_CleanUp : TriggerState {
            internal StateG01P22_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P22End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P23_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P23_CleanUp : TriggerState {
            internal StateG01P23_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P23End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P24_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P24_CleanUp : TriggerState {
            internal StateG01P24_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P24End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P25_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P25_CleanUp : TriggerState {
            internal StateG01P25_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P25End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P26_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P26_CleanUp : TriggerState {
            internal StateG01P26_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P26End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P27_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P27_CleanUp : TriggerState {
            internal StateG01P27_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P27End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P28_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P28_CleanUp : TriggerState {
            internal StateG01P28_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P28End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P29_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P29_CleanUp : TriggerState {
            internal StateG01P29_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P29End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG01P30_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG01P30_CleanUp : TriggerState {
            internal StateG01P30_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G01P30End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P01_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P01_CleanUp : TriggerState {
            internal StateG02P01_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P01End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P02_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P02_CleanUp : TriggerState {
            internal StateG02P02_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P02End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P03_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P03_CleanUp : TriggerState {
            internal StateG02P03_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P03End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P04_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P04_CleanUp : TriggerState {
            internal StateG02P04_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P04End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P05_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P05_CleanUp : TriggerState {
            internal StateG02P05_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P05End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P06_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P06_CleanUp : TriggerState {
            internal StateG02P06_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P06End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P07_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P07_CleanUp : TriggerState {
            internal StateG02P07_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P07End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P08_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P08_CleanUp : TriggerState {
            internal StateG02P08_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P08End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P09_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P09_CleanUp : TriggerState {
            internal StateG02P09_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P09End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P10_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P10_CleanUp : TriggerState {
            internal StateG02P10_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P10End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P11_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P11_CleanUp : TriggerState {
            internal StateG02P11_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P11End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P12_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P12_CleanUp : TriggerState {
            internal StateG02P12_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P12End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P13_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P13_CleanUp : TriggerState {
            internal StateG02P13_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P13End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P14_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P14_CleanUp : TriggerState {
            internal StateG02P14_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P14End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P15_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P15_CleanUp : TriggerState {
            internal StateG02P15_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P15End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P16_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P16_CleanUp : TriggerState {
            internal StateG02P16_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P16End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P17_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P17_CleanUp : TriggerState {
            internal StateG02P17_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P17End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P18_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P18_CleanUp : TriggerState {
            internal StateG02P18_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P18End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P19_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P19_CleanUp : TriggerState {
            internal StateG02P19_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P19End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P20_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P20_CleanUp : TriggerState {
            internal StateG02P20_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P20End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P21_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P21_CleanUp : TriggerState {
            internal StateG02P21_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P21End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P22_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P22_CleanUp : TriggerState {
            internal StateG02P22_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P22End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P23_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P23_CleanUp : TriggerState {
            internal StateG02P23_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P23End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P24_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P24_CleanUp : TriggerState {
            internal StateG02P24_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P24End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P25_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P25_CleanUp : TriggerState {
            internal StateG02P25_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P25End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P26_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P26_CleanUp : TriggerState {
            internal StateG02P26_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P26End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P27_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P27_CleanUp : TriggerState {
            internal StateG02P27_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P27End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P28_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P28_CleanUp : TriggerState {
            internal StateG02P28_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P28End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P29_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P29_CleanUp : TriggerState {
            internal StateG02P29_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P29End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG02P30_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG02P30_CleanUp : TriggerState {
            internal StateG02P30_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G02P30End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P01_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P01_CleanUp : TriggerState {
            internal StateG03P01_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P01End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P02_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P02_CleanUp : TriggerState {
            internal StateG03P02_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P02End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P03_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P03_CleanUp : TriggerState {
            internal StateG03P03_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P03End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P04_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P04_CleanUp : TriggerState {
            internal StateG03P04_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P04End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P05_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P05_CleanUp : TriggerState {
            internal StateG03P05_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P05End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P06_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P06_CleanUp : TriggerState {
            internal StateG03P06_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P06End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P07_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P07_CleanUp : TriggerState {
            internal StateG03P07_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P07End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P08_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P08_CleanUp : TriggerState {
            internal StateG03P08_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P08End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P09_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P09_CleanUp : TriggerState {
            internal StateG03P09_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P09End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P10_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P10_CleanUp : TriggerState {
            internal StateG03P10_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P10End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P11_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P11_CleanUp : TriggerState {
            internal StateG03P11_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P11End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P12_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P12_CleanUp : TriggerState {
            internal StateG03P12_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P12End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P13_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P13_CleanUp : TriggerState {
            internal StateG03P13_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P13End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P14_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P14_CleanUp : TriggerState {
            internal StateG03P14_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P14End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P15_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P15_CleanUp : TriggerState {
            internal StateG03P15_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P15End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P16_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P16_CleanUp : TriggerState {
            internal StateG03P16_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P16End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P17_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P17_CleanUp : TriggerState {
            internal StateG03P17_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P17End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P18_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P18_CleanUp : TriggerState {
            internal StateG03P18_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P18End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P19_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P19_CleanUp : TriggerState {
            internal StateG03P19_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P19End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P20_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P20_CleanUp : TriggerState {
            internal StateG03P20_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P20End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P21_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P21_CleanUp : TriggerState {
            internal StateG03P21_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P21End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P22_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P22_CleanUp : TriggerState {
            internal StateG03P22_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P22End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P23_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P23_CleanUp : TriggerState {
            internal StateG03P23_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P23End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P24_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P24_CleanUp : TriggerState {
            internal StateG03P24_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P24End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P25_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P25_CleanUp : TriggerState {
            internal StateG03P25_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P25End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P26_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P26_CleanUp : TriggerState {
            internal StateG03P26_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P26End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P27_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P27_CleanUp : TriggerState {
            internal StateG03P27_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P27End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P28_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P28_CleanUp : TriggerState {
            internal StateG03P28_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P28End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P29_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P29_CleanUp : TriggerState {
            internal StateG03P29_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P29End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG03P30_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG03P30_CleanUp : TriggerState {
            internal StateG03P30_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G03P30End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P01_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P01_CleanUp : TriggerState {
            internal StateG04P01_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P01End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P02_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P02_CleanUp : TriggerState {
            internal StateG04P02_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P02End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P03_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P03_CleanUp : TriggerState {
            internal StateG04P03_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P03End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P04_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P04_CleanUp : TriggerState {
            internal StateG04P04_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P04End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P05_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P05_CleanUp : TriggerState {
            internal StateG04P05_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P05End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P06_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P06_CleanUp : TriggerState {
            internal StateG04P06_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P06End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P07_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P07_CleanUp : TriggerState {
            internal StateG04P07_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P07End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P08_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P08_CleanUp : TriggerState {
            internal StateG04P08_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P08End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P09_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P09_CleanUp : TriggerState {
            internal StateG04P09_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P09End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P10_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P10_CleanUp : TriggerState {
            internal StateG04P10_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P10End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P11_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P11_CleanUp : TriggerState {
            internal StateG04P11_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P11End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P12_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P12_CleanUp : TriggerState {
            internal StateG04P12_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P12End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P13_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P13_CleanUp : TriggerState {
            internal StateG04P13_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P13End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P14_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P14_CleanUp : TriggerState {
            internal StateG04P14_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P14End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P15_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P15_CleanUp : TriggerState {
            internal StateG04P15_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P15End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P16_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P16_CleanUp : TriggerState {
            internal StateG04P16_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P16End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P17_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P17_CleanUp : TriggerState {
            internal StateG04P17_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P17End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P18_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P18_CleanUp : TriggerState {
            internal StateG04P18_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P18End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P19_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P19_CleanUp : TriggerState {
            internal StateG04P19_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P19End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P20_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P20_CleanUp : TriggerState {
            internal StateG04P20_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P20End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P21_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P21_CleanUp : TriggerState {
            internal StateG04P21_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P21End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P22_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P22_CleanUp : TriggerState {
            internal StateG04P22_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P22End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P23_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P23_CleanUp : TriggerState {
            internal StateG04P23_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P23End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P24_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P24_CleanUp : TriggerState {
            internal StateG04P24_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P24End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P25_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P25_CleanUp : TriggerState {
            internal StateG04P25_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P25End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P26_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P26_CleanUp : TriggerState {
            internal StateG04P26_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P26End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P27_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P27_CleanUp : TriggerState {
            internal StateG04P27_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P27End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P28_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P28_CleanUp : TriggerState {
            internal StateG04P28_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P28End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P29_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P29_CleanUp : TriggerState {
            internal StateG04P29_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P29End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P30_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P30_CleanUp : TriggerState {
            internal StateG04P30_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P30End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P31_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P31_CleanUp : TriggerState {
            internal StateG04P31_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P31End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P32_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P32_CleanUp : TriggerState {
            internal StateG04P32_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P32End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P33_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P33_CleanUp : TriggerState {
            internal StateG04P33_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P33End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P34_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P34_CleanUp : TriggerState {
            internal StateG04P34_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P34End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P35_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P35_CleanUp : TriggerState {
            internal StateG04P35_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P35End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P36_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P36_CleanUp : TriggerState {
            internal StateG04P36_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P36End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P37_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P37_CleanUp : TriggerState {
            internal StateG04P37_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P37End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P38_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P38_CleanUp : TriggerState {
            internal StateG04P38_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P38End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P39_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P39_CleanUp : TriggerState {
            internal StateG04P39_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P39End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG04P40_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG04P40_CleanUp : TriggerState {
            internal StateG04P40_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G04P40End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P01_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P01_CleanUp : TriggerState {
            internal StateG05P01_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P01End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P02_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P02_CleanUp : TriggerState {
            internal StateG05P02_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P02End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P03_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P03_CleanUp : TriggerState {
            internal StateG05P03_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P03End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P04_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P04_CleanUp : TriggerState {
            internal StateG05P04_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P04End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P05_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P05_CleanUp : TriggerState {
            internal StateG05P05_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P05End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P06_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P06_CleanUp : TriggerState {
            internal StateG05P06_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P06End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P07_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P07_CleanUp : TriggerState {
            internal StateG05P07_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P07End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P08_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P08_CleanUp : TriggerState {
            internal StateG05P08_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P08End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P09_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P09_CleanUp : TriggerState {
            internal StateG05P09_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P09End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P10_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P10_CleanUp : TriggerState {
            internal StateG05P10_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P10End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P11_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P11_CleanUp : TriggerState {
            internal StateG05P11_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P11End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P12_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P12_CleanUp : TriggerState {
            internal StateG05P12_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P12End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P13_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P13_CleanUp : TriggerState {
            internal StateG05P13_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P13End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P14_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P14_CleanUp : TriggerState {
            internal StateG05P14_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P14End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P15_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P15_CleanUp : TriggerState {
            internal StateG05P15_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P15End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P16_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P16_CleanUp : TriggerState {
            internal StateG05P16_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P16End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P17_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P17_CleanUp : TriggerState {
            internal StateG05P17_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P17End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P18_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P18_CleanUp : TriggerState {
            internal StateG05P18_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P18End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P19_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P19_CleanUp : TriggerState {
            internal StateG05P19_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P19End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P20_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P20_CleanUp : TriggerState {
            internal StateG05P20_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P20End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P21_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P21_CleanUp : TriggerState {
            internal StateG05P21_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P21End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P22_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P22_CleanUp : TriggerState {
            internal StateG05P22_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P22End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P23_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P23_CleanUp : TriggerState {
            internal StateG05P23_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P23End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P24_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P24_CleanUp : TriggerState {
            internal StateG05P24_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P24End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P25_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P25_CleanUp : TriggerState {
            internal StateG05P25_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P25End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P26_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P26_CleanUp : TriggerState {
            internal StateG05P26_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P26End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P27_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P27_CleanUp : TriggerState {
            internal StateG05P27_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P27End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P28_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P28_CleanUp : TriggerState {
            internal StateG05P28_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P28End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P29_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P29_CleanUp : TriggerState {
            internal StateG05P29_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P29End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P30_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P30_CleanUp : TriggerState {
            internal StateG05P30_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P30End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P31_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P31_CleanUp : TriggerState {
            internal StateG05P31_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P31End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P32_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P32_CleanUp : TriggerState {
            internal StateG05P32_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P32End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P33_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P33_CleanUp : TriggerState {
            internal StateG05P33_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P33End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P34_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P34_CleanUp : TriggerState {
            internal StateG05P34_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P34End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P35_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P35_CleanUp : TriggerState {
            internal StateG05P35_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P35End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P36_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P36_CleanUp : TriggerState {
            internal StateG05P36_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P36End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P37_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P37_CleanUp : TriggerState {
            internal StateG05P37_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P37End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P38_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P38_CleanUp : TriggerState {
            internal StateG05P38_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P38End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P39_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P39_CleanUp : TriggerState {
            internal StateG05P39_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P39End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P40_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P40_CleanUp : TriggerState {
            internal StateG05P40_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P40End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P41_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P41_CleanUp : TriggerState {
            internal StateG05P41_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P41End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P42_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P42_CleanUp : TriggerState {
            internal StateG05P42_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P42End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P43_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P43_CleanUp : TriggerState {
            internal StateG05P43_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P43End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P44_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P44_CleanUp : TriggerState {
            internal StateG05P44_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P44End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P45_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P45_CleanUp : TriggerState {
            internal StateG05P45_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P45End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P46_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P46_CleanUp : TriggerState {
            internal StateG05P46_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P46End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P47_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P47_CleanUp : TriggerState {
            internal StateG05P47_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P47End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P48_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P48_CleanUp : TriggerState {
            internal StateG05P48_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P48End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P49_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P49_CleanUp : TriggerState {
            internal StateG05P49_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P49End") == 1) {
                    return new StateRoundCheckOutDelay(context);
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

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11111")) {
                    return new StateG05P50_CleanUp(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(id: "11111");
            }
        }

        private class StateG05P50_CleanUp : TriggerState {
            internal StateG05P50_CleanUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraSelect(arg1: 901, arg2: true);
                context.SetCinematicUI(type: 3, script: "$66200001_GD__01_MASSIVEMAIN__66$");
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DJDD_Dancing_01");
                context.SetMesh(
                    arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633}, arg2: false, arg3: 2000, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg1: new[] {6901, 6902, 6903, 6904, 6905, 6906},
                    arg2: "DDStop_Stage_Fail_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "G05P50End") == 1) {
                    return new StateRoundCheckOutDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoundCheckOutDelay : TriggerState {
            internal StateRoundCheckOutDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateRoundCheckOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoundCheckOut : TriggerState {
            internal StateRoundCheckOut(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 11, key: "BannerCheckIn", value: 1);
                context.GuildVsGameScoreByUser(triggerBoxId: 9001, score: true);
                context.SetMesh(
                    arg1: new[]
                        {8900, 8901, 8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912, 8913, 8914},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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

                if (context.GetUserValue(key: "Round") == 5) {
                    return new StateR05EndDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}