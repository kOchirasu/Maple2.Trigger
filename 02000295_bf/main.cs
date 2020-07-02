namespace Maple2.Trigger._02000295_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 3000, arg2: false, arg3: false);
                context.SetLadder(arg1: 3001, arg2: false, arg3: false);
                context.SetLadder(arg1: 3002, arg2: false, arg3: false);
                context.SetLadder(arg1: 3003, arg2: false, arg3: false);
                context.SetLadder(arg1: 3004, arg2: false, arg3: false);
                context.DestroyMonster(arg1: new[] {910, 911, 912, 913, 914, 915, 916, 917});
                context.CreateMonster(arg1: new[] {4100}, arg2: false);
                context.DestroyMonster(arg1: new[] {4101});
                context.CreateMonster(arg1: new[] {900, 901, 902, 800, 801, 802, 803, 804, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331}, arg2: true);
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, arg2: true);
                context.SetEffect(arg1: new[] {5000, 5001, 5002, 5100, 5101, 5102, 5103}, arg2: false);
                context.SetBreakable(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {95001, 95002, 95003, 95004, 95005, 95006, 2000, 2001, 2002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212, 1213, 1214, 1215, 1216, 1217, 1218, 1219, 1220, 1221, 1222, 1223, 1224, 1225, 1226, 1227, 1228, 1229, 1230, 1231, 1232, 1233, 1234, 1235, 1236, 1237, 1238, 1239, 1240, 1241, 1242, 1243, 1244, 1245, 1246}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145, 1146, 1147, 1148, 1149, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1159}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "LuminaArmyJoin", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpcMonologue01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue01 : TriggerState {
            internal StateNpcMonologue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
                context.SetSkip(arg1: "CameraWalk02");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpcMonologue02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue02 : TriggerState {
            internal StateNpcMonologue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$02000295_BF__MAIN__0$", arg4: 3, arg5: 0);
                context.SetSkip(arg1: "CameraWalk02");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraWalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetSkip(arg1: "CameraWalk02");
                context.AddBalloonTalk(spawnPointId: 301, msg: "$02000295_BF__MAIN__1$", duration: 3000, delayTick: 2000);
                context.AddBalloonTalk(spawnPointId: 310, msg: "$02000295_BF__MAIN__2$", duration: 3000, delayTick: 2000);
                context.AddBalloonTalk(spawnPointId: 318, msg: "$02000295_BF__MAIN__3$", duration: 3000, delayTick: 3000);
                context.AddBalloonTalk(spawnPointId: 316, msg: "$02000295_BF__MAIN__4$", duration: 3000, delayTick: 3000);
                context.AddBalloonTalk(spawnPointId: 307, msg: "$02000295_BF__MAIN__5$", duration: 3000, delayTick: 4000);
                context.AddBalloonTalk(spawnPointId: 312, msg: "$02000295_BF__MAIN__6$", duration: 3000, delayTick: 4000);
                context.AddBalloonTalk(spawnPointId: 305, msg: "$02000295_BF__MAIN__7$", duration: 3000, delayTick: 5000);
                context.AddBalloonTalk(spawnPointId: 314, msg: "$02000295_BF__MAIN__8$", duration: 3000, delayTick: 5000);
                context.AddBalloonTalk(spawnPointId: 325, msg: "$02000295_BF__MAIN__9$", duration: 3000, delayTick: 2000);
                context.AddBalloonTalk(spawnPointId: 323, msg: "$02000295_BF__MAIN__10$", duration: 3000, delayTick: 2000);
                context.AddBalloonTalk(spawnPointId: 323, msg: "$02000295_BF__MAIN__11$", duration: 3000, delayTick: 3000);
                context.AddBalloonTalk(spawnPointId: 327, msg: "$02000295_BF__MAIN__12$", duration: 3000, delayTick: 4000);
                context.AddBalloonTalk(spawnPointId: 330, msg: "$02000295_BF__MAIN__13$", duration: 3000, delayTick: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateCameraWalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk02 : TriggerState {
            internal StateCameraWalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 601, arg2: false);
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCameraWalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk03 : TriggerState {
            internal StateCameraWalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetLadder(arg1: 3000, arg2: true, arg3: true, arg4: 10);
                context.SetLadder(arg1: 3001, arg2: true, arg3: true, arg4: 12);
                context.SetMesh(arg1: new[] {2000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetSkip(arg1: "CameraWalk05");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraWalk04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk04 : TriggerState {
            internal StateCameraWalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$02000295_BF__MAIN__14$", arg4: 3, arg5: 1);
                context.SetSkip(arg1: "CameraWalk05");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCameraWalk05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk05 : TriggerState {
            internal StateCameraWalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_202");
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$02000295_BF__MAIN__15$", arg4: 5, arg5: 0);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 600, arg2: false);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002952, textId: 20002952, duration: 3000);
                context.SetEffect(arg1: new[] {5000, 5001, 5002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    return new StateBattleReady01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleReady01 : TriggerState {
            internal StateBattleReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002951, textId: 20002951, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTrigger01웨이브(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger01웨이브 : TriggerState {
            internal StateTrigger01웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000, 5001, 5002}, arg2: false);
                context.SetMesh(arg1: new[] {95001, 95002, 95003, 95004, 95005, 95006}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.CreateMonster(arg1: new[] {910, 911}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTrigger02웨이브(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger02웨이브 : TriggerState {
            internal StateTrigger02웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {912, 913}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateTrigger03웨이브(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger03웨이브 : TriggerState {
            internal StateTrigger03웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {914, 915}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateTrigger04웨이브(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger04웨이브 : TriggerState {
            internal StateTrigger04웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {916, 917}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {910, 911, 912, 913, 914, 915, 916, 917})) {
                    return new StateBossAct01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossAct01 : TriggerState {
            internal StateBossAct01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossAct02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossAct02 : TriggerState {
            internal StateBossAct02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 603, arg2: true);
                context.SetEffect(arg1: new[] {5103}, arg2: true);
                context.SetSkip(arg1: "BossAct03");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBossAct03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossAct03 : TriggerState {
            internal StateBossAct03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 603, arg2: false);
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattle01 : TriggerState {
            internal StateBossBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {4100});
                context.CreateMonster(arg1: new[] {4101}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "LuminaArmyJoin") == 1) {
                    return new StateBossBattle02(context);
                }

                if (context.MonsterDead(arg1: new[] {4101})) {
                    return new StateBossBattle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattle02 : TriggerState {
            internal StateBossBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8010, 8011, 8012}, arg2: false);
                context.DestroyMonster(arg1: new[] {900, 901, 902});
                context.ChangeMonster(arg1: 800, arg2: 810);
                context.ChangeMonster(arg1: 801, arg2: 811);
                context.ChangeMonster(arg1: 802, arg2: 812);
                context.ChangeMonster(arg1: 803, arg2: 813);
                context.ChangeMonster(arg1: 804, arg2: 814);
                context.ChangeMonster(arg1: 202, arg2: 203);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBossBattle03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattle03 : TriggerState {
            internal StateBossBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 810, arg2: "MS2PatrolData_800");
                context.MoveNpc(arg1: 811, arg2: "MS2PatrolData_801");
                context.MoveNpc(arg1: 812, arg2: "MS2PatrolData_802");
                context.MoveNpc(arg1: 813, arg2: "MS2PatrolData_803");
                context.MoveNpc(arg1: 814, arg2: "MS2PatrolData_804");
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_203");
                context.SetConversation(arg1: 1, arg2: 203, arg3: "$02000295_BF__MAIN__16$", arg4: 3, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 203, arg3: "$02000295_BF__MAIN__17$", arg4: 4, arg5: 7);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {4101})) {
                    return new StateBattleEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd01 : TriggerState {
            internal StateBattleEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8003, 8004, 8005, 8006, 8007, 8008, 8009}, arg2: false);
                context.SetMesh(arg1: new[] {95001, 95002, 95003, 95004, 95005, 95006}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_204");
                context.SetConversation(arg1: 1, arg2: 203, arg3: "$02000295_BF__MAIN__18$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBattleEnd02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd02 : TriggerState {
            internal StateBattleEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBattleEnd03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd03 : TriggerState {
            internal StateBattleEnd03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000295, arg2: 3, arg3: 9000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateReleaseSlaves01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReleaseSlaves01 : TriggerState {
            internal StateReleaseSlaves01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 602, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReleaseSlaves02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReleaseSlaves02 : TriggerState {
            internal StateReleaseSlaves02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212, 1213, 1214, 1215, 1216, 1217, 1218, 1219, 1220, 1221, 1222, 1223, 1224, 1225, 1226, 1227, 1228, 1229, 1230, 1231, 1232, 1233, 1234, 1235, 1236, 1237, 1238, 1239, 1240, 1241, 1242, 1243, 1244, 1245, 1246}, arg2: true, arg3: 200, arg4: 30, arg5: 2f);
                context.SetEffect(arg1: new[] {5100, 5101}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReleaseSlaves03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReleaseSlaves03 : TriggerState {
            internal StateReleaseSlaves03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145, 1146, 1147, 1148, 1149, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1159}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetBreakable(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229}, arg2: true);
                context.ChangeMonster(arg1: 301, arg2: 401);
                context.ChangeMonster(arg1: 302, arg2: 402);
                context.ChangeMonster(arg1: 303, arg2: 403);
                context.ChangeMonster(arg1: 304, arg2: 404);
                context.ChangeMonster(arg1: 305, arg2: 405);
                context.ChangeMonster(arg1: 306, arg2: 406);
                context.ChangeMonster(arg1: 307, arg2: 407);
                context.ChangeMonster(arg1: 308, arg2: 408);
                context.ChangeMonster(arg1: 309, arg2: 409);
                context.ChangeMonster(arg1: 310, arg2: 410);
                context.ChangeMonster(arg1: 311, arg2: 411);
                context.ChangeMonster(arg1: 312, arg2: 412);
                context.ChangeMonster(arg1: 313, arg2: 413);
                context.ChangeMonster(arg1: 314, arg2: 414);
                context.ChangeMonster(arg1: 315, arg2: 415);
                context.ChangeMonster(arg1: 316, arg2: 416);
                context.ChangeMonster(arg1: 317, arg2: 417);
                context.ChangeMonster(arg1: 318, arg2: 418);
                context.ChangeMonster(arg1: 320, arg2: 420);
                context.ChangeMonster(arg1: 321, arg2: 421);
                context.ChangeMonster(arg1: 322, arg2: 422);
                context.ChangeMonster(arg1: 323, arg2: 423);
                context.ChangeMonster(arg1: 324, arg2: 424);
                context.ChangeMonster(arg1: 325, arg2: 425);
                context.ChangeMonster(arg1: 326, arg2: 426);
                context.ChangeMonster(arg1: 327, arg2: 427);
                context.ChangeMonster(arg1: 328, arg2: 428);
                context.ChangeMonster(arg1: 329, arg2: 429);
                context.ChangeMonster(arg1: 330, arg2: 430);
                context.ChangeMonster(arg1: 331, arg2: 431);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateReleaseSlaves04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReleaseSlaves04 : TriggerState {
            internal StateReleaseSlaves04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetEffect(arg1: new[] {5100}, arg2: false);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_301");
                context.MoveNpc(arg1: 402, arg2: "MS2PatrolData_302");
                context.MoveNpc(arg1: 403, arg2: "MS2PatrolData_303");
                context.MoveNpc(arg1: 404, arg2: "MS2PatrolData_304");
                context.MoveNpc(arg1: 405, arg2: "MS2PatrolData_305");
                context.MoveNpc(arg1: 406, arg2: "MS2PatrolData_306");
                context.MoveNpc(arg1: 407, arg2: "MS2PatrolData_307");
                context.MoveNpc(arg1: 408, arg2: "MS2PatrolData_308");
                context.MoveNpc(arg1: 409, arg2: "MS2PatrolData_309");
                context.MoveNpc(arg1: 410, arg2: "MS2PatrolData_310");
                context.MoveNpc(arg1: 411, arg2: "MS2PatrolData_311");
                context.MoveNpc(arg1: 412, arg2: "MS2PatrolData_312");
                context.MoveNpc(arg1: 413, arg2: "MS2PatrolData_313");
                context.MoveNpc(arg1: 414, arg2: "MS2PatrolData_314");
                context.MoveNpc(arg1: 415, arg2: "MS2PatrolData_315");
                context.MoveNpc(arg1: 416, arg2: "MS2PatrolData_316");
                context.MoveNpc(arg1: 417, arg2: "MS2PatrolData_317");
                context.MoveNpc(arg1: 418, arg2: "MS2PatrolData_318");
                context.MoveNpc(arg1: 420, arg2: "MS2PatrolData_320");
                context.MoveNpc(arg1: 421, arg2: "MS2PatrolData_321");
                context.MoveNpc(arg1: 422, arg2: "MS2PatrolData_322");
                context.MoveNpc(arg1: 423, arg2: "MS2PatrolData_323");
                context.MoveNpc(arg1: 424, arg2: "MS2PatrolData_324");
                context.MoveNpc(arg1: 425, arg2: "MS2PatrolData_325");
                context.MoveNpc(arg1: 426, arg2: "MS2PatrolData_326");
                context.MoveNpc(arg1: 427, arg2: "MS2PatrolData_327");
                context.MoveNpc(arg1: 428, arg2: "MS2PatrolData_328");
                context.MoveNpc(arg1: 429, arg2: "MS2PatrolData_329");
                context.MoveNpc(arg1: 430, arg2: "MS2PatrolData_330");
                context.MoveNpc(arg1: 431, arg2: "MS2PatrolData_331");
                context.SetConversation(arg1: 1, arg2: 402, arg3: "$02000295_BF__MAIN__19$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 410, arg3: "$02000295_BF__MAIN__20$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 418, arg3: "$02000295_BF__MAIN__21$", arg4: 3, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 416, arg3: "$02000295_BF__MAIN__22$", arg4: 2, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 407, arg3: "$02000295_BF__MAIN__23$", arg4: 3, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 412, arg3: "$02000295_BF__MAIN__24$", arg4: 3, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 405, arg3: "$02000295_BF__MAIN__25$", arg4: 3, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 414, arg3: "$02000295_BF__MAIN__26$", arg4: 3, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 425, arg3: "$02000295_BF__MAIN__27$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 421, arg3: "$02000295_BF__MAIN__28$", arg4: 3, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 424, arg3: "$02000295_BF__MAIN__29$", arg4: 3, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 427, arg3: "$02000295_BF__MAIN__30$", arg4: 3, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 430, arg3: "$02000295_BF__MAIN__31$", arg4: 3, arg5: 3);
                context.SetSkip(arg1: "ReleaseSlaves05");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateReleaseSlaves05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReleaseSlaves05 : TriggerState {
            internal StateReleaseSlaves05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.CreateMonster(arg1: new[] {200}, arg2: true);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_199");
                context.CameraSelect(arg1: 602, arg2: false);
                context.CameraSelect(arg1: 603, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateToBeContinued01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToBeContinued01 : TriggerState {
            internal StateToBeContinued01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$02000295_BF__MAIN__32$", arg4: 4);
                context.SetSkip(arg1: "Quit01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.RemoveBalloonTalk(spawnPointId: 200);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 603, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "ReleaseTheSlaves");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit03 : TriggerState {
            internal StateQuit03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "ClearKatramusfirst");
                context.SetLadder(arg1: 3002, arg2: true, arg3: true, arg4: 10);
                context.SetLadder(arg1: 3003, arg2: true, arg3: true, arg4: 12);
                context.SetLadder(arg1: 3004, arg2: true, arg3: true, arg4: 14);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.DungeonClear();
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}