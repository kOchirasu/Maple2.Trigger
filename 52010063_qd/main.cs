using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010063_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 111, 112, 113, 114, 115}, arg2: false);
                context.DestroyMonster(arg1: new[] {211, 212, 213, 214, 215});
                context.SetEffect(arg1: new[] {6000, 6001, 6002, 6003, 6004, 6010, 6011}, arg2: false);
                context.SetMesh(arg1: new[] {4001, 4002, 4003, 4004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestConditionCheck : TriggerState {
            internal StateQuestConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000066}, arg3: new byte[] {3})) {
                    return new State맵이동_작전실로(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000066}, arg3: new byte[] {2})) {
                    return new State처치후_Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000066}, arg3: new byte[] {1})) {
                    return new State처치후_Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000065}, arg3: new byte[] {3})) {
                    return new State처치후_Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000065}, arg3: new byte[] {2})) {
                    return new State처치후_Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000065}, arg3: new byte[] {1})) {
                    return new State처치후_Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000064}, arg3: new byte[] {3})) {
                    return new State처치후_Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000064}, arg3: new byte[] {2})) {
                    return new State처치후_Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000064}, arg3: new byte[] {1})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State처치후_Wait : TriggerState {
            internal State처치후_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(arg1: new[] {101, 102, 111, 112, 113, 114, 115, 211, 212, 213, 214, 215, 221, 222, 223, 224, 225, 226});
                context.MoveUser(arg1: 52010063, arg2: 20);
                context.CreateMonster(arg1: new[] {103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State처치후(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State처치후 : TriggerState {
            internal State처치후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State맵이동_작전실로 : TriggerState {
            internal State맵이동_작전실로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 111, 112, 113, 114, 115, 211, 212, 213, 214, 215, 221, 222, 223, 224, 225, 226});
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUser(arg1: 52010052, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFinal맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State전투전스킵완료(context), arg2: "nextState");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Dead_A", arg3: 999999f);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Attack_02_D", arg3: 17000f);
                context.SetEffect(arg1: new[] {6000, 6003, 6001, 6002}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State인페르녹줌인00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹줌인00 : TriggerState {
            internal State인페르녹줌인00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State인페르녹줌인01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹줌인01 : TriggerState {
            internal State인페르녹줌인01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8000, 8001, 8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StatePC놀람01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC놀람01 : TriggerState {
            internal StatePC놀람01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC놀람02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC놀람02 : TriggerState {
            internal StatePC놀람02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52010063_QD__main__0$", duration: 3000, align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹줌인02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹줌인02 : TriggerState {
            internal State인페르녹줌인02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8004}, arg2: false);
                context.AddCinematicTalk(npcId: 11003832, illustId: "infernog_nomal", script: "$52010063_QD__main__1$", duration: 5000, align: Align.Right);
                context.SetEffect(arg1: new[] {6000, 6003}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Attack_03_D");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State인페르녹줌인03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹줌인03 : TriggerState {
            internal State인페르녹줌인03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003832, illustId: "infernog_nomal", script: "$52010063_QD__main__2$", duration: 5000, align: Align.Right);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Attack_03_F");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State인페르녹줌인04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹줌인04 : TriggerState {
            internal State인페르녹줌인04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8002}, arg2: false);
                context.AddCinematicTalk(npcId: 11003832, illustId: "infernog_nomal", script: "$52010063_QD__main__3$", duration: 5000, align: Align.Right);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_Infernog_goforward");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State부하Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부하Script01 : TriggerState {
            internal State부하Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8011}, arg2: false);
                context.AddCinematicTalk(npcId: 11003839, script: "$52010063_QD__main__4$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionSequence(arg1: 114, arg2: "Attack_01_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State부하Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부하Script02 : TriggerState {
            internal State부하Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8012}, arg2: false);
                context.AddCinematicTalk(npcId: 11003839, script: "$52010063_QD__main__5$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionSequence(arg1: 115, arg2: "Attack_01_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인페르녹Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹Script01 : TriggerState {
            internal State인페르녹Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8004}, arg2: false);
                context.AddCinematicTalk(npcId: 11003832, illustId: "infernog_nomal", script: "$52010063_QD__main__6$", duration: 4000, align: Align.Right);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Attack_02_F");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State인페르녹Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹Script02 : TriggerState {
            internal State인페르녹Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8003, 8005}, arg2: false);
                context.AddCinematicTalk(npcId: 11003832, illustId: "infernog_nomal", script: "$52010063_QD__main__7$", duration: 6000, align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State인페르녹Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹Script03 : TriggerState {
            internal State인페르녹Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003832, illustId: "infernog_nomal", script: "$52010063_QD__main__8$", duration: 5000, align: Align.Right);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Attack_02_E");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State인페르녹Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹Script04 : TriggerState {
            internal State인페르녹Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003832, illustId: "infernog_nomal", script: "$52010063_QD__main__9$", duration: 5000, align: Align.Right);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Attack_03_D");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State인페르녹Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹Script05 : TriggerState {
            internal State인페르녹Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8004, 8000}, arg2: false);
                context.AddCinematicTalk(npcId: 11003832, illustId: "infernog_nomal", script: "$52010063_QD__main__10$", duration: 5000, align: Align.Right);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Leave_01_A,Leave_02_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State부하들Prepare00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부하들Prepare00 : TriggerState {
            internal State부하들Prepare00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8000}, arg2: false);
                context.AddCinematicTalk(npcId: 11003839, script: "$52010063_QD__main__11$", duration: 3000, align: Align.Right);
                context.SetEffect(arg1: new[] {6010}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Leave_02_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State부하들Spawn00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부하들Spawn00 : TriggerState {
            internal State부하들Spawn00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State부하들Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투전스킵완료 : TriggerState {
            internal State전투전스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(arg1: new[] {102, 111, 112, 113, 114, 115});
                context.CreateMonster(arg1: new[] {211}, arg2: true);
                context.MoveUser(arg1: 52010063, arg2: 11);
                context.SetEffect(arg1: new[] {6000, 6003}, arg2: false);
                context.SetEffect(arg1: new[] {6010}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State부하들Spawn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부하들Spawn01 : TriggerState {
            internal State부하들Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102, 111, 112, 113, 114, 115});
                context.CreateMonster(arg1: new[] {211, 221, 222, 223, 224, 225, 226}, arg2: false);
                context.MoveUser(arg1: 52010063, arg2: 11);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State부하들Spawn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부하들Spawn02 : TriggerState {
            internal State부하들Spawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State부하들Spawn211(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부하들Spawn211 : TriggerState {
            internal State부하들Spawn211(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {212}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {211})) {
                    return new State부하들Spawn212(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부하들Spawn212 : TriggerState {
            internal State부하들Spawn212(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {213}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {212})) {
                    return new State부하들Spawn213(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부하들Spawn213 : TriggerState {
            internal State부하들Spawn213(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {214}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {213})) {
                    return new State부하들Spawn214215(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부하들Spawn214215 : TriggerState {
            internal State부하들Spawn214215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {215}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {214, 215})) {
                    return new State트리스탄구출00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄구출00 : TriggerState {
            internal State트리스탄구출00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(arg1: new[] {111, 112, 113, 114, 115, 211, 212, 213, 214, 215, 221, 222, 223, 224, 225, 226});
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "crimsonbalrogwipeout");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetMesh(arg1: new[] {4001, 4002, 4003, 4004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄구출01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄구출01 : TriggerState {
            internal State트리스탄구출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.MoveUser(arg1: 52010063, arg2: 20);
                context.SetEffect(arg1: new[] {6001, 6002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄구출02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄구출02 : TriggerState {
            internal State트리스탄구출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State전투후스킵완료(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new[] {8003, 8013, 8014}, arg2: false);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Dead_A", arg3: 5000f);
                context.SetEffect(arg1: new[] {6004}, arg2: true);
                context.AddCinematicTalk(npcId: 11003825, illustId: "Tristan_normal", script: "$52010063_QD__main__12$", duration: 5000, align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State트리스탄구출03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄구출03 : TriggerState {
            internal State트리스탄구출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6010}, arg2: false);
                context.SetEffect(arg1: new[] {6011}, arg2: true);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_Tristan_walk");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄구출04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄구출04 : TriggerState {
            internal State트리스탄구출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8022, 8021}, arg2: false);
                context.AddCinematicTalk(npcId: 11003825, illustId: "Tristan_normal", script: "$52010063_QD__main__13$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "ChatUp_A", arg3: 3000f);
                context.SetEffect(arg1: new[] {6004, 6011}, arg2: false);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투후스킵완료 : TriggerState {
            internal State전투후스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000, 6001, 6002, 6003, 6004, 6005, 6010, 6011}, arg2: false);
                context.MoveUser(arg1: 52010063, arg2: 20);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_Tristan_walk");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetMesh(arg1: new[] {4001, 4002, 4003, 4004}, arg2: false);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "tristanrescue");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000065}, arg3: new byte[] {3})) {
                    return new State콘대르_대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State콘대르_대사 : TriggerState {
            internal State콘대르_대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003534, illust: "Conder_normal", script: "$52010063_QD__main__15$", duration: 12098, voice: @"ko/Npc/00002170");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 12098)) {
                    return new StateQuestUserDetection_대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestUserDetection_대사 : TriggerState {
            internal StateQuestUserDetection_대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000066}, arg3: new byte[] {3})) {
                    return new State블리체_대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블리체_대사 : TriggerState {
            internal State블리체_대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11003533, illust: "Bliche_nomal", script: "$52010063_QD__main__14$", duration: 13000, voice: @"ko/Npc/00002153");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new State마지막체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막체크 : TriggerState {
            internal State마지막체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {91000066}, arg3: new byte[] {3})) {
                    return new State맵이동_작전실로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}