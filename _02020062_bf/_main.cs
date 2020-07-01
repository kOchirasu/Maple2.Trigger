namespace Maple2.Trigger._02020062_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 2, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 3, isEnable: false);
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
                context.ResetTimer(arg1: "3");
                context.SetEffect(arg1: new[] {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016}, arg2: true);
                context.SetMesh(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048}, arg2: true);
                context.SetEffect(arg1: new[] {2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116}, arg2: true);
                context.SetMesh(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145, 1146, 1147, 1148}, arg2: true);
                context.SetActor(arg1: 1901, arg2: true, arg3: "Idle_A");
                context.ShadowExpedition(type: "CloseBossGauge");
                context.SetUserValue(triggerId: 99990002, key: "SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "ObjectPhase", value: 0);
                context.SetUserValue(triggerId: 99990008, key: "BossPhase", value: 0);
                context.SetUserValue(triggerId: 99990024, key: "MovePanel01", value: 0);
                context.SetUserValue(triggerId: 99990025, key: "MovePanel02", value: 0);
                context.SetUserValue(triggerId: 99990026, key: "MovePanel03", value: 0);
                context.SetUserValue(triggerId: 99990027, key: "MovePanel04", value: 0);
                context.SetMesh(arg1: new[] {40000, 40001, 40002, 40003, 40004, 40005, 40006, 40007, 40008, 40009, 40010, 40011, 40012, 40013, 40014, 40015, 40016, 40017, 40018, 40019, 40020, 40021}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001}) || context.UserDetected(arg1: new[] {9003})) {
                    context.State = new State유저카운트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저카운트 : TriggerState {
            internal State유저카운트(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "FieldGameStart") == 1) {
                    context.State = new State딜레이(context);
                    return;
                }

                if (context.GetUserValue(key: "FieldGameStart") == 2) {
                    context.State = new State방폭(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9002, arg2: "trigger", arg3: "corps_battle");
                context.SetEventUI(arg1: 1, arg2: "$02020062_BF__MAIN__0$", arg3: 5000);
                context.CameraSelect(arg1: 999, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State방폭 : TriggerState {
            internal State방폭(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020062_BF__MAIN__1$", arg3: 10000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State내보내기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State내보내기 : TriggerState {
            internal State내보내기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016}, arg2: false);
                context.SetMesh(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048}, arg2: false);
                context.SetEffect(arg1: new[] {2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116}, arg2: false);
                context.SetMesh(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145, 1146, 1147, 1148}, arg2: false);
                context.CameraReset(interpolationTime: 1f);
                context.SetEventUI(arg1: 0, arg2: "1,3");
                context.SetEventUI(arg1: 1, arg2: "$02020062_BF__MAIN__2$", arg3: 5000);
                context.SetTimer(arg1: "1", arg2: 180, arg3: true, arg4: true, arg5: 60);
                context.ShadowExpedition(type: "OpenBossGauge", maxGaugePoint: 750);
                context.SetUserValue(triggerId: 99990002, key: "SpawnStart", value: 1);
                context.SetActor(arg1: 1901, arg2: false, arg3: "Idle_A");
                context.CreateMonster(arg1: new[] {701}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "GaugeClear") == 1) {
                    context.State = new State오브젝트페이즈(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State실패_세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트페이즈 : TriggerState {
            internal State오브젝트페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GiveRewardContent(rewardId: 31000001);
                context.SetEventUI(arg1: 1, arg2: "$02020062_BF__MAIN__3$", arg3: 5000);
                context.ShadowExpedition(type: "CloseBossGauge");
                context.SetEventUI(arg1: 0, arg2: "2,3");
                context.ResetTimer(arg1: "1");
                context.SetUserValue(triggerId: 99990003, key: "ObjectPhase", value: 1);
                context.SetTimer(arg1: "2", arg2: 180, arg3: true, arg4: true, arg5: 60);
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 2, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 3, isEnable: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ObjectClear") == 1) {
                    context.State = new State보스페이즈(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State실패_세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스페이즈 : TriggerState {
            internal State보스페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GiveRewardContent(rewardId: 31000002);
                context.DestroyMonster(arg1: new[] {-1});
                context.SetEventUI(arg1: 1, arg2: "$02020062_BF__MAIN__4$", arg3: 5000);
                context.ResetTimer(arg1: "2");
                context.SetEventUI(arg1: 0, arg2: "3,3");
                context.SetUserValue(triggerId: 99990008, key: "BossPhase", value: 1);
                context.SetTimer(arg1: "3", arg2: 180, arg3: true, arg4: true, arg5: 60);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BossClear") == 1) {
                    context.State = new State성공_세팅(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State실패_세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State성공_세팅 : TriggerState {
            internal State성공_세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020062_BF__MAIN__5$");
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
                context.ResetTimer(arg1: "3");
                context.SetUserValue(triggerId: 99990002, key: "SpawnStart", value: 2);
                context.SetUserValue(triggerId: 99990003, key: "ObjectPhase", value: 2);
                context.SetUserValue(triggerId: 99990004, key: "BossPhase", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State성공_추가대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State성공_추가대사 : TriggerState {
            internal State성공_추가대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11003533, illust: "Bliche_smile", duration: 5000, script: "$02020062_BF__MAIN__6$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패_세팅 : TriggerState {
            internal State실패_세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020062_BF__MAIN__7$");
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
                context.ResetTimer(arg1: "3");
                context.SetUserValue(triggerId: 99990002, key: "SpawnStart", value: 2);
                context.SetUserValue(triggerId: 99990003, key: "ObjectPhase", value: 2);
                context.SetUserValue(triggerId: 99990004, key: "BossPhase", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State실패_추가대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패_추가대사 : TriggerState {
            internal State실패_추가대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11003533, illust: "Bliche_normal", duration: 5000, script: "$02020062_BF__MAIN__8$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State성공 : TriggerState {
            internal State성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.FieldWarEnd(isClear: true);
                context.SetAchievement(arg2: "trigger", arg3: "FieldwarAchieve_2");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.FieldWarEnd(isClear: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}