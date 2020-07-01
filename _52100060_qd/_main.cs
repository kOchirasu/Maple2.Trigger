namespace Maple2.Trigger._52100060_qd {
    public static class _main {
        public class StateQuestDungeonStart : TriggerState {
            internal StateQuestDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8100, enable: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {50100320}, arg3: new byte[] {3})) {
                    context.State = new Stateteleport02000487(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {50100320}, arg3: new byte[] {2})) {
                    context.State = new StateReady(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {50100320}, arg3: new byte[] {1})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 1, arg2: true);
                context.VisibleMyPc(isVisible: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {600}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1000})) {
                    context.State = new Statenarration01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenarration01 : TriggerState {
            internal Statenarration01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52100060_QD__MAIN__12$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCamera_Move_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCamera_Move_01 : TriggerState {
            internal StateCamera_Move_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(arg1: new[] {600}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNPC_Show(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC_Show : TriggerState {
            internal StateNPC_Show(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "teleport02000487");
                context.CreateMonster(arg1: new[] {1, 2}, arg2: false);
                context.SetNpcRotation(arg1: 1, arg2: 180);
                context.SetNpcRotation(arg1: 2, arg2: 180);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNPC_Change_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC_Change_1 : TriggerState {
            internal StateNPC_Change_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1, 2}, arg2: false);
                context.CreateMonster(arg1: new[] {101, 102}, arg2: false);
                context.CameraSelectPath(arg1: new[] {2, 3}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateTalk_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalk_1 : TriggerState {
            internal StateTalk_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: false);
                context.CameraSelect(arg1: 4, arg2: true);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Attack_01_A");
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", msg: "$52100060_QD__MAIN__0$", duration: 2000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateTalk_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalk_2 : TriggerState {
            internal StateTalk_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 5, arg2: true);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Bore_B");
                context.AddCinematicTalk(npcId: 11001813, illustId: "11001813", msg: "$52100060_QD__MAIN__1$", duration: 3000, align: "Right");
                context.AddCinematicTalk(npcId: 11001813, illustId: "11001813", msg: "$52100060_QD__MAIN__2$", duration: 3000, align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateTalk_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalk_3 : TriggerState {
            internal StateTalk_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {10, 11, 12}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11001813, illustId: "11001813", msg: "$52100060_QD__MAIN__3$", duration: 3000, align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTalk_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalk_4 : TriggerState {
            internal StateTalk_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 4, arg2: true);
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", msg: "$52100060_QD__MAIN__4$", duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateTalk_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalk_5 : TriggerState {
            internal StateTalk_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {6, 7}, arg2: false);
                context.AddCinematicTalk(npcId: 11001813, illustId: "11001813", msg: "$52100060_QD__MAIN__5$", duration: 3000, align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateTalk_6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalk_6 : TriggerState {
            internal StateTalk_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {77, 78}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_B");
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", msg: "$52100060_QD__MAIN__6$", duration: 2000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateTalk_7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalk_7 : TriggerState {
            internal StateTalk_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004022, illustId: "11004022", msg: "$52100060_QD__MAIN__7$", duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateTalk_8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalk_8 : TriggerState {
            internal StateTalk_8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 44, arg2: true);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {200});
                context.AddCinematicTalk(npcId: 11001813, illustId: "11001813", msg: "$52100060_QD__MAIN__8$", duration: 4000, align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTalk_9(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalk_9 : TriggerState {
            internal StateTalk_9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {13, 14, 15}, arg2: false);
                context.SetEffect(arg1: new[] {600}, arg2: false);
                context.AddCinematicTalk(npcId: 11001813, illustId: "11001813", msg: "$52100060_QD__MAIN__9$", duration: 3000, align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTalk_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalk_10 : TriggerState {
            internal StateTalk_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 200, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11001593, illustId: "11001593", msg: "$52100060_QD__MAIN__10$", duration: 4000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTalk_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalk_11 : TriggerState {
            internal StateTalk_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 16, arg2: true);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Bore_B");
                context.AddCinematicTalk(npcId: 11001813, illustId: "11001813", msg: "$52100060_QD__MAIN__11$", duration: 2000, align: "Right");
                context.CameraSelect(arg1: 8, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateNPC_Attack_Move(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC_Attack_Move : TriggerState {
            internal StateNPC_Attack_Move(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 0.5f, endScale: 0.3f, duration: 3.0f, interpolator: 1);
                context.CameraSelectPath(arg1: new[] {8, 9}, arg2: false);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData2");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData3");
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateteleport02000487(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateteleport02000487 : TriggerState {
            internal Stateteleport02000487(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.DestroyMonster(arg1: new[] {-1});
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 02000487, arg2: 3);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}