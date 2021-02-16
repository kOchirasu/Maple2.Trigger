namespace Maple2.Trigger._52000126_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100210}, arg3: new byte[] {1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: true);
                context.MoveUser(arg1: 52000126, arg2: 6002);
                context.SetSceneSkip(state: new StateBattle_ready(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_01 : TriggerState {
            internal StateTalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003209, msg: "$52000126_QD__MAIN__0$", duration: 2000, align: "Left");
                context.CreateMonster(arg1: new[] {301, 302, 303}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_02 : TriggerState {
            internal StateTalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: true);
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003209, msg: "$52000126_QD__MAIN__1$", duration: 2000, align: "Left");
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_3002");
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_3003");
                context.MoveNpc(arg1: 303, arg2: "MS2PatrolData_3004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4002, 4003}, arg2: false);
                context.AddCinematicTalk(npcId: 11003214, msg: "$52000126_QD__MAIN__2$", duration: 3000, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003214, msg: "$52000126_QD__MAIN__3$", duration: 3000, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.AddCinematicTalk(npcId: 11003214, msg: "$52000126_QD__MAIN__4$", duration: 4000, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4005, 4006, 4007}, arg2: false);
                context.AddCinematicTalk(npcId: 11003214, msg: "$52000126_QD__MAIN__5$", duration: 3000, align: "Left");
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004}, arg2: true);
                context.SetOnetimeEffect(id: 20, enable: true, path: @"BG/Common/Sound/Eff_Object_Explosion_Debris_01.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3005");
                context.SetNpcEmotionLoop(arg1: 302, arg2: "Attack_Idle_A", arg3: 7000f);
                context.SetNpcEmotionLoop(arg1: 303, arg2: "Attack_Idle_A", arg3: 7000f);
                context.AddCinematicTalk(npcId: 11003213, msg: "$52000126_QD__MAIN__6$", duration: 2000, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4009}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Attack_01_A");
                context.AddCinematicTalk(npcId: 11003214, msg: "$52000126_QD__MAIN__7$", duration: 3000, align: "Left");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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
                context.DestroyMonster(arg1: new[] {301, 302, 303});
                context.CreateMonster(arg1: new[] {601, 602, 603}, arg2: true);
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
                context.SetEventUI(arg1: 1, arg2: "$52000126_QD__MAIN__8$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {601, 602, 603})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "maskbattle");
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}