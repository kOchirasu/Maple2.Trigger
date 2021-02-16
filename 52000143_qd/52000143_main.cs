using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000143_qd {
    public static class _52000143_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetMesh(arg1: new[] {4003, 4004, 4005, 4006}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new[] {8001}, arg2: false);
                context.AddBuff(arg1: new[] {701}, arg2: 70000124, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State한번더Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State한번더Wait : TriggerState {
            internal State한번더Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State로베와대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_01 : TriggerState {
            internal State로베와대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State로베Combat_01(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, script: "$52000143_QD__52000143_MAIN__0$", duration: 3000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State로베와대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_02 : TriggerState {
            internal State로베와대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000143_QD__52000143_MAIN__1$", duration: 3500, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State로베와대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_03 : TriggerState {
            internal State로베와대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000143_QD__52000143_MAIN__2$", duration: 3000, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State로베와대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_04 : TriggerState {
            internal State로베와대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000143_QD__52000143_MAIN__3$", duration: 2500, illustId: "Robe_normal", align: Align.Right);
                context.AddCinematicTalk(npcId: 11003401, script: "$52000143_QD__52000143_MAIN__4$", duration: 3000, illustId: "Robe_normal", align: Align.Right);
                context.AddCinematicTalk(npcId: 11003401, script: "$52000143_QD__52000143_MAIN__5$", duration: 2500, illustId: "Robe_normal", align: Align.Right);
                context.AddCinematicTalk(npcId: 11003401, script: "$52000143_QD__52000143_MAIN__6$", duration: 3000, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new State로베와대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_05 : TriggerState {
            internal State로베와대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000143_QD__52000143_MAIN__7$", duration: 3500, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State로베와대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_06 : TriggerState {
            internal State로베와대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000143_QD__52000143_MAIN__8$", duration: 1000, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State로베와대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화_07 : TriggerState {
            internal State로베와대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State로베Combat_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베Combat_01 : TriggerState {
            internal State로베Combat_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State로베Combat_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베Combat_02 : TriggerState {
            internal State로베Combat_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State로베Combat_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베Combat_03 : TriggerState {
            internal State로베Combat_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 25201431, textId: 25201431);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new State로베Combat_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베Combat_04 : TriggerState {
            internal State로베Combat_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityId: 25201431);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State로베Combat_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베Combat_05 : TriggerState {
            internal State로베Combat_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {103, 104, 105, 106, 107}, arg2: false);
                context.AddCinematicTalk(npcId: 11003404, script: "$52000143_QD__52000143_MAIN__9$", duration: 2500, align: Align.Center);
                context.MoveUser(arg1: 52000143, arg2: 99);
                context.CameraSelectPath(pathIds: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State알론Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론Spawn_01 : TriggerState {
            internal State알론Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State알론Spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론Spawn_02 : TriggerState {
            internal State알론Spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2001");
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 107, arg2: "MS2PatrolData_2004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3자대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3자대화_03 : TriggerState {
            internal State3자대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8002, 8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State3자대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3자대화_04 : TriggerState {
            internal State3자대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State마무리_01(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 11003401, script: "$52000143_QD__52000143_MAIN__10$", duration: 2500, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3자대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3자대화_05 : TriggerState {
            internal State3자대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003404, script: "$52000143_QD__52000143_MAIN__11$", duration: 3000, illustId: "Alon_normal", align: Align.Center);
                context.AddCinematicTalk(npcId: 11003404, script: "$52000143_QD__52000143_MAIN__12$", duration: 2500, illustId: "Alon_normal", align: Align.Center);
                context.AddCinematicTalk(npcId: 11003404, script: "$52000143_QD__52000143_MAIN__13$", duration: 3000, illustId: "Alon_normal", align: Align.Center);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State3자대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3자대화_06 : TriggerState {
            internal State3자대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000143_QD__52000143_MAIN__14$", duration: 3500, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State3자대화_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3자대화_07 : TriggerState {
            internal State3자대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003404, script: "$52000143_QD__52000143_MAIN__15$", duration: 3000, illustId: "Alon_normal", align: Align.Center);
                context.AddCinematicTalk(npcId: 11003404, script: "$52000143_QD__52000143_MAIN__16$", duration: 3000, illustId: "Alon_normal", align: Align.Center);
                context.AddCinematicTalk(npcId: 11003404, script: "$52000143_QD__52000143_MAIN__17$", duration: 3000, illustId: "Alon_normal", align: Align.Center);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State3자대화_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3자대화_08 : TriggerState {
            internal State3자대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000143_QD__52000143_MAIN__18$", duration: 2500, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3자대화_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3자대화_09 : TriggerState {
            internal State3자대화_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000143_QD__52000143_MAIN__19$", duration: 2500, align: Align.Left);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3자대화_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3자대화_10 : TriggerState {
            internal State3자대화_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003404, script: "$52000143_QD__52000143_MAIN__20$", duration: 3000, illustId: "Alon_normal", align: Align.Center);
                context.AddCinematicTalk(npcId: 11003404, script: "$52000143_QD__52000143_MAIN__21$", duration: 2500, illustId: "Alon_normal", align: Align.Center);
                context.AddCinematicTalk(npcId: 11003404, script: "$52000143_QD__52000143_MAIN__22$", duration: 3000, illustId: "Alon_normal", align: Align.Center);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State3자대화_10_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3자대화_10_1 : TriggerState {
            internal State3자대화_10_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3자대화_10_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3자대화_10_2 : TriggerState {
            internal State3자대화_10_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000143_QD__52000143_MAIN__23$", duration: 2500, align: Align.Left);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2006");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State3자대화_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3자대화_11 : TriggerState {
            internal State3자대화_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8004}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2005");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3자대화_11_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3자대화_11_1 : TriggerState {
            internal State3자대화_11_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000143_QD__52000143_MAIN__28$", duration: 3000, align: Align.Left);
                context.SetPcEmotionSequence(arg1: "Knight_Bore_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State3자대화_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3자대화_12 : TriggerState {
            internal State3자대화_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003404, script: "$52000143_QD__52000143_MAIN__24$", duration: 5500, illustId: "Alon_normal", align: Align.Right);
                context.AddCinematicTalk(npcId: 11003404, script: "$52000143_QD__52000143_MAIN__25$", duration: 5500, illustId: "Alon_normal", align: Align.Right);
                context.AddCinematicTalk(npcId: 11003404, script: "$52000143_QD__52000143_MAIN__26$", duration: 5000, illustId: "Alon_normal", align: Align.Right);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 17000)) {
                    return new State마무리_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리_01 : TriggerState {
            internal State마무리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마무리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리_02 : TriggerState {
            internal State마무리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000143_QD__52000143_MAIN__27$");
                context.RemoveBuff(arg1: 701, arg2: 70000124);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000144, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}