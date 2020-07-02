namespace Maple2.Trigger._52020020_qd {
    public static class _main_a {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200130}, arg3: new byte[] {2})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200130}, arg3: new byte[] {3})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52020020, arg2: 6001);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonologue_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonologue_01 : TriggerState {
            internal StateMonologue_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "으으.......", duration: 2500, align: "Right");
                context.SetSceneSkip(arg1: "end", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateMonologue_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonologue_02 : TriggerState {
            internal StateMonologue_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "도대체 무슨 일이 일어난 거지?", duration: 2500, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateMonologue_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonologue_03 : TriggerState {
            internal StateMonologue_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: ".......", duration: 3000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateMonologue_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonologue_04 : TriggerState {
            internal StateMonologue_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetPcEmotionLoop(arg1: "Sit_Ground_Idle_A", arg2: 3000f);
                context.AddCinematicTalk(npcId: 0, msg: "잠깐! 여기는?!", duration: 3000, align: "Right");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}