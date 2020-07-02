namespace Maple2.Trigger._52000072_qd {
    public static class _questnpcspawn01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002684}, arg3: new byte[] {2})) {
                    // return new StateNpcRemove01(context);
                    return null;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002684}, arg3: new byte[] {1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002683}, arg3: new byte[] {3})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002683}, arg3: new byte[] {2})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002683}, arg3: new byte[] {1})) {
                    return new StateNpcChange01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002682}, arg3: new byte[] {3})) {
                    return new StateNpcChange02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002682}, arg3: new byte[] {2})) {
                    return new StateNpcChange02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002682}, arg3: new byte[] {1})) {
                    return new StateNpcChange02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002681}, arg3: new byte[] {3})) {
                    return new StateNpcChange02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002681}, arg3: new byte[] {2})) {
                    return new StateNpcChange02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002681}, arg3: new byte[] {1})) {
                    return new StateSetCamera01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcChange02 : TriggerState {
            internal StateNpcChange02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetCamera01 : TriggerState {
            internal StateSetCamera01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "ActEnd01", arg2: "exit");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSetCamera02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetCamera02 : TriggerState {
            internal StateSetCamera02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: true);
                context.CreateMonster(arg1: new[] {102, 301, 401}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateActStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActStart01 : TriggerState {
            internal StateActStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_301");
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_401");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateActStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActStart02 : TriggerState {
            internal StateActStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_102");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateActStart03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActStart03 : TriggerState {
            internal StateActStart03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateActEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActEnd01 : TriggerState {
            internal StateActEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {301, 401});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateActEnd02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActEnd02 : TriggerState {
            internal StateActEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateActEnd03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActEnd03 : TriggerState {
            internal StateActEnd03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuestComplete(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestComplete : TriggerState {
            internal StateQuestComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "triangularRelation");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}