namespace Maple2.Trigger._52000046_qd {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {60100215}, arg3: new byte[] {2})) {
                    return new Stateready(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {60100215}, arg3: new byte[] {3})) {
                    return new Statescene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.DestroyMonster(arg1: new[] {1001, 1002, 2002});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statecamera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statecamera : TriggerState {
            internal Statecamera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001, 4002, 4003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statescene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "ChatUp_A");
                context.AddCinematicTalk(npcId: 11003216, msg: "$52000046_QD__MAIN__0$", duration: 3000, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statescene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "NameCaption", scale: 2.3f, title: "$52000046_QD__MAIN__1$", desc: "$52000046_QD__MAIN__2$", align: "centerLeft", offsetRateX: -0.15f, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statescene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statescene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001, 1002, 2002, 101});
                context.CreateMonster(arg1: new[] {102}, arg2: true);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statescene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_05 : TriggerState {
            internal Statescene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Stateemd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateemd : TriggerState {
            internal Stateemd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}