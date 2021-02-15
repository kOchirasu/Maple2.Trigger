namespace Maple2.Trigger._02020065_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ScoreBoardRemove();
                context.SetEffect(arg1: new[] {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032}, arg2: true);
                context.SetEffect(arg1: new[] {10001, 10002}, arg2: false);
                context.SetMesh(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048, 1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068, 1069, 1070, 1071, 1072, 1073, 1074, 1075, 1076, 1077, 1078, 1079, 1080, 1081, 1082, 1083, 1084, 1085, 1086, 1087, 1088, 1089, 1090, 1091, 1092, 1093, 1094, 1095, 1096}, arg2: true);
                context.SetMesh(arg1: new[] {4001}, arg2: false);
                context.SetActor(arg1: 4002, arg2: true, arg3: "ks_quest_fusiondevice_A01_off");
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 2, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 3, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 4, isEnable: false);
                context.SetUserValue(triggerId: 99990002, key: "Battle_1_SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Battle_2_Start", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Battle_3_Start", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "Battle_2_SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990006, key: "Battle_3_SpawnStart", value: 0);
                context.ResetTimer(arg1: "1");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001}) || context.UserDetected(arg1: new[] {9003})) {
                    return new State유저Count(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저Count : TriggerState {
            internal State유저Count(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4002, arg2: true, arg3: "ks_quest_fusiondevice_A01_on");
                context.SetEffect(arg1: new[] {10001}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetAchievement(arg1: 9002, arg2: "trigger", arg3: "corps_battle");
                context.SetEventUI(arg1: 1, arg2: "$02020065_BF__MAIN__0$", arg3: 5000);
                context.CameraSelect(arg1: 998, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetEventUI(arg1: 1, arg2: "$02020065_BF__MAIN__1$", arg3: 10000);
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032}, arg2: false);
                context.SetMesh(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048, 1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068, 1069, 1070, 1071, 1072, 1073, 1074, 1075, 1076, 1077, 1078, 1079, 1080, 1081, 1082, 1083, 1084, 1085, 1086, 1087, 1088, 1089, 1090, 1091, 1092, 1093, 1094, 1095, 1096}, arg2: false);
                context.CameraReset(interpolationTime: 1f);
                context.SetEventUI(arg1: 0, arg2: "1,3");
                context.SetEventUI(arg1: 1, arg2: "$02020065_BF__MAIN__2$", arg3: 5000);
                context.CreateMonster(arg1: new[] {801}, arg2: false);
                context.SetUserValue(triggerId: 99990002, key: "Battle_1_SpawnStart", value: 1);
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 2, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 3, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 4, isEnable: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_1_Clear") == 1) {
                    context.SetUserValue(triggerId: 99990002, key: "Battle_1_SpawnStart", value: 0);
                    return new State포탑Phase(context);
                }

                if (context.MonsterDead(arg1: new[] {801})) {
                    context.SetActor(arg1: 4002, arg2: true, arg3: "ks_quest_fusiondevice_A01_off");
                    context.SetEffect(arg1: new[] {10001}, arg2: false);
                    context.SetEffect(arg1: new[] {10002}, arg2: true);
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
                context.SetEventUI(arg1: 0, arg2: "2,3");
                context.SetEventUI(arg1: 1, arg2: "$02020065_BF__MAIN__3$", arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_2_Clear") == 1) {
                    context.SetUserValue(triggerId: 99990005, key: "Battle_2_SpawnStart", value: 0);
                    return new StateBossPhase(context);
                }

                if (context.MonsterDead(arg1: new[] {801})) {
                    context.SetActor(arg1: 4002, arg2: true, arg3: "ks_quest_fusiondevice_A01_off");
                    context.SetEffect(arg1: new[] {10001}, arg2: false);
                    context.SetEffect(arg1: new[] {10002}, arg2: true);
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
                context.SetEventUI(arg1: 0, arg2: "3,3");
                context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020065_BF__MAIN__4$");
                context.SetUserValue(triggerId: 99990004, key: "Battle_3_Start", value: 1);
                context.SetTimer(arg1: "1", arg2: 180, arg3: true, arg4: true, arg5: 60);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_3_Clear") == 1) {
                    return new StateSuccess_세팅(context);
                }

                if (context.MonsterDead(arg1: new[] {801})) {
                    context.SetActor(arg1: 4002, arg2: true, arg3: "ks_quest_fusiondevice_A01_off");
                    context.SetEffect(arg1: new[] {10001}, arg2: false);
                    context.SetEffect(arg1: new[] {10002}, arg2: true);
                    return new State실패_세팅(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new State실패_세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess_세팅 : TriggerState {
            internal StateSuccess_세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020065_BF__MAIN__5$");
                context.SetUserValue(triggerId: 99990002, key: "Battle_1_SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Battle_2_Start", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Battle_3_Start", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "Battle_2_SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990006, key: "Battle_3_SpawnStart", value: 0);
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
            }

            public override TriggerState Execute() {
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
                context.SideNpcTalk(type: "talk", npcId: 11003533, illust: "Bliche_smile", duration: 5000, script: "$02020065_BF__MAIN__6$");
            }

            public override TriggerState Execute() {
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
                context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020065_BF__MAIN__7$");
                context.SetUserValue(triggerId: 99990002, key: "Battle_1_SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Battle_2_Start", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Battle_3_Start", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "Battle_2_SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990006, key: "Battle_3_SpawnStart", value: 0);
                context.ScoreBoardRemove();
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
            }

            public override TriggerState Execute() {
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
                context.SideNpcTalk(type: "talk", npcId: 11003533, illust: "Bliche_normal", duration: 5000, script: "$02020065_BF__MAIN__8$");
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {-1});
                context.FieldWarEnd(isClear: true);
                context.SetAchievement(arg2: "trigger", arg3: "FieldwarAchieve_1");
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.FieldWarEnd(isClear: false);
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}