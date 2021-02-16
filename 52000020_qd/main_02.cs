namespace Maple2.Trigger._52000020_qd {
    public static class _main_02 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {60100095}, arg3: new byte[] {1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {202, 302, 404, 405, 406, 407, 408, 409, 410, 411}, arg2: true);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetSceneSkip(state: new StateBattle_ready(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera : TriggerState {
            internal StateCamera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 4001, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: false);
                context.SetSound(arg1: 7002, arg2: true);
                context.AddCinematicTalk(npcId: 11003193, msg: "$52000020_QD__MAIN_02__0$", duration: 2000, align: "center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4003, 4004}, arg2: false);
                context.MoveUser(arg1: 52000020, arg2: 6001);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 302, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 29000266, msg: "$52000020_QD__MAIN_02__1$", duration: 2000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 302, arg2: "Emotion_Angry_A");
                context.AddCinematicTalk(npcId: 29000266, msg: "$52000020_QD__MAIN_02__2$", duration: 2000, align: "center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 302, arg2: "ChatUp_A");
                context.AddCinematicTalk(npcId: 29000266, msg: "$52000020_QD__MAIN_02__3$", duration: 2000, align: "center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4006}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 404, arg2: "ChatUp_A");
                context.SetNpcEmotionSequence(arg1: 405, arg2: "ChatUp_A");
                context.SetNpcEmotionSequence(arg1: 406, arg2: "ChatUp_A");
                context.SetNpcEmotionSequence(arg1: 407, arg2: "ChatUp_A");
                context.SetNpcEmotionSequence(arg1: 408, arg2: "ChatUp_A");
                context.SetNpcEmotionSequence(arg1: 409, arg2: "ChatUp_A");
                context.SetNpcEmotionSequence(arg1: 410, arg2: "ChatUp_A");
                context.SetNpcEmotionSequence(arg1: 411, arg2: "ChatUp_A");
                context.AddBalloonTalk(spawnPointId: 404, msg: "$52000020_QD__MAIN_02__4$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 405, msg: "$52000020_QD__MAIN_02__5$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 406, msg: "$52000020_QD__MAIN_02__6$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 407, msg: "$52000020_QD__MAIN_02__7$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 408, msg: "$52000020_QD__MAIN_02__8$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 409, msg: "$52000020_QD__MAIN_02__9$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 410, msg: "$52000020_QD__MAIN_02__10$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 411, msg: "$52000020_QD__MAIN_02__11$", duration: 2000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_07 : TriggerState {
            internal StateScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 502, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 29000266, msg: "$52000020_QD__MAIN_02__12$", duration: 2000, align: "center");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBattle_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_ready : TriggerState {
            internal StateBattle_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {404, 405});
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBattle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle : TriggerState {
            internal StateBattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CreateMonster(arg1: new[] {604, 605}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattleMsg(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleMsg : TriggerState {
            internal StateBattleMsg(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52000020_QD__MAIN_02__13$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {604, 605})) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_2 : TriggerState {
            internal StateRound_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {406, 407, 408, 409});
                context.CreateMonster(arg1: new[] {606, 607, 608, 609}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {604, 605})) {
                    return new StateDelay_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay_a : TriggerState {
            internal StateDelay_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_3 : TriggerState {
            internal StateRound_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {410, 411, 302});
                context.CreateMonster(arg1: new[] {610, 611, 502}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {610, 611, 502})) {
                    return new StateDelay_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay_b : TriggerState {
            internal StateDelay_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 2002, arg2: "trigger", arg3: "mafiabattle");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWinready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWinready : TriggerState {
            internal StateWinready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetSound(arg1: 7002, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
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