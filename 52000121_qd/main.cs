namespace Maple2.Trigger._52000121_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new[] {121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001563}, arg3: new byte[] {1})) {
                    return new StateSetupCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001563}, arg3: new byte[] {2})) {
                    return new StateFinal맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic : TriggerState {
            internal StateSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.SetSceneSkip(arg1: "전투직전_스킵완료", arg2: "nextState");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 2, arg2: 11003309, arg3: "$52000121_QD__MAIN__0$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_B", arg3: 4000f);
                context.SetSkip(state: new State오스칼Script01_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State투르카Script01(context);
            }

            public override void OnExit() { }
        }

        private class State투르카Script01 : TriggerState {
            internal State투르카Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003362, arg3: "$52000121_QD__MAIN__1$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Bore_B", arg3: 4000f);
                context.SetSkip(state: new State투르카Script01_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State마노비치Script01(context);
            }

            public override void OnExit() { }
        }

        private class State마노비치Script01 : TriggerState {
            internal State마노비치Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8022}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003308, arg3: "$52000121_QD__MAIN__2$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 3000f);
                context.SetSkip(state: new State마노비치Script01_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State투르카Script02(context);
            }

            public override void OnExit() { }
        }

        private class State투르카Script02 : TriggerState {
            internal State투르카Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8023}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003362, arg3: "$52000121_QD__MAIN__3$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3000f);
                context.SetSkip(state: new State투르카Script02_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State투르카Script03(context);
            }

            public override void OnExit() { }
        }

        private class State투르카Script03 : TriggerState {
            internal State투르카Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003362, arg3: "$52000121_QD__MAIN__4$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3000f);
                context.SetSkip(state: new State투르카Script03_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State오스칼Script02(context);
            }

            public override void OnExit() { }
        }

        private class State오스칼Script02 : TriggerState {
            internal State오스칼Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8021}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003309, arg3: "$52000121_QD__MAIN__5$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Attack_Idle_A", arg3: 4000f);
                context.SetSkip(state: new State오스칼Script02_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State투르카Script04(context);
            }

            public override void OnExit() { }
        }

        private class State투르카Script04 : TriggerState {
            internal State투르카Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8023}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003362, arg3: "$52000121_QD__MAIN__6$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(state: new State투르카Script04_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State아르마노열폭Prepare(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노열폭Prepare : TriggerState {
            internal State아르마노열폭Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8025}, arg2: false);
                context.FaceEmotion(spawnPointId: 104, emotionName: "Angry");
            }

            public override TriggerState Execute() {
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
                context.FaceEmotion(spawnPointId: 104, emotionName: "Angry");
                context.AddCinematicTalk(npcId: 11003364, msg: "$52000121_QD__MAIN__7$", duration: 2000, align: "left");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8024}, arg2: false);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_104_run");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8030}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101_Attack");
                context.AddCinematicTalk(npcId: 11003362, msg: "$52000121_QD__MAIN__8$", duration: 1000, align: "left");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8031}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Attack_02_B");
                context.SetNpcEmotionLoop(arg1: 104, arg2: "Run_A", arg3: 3000f);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8022}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Attack_Idle_A", arg3: 3000f);
                context.AddCinematicTalk(npcId: 11003308, msg: "$52000121_QD__MAIN__9$", duration: 1500, align: "left");
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {101, 102, 104});
                context.CreateMonster(arg1: new[] {105, 106}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8040}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Down_Idle_A", arg3: 30000f);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8041}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
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
                context.FaceEmotion(spawnPointId: 106, emotionName: "Cry");
                context.AddCinematicTalk(npcId: 11003364, msg: "$52000121_QD__MAIN__10$", duration: 1500, align: "left");
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Stun_A", arg3: 3000f);
                context.AddCinematicTalk(npcId: 11003309, illustId: "Oskhal_normal", msg: "$52000121_QD__MAIN__11$", duration: 2000, align: "left");
                context.SetSkip(state: new State오스칼멘붕_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State투르카Script05(context);
            }

            public override void OnExit() { }
        }

        private class State투르카Script05 : TriggerState {
            internal State투르카Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8035}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101_disappear_01");
                context.SetConversation(arg1: 2, arg2: 11003362, arg3: "$52000121_QD__MAIN__12$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State투르카Script05_skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePCAppearWait(context);
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

            public override TriggerState Execute() {
                return new StatePCAppearWait(context);
            }

            public override void OnExit() { }
        }

        private class StatePCAppearWait : TriggerState {
            internal StatePCAppearWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8036}, arg2: false);
                context.MoveUser(arg1: 52000121, arg2: 10);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101_disappear_02");
                context.SetConversation(arg1: 2, arg2: 11003362, arg3: "$52000121_QD__MAIN__13$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCAppear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCAppear : TriggerState {
            internal StatePCAppear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8034}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Run");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101_disappear_04");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000121_QD__MAIN__14$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8036}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003362, arg3: "$52000121_QD__MAIN__15$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101_disappear_03");
                context.SetConversation(arg1: 2, arg2: 11003362, arg3: "$52000121_QD__MAIN__16$", arg4: 2, arg5: 0);
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterAppear00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterAppear00 : TriggerState {
            internal StateMonsterAppear00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111}, arg2: true);
                context.DestroyMonster(arg1: new[] {101});
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterAppear01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterAppear01 : TriggerState {
            internal StateMonsterAppear01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8037}, arg2: false);
                context.DestroyMonster(arg1: new[] {103});
                context.CreateMonster(arg1: new[] {110}, arg2: true);
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterAppear02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterAppear02 : TriggerState {
            internal StateMonsterAppear02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8038}, arg2: false);
                context.CreateMonster(arg1: new[] {108}, arg2: true);
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterAppear03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterAppear03 : TriggerState {
            internal StateMonsterAppear03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8039}, arg2: false);
                context.CreateMonster(arg1: new[] {112}, arg2: true);
                context.SetSkip();
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
                context.CameraSelectPath(arg1: new[] {8036}, arg2: false);
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 108});
                context.CreateMonster(arg1: new[] {105, 106}, arg2: false);
                context.CreateMonster(arg1: new[] {108, 110, 111, 112}, arg2: true);
                context.MoveUser(arg1: 52000121, arg2: 10);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {110, 111, 112})) {
                    return new StateBattleStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart02 : TriggerState {
            internal StateBattleStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {113, 114, 115}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {113, 114, 115})) {
                    return new State전투끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투끝 : TriggerState {
            internal State전투끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8040}, arg2: false);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "ManovichMobKill");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {108});
                context.CreateMonster(arg1: new[] {103}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8040}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "마노비치리타이어_스킵완료", arg2: "exit");
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 2, arg2: 11003361, arg3: "$52000121_QD__MAIN__18$", arg4: 2, arg5: 0);
                context.SetSkip(state: new State마노비치Script03_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State아르마노Script01(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노Script01 : TriggerState {
            internal State아르마노Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8042}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003364, arg3: "$52000121_QD__MAIN__19$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State아르마노Script01_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State아르마노Script02(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노Script02 : TriggerState {
            internal State아르마노Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003364, arg3: "$52000121_QD__MAIN__20$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State아르마노Script02_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State마노비치Script04(context);
            }

            public override void OnExit() { }
        }

        private class State마노비치Script04 : TriggerState {
            internal State마노비치Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8041}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003361, arg3: "$52000121_QD__MAIN__21$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State마노비치Script04_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State마노비치Script05(context);
            }

            public override void OnExit() { }
        }

        private class State마노비치Script05 : TriggerState {
            internal State마노비치Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003361, arg3: "$52000121_QD__MAIN__22$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State마노비치Script05_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State마노비치Script06(context);
            }

            public override void OnExit() { }
        }

        private class State마노비치Script06 : TriggerState {
            internal State마노비치Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8046}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003361, arg3: "$52000121_QD__MAIN__23$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State마노비치Script06_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State마노비치Script07(context);
            }

            public override void OnExit() { }
        }

        private class State마노비치Script07 : TriggerState {
            internal State마노비치Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8043}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003361, arg3: "$52000121_QD__MAIN__24$", arg4: 2, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Event_02_A");
                context.SetSkip(state: new State마노비치Script07_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State마노비치Script08(context);
            }

            public override void OnExit() { }
        }

        private class State마노비치Script08 : TriggerState {
            internal State마노비치Script08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8047}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003361, arg3: "$52000121_QD__MAIN__25$", arg4: 2, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Event_03_A", arg3: 10000f);
                context.SetSkip(state: new State마노비치Script08_skip(context));
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new State마노비치죽음(context);
            }

            public override void OnExit() { }
        }

        private class State마노비치죽음 : TriggerState {
            internal State마노비치죽음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8044}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Event_04_A");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8050}, arg2: false);
                context.AddCinematicTalk(npcId: 11003364, msg: "$52000121_QD__MAIN__26$", duration: 4000, align: "left");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {108});
                context.CreateMonster(arg1: new[] {103}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "ManovichRetire");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 02000072, arg2: 1);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFinal맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}