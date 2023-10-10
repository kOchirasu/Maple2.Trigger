using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000121_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(spawnIds: new []{121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001563}, questStates: new byte[]{1})) {
                    return new StateSetupCinematic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001563}, questStates: new byte[]{2})) {
                    return new StateFinal맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic : TriggerState {
            internal StateSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State위기상황00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황00 : TriggerState {
            internal State위기상황00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.SetSceneSkip(state: new State전투직전_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new State위기상황01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황01 : TriggerState {
            internal State위기상황01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State위기상황02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황02 : TriggerState {
            internal State위기상황02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State위기상황03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황03 : TriggerState {
            internal State위기상황03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State위기상황04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위기상황04 : TriggerState {
            internal State위기상황04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State대치상황시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대치상황시작 : TriggerState {
            internal State대치상황시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8010}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State오스칼Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Script01 : TriggerState {
            internal State오스칼Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003309, script: "$52000121_QD__MAIN__0$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Talk_B", duration: 4000f);
                context.SetSkip(state: new State오스칼Script01_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State투르카Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Script01_skip : TriggerState {
            internal State오스칼Script01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State투르카Script01(context);
            }

            public override void OnExit() { }
        }

        private class State투르카Script01 : TriggerState {
            internal State투르카Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003362, script: "$52000121_QD__MAIN__1$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Bore_B", duration: 4000f);
                context.SetSkip(state: new State투르카Script01_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State마노비치Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Script01_skip : TriggerState {
            internal State투르카Script01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State마노비치Script01(context);
            }

            public override void OnExit() { }
        }

        private class State마노비치Script01 : TriggerState {
            internal State마노비치Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8022}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003308, script: "$52000121_QD__MAIN__2$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 3000f);
                context.SetSkip(state: new State마노비치Script01_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State투르카Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마노비치Script01_skip : TriggerState {
            internal State마노비치Script01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State투르카Script02(context);
            }

            public override void OnExit() { }
        }

        private class State투르카Script02 : TriggerState {
            internal State투르카Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8023}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003362, script: "$52000121_QD__MAIN__3$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3000f);
                context.SetSkip(state: new State투르카Script02_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State투르카Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Script02_skip : TriggerState {
            internal State투르카Script02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State투르카Script03(context);
            }

            public override void OnExit() { }
        }

        private class State투르카Script03 : TriggerState {
            internal State투르카Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003362, script: "$52000121_QD__MAIN__4$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3000f);
                context.SetSkip(state: new State투르카Script03_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오스칼Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Script03_skip : TriggerState {
            internal State투르카Script03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State오스칼Script02(context);
            }

            public override void OnExit() { }
        }

        private class State오스칼Script02 : TriggerState {
            internal State오스칼Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8021}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003309, script: "$52000121_QD__MAIN__5$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Attack_Idle_A", duration: 4000f);
                context.SetSkip(state: new State오스칼Script02_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State투르카Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Script02_skip : TriggerState {
            internal State오스칼Script02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State투르카Script04(context);
            }

            public override void OnExit() { }
        }

        private class State투르카Script04 : TriggerState {
            internal State투르카Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8023}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003362, script: "$52000121_QD__MAIN__6$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 4000f);
                context.SetSkip(state: new State투르카Script04_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아르마노열폭Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Script04_skip : TriggerState {
            internal State투르카Script04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State아르마노열폭Prepare(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노열폭Prepare : TriggerState {
            internal State아르마노열폭Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8025}, returnView: false);
                context.FaceEmotion(spawnId: 104, emotionName: "Angry");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아르마노열폭시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노열폭시작 : TriggerState {
            internal State아르마노열폭시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 104, emotionName: "Angry");
                context.AddCinematicTalk(npcId: 11003364, script: "$52000121_QD__MAIN__7$", duration: 2000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아르마노달려(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노달려 : TriggerState {
            internal State아르마노달려(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8024}, returnView: false);
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_104_run");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카공격00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격00 : TriggerState {
            internal State투르카공격00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8030}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101_Attack");
                context.AddCinematicTalk(npcId: 11003362, script: "$52000121_QD__MAIN__8$", duration: 1000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카공격01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격01 : TriggerState {
            internal State투르카공격01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8031}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Attack_02_B");
                context.SetNpcEmotionLoop(spawnId: 104, sequenceName: "Run_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마노비치Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마노비치Script02 : TriggerState {
            internal State마노비치Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8022}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Attack_Idle_A", duration: 3000f);
                context.AddCinematicTalk(npcId: 11003308, script: "$52000121_QD__MAIN__9$", duration: 1500, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리셋Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리셋Wait01 : TriggerState {
            internal State리셋Wait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 104});
                context.CreateMonster(spawnIds: new []{105, 106}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State리셋Wait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리셋Wait02 : TriggerState {
            internal State리셋Wait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8040}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 105, sequenceName: "Down_Idle_A", duration: 30000f);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State잠시후(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시후 : TriggerState {
            internal State잠시후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8041}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State불효자멘붕(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불효자멘붕 : TriggerState {
            internal State불효자멘붕(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 106, emotionName: "Cry");
                context.AddCinematicTalk(npcId: 11003364, script: "$52000121_QD__MAIN__10$", duration: 1500, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State오스칼멘붕(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼멘붕 : TriggerState {
            internal State오스칼멘붕(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Stun_A", duration: 3000f);
                context.AddCinematicTalk(npcId: 11003309, illustId: "Oskhal_normal", script: "$52000121_QD__MAIN__11$", duration: 2000, align: Align.Left);
                context.SetSkip(state: new State오스칼멘붕_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State투르카Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼멘붕_skip : TriggerState {
            internal State오스칼멘붕_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State투르카Script05(context);
            }

            public override void OnExit() { }
        }

        private class State투르카Script05 : TriggerState {
            internal State투르카Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8035}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101_disappear_01");
                context.SetConversation(type: 2, spawnId: 11003362, script: "$52000121_QD__MAIN__12$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State투르카Script05_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePCSpawnWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Script05_skip : TriggerState {
            internal State투르카Script05_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StatePCSpawnWait(context);
            }

            public override void OnExit() { }
        }

        private class StatePCSpawnWait : TriggerState {
            internal StatePCSpawnWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8036}, returnView: false);
                context.MoveUser(mapId: 52000121, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State투르카Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Script06 : TriggerState {
            internal State투르카Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101_disappear_02");
                context.SetConversation(type: 2, spawnId: 11003362, script: "$52000121_QD__MAIN__13$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCSpawn : TriggerState {
            internal StatePCSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8034}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_Run");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101_disappear_04");
                context.SetConversation(type: 1, spawnId: 0, script: "$52000121_QD__MAIN__14$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State투르카Script07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Script07 : TriggerState {
            internal State투르카Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8036}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003362, script: "$52000121_QD__MAIN__15$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State투르카Script08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Script08 : TriggerState {
            internal State투르카Script08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101_disappear_03");
                context.SetConversation(type: 2, spawnId: 11003362, script: "$52000121_QD__MAIN__16$", arg4: 2, arg5: 0);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn00 : TriggerState {
            internal StateMonsterSpawn00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111}, arg2: true);
                context.DestroyMonster(spawnIds: new []{101});
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01 : TriggerState {
            internal StateMonsterSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8037}, returnView: false);
                context.DestroyMonster(spawnIds: new []{103});
                context.CreateMonster(spawnIds: new []{110}, arg2: true);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn02 : TriggerState {
            internal StateMonsterSpawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8038}, returnView: false);
                context.CreateMonster(spawnIds: new []{108}, arg2: true);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn03 : TriggerState {
            internal StateMonsterSpawn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8039}, returnView: false);
                context.CreateMonster(spawnIds: new []{112}, arg2: true);
                context.SetSkip();
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWaitCombat01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투직전_스킵완료 : TriggerState {
            internal State전투직전_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.CameraSelectPath(pathIds: new []{8036}, returnView: false);
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 108});
                context.CreateMonster(spawnIds: new []{105, 106}, arg2: false);
                context.CreateMonster(spawnIds: new []{108, 110, 111, 112}, arg2: true);
                context.MoveUser(mapId: 52000121, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWaitCombat01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitCombat01 : TriggerState {
            internal StateWaitCombat01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Prepare01 : TriggerState {
            internal State전투Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{110, 111, 112})) {
                    return new StateBattleStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart02 : TriggerState {
            internal StateBattleStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{113, 114, 115}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{113, 114, 115})) {
                    return new State전투끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투끝 : TriggerState {
            internal State전투끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8040}, returnView: false);
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "ManovichMobKill");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State암전02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전02 : TriggerState {
            internal State암전02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpc교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc교체01 : TriggerState {
            internal StateNpc교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{108});
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아빠와아들Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아빠와아들Wait : TriggerState {
            internal State아빠와아들Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8040}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new State마노비치리타이어_스킵완료(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마노비치Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마노비치Script03 : TriggerState {
            internal State마노비치Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003361, script: "$52000121_QD__MAIN__18$", arg4: 2, arg5: 0);
                context.SetSkip(state: new State마노비치Script03_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아르마노Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마노비치Script03_skip : TriggerState {
            internal State마노비치Script03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State아르마노Script01(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노Script01 : TriggerState {
            internal State아르마노Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8042}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003364, script: "$52000121_QD__MAIN__19$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State아르마노Script01_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아르마노Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script01_skip : TriggerState {
            internal State아르마노Script01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State아르마노Script02(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노Script02 : TriggerState {
            internal State아르마노Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003364, script: "$52000121_QD__MAIN__20$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State아르마노Script02_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마노비치Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script02_skip : TriggerState {
            internal State아르마노Script02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State마노비치Script04(context);
            }

            public override void OnExit() { }
        }

        private class State마노비치Script04 : TriggerState {
            internal State마노비치Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8041}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003361, script: "$52000121_QD__MAIN__21$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State마노비치Script04_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마노비치Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마노비치Script04_skip : TriggerState {
            internal State마노비치Script04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State마노비치Script05(context);
            }

            public override void OnExit() { }
        }

        private class State마노비치Script05 : TriggerState {
            internal State마노비치Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003361, script: "$52000121_QD__MAIN__22$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State마노비치Script05_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마노비치Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마노비치Script05_skip : TriggerState {
            internal State마노비치Script05_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State마노비치Script06(context);
            }

            public override void OnExit() { }
        }

        private class State마노비치Script06 : TriggerState {
            internal State마노비치Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8046}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003361, script: "$52000121_QD__MAIN__23$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State마노비치Script06_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마노비치Script07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마노비치Script06_skip : TriggerState {
            internal State마노비치Script06_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State마노비치Script07(context);
            }

            public override void OnExit() { }
        }

        private class State마노비치Script07 : TriggerState {
            internal State마노비치Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8043}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003361, script: "$52000121_QD__MAIN__24$", arg4: 2, arg5: 0);
                context.SetNpcEmotionSequence(spawnId: 105, sequenceName: "Event_02_A");
                context.SetSkip(state: new State마노비치Script07_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마노비치Script08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마노비치Script07_skip : TriggerState {
            internal State마노비치Script07_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State마노비치Script08(context);
            }

            public override void OnExit() { }
        }

        private class State마노비치Script08 : TriggerState {
            internal State마노비치Script08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8047}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11003361, script: "$52000121_QD__MAIN__25$", arg4: 2, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 105, sequenceName: "Event_03_A", duration: 10000f);
                context.SetSkip(state: new State마노비치Script08_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마노비치죽음(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마노비치Script08_skip : TriggerState {
            internal State마노비치Script08_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State마노비치죽음(context);
            }

            public override void OnExit() { }
        }

        private class State마노비치죽음 : TriggerState {
            internal State마노비치죽음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8044}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 105, sequenceName: "Event_04_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State아르마노오열(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노오열 : TriggerState {
            internal State아르마노오열(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8050}, returnView: false);
                context.AddCinematicTalk(npcId: 11003364, script: "$52000121_QD__MAIN__26$", duration: 4000, align: Align.Left);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마노비치리타이어_스킵완료 : TriggerState {
            internal State마노비치리타이어_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.DestroyMonster(spawnIds: new []{108});
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "ManovichRetire");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFinal맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFinal맵이동 : TriggerState {
            internal StateFinal맵이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000072, portalId: 1);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFinal맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
