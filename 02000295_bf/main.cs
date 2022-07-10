namespace Maple2.Trigger._02000295_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 3000, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 3001, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 3002, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 3003, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 3004, visible: false, animationEffect: false);
                context.DestroyMonster(spawnIds: new []{910, 911, 912, 913, 914, 915, 916, 917});
                context.CreateMonster(spawnIds: new []{4100}, arg2: false);
                context.DestroyMonster(spawnIds: new []{4101});
                context.CreateMonster(spawnIds: new []{900, 901, 902, 800, 801, 802, 803, 804, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331}, arg2: true);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, visible: true);
                context.SetEffect(triggerIds: new []{5000, 5001, 5002, 5100, 5101, 5102, 5103}, visible: false);
                context.SetBreakable(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229}, arg2: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{95001, 95002, 95003, 95004, 95005, 95006, 2000, 2001, 2002}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212, 1213, 1214, 1215, 1216, 1217, 1218, 1219, 1220, 1221, 1222, 1223, 1224, 1225, 1226, 1227, 1228, 1229, 1230, 1231, 1232, 1233, 1234, 1235, 1236, 1237, 1238, 1239, 1240, 1241, 1242, 1243, 1244, 1245, 1246}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145, 1146, 1147, 1148, 1149, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1159}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "LuminaArmyJoin", value: 0);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_201");
                context.SetSkip(state: new StateCameraWalk02(context));
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 1, spawnId: 201, script: "$02000295_BF__MAIN__0$", arg4: 3, arg5: 0);
                context.SetSkip(state: new StateCameraWalk02(context));
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 601, enable: true);
                context.SetSkip(state: new StateCameraWalk02(context));
                context.AddBalloonTalk(spawnId: 301, msg: "$02000295_BF__MAIN__1$", duration: 3000, delayTick: 2000);
                context.AddBalloonTalk(spawnId: 310, msg: "$02000295_BF__MAIN__2$", duration: 3000, delayTick: 2000);
                context.AddBalloonTalk(spawnId: 318, msg: "$02000295_BF__MAIN__3$", duration: 3000, delayTick: 3000);
                context.AddBalloonTalk(spawnId: 316, msg: "$02000295_BF__MAIN__4$", duration: 3000, delayTick: 3000);
                context.AddBalloonTalk(spawnId: 307, msg: "$02000295_BF__MAIN__5$", duration: 3000, delayTick: 4000);
                context.AddBalloonTalk(spawnId: 312, msg: "$02000295_BF__MAIN__6$", duration: 3000, delayTick: 4000);
                context.AddBalloonTalk(spawnId: 305, msg: "$02000295_BF__MAIN__7$", duration: 3000, delayTick: 5000);
                context.AddBalloonTalk(spawnId: 314, msg: "$02000295_BF__MAIN__8$", duration: 3000, delayTick: 5000);
                context.AddBalloonTalk(spawnId: 325, msg: "$02000295_BF__MAIN__9$", duration: 3000, delayTick: 2000);
                context.AddBalloonTalk(spawnId: 323, msg: "$02000295_BF__MAIN__10$", duration: 3000, delayTick: 2000);
                context.AddBalloonTalk(spawnId: 323, msg: "$02000295_BF__MAIN__11$", duration: 3000, delayTick: 3000);
                context.AddBalloonTalk(spawnId: 327, msg: "$02000295_BF__MAIN__12$", duration: 3000, delayTick: 4000);
                context.AddBalloonTalk(spawnId: 330, msg: "$02000295_BF__MAIN__13$", duration: 3000, delayTick: 5000);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 601, enable: false);
                context.DestroyMonster(spawnIds: new []{201});
                context.CreateMonster(spawnIds: new []{202}, arg2: false);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetLadder(triggerId: 3000, visible: true, animationEffect: true, animationDelay: 10);
                context.SetLadder(triggerId: 3001, visible: true, animationEffect: true, animationDelay: 12);
                context.SetMesh(triggerIds: new []{2000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CameraSelect(triggerId: 600, enable: true);
                context.SetSkip(state: new StateCameraWalk05(context));
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 1, spawnId: 202, script: "$02000295_BF__MAIN__14$", arg4: 3, arg5: 1);
                context.SetSkip(state: new StateCameraWalk05(context));
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_202");
                context.SetConversation(type: 1, spawnId: 202, script: "$02000295_BF__MAIN__15$", arg4: 5, arg5: 0);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 600, enable: false);
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002952, textId: 20002952, duration: 3000);
                context.SetEffect(triggerIds: new []{5000, 5001, 5002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateBattleReady01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleReady01 : TriggerState {
            internal StateBattleReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9000}, sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002951, textId: 20002951, duration: 5000);
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{5000, 5001, 5002}, visible: false);
                context.SetMesh(triggerIds: new []{95001, 95002, 95003, 95004, 95005, 95006}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.CreateMonster(spawnIds: new []{910, 911}, arg2: true);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{912, 913}, arg2: true);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{914, 915}, arg2: true);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{916, 917}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{910, 911, 912, 913, 914, 915, 916, 917})) {
                    return new StateBossAct01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossAct01 : TriggerState {
            internal StateBossAct01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 603, enable: true);
                context.SetEffect(triggerIds: new []{5103}, visible: true);
                context.SetSkip(state: new StateBossAct03(context));
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 603, enable: false);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{4100});
                context.CreateMonster(spawnIds: new []{4101}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "LuminaArmyJoin") == 1) {
                    return new StateBossBattle02(context);
                }

                if (context.MonsterDead(spawnIds: new []{4101})) {
                    return new StateBossBattle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattle02 : TriggerState {
            internal StateBossBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8010, 8011, 8012}, visible: false);
                context.DestroyMonster(spawnIds: new []{900, 901, 902});
                context.ChangeMonster(removeSpawnId: 800, addSpawnId: 810);
                context.ChangeMonster(removeSpawnId: 801, addSpawnId: 811);
                context.ChangeMonster(removeSpawnId: 802, addSpawnId: 812);
                context.ChangeMonster(removeSpawnId: 803, addSpawnId: 813);
                context.ChangeMonster(removeSpawnId: 804, addSpawnId: 814);
                context.ChangeMonster(removeSpawnId: 202, addSpawnId: 203);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 810, patrolName: "MS2PatrolData_800");
                context.MoveNpc(spawnId: 811, patrolName: "MS2PatrolData_801");
                context.MoveNpc(spawnId: 812, patrolName: "MS2PatrolData_802");
                context.MoveNpc(spawnId: 813, patrolName: "MS2PatrolData_803");
                context.MoveNpc(spawnId: 814, patrolName: "MS2PatrolData_804");
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_203");
                context.SetConversation(type: 1, spawnId: 203, script: "$02000295_BF__MAIN__16$", arg4: 3, arg5: 3);
                context.SetConversation(type: 1, spawnId: 203, script: "$02000295_BF__MAIN__17$", arg4: 4, arg5: 7);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4101})) {
                    return new StateBattleEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd01 : TriggerState {
            internal StateBattleEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8003, 8004, 8005, 8006, 8007, 8008, 8009}, visible: false);
                context.SetMesh(triggerIds: new []{95001, 95002, 95003, 95004, 95005, 95006}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_204");
                context.SetConversation(type: 1, spawnId: 203, script: "$02000295_BF__MAIN__18$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 02000295, portalId: 3, boxId: 9000);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 602, enable: true);
            }

            public override TriggerState? Execute() {
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
                context.SetMesh(triggerIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212, 1213, 1214, 1215, 1216, 1217, 1218, 1219, 1220, 1221, 1222, 1223, 1224, 1225, 1226, 1227, 1228, 1229, 1230, 1231, 1232, 1233, 1234, 1235, 1236, 1237, 1238, 1239, 1240, 1241, 1242, 1243, 1244, 1245, 1246}, visible: true, arg3: 200, arg4: 30, arg5: 2f);
                context.SetEffect(triggerIds: new []{5100, 5101}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.SetMesh(triggerIds: new []{1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145, 1146, 1147, 1148, 1149, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1159}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetBreakable(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229}, arg2: true);
                context.ChangeMonster(removeSpawnId: 301, addSpawnId: 401);
                context.ChangeMonster(removeSpawnId: 302, addSpawnId: 402);
                context.ChangeMonster(removeSpawnId: 303, addSpawnId: 403);
                context.ChangeMonster(removeSpawnId: 304, addSpawnId: 404);
                context.ChangeMonster(removeSpawnId: 305, addSpawnId: 405);
                context.ChangeMonster(removeSpawnId: 306, addSpawnId: 406);
                context.ChangeMonster(removeSpawnId: 307, addSpawnId: 407);
                context.ChangeMonster(removeSpawnId: 308, addSpawnId: 408);
                context.ChangeMonster(removeSpawnId: 309, addSpawnId: 409);
                context.ChangeMonster(removeSpawnId: 310, addSpawnId: 410);
                context.ChangeMonster(removeSpawnId: 311, addSpawnId: 411);
                context.ChangeMonster(removeSpawnId: 312, addSpawnId: 412);
                context.ChangeMonster(removeSpawnId: 313, addSpawnId: 413);
                context.ChangeMonster(removeSpawnId: 314, addSpawnId: 414);
                context.ChangeMonster(removeSpawnId: 315, addSpawnId: 415);
                context.ChangeMonster(removeSpawnId: 316, addSpawnId: 416);
                context.ChangeMonster(removeSpawnId: 317, addSpawnId: 417);
                context.ChangeMonster(removeSpawnId: 318, addSpawnId: 418);
                context.ChangeMonster(removeSpawnId: 320, addSpawnId: 420);
                context.ChangeMonster(removeSpawnId: 321, addSpawnId: 421);
                context.ChangeMonster(removeSpawnId: 322, addSpawnId: 422);
                context.ChangeMonster(removeSpawnId: 323, addSpawnId: 423);
                context.ChangeMonster(removeSpawnId: 324, addSpawnId: 424);
                context.ChangeMonster(removeSpawnId: 325, addSpawnId: 425);
                context.ChangeMonster(removeSpawnId: 326, addSpawnId: 426);
                context.ChangeMonster(removeSpawnId: 327, addSpawnId: 427);
                context.ChangeMonster(removeSpawnId: 328, addSpawnId: 428);
                context.ChangeMonster(removeSpawnId: 329, addSpawnId: 429);
                context.ChangeMonster(removeSpawnId: 330, addSpawnId: 430);
                context.ChangeMonster(removeSpawnId: 331, addSpawnId: 431);
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetEffect(triggerIds: new []{5100}, visible: false);
                context.MoveNpc(spawnId: 401, patrolName: "MS2PatrolData_301");
                context.MoveNpc(spawnId: 402, patrolName: "MS2PatrolData_302");
                context.MoveNpc(spawnId: 403, patrolName: "MS2PatrolData_303");
                context.MoveNpc(spawnId: 404, patrolName: "MS2PatrolData_304");
                context.MoveNpc(spawnId: 405, patrolName: "MS2PatrolData_305");
                context.MoveNpc(spawnId: 406, patrolName: "MS2PatrolData_306");
                context.MoveNpc(spawnId: 407, patrolName: "MS2PatrolData_307");
                context.MoveNpc(spawnId: 408, patrolName: "MS2PatrolData_308");
                context.MoveNpc(spawnId: 409, patrolName: "MS2PatrolData_309");
                context.MoveNpc(spawnId: 410, patrolName: "MS2PatrolData_310");
                context.MoveNpc(spawnId: 411, patrolName: "MS2PatrolData_311");
                context.MoveNpc(spawnId: 412, patrolName: "MS2PatrolData_312");
                context.MoveNpc(spawnId: 413, patrolName: "MS2PatrolData_313");
                context.MoveNpc(spawnId: 414, patrolName: "MS2PatrolData_314");
                context.MoveNpc(spawnId: 415, patrolName: "MS2PatrolData_315");
                context.MoveNpc(spawnId: 416, patrolName: "MS2PatrolData_316");
                context.MoveNpc(spawnId: 417, patrolName: "MS2PatrolData_317");
                context.MoveNpc(spawnId: 418, patrolName: "MS2PatrolData_318");
                context.MoveNpc(spawnId: 420, patrolName: "MS2PatrolData_320");
                context.MoveNpc(spawnId: 421, patrolName: "MS2PatrolData_321");
                context.MoveNpc(spawnId: 422, patrolName: "MS2PatrolData_322");
                context.MoveNpc(spawnId: 423, patrolName: "MS2PatrolData_323");
                context.MoveNpc(spawnId: 424, patrolName: "MS2PatrolData_324");
                context.MoveNpc(spawnId: 425, patrolName: "MS2PatrolData_325");
                context.MoveNpc(spawnId: 426, patrolName: "MS2PatrolData_326");
                context.MoveNpc(spawnId: 427, patrolName: "MS2PatrolData_327");
                context.MoveNpc(spawnId: 428, patrolName: "MS2PatrolData_328");
                context.MoveNpc(spawnId: 429, patrolName: "MS2PatrolData_329");
                context.MoveNpc(spawnId: 430, patrolName: "MS2PatrolData_330");
                context.MoveNpc(spawnId: 431, patrolName: "MS2PatrolData_331");
                context.SetConversation(type: 1, spawnId: 402, script: "$02000295_BF__MAIN__19$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 410, script: "$02000295_BF__MAIN__20$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 418, script: "$02000295_BF__MAIN__21$", arg4: 3, arg5: 1);
                context.SetConversation(type: 1, spawnId: 416, script: "$02000295_BF__MAIN__22$", arg4: 2, arg5: 2);
                context.SetConversation(type: 1, spawnId: 407, script: "$02000295_BF__MAIN__23$", arg4: 3, arg5: 2);
                context.SetConversation(type: 1, spawnId: 412, script: "$02000295_BF__MAIN__24$", arg4: 3, arg5: 3);
                context.SetConversation(type: 1, spawnId: 405, script: "$02000295_BF__MAIN__25$", arg4: 3, arg5: 3);
                context.SetConversation(type: 1, spawnId: 414, script: "$02000295_BF__MAIN__26$", arg4: 3, arg5: 3);
                context.SetConversation(type: 1, spawnId: 425, script: "$02000295_BF__MAIN__27$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 421, script: "$02000295_BF__MAIN__28$", arg4: 3, arg5: 1);
                context.SetConversation(type: 1, spawnId: 424, script: "$02000295_BF__MAIN__29$", arg4: 3, arg5: 2);
                context.SetConversation(type: 1, spawnId: 427, script: "$02000295_BF__MAIN__30$", arg4: 3, arg5: 2);
                context.SetConversation(type: 1, spawnId: 430, script: "$02000295_BF__MAIN__31$", arg4: 3, arg5: 3);
                context.SetSkip(state: new StateReleaseSlaves05(context));
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{200}, arg2: true);
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_199");
                context.CameraSelect(triggerId: 602, enable: false);
                context.CameraSelect(triggerId: 603, enable: true);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 2, spawnId: 11000006, script: "$02000295_BF__MAIN__32$", arg4: 4);
                context.SetSkip(state: new StateQuit01(context));
            }

            public override TriggerState? Execute() {
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
                context.RemoveBalloonTalk(spawnId: 200);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 603, enable: false);
            }

            public override TriggerState? Execute() {
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
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "ReleaseTheSlaves");
            }

            public override TriggerState? Execute() {
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
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "ClearKatramusfirst");
                context.SetLadder(triggerId: 3002, visible: true, animationEffect: true, animationDelay: 10);
                context.SetLadder(triggerId: 3003, visible: true, animationEffect: true, animationDelay: 12);
                context.SetLadder(triggerId: 3004, visible: true, animationEffect: true, animationDelay: 14);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.DungeonClear();
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
