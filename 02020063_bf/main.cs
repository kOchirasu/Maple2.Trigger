using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020063_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032}, visible: true);
                context.SetEffect(triggerIds: new []{10001, 10002}, visible: false);
                context.SetMesh(triggerIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048, 1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068, 1069, 1070, 1071, 1072, 1073, 1074, 1075, 1076, 1077, 1078, 1079, 1080, 1081, 1082, 1083, 1084, 1085, 1086, 1087, 1088, 1089, 1090, 1091, 1092, 1093, 1094, 1095, 1096}, visible: true);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
                context.EnableSpawnPointPc(spawnId: 0, enabled: true);
                context.EnableSpawnPointPc(spawnId: 1, enabled: true);
                context.EnableSpawnPointPc(spawnId: 2, enabled: false);
                context.SetUserValue(triggerId: 99990002, key: "Battle_1_SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Battle_2_Start", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Battle_3_Start", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "Battle_2_SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990006, key: "Battle_3_SpawnStart", value: 0);
                context.SetActor(triggerId: 4002, visible: true, initialSequence: "ks_quest_fusiondevice_A01_off");
                context.ResetTimer(timerId: "1");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001}) || context.UserDetected(boxIds: new []{9003})) {
                    return new State유저Count(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저Count : TriggerState {
            internal State유저Count(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4002, visible: true, initialSequence: "ks_quest_fusiondevice_A01_on");
                context.SetEffect(triggerIds: new []{10001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "FieldGameStart") == 1) {
                    return new StateDelay(context);
                }

                if (context.GetUserValue(key: "FieldGameStart") == 2) {
                    return new State방폭(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9002, type: "trigger", code: "corps_battle");
                context.SetEventUI(arg1: 1, script: "$02020063_BF__MAIN__0$", duration: 5000);
                context.CameraSelect(triggerId: 998, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방폭 : TriggerState {
            internal State방폭(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020063_BF__MAIN__1$", duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State내보내기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State내보내기 : TriggerState {
            internal State내보내기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 0, portalId: 0);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032}, visible: false);
                context.SetMesh(triggerIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048, 1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068, 1069, 1070, 1071, 1072, 1073, 1074, 1075, 1076, 1077, 1078, 1079, 1080, 1081, 1082, 1083, 1084, 1085, 1086, 1087, 1088, 1089, 1090, 1091, 1092, 1093, 1094, 1095, 1096}, visible: false);
                context.CreateMonster(spawnIds: new []{801}, arg2: false);
                context.CameraReset(interpolationTime: 1f);
                context.SetEventUI(arg1: 0, script: "1,3");
                context.SetEventUI(arg1: 1, script: "$02020063_BF__MAIN__2$", duration: 5000);
                context.SetUserValue(triggerId: 99990002, key: "Battle_1_SpawnStart", value: 1);
                context.EnableSpawnPointPc(spawnId: 0, enabled: false);
                context.EnableSpawnPointPc(spawnId: 1, enabled: false);
                context.EnableSpawnPointPc(spawnId: 2, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle_1_Clear") == 1) {
                    context.SetUserValue(triggerId: 99990002, key: "Battle_1_SpawnStart", value: 0);
                    return new State포탑Phase(context);
                }

                if (context.MonsterDead(spawnIds: new []{801})) {
                    context.SetActor(triggerId: 4002, visible: true, initialSequence: "ks_quest_fusiondevice_A01_off");
                    context.SetEffect(triggerIds: new []{10001}, visible: false);
                    context.SetEffect(triggerIds: new []{10002}, visible: true);
                    return new State실패_세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탑Phase : TriggerState {
            internal State포탑Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GiveRewardContent(rewardId: 31000001);
                context.SetUserValue(triggerId: 99990003, key: "Battle_2_Start", value: 1);
                context.SetUserValue(triggerId: 99990005, key: "Battle_2_SpawnStart", value: 1);
                context.SetEventUI(arg1: 0, script: "2,3");
                context.SetEventUI(arg1: 1, script: "$02020063_BF__MAIN__3$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle_2_Clear") == 1) {
                    context.SetUserValue(triggerId: 99990005, key: "Battle_2_SpawnStart", value: 0);
                    return new StateBossPhase(context);
                }

                if (context.MonsterDead(spawnIds: new []{801})) {
                    context.SetActor(triggerId: 4002, visible: true, initialSequence: "ks_quest_fusiondevice_A01_off");
                    context.SetEffect(triggerIds: new []{10001}, visible: false);
                    context.SetEffect(triggerIds: new []{10002}, visible: true);
                    return new State실패_세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossPhase : TriggerState {
            internal StateBossPhase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GiveRewardContent(rewardId: 31000002);
                context.SetEventUI(arg1: 0, script: "3,3");
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020063_BF__MAIN__4$");
                context.SetUserValue(triggerId: 99990004, key: "Battle_3_Start", value: 1);
                context.SetTimer(timerId: "1", seconds: 180, autoRemove: true, display: true, vOffset: 60);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle_3_Clear") == 1) {
                    return new StateSuccess_세팅(context);
                }

                if (context.MonsterDead(spawnIds: new []{801})) {
                    context.SetActor(triggerId: 4002, visible: true, initialSequence: "ks_quest_fusiondevice_A01_off");
                    context.SetEffect(triggerIds: new []{10001}, visible: false);
                    context.SetEffect(triggerIds: new []{10002}, visible: true);
                    return new State실패_세팅(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    context.SetActor(triggerId: 4002, visible: true, initialSequence: "ks_quest_fusiondevice_A01_off");
                    return new State실패_세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess_세팅 : TriggerState {
            internal StateSuccess_세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020063_BF__MAIN__5$");
                context.SetUserValue(triggerId: 99990002, key: "Battle_1_SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Battle_2_Start", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Battle_3_Start", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "Battle_2_SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990006, key: "Battle_3_SpawnStart", value: 0);
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "2");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateSuccess_추가대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess_추가대사 : TriggerState {
            internal StateSuccess_추가대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003533, illust: "Bliche_smile", duration: 5000, script: "$02020063_BF__MAIN__6$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateSuccess(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패_세팅 : TriggerState {
            internal State실패_세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020063_BF__MAIN__7$");
                context.SetUserValue(triggerId: 99990002, key: "Battle_1_SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Battle_2_Start", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Battle_3_Start", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "Battle_2_SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990006, key: "Battle_3_SpawnStart", value: 0);
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "2");
                context.SetMesh(triggerIds: new []{4001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패_추가대사 : TriggerState {
            internal State실패_추가대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003533, illust: "Bliche_normal", duration: 5000, script: "$02020063_BF__MAIN__8$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess : TriggerState {
            internal StateSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.FieldWarEnd(isClear: true);
                context.SetAchievement(type: "trigger", code: "FieldwarAchieve_2");
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.FieldWarEnd(isClear: false);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
