using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000069_qd {
    public static class _tria_bunker {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610}, visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019, 8020, 8021}, visible: true);
                context.CreateMonster(spawnIds: new []{1000, 1001, 1002, 1003, 1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1201, 1202, 1203, 2001, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetSceneSkip(state: new StateStopCinematic(context));
                    context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                    return new StateCamera이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동 : TriggerState {
            internal StateCamera이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enable: true);
                context.AddCinematicTalk(npcId: 11000064, illustId: "Lennon_normal", script: "$52000069_QD__TRIA_BUNKER__0$", duration: 9195, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.AddBuff(boxIds: new []{199}, skillId: 70000109, level: 1, arg4: false, arg5: false);
                context.CameraSelect(triggerId: 301, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003A");
                context.SetConversation(type: 1, spawnId: 1003, script: "$52000069_QD__TRIA_BUNKER__1$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new State2차Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차Cinematic : TriggerState {
            internal State2차Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 11100101, enable: true, path: @"BG/Common/Sound/Eff_Object_Devlin_Appear_01.xml ");
                context.SetNpcEmotionSequence(spawnId: 2001, sequenceName: "AttackReady_A");
                context.CameraSelect(triggerId: 302, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State프레이Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레이Script01 : TriggerState {
            internal State프레이Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 303, enable: true);
                context.SetNpcEmotionSequence(spawnId: 2003, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11000119, illustId: "Fray_serious", script: "$52000069_QD__TRIA_BUNKER__2$", duration: 4000, align: Align.Center);
                context.SetSceneSkip(state: new State대사스킵용01(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State돌격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사스킵용01 : TriggerState {
            internal State대사스킵용01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new State돌격(context);
            }

            public override void OnExit() { }
        }

        private class State돌격 : TriggerState {
            internal State돌격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraSelect(triggerId: 304, enable: true);
                context.SetAgent(triggerIds: new []{8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019, 8020, 8021}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReinforcementsWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReinforcementsWait : TriggerState {
            internal StateReinforcementsWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 304, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateReinforcementsSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReinforcementsSpawn : TriggerState {
            internal StateReinforcementsSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1201, 1202, 1203, 2101, 2102, 2103});
                context.CreateMonster(spawnIds: new []{1004, 1005, 1301, 1302, 1303, 1304}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateReinforcementsCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReinforcementsCinematic : TriggerState {
            internal StateReinforcementsCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddBuff(boxIds: new []{199}, skillId: 70000107, level: 1, arg4: false, arg5: false);
                context.CameraSelect(triggerId: 305, enable: true);
                context.SetConversation(type: 1, spawnId: 1004, script: "$52000069_QD__TRIA_BUNKER__3$", arg4: 4, arg5: 0);
                context.SetConversation(type: 1, spawnId: 1005, script: "$52000069_QD__TRIA_BUNKER__4$", arg4: 4, arg5: 0);
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_1004A");
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005A");
                context.MoveNpc(spawnId: 1301, patrolName: "MS2PatrolData_1301A");
                context.MoveNpc(spawnId: 1302, patrolName: "MS2PatrolData_1302A");
                context.MoveNpc(spawnId: 1303, patrolName: "MS2PatrolData_1303A");
                context.MoveNpc(spawnId: 1304, patrolName: "MS2PatrolData_1304A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateMissionWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMissionWait : TriggerState {
            internal StateMissionWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.RemoveBuff(boxId: 199, skillId: 70000107);
                context.CameraSelect(triggerId: 305, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new State데블린DeadDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State데블린DeadDelay : TriggerState {
            internal State데블린DeadDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateNPC교체(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체 : TriggerState {
            internal StateNPC교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52000069, portalId: 2);
                context.CreateMonster(spawnIds: new []{1006, 1007, 1009}, arg2: false);
                context.DestroyMonster(spawnIds: new []{1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1003, 1004, 1005, 1301, 1302, 1303, 1304, 2001, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에레브StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브StartCinematic : TriggerState {
            internal State에레브StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateNPC교체2(context), arg2: "nextState");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 306, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State에레브Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브Script01 : TriggerState {
            internal State에레브Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionSequence(spawnId: 1000, sequenceName: "Talk_A");
                context.SetSound(triggerId: 90000, arg2: true);
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52000069_QD__TRIA_BUNKER__5$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State에레브Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브Script02 : TriggerState {
            internal State에레브Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000064, script: "$52000069_QD__TRIA_BUNKER__6$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State에레브Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브Script03 : TriggerState {
            internal State에레브Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001975, script: "$52000069_QD__TRIA_BUNKER__7$", arg4: 4);
                context.SetOnetimeEffect(id: 1991, enable: true, path: @"BG/Common/Sound/Eff_Madria_TriaSeige_02_00001991.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에레브Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브Script04 : TriggerState {
            internal State에레브Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 90000, arg2: false);
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_surprise", script: "$52000069_QD__TRIA_BUNKER__8$", duration: 4000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State마드리아Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아Spawn : TriggerState {
            internal State마드리아Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.CameraSelect(triggerId: 307, enable: true);
                context.CreateMonster(spawnIds: new []{2000}, arg2: false, arg3: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State방향전환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방향전환 : TriggerState {
            internal State방향전환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{609}, visible: true);
                context.MoveNpc(spawnId: 1006, patrolName: "MS2PatrolData_1006A");
                context.MoveNpc(spawnId: 1007, patrolName: "MS2PatrolData_1007A");
                context.MoveNpc(spawnId: 1009, patrolName: "MS2PatrolData_1009A");
                context.MoveUserPath(patrolName: "MS2PatrolData_PCA");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State광역마법(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State광역마법 : TriggerState {
            internal State광역마법(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.MoveNpc(spawnId: 2000, patrolName: "MS2PatrolData_2000A");
                context.SetEffect(triggerIds: new []{609, 602, 603, 604, 605, 606}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State처맞음(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State처맞음 : TriggerState {
            internal State처맞음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetNpcEmotionSequence(spawnId: 1006, sequenceName: "Damg_A");
                context.SetNpcEmotionSequence(spawnId: 1007, sequenceName: "Damg_A");
                context.SetNpcEmotionSequence(spawnId: 1009, sequenceName: "Damg_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 250)) {
                    return new State쓰러짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쓰러짐 : TriggerState {
            internal State쓰러짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 1006, sequenceName: "Down_Idle_A", duration: 999999999f);
                context.SetNpcEmotionLoop(spawnId: 1007, sequenceName: "Down_Idle_A", duration: 999999999f);
                context.SetNpcEmotionLoop(spawnId: 1009, sequenceName: "Dead_Idle_A", duration: 999999999f);
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 12000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State쓰러짐2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쓰러짐2 : TriggerState {
            internal State쓰러짐2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1001, 1002});
                context.CameraSelect(triggerId: 309, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마드리아워킹(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아워킹 : TriggerState {
            internal State마드리아워킹(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 308, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마드리아오버숄더(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아오버숄더 : TriggerState {
            internal State마드리아오버숄더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001820, script: "$52000069_QD__TRIA_BUNKER__9$", arg4: 7);
                context.SetOnetimeEffect(id: 1992, enable: true, path: @"BG/Common/Sound/Eff_Madria_TriaSeige_03_00001992.xml");
                context.CameraSelect(triggerId: 310, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State마드리아공격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아공격 : TriggerState {
            internal State마드리아공격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000075, illustId: "Ereb_serious", script: "$52000069_QD__TRIA_BUNKER__10$", duration: 3000, align: Align.Center);
                context.CameraSelect(triggerId: 311, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State마드리아공격2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아공격2 : TriggerState {
            internal State마드리아공격2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001820, script: "$52000069_QD__TRIA_BUNKER__11$", arg4: 12);
                context.SetOnetimeEffect(id: 1993, enable: true, path: @"BG/Common/Sound/Eff_Madria_TriaSeige_04_00001993.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12500)) {
                    return new State마드리아공격3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아공격3 : TriggerState {
            internal State마드리아공격3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001820, script: "$52000069_QD__TRIA_BUNKER__12$", arg4: 11);
                context.SetOnetimeEffect(id: 1994, enable: true, path: @"BG/Common/Sound/Eff_Madria_TriaSeige_05_00001994.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11200)) {
                    return new State마드리아공격4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아공격4 : TriggerState {
            internal State마드리아공격4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001820, script: "$52000069_QD__TRIA_BUNKER__13$", arg4: 8);
                context.SetOnetimeEffect(id: 1995, enable: true, path: @"BG/Common/Sound/Eff_Madria_TriaSeige_06_00001995.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8100)) {
                    return new State마드리아공격5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아공격5 : TriggerState {
            internal State마드리아공격5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 1000, sequenceName: "Damg_A");
                context.CameraSelect(triggerId: 315, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에레브각성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브각성 : TriggerState {
            internal State에레브각성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{607}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State에레브각성2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브각성2 : TriggerState {
            internal State에레브각성2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 1000, sequenceName: "Damg_Idle_B", duration: 999999999f);
                context.CameraSelect(triggerId: 312, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마드리아놀람(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아놀람 : TriggerState {
            internal State마드리아놀람(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 314, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera눈속임(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera눈속임 : TriggerState {
            internal StateCamera눈속임(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 312, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State에레브Buff2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브Buff2 : TriggerState {
            internal State에레브Buff2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 313, enable: true);
                context.SetNpcEmotionSequence(spawnId: 1000, sequenceName: "Spell_A");
                context.SetOnetimeEffect(id: 02100287, enable: true, path: @"BG/Common/Sound/Eff_System_Chapter8_Destruction_of_Ereb_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State화이트아웃(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화이트아웃 : TriggerState {
            internal State화이트아웃(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{608}, visible: true);
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State마드리아Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아Script01 : TriggerState {
            internal State마드리아Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001820, script: "$52000069_QD__TRIA_BUNKER__14$", arg4: 7);
                context.SetOnetimeEffect(id: 1996, enable: true, path: @"BG/Common/Sound/Eff_Madria_TriaSeige_07_00001996.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State마드리아Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마드리아Script02 : TriggerState {
            internal State마드리아Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001820, script: "$52000069_QD__TRIA_BUNKER__15$", arg4: 3);
                context.SetOnetimeEffect(id: 1997, enable: true, path: @"BG/Common/Sound/Eff_Madria_TriaSeige_08_00001997.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateNPC교체2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체2 : TriggerState {
            internal StateNPC교체2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveBuff(boxId: 199, skillId: 70000109);
                context.SetEffect(triggerIds: new []{601, 607}, visible: false);
                context.SetPcEmotionSequence(sequenceNames: new []{"Idle_A"});
                context.DestroyMonster(spawnIds: new []{1000, 1006, 1007, 1009, 2000, 1001, 1002});
                context.MoveUser(mapId: 52000069, portalId: 2);
                context.CreateMonster(spawnIds: new []{1000, 1006, 1007, 1010, 1011, 1001, 1002, 9999}, arg2: false);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAchievement(triggerId: 91000, type: "trigger", code: "TriaSeigeClear");
                context.SetSound(triggerId: 90000, arg2: true);
                context.CameraSelect(triggerId: 313, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
