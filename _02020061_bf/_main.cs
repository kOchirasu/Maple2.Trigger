namespace Maple2.Trigger._02020061_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 2, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 3, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 4, isEnable: false);
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
                context.ResetTimer(arg1: "3");
                context.SetActor(arg1: 1901, arg2: true, arg3: "Idle_A");
                context.SetEffect(arg1: new[] {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016}, arg2: true);
                context.SetMesh(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048}, arg2: true);
                context.ShadowExpeditionCloseBossGauge();
                context.SetUserValue(triggerId: 99990002, key: "SpawnStart", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "ObjectPhase", value: 0);
                context.SetUserValue(triggerId: 99990008, key: "BossPhase", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    return new State유저카운트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저카운트 : TriggerState {
            internal State유저카운트(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "FieldGameStart") == 1) {
                    return new State딜레이(context);
                }

                if (context.GetUserValue(key: "FieldGameStart") == 2) {
                    return new State방폭(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9002, arg2: "trigger", arg3: "corps_battle");
                context.SetEventUI(arg1: 1, arg2: "$02020061_BF__MAIN__0$", arg3: 5000);
                context.CameraSelect(arg1: 999, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방폭 : TriggerState {
            internal State방폭(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020061_BF__MAIN__1$", arg3: 10000);
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
                return new State종료(context);
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 2, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 3, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 4, isEnable: true);
                context.CameraReset(interpolationTime: 1f);
                context.SetEffect(arg1: new[] {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016}, arg2: false);
                context.SetMesh(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048}, arg2: false);
                context.SetEventUI(arg1: 0, arg2: "1,3");
                context.SetEventUI(arg1: 1, arg2: "$02020061_BF__MAIN__2$", arg3: 5000);
                context.SetTimer(arg1: "1", arg2: 180, arg3: true, arg4: true, arg5: 60);
                context.ShadowExpeditionOpenBossGauge(maxGaugePoint: 800);
                context.SetUserValue(triggerId: 99990002, key: "SpawnStart", value: 1);
                context.SetActor(arg1: 1901, arg2: false, arg3: "Idle_A");
                context.CreateMonster(arg1: new[] {701}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "GaugeClear") == 1) {
                    return new State오브젝트페이즈(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new State실패_세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트페이즈 : TriggerState {
            internal State오브젝트페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GiveRewardContent(rewardId: 31000001);
                context.SetEventUI(arg1: 1, arg2: "$02020061_BF__MAIN__3$", arg3: 5000);
                context.ShadowExpeditionCloseBossGauge();
                context.SetEventUI(arg1: 0, arg2: "2,3");
                context.ResetTimer(arg1: "1");
                context.SetUserValue(triggerId: 99990003, key: "ObjectPhase", value: 1);
                context.SetTimer(arg1: "2", arg2: 180, arg3: true, arg4: true, arg5: 60);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectClear") == 1) {
                    return new State보스페이즈(context);
                }

                if (context.TimeExpired(arg1: "2")) {
                    return new State실패_세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스페이즈 : TriggerState {
            internal State보스페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GiveRewardContent(rewardId: 31000002);
                context.DestroyMonster(arg1: new[] {-1});
                context.SetEventUI(arg1: 1, arg2: "$02020061_BF__MAIN__4$", arg3: 5000);
                context.ResetTimer(arg1: "2");
                context.SetEventUI(arg1: 0, arg2: "3,3");
                context.SetUserValue(triggerId: 99990008, key: "BossPhase", value: 1);
                context.SetTimer(arg1: "3", arg2: 180, arg3: true, arg4: true, arg5: 60);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossClear") == 1) {
                    return new State성공_세팅(context);
                }

                if (context.TimeExpired(arg1: "3")) {
                    return new State실패_세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State성공_세팅 : TriggerState {
            internal State성공_세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020061_BF__MAIN__5$");
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
                context.ResetTimer(arg1: "3");
                context.SetUserValue(triggerId: 99990002, key: "SpawnStart", value: 2);
                context.SetUserValue(triggerId: 99990003, key: "ObjectPhase", value: 2);
                context.SetUserValue(triggerId: 99990004, key: "BossPhase", value: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State성공_대사용(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State성공_대사용 : TriggerState {
            internal State성공_대사용(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11003533, illust: "Bliche_smile", duration: 5000, script: "$02020061_BF__MAIN__6$");
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State성공(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패_세팅 : TriggerState {
            internal State실패_세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020061_BF__MAIN__7$");
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
                context.ResetTimer(arg1: "3");
                context.SetUserValue(triggerId: 99990002, key: "SpawnStart", value: 2);
                context.SetUserValue(triggerId: 99990003, key: "ObjectPhase", value: 2);
                context.SetUserValue(triggerId: 99990004, key: "BossPhase", value: 2);
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State실패_대사용(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패_대사용 : TriggerState {
            internal State실패_대사용(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11003533, illust: "Bliche_normal", duration: 5000, script: "$02020061_BF__MAIN__8$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State성공 : TriggerState {
            internal State성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FieldWarEnd(isClear: true);
                context.SetAchievement(arg2: "trigger", arg3: "FieldwarAchieve_1");
            }

            public override TriggerState Execute() {
                return new State종료(context);
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FieldWarEnd(isClear: false);
            }

            public override TriggerState Execute() {
                return new State종료(context);
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}