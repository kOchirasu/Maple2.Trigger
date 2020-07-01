namespace Maple2.Trigger._52000140_qd {
    public static class _main {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    context.State = new State카메라연출_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라연출_01 : TriggerState {
            internal State카메라연출_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라연출_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라연출_02 : TriggerState {
            internal State카메라연출_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State카메라연출_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라연출_04 : TriggerState {
            internal State카메라연출_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State카메라연출_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라연출_05 : TriggerState {
            internal State카메라연출_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State삼자대화_01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2002");
            }
        }

        private class State삼자대화_01 : TriggerState {
            internal State삼자대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "투르카소멸_01", arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, msg: "$52000140_QD__MAIN__0$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State삼자대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_02 : TriggerState {
            internal State삼자대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000140_QD__MAIN__1$", duration: 3000,
                    align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State삼자대화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대화_03 : TriggerState {
            internal State삼자대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003329, msg: "$52000140_QD__MAIN__2$", duration: 2500,
                    align: "right");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2003");
                context.AddCinematicTalk(npcId: 11003329, msg: "$52000140_QD__MAIN__3$", duration: 2500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    context.State = new State투르카소멸_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카소멸_01 : TriggerState {
            internal State투르카소멸_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.DestroyMonster(arg1: new[] {102});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State투르카소멸_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카소멸_02 : TriggerState {
            internal State투르카소멸_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {105}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State어둠의졸개_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어둠의졸개_01 : TriggerState {
            internal State어둠의졸개_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103, 104}, arg2: true);
                context.ShowGuideSummary(entityId: 25201401, textId: 25201401);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {103, 104})) {
                    context.State = new State졸개퇴치완료_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State졸개퇴치완료_01 : TriggerState {
            internal State졸개퇴치완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityId: 25201401);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State졸개퇴치완료_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State졸개퇴치완료_02 : TriggerState {
            internal State졸개퇴치완료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000140, arg2: 99);
                context.DestroyMonster(arg1: new[] {105});
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2002");
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State졸개퇴치완료_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State졸개퇴치완료_03 : TriggerState {
            internal State졸개퇴치완료_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State알론과대화_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론과대화_01 : TriggerState {
            internal State알론과대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "투르카와전투_01", arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, msg: "$52000140_QD__MAIN__4$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State알론과대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론과대화_02 : TriggerState {
            internal State알론과대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000140_QD__MAIN__5$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State알론과대화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론과대화_03 : TriggerState {
            internal State알론과대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000140_QD__MAIN__6$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State알론과대화_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론과대화_04 : TriggerState {
            internal State알론과대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000140_QD__MAIN__7$", duration: 2500,
                    align: "right");
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000140_QD__MAIN__8$", duration: 2500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    context.State = new State알론과대화_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론과대화_05 : TriggerState {
            internal State알론과대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000140_QD__MAIN__9$", duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State알론과대화_06(context);
                    return;
                }
            }

            public override void OnExit() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2003");
            }
        }

        private class State알론과대화_06 : TriggerState {
            internal State알론과대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000140_QD__MAIN__10$", duration: 2000,
                    align: "right");
                context.MoveUserPath(arg1: "MS2PatrolData_2008");
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    context.State = new State알론과대화_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론과대화_07 : TriggerState {
            internal State알론과대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003, 8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2200)) {
                    context.State = new State2차삼자대화_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_01 : TriggerState {
            internal State2차삼자대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003329, msg: "$52000140_QD__MAIN__11$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2차삼자대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_02 : TriggerState {
            internal State2차삼자대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000140_QD__MAIN__12$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2차삼자대화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_03 : TriggerState {
            internal State2차삼자대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003329, msg: "$52000140_QD__MAIN__13$", duration: 2500,
                    align: "right");
                context.AddCinematicTalk(npcId: 11003329, msg: "$52000140_QD__MAIN__14$", duration: 2500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5200)) {
                    context.State = new State2차삼자대화_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_04 : TriggerState {
            internal State2차삼자대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000140_QD__MAIN__15$", duration: 2500,
                    align: "center");
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000140_QD__MAIN__16$", duration: 2500,
                    align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5200)) {
                    context.State = new State2차삼자대화_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_05 : TriggerState {
            internal State2차삼자대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003329, msg: "$52000140_QD__MAIN__17$", duration: 2500,
                    align: "right");
                context.AddCinematicTalk(npcId: 11003329, msg: "$52000140_QD__MAIN__18$", duration: 2500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    context.State = new State2차삼자대화_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_06 : TriggerState {
            internal State2차삼자대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000140_QD__MAIN__19$", duration: 2500,
                    align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2차삼자대화_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_07 : TriggerState {
            internal State2차삼자대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003329, msg: "$52000140_QD__MAIN__20$", duration: 2500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2차삼자대화_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차삼자대화_08 : TriggerState {
            internal State2차삼자대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000140_QD__MAIN__21$", duration: 2000,
                    align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    context.State = new State투르카와전투_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카와전투_01 : TriggerState {
            internal State투르카와전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {106}, arg2: true);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {105}, arg2: true);
                context.ShowGuideSummary(entityId: 25201402, textId: 25201402);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State투르카와전투_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카와전투_02 : TriggerState {
            internal State투르카와전투_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.HideGuideSummary(entityId: 25201402);
                context.MoveUser(arg1: 52000140, arg2: 99);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State투르카와전투_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카와전투_03 : TriggerState {
            internal State투르카와전투_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.DestroyMonster(arg1: new[] {106});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.DestroyMonster(arg1: new[] {105});
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2008");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State3차삼자대화_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차삼자대화_01 : TriggerState {
            internal State3차삼자대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003329, msg: "$52000140_QD__MAIN__22$", duration: 2500,
                    align: "right");
                context.AddCinematicTalk(npcId: 11003329, msg: "$52000140_QD__MAIN__23$", duration: 2500,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    context.State = new State3차삼자대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차삼자대화_02 : TriggerState {
            internal State3차삼자대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000140_QD__MAIN__24$", duration: 2000);
                context.MoveUserPath(arg1: "MS2PatrolData_2005");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2200)) {
                    context.State = new State3차삼자대화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차삼자대화_03 : TriggerState {
            internal State3차삼자대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8006}, arg2: false);
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000140_QD__MAIN__25$", duration: 2000,
                    align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2200)) {
                    context.State = new State투르카퇴장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카퇴장_01 : TriggerState {
            internal State투르카퇴장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8007}, arg2: false);
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.DestroyMonster(arg1: new[] {102});
                context.SetPcEmotionSequence(arg1: "Priest_Skill_Divine_Protection_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new State투르카퇴장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State투르카퇴장_02 : TriggerState {
            internal State투르카퇴장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 10000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC의부상_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC의부상_01 : TriggerState {
            internal StatePC의부상_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 10000f);
                context.SetEffect(arg1: new[] {5001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePC의부상_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC의부상_02 : TriggerState {
            internal StatePC의부상_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {8004, 8005}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2007");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StatePC의부상_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC의부상_03 : TriggerState {
            internal StatePC의부상_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State강제이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000141, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}