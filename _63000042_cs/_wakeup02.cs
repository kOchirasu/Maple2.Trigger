namespace Maple2.Trigger._63000042_cs {
    public static class _wakeup02 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {60100005, 60100006, 60100007, 60100008, 60100009, 60100010}, arg3: new byte[] {2})) {
                    return new Stateready(context);
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
                context.DestroyMonster(arg1: new[] {102});
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.MoveUser(arg1: 63000042, arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statetalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_01 : TriggerState {
            internal Statetalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$63000042_CS__WAKEUP02__0$", duration: 3000);
                context.SetSceneSkip(arg1: "sitready", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statetalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_02 : TriggerState {
            internal Statetalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$63000042_CS__WAKEUP02__1$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statetalk_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_03 : TriggerState {
            internal Statetalk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$63000042_CS__WAKEUP02__2$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Statetalk_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_04 : TriggerState {
            internal Statetalk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003145, msg: "$63000042_CS__WAKEUP02__3$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Statetalk_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_05 : TriggerState {
            internal Statetalk_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$63000042_CS__WAKEUP02__4$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Statetalk_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_06 : TriggerState {
            internal Statetalk_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$63000042_CS__WAKEUP02__5$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statetalk_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_07 : TriggerState {
            internal Statetalk_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$63000042_CS__WAKEUP02__6$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statetalk_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_08 : TriggerState {
            internal Statetalk_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003145, msg: "$63000042_CS__WAKEUP02__7$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statetalk_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_09 : TriggerState {
            internal Statetalk_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$63000042_CS__WAKEUP02__8$", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statesitready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statesitready : TriggerState {
            internal Statesitready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Sit_Ground_Idle_A", arg2: 13000f);
                context.SetSound(arg1: 7002, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Statefadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statefadein : TriggerState {
            internal Statefadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateMonster(arg1: new[] {103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statepraymove_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepraymove_01 : TriggerState {
            internal Statepraymove_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_103");
                context.AddCinematicTalk(npcId: 11003165, illustId: "Fray_normal", msg: "$63000042_CS__WAKEUP02__9$", duration: 3000, align: "Left");
                context.SetSceneSkip(arg1: "end", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statepraytalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepraytalk_02 : TriggerState {
            internal Statepraytalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003165, msg: "$63000042_CS__WAKEUP02__10$", duration: 3000);
                context.CameraSelectPath(arg1: new[] {502}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statepray(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepray : TriggerState {
            internal Statepray(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(scale: 2.5f, type: "NameCaption", title: "$63000042_CS__WAKEUP02__11$", desc: "$63000042_CS__WAKEUP02__12$", align: "centerRight", offsetRateX: 0.5f, duration: 4000);
                context.CameraSelectPath(arg1: new[] {502, 503}, arg2: false);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Stateend(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Sit_Ground_Idle_A", arg2: 100f);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {60100010}, arg3: new byte[] {1})) {
                    return new Statewarp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statewarp : TriggerState {
            internal Statewarp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000033, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}